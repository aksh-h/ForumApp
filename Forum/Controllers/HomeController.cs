using ForumBL;
using ForumModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AskQuestions()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Forum()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // Ask Question
        public JsonResult PostQuestion(string question, string discription)
        {
            QuestionBL bl = new QuestionBL();
            string res = bl.InsertQuestion(question, discription);
            if (res == "1")
            {
                return Json("Successfully Inserted!!", JsonRequestBehavior.AllowGet);
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetAllQuestion()
        {
            QuestionBL bl = new QuestionBL();
            List<Questions> quesList = bl.GetAllQuestion();
            return Json(quesList, JsonRequestBehavior.AllowGet);
        }
        public JsonResult EditQuestion(string questionID)
        {
            QuestionBL bl = new QuestionBL();
            int quesID = Convert.ToInt32(questionID);
            Questions questions = bl.EditQuestion(quesID);
            return Json(questions, JsonRequestBehavior.AllowGet);
        }
        public JsonResult UpdateQuestion(string questionID, string question, string discription)
        {
            QuestionBL bl = new QuestionBL();
            int quesID = Convert.ToInt32(questionID);
            string res = bl.UpdateQuestion(quesID, question, discription ?? "");
            if (res == "1")
            {
                return Json("Successfully Updated!!", JsonRequestBehavior.AllowGet);
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteQuestion(string questionID)
        {
            QuestionBL bl = new QuestionBL();
            int quesID = Convert.ToInt32(questionID);
            string res = bl.DeleteQuestion(quesID);
            if (res == "1")
            {
                return Json("Successfully Deleted!!", JsonRequestBehavior.AllowGet);
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        // Forum 

        public JsonResult GetReplyForAQuestions(string questionID)
        {
            ReplyBL rBl = new ReplyBL();
            if (!string.IsNullOrEmpty(questionID))
            {
                int quesID = Convert.ToInt32(questionID);
                List<Replys> replys = rBl.GetReplyForAQuestions(quesID);
                return Json(replys, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("No replies found for the selected question", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult PostReply(string QuestionId, string Reply)
        {
            string res = "";
            if (!string.IsNullOrEmpty(QuestionId) && !string.IsNullOrEmpty(Reply))
            {
                ReplyBL rBl = new ReplyBL();
                int quesId = Convert.ToInt32(QuestionId);
                res = rBl.InsertIntoReply(quesId, Reply);
                if (res == "1")
                {
                    return Json("Replied Successfully!!", JsonRequestBehavior.AllowGet);
                }
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        public JsonResult UpdateIntoReply(string reply, string replyId)
        {
            string res = "";
            if (!string.IsNullOrEmpty(replyId) && !string.IsNullOrEmpty(reply))
            {
                ReplyBL rBl = new ReplyBL();
                int replyID = Convert.ToInt32(replyId);
                res = rBl.UpdateIntoReply(reply, replyID);
                if (res == "1")
                {
                    return Json("Updated Reply Successfully!!", JsonRequestBehavior.AllowGet);
                }
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetReplyaToEdit(string replyId)
        {
            string res = "";
            if (!string.IsNullOrEmpty(replyId))
            {
                ReplyBL rBl = new ReplyBL();
                int replyID = Convert.ToInt32(replyId);
                Replys replys = rBl.GetReplyaToEdit(replyID);
                return Json(replys, JsonRequestBehavior.AllowGet);
            }
            return Json("", JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteAReply(string replyId)
        {
            string res = "";
            if (!string.IsNullOrEmpty(replyId))
            {
                ReplyBL rBl = new ReplyBL();
                int replyID = Convert.ToInt32(replyId);
                res = rBl.DeleteAReply(replyID);
                if (res == "1")
                {
                    return Json("Deleted Reply Successfully!!", JsonRequestBehavior.AllowGet);
                }
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}