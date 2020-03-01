using ForumDL;
using ForumModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ForumBL
{
    public class ReplyBL
    {
        ReplyDL rdl = new ReplyDL();
        //public void GetReplyToAllQuestions()
        //{
        //    List<Replys> replys = rdl.GetReplyToAllQuestions();
        //    if (replys.Count > 0)
        //    {
        //        var quenList = replys.GroupBy(x => x.Question).Select(x => x.Key).ToList();
        //        List<QuestionAndReplies> listQuestionAndReplies = new List<QuestionAndReplies>();

        //        List<string> replies = new List<string>();
        //        foreach (var que in quenList)
        //        {
        //            replies = replys.Where(x => x.Question == que).Select(x => x.Reply).ToList();
        //            int qId = replys.Where(x => x.Question == que).Select(x => x.QuestionID).FirstOrDefault();
        //        }
        //        foreach (var reply in replys)
        //        {
        //            QuestionAndReplies questionAndReplies = new QuestionAndReplies();
        //            questionAndReplies.QuestionID = reply.QuestionID;
        //            questionAndReplies.Question = reply.Question;
        //            questionAndReplies.Discription = reply.Discription;
        //        }
        //    }
        //}

        public List<Replys> GetReplyForAQuestions(int QuestionID)
        {
            List<Replys> replys = rdl.GetReplyForAQuestions(QuestionID);
            return replys;
        }
        public string InsertIntoReply(int QuestionId, string Reply)
        {
            string res = rdl.InsertIntoReply(QuestionId, Reply);
            return res;
        }
        public string UpdateIntoReply(string reply, int replyId)
        {
            string res = rdl.UpdateIntoReply(reply, replyId);
            return res;
        }
        public Replys GetReplyaToEdit(int replyId)
        {
            Replys res = rdl.GetReplyaToEdit(replyId);
            return res;
        }
        public string DeleteAReply(int replyId)
        {
            string res = rdl.DeleteAReply(replyId);
            return res;
        }
    }
}
