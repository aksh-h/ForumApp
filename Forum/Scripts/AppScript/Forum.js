$(document).ready(function () {
    // Get all questions
    $.ajax({
        url: '../Home/GetAllQuestion',
        type: 'GET',
        success: function (data) {
            if (data.length > 0) {
                $.each(data, function (i, val) {
                    var div = "";
                    div += '<div class="question"><button type="button" class="btn btn-link reply replyRight" id="' + val.QuestionID + '-reply" data-toggle="modal">Reply</button>'
                        + '<input type="hidden" value="' + val.QuestionID + '"><span style="cursor:pointer" id="' + val.QuestionID + '-QuesClick" class="QuesClick">' + val.Question + '</span>'
                        + '<div id="' + val.QuestionID + '-replyDiv" class=""></div>'
                        + '</div>';

                    $('#questions').append(div);
                });
            }
        }
    });

    // on click of question, get the replies
    $('body').on('click', '.QuesClick', function () {
        console.log(this.id.split('-')[0]);
        var qid = this.id.split('-')[0];
        if (qid !== "") {
            GetReply(qid);
        }

    });

    // Get reply for a question
    function GetReply(qid) {
        $.ajax({
            url: '../Home/GetReplyForAQuestions',
            type: 'GET',
            data: { questionID: qid },
            success: function (res) {
                if (res.length > 0) {
                    console.log(res);
                    var re = "";
                    $.each(res, function (i, val) {
                        re += '<div class="replyBg">'
                            + '<div class="col-sm-10">' + val.Reply + '</div>'
                            + '<button type="button" class="glyphicon glyphicon-pencil btn btn-warning EditReply" style="float:right; margin:2px" id="' + val.ReplyID + '-' + val.QuestionID + '-EditReply"></button>'
                            + '<button type="button" class="glyphicon glyphicon-trash btn btn-danger DeleteReply" style="float:right; margin:2px;" id="' + val.ReplyID + '-' + val.QuestionID + '-DeleteReply"></button>'
                            + '</div>';
                    });
                    $('#' + qid + '-replyDiv').empty().append(re);
                }
                else {
                    $('#' + qid + '-replyDiv').empty();
                }
            }
        });
    }

    // holding question id upon clicking on Reply button
    $("body").on("click", ".reply", function () {
        console.log(this.id);
        var id = this.id.split('-')[0];
        $('#hiddenQID').val(id);
        $('#replyModalLabel').modal({ show: true });
        $('#updateReplybutton').addClass('d-none').removeClass('d-block');
        $('#Replybutton').addClass('d-block').removeClass('d-none');
    });

    // Reply to question
    $('#Replybutton').click(function () {
        var replyText = $('#ReplyText').val();
        var qid = $('#hiddenQID').val();
        if (replyText !== "") {
            $('#replyModalLabel').modal('toggle');
            $.ajax({
                url: '../Home/PostReply',
                type: 'POST',
                data: { QuestionId: qid, Reply: replyText },
                success: function (res) {
                    GetReply(qid);
                    $('#ReplyText').val('');
                    alert(res);
                },
                error: function (er) {
                    alert(er);
                }
            });
        }
    });

    // Edit Reply
    $('body').on('click', '.EditReply', function () {
        var replyid = this.id.split('-')[0];
        var qid = this.id.split('-')[1];
        $('#hiddenReplyID').val(replyid);
        $('#hiddenQID').val(qid);
        if (replyid !== "") {
            $('#Replybutton').addClass('d-none').removeClass('d-block');
            $('#updateReplybutton').addClass('d-block').removeClass('d-none');
            $.ajax({
                url: '../Home/GetReplyaToEdit',
                type: 'POST',
                data: { replyId: replyid },
                success: function (res) {
                    $('#replyModalLabel').modal({ show: true });
                    $('#ReplyText').val(res.Reply);
                },
                error: function (er) {
                    alert(er);
                }

            });
        }
    });

    // Update Reply
    $('#updateReplybutton').click(function () {
        var replyId = $('#hiddenReplyID').val();
        var qid = $('#hiddenQID').val();
        if (replyId !== "") {
            var replyText = $('#ReplyText').val();
            if (replyText !== "") {
                $('#replyModalLabel').modal('toggle');
                $.ajax({
                    url: '../Home/UpdateIntoReply',
                    type: 'POST',
                    data: { reply: replyText, replyId: replyId },
                    success: function (res) {
                        alert(res);
                        $('#ReplyText').val('');
                        GetReply(qid);
                    },
                    error: function (er) {
                        alert(er);
                    }
                });
            }
            $('#updateReplybutton').addClass('d-none').removeClass('d-block');
            $('#Replybutton').addClass('d-block').removeClass('d-none');
        }
    });

    // Delete Reply
    $('body').on('click', '.DeleteReply', function () {
        console.log(this.id.split('-')[0]);
        var replyid = this.id.split('-')[0];
        var qid = this.id.split('-')[1];
        if (replyid !== "") {
            $.ajax({
                url: '../Home/DeleteAReply',
                type: 'POST',
                data: { replyId: replyid },
                success: function (res) {
                    GetReply(qid);
                },
                error: function (er) {
                    alert(er);
                }

            });
        }
    });

    // Model won't close using excase button or mouse event
    $('.modal').modal({
        backdrop: 'static',
        keyboard: false,
        show: false
    });
});