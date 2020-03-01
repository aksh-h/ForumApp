using ForumDL;
using ForumModel;
using System;
using System.Collections.Generic;

namespace ForumBL
{
    public class QuestionBL
    {
        QuestionDL qdl = new QuestionDL();
        public string InsertQuestion(string question, string discription)
        {
            string res = qdl.InsertQuestion(question, discription ?? "");
            return res;
        }
        public List<Questions> GetAllQuestion()
        {
            List<Questions> queList = qdl.GetAllQuestion();
            return queList;
        }
        public string UpdateQuestion(int questionID, string question, string discription)
        {
            string updateQue = qdl.UpdateQuestion(questionID, question, discription);
            return updateQue;
        }
        public Questions EditQuestion(int questionID)
        {
            Questions que = qdl.EditQuestion(questionID);
            return que;
        }
        public string DeleteQuestion(int questionID)
        {
            string res = qdl.DeleteQuestion(questionID);
            return res;
        }
    }
}
