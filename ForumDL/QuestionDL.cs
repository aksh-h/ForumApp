using ForumModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ForumDL
{
    public class QuestionDL
    {
        public string InsertQuestion(string question, string discription)
        {
            string result;
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumDBConnection"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[InsertIntoQuestions]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Question", question);
                        cmd.Parameters.AddWithValue("@Discription", discription);
                        con.Open();
                        var val = cmd.ExecuteNonQuery();
                        result = Convert.ToString(val);
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message + "\n" + ex.StackTrace;
            }
            return result;
        }
        public List<Questions> GetAllQuestion()
        {
            List<Questions> lque = new List<Questions>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumDBConnection"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetAllQuestions]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Questions que = new Questions();
                            que.QuestionID = reader.GetInt32(reader.GetOrdinal("QuestionID"));
                            que.Question = reader.GetString(reader.GetOrdinal("Question"));
                            que.Description = reader.GetString(reader.GetOrdinal("Discription"));
                            que.CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                            lque.Add(que);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return lque;
        }
        public string UpdateQuestion(int questionID, string question, string discription)
        {
            string result;
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumDBConnection"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[UpdateQuestion]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@QuestionID", questionID);
                        cmd.Parameters.AddWithValue("@Question", question);
                        cmd.Parameters.AddWithValue("@Discription", discription);
                        con.Open();
                        var val = cmd.ExecuteNonQuery();
                        result = Convert.ToString(val);
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message + "\n" + ex.StackTrace;
            }
            return result;
        }
        public Questions EditQuestion(int questionID)
        {
            Questions que = new Questions();
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumDBConnection"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[GetQuestion]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@QuestionID", questionID);
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            que.QuestionID = reader.GetInt32(reader.GetOrdinal("QuestionID"));
                            que.Question = reader.IsDBNull(reader.GetOrdinal("Question")) ? "" : reader.GetString(reader.GetOrdinal("Question"));
                            que.Description = reader.IsDBNull(reader.GetOrdinal("Discription")) ? "" : reader.GetString(reader.GetOrdinal("Discription"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return que;
        }
        public string DeleteQuestion(int questionID)
        {
            string result;
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ForumDBConnection"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[DeleteQuestion]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@QuestionID", questionID);
                        con.Open();
                        var val = cmd.ExecuteNonQuery();
                        result = Convert.ToString(val);
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message + "\n" + ex.StackTrace;
            }
            return result;
        }
    }
}
