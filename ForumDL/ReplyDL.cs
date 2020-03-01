using ForumModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ForumDL
{
    public class ReplyDL
    {
        //public List<Replys> GetReplyToAllQuestions()
        //{
        //    List<Replys> listReplies = new List<Replys>();
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumDBConnection"].ToString()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand("[dbo].[GetReplyToAllQuestions]", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                con.Open();
        //                SqlDataReader reader = null;
        //                reader = cmd.ExecuteReader();
        //                while (reader.Read())
        //                {
        //                    Replys reply = new Replys();
        //                    reply.QuestionID = reader.GetInt32(reader.GetOrdinal("QuestionID"));
        //                    reply.Question = reader.GetString(reader.GetOrdinal("Question"));
        //                    reply.Reply = reader.IsDBNull(reader.GetOrdinal("Reply")) ? "" : reader.GetString(reader.GetOrdinal("Reply"));
        //                    reply.Discription = reader.IsDBNull(reader.GetOrdinal("Discription")) ? "" : reader.GetString(reader.GetOrdinal("Discription"));
        //                    reply.ReplyID = reader.IsDBNull(reader.GetOrdinal("ReplyID")) ? 0 : reader.GetInt32(reader.GetOrdinal("ReplyID"));
        //                    listReplies.Add(reply);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return listReplies;
        //}

        public List<Replys> GetReplyForAQuestions(int questionID)
        {
            List<Replys> listReplies = new List<Replys>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumDBConnection"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetReplyForAQuestions]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@QuestionID", questionID);
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Replys reply = new Replys();
                            reply.QuestionID = reader.GetInt32(reader.GetOrdinal("QuestionID"));
                            reply.Question = reader.GetString(reader.GetOrdinal("Question"));
                            reply.Reply = reader.IsDBNull(reader.GetOrdinal("Reply")) ? "" : reader.GetString(reader.GetOrdinal("Reply"));
                            reply.Discription = reader.IsDBNull(reader.GetOrdinal("Discription")) ? "" : reader.GetString(reader.GetOrdinal("Discription"));
                            reply.ReplyID = reader.IsDBNull(reader.GetOrdinal("ReplyID")) ? 0 : reader.GetInt32(reader.GetOrdinal("ReplyID"));
                            listReplies.Add(reply);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return listReplies;
        }
        public string InsertIntoReply(int QuestionId, string Reply)
        {
            string result = "";
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumDBConnection"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[InsertIntoReply]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@QuestionID", QuestionId);
                        cmd.Parameters.AddWithValue("@Reply", Reply);
                        con.Open();
                        var val = cmd.ExecuteNonQuery();
                        result = Convert.ToString(val);
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message + ex.StackTrace;
            }
            return result;
        }
        public string UpdateIntoReply(string reply, int replyId)
        {
            string result = "";
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumDBConnection"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[UpdateReply]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Reply", reply);
                        cmd.Parameters.AddWithValue("@ReplyID", replyId);
                        con.Open();
                        var val = cmd.ExecuteNonQuery();
                        result = Convert.ToString(val);
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message + ex.StackTrace;
            }
            return result;
        }
        public Replys GetReplyaToEdit(int replyId)
        {
            Replys reply = new Replys();

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumDBConnection"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetAReply]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ReplyId", replyId);
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            reply.Reply = reader.IsDBNull(reader.GetOrdinal("Reply")) ? "" : reader.GetString(reader.GetOrdinal("Reply"));
                            reply.ReplyID = reader.IsDBNull(reader.GetOrdinal("ReplyID")) ? 0 : reader.GetInt32(reader.GetOrdinal("ReplyID"));
                            return reply;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return reply;
        }
        public string DeleteAReply(int replyId)
        {
            string result = "";
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumDBConnection"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[DeleteReply]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ReplyId", replyId);
                        con.Open();
                        var val = cmd.ExecuteNonQuery();
                        result = Convert.ToString(val);
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message + ex.StackTrace;
            }
            return result;
        }
    }
}
