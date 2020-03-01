$(document).ready(function () {
    // Listing Questions
    loadQuestions();
    function loadQuestions() {
        $.ajax({
            url: '../Home/GetAllQuestion',
            type: 'GET',
            success: function (data) {
                if (data.length > 0) {
                    var div = "";
                    $.each(data, function (i, val) {
                        div += '<div class="question"><input type="hidden" value="' + val.QuestionID + '">'
                            + '<button type="button" class="glyphicon glyphicon-trash btn btn-danger Delete" style="float:right; margin:2px" id="' + val.QuestionID + '-Delete" title="Delete"></button>'
                            + '<button type="button" class="glyphicon glyphicon-pencil btn btn-primary Edit" style="float:right; margin:2px" id="' + val.QuestionID + '-Edit" title="Edit"></button>'
                            + val.Question + '</div >';
                    });
                    $('#questionList').empty().append(div);
                }
            }
        });
    }

    //insert question
    $('#postQuestion').click(function () {
        var ques = $('#question').val();
        var disc = $('#discription').val();
        console.log(ques + "-----" + disc);
        if (ques !== "") {
            $.ajax({
                url: '../Home/PostQuestion',
                type: 'POST',
                data: { question: ques, discription: disc },
                success: function (res) {
                    //alert(res);
                    $('.clear').val('');
                    loadQuestions();
                },
                error: function (er) {
                    alert(er);
                }
            });
        }
        else {
            alert("Please ask a question!!");
        }
    });

    // Edit Question
    $('body').on('click', '.Edit', function () {
        var id = this.id.split('-')[0];
        $('#hiddenEditID').val(id);
        if (id !== "") {
            $.ajax({
                url: '../Home/EditQuestion',
                type: 'POST',
                data: { questionID: id },
                success: function (res) {
                    console.log(res);
                    $('#question').val(res.Question);
                    $('#discription').val(res.Description);
                    $('#updateQuestion').removeClass('d-none').addClass('d-block');
                    $('#cancelButton').removeClass('d-none').addClass('d-block');
                    $('#postQuestion').removeClass('d-block').addClass('d-none');
                    $('#question').focus();
                },
                error: function (er) {

                }
            });
        }
    });

    // Update Question

    $('#updateQuestion').click(function () {
        var ques = $('#question').val();
        var disc = $('#discription').val();
        var editId = $('#hiddenEditID').val();
        console.log(ques + "-----" + disc);
        if (ques !== "") {
            $.ajax({
                url: '../Home/UpdateQuestion',
                type: 'POST',
                data: { questionID: editId, question: ques, discription: disc },
                success: function (res) {
                    $('.clear').val('');
                    $('#updateQuestion').removeClass('d-block').addClass('d-none');
                    $('#cancelButton').removeClass('d-block').addClass('d-none');
                    $('#postQuestion').removeClass('d-none').addClass('d-block');
                    loadQuestions();
                    alert(res);
                },
                error: function (er) {
                    alert(er);
                }
            });
        }
        else {
            alert("Please ask a question!!");
        }
    });

    // Delete Question
    $('body').on('click', '.Delete', function () {
        var id = this.id.split('-')[0];
        if (id !== "") {
            $.ajax({
                url: '../Home/DeleteQuestion',
                type: 'POST',
                data: { questionID: id },
                success: function (res) {
                    console.log(res);
                    loadQuestions();
                    alert(res);
                },
                error: function (er) {

                }
            });
        }
    });

    // cancel edit
    $('#cancelButton').click(function () {
        $('.clear').val('');
    })
});