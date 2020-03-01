using System;
using System.Collections.Generic;
using System.Text;

namespace ForumModel
{
    public class Replys
    {
        public int ReplyID { get; set; }
        public int QuestionID { get; set; }
        public string Reply { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsEnable { get; set; }
        public string Question { get; set; }
        public string Discription { get; set; }
    }

    public class QuestionAndReplies
    {
        public int ReplyID { get; set; }
        public int QuestionID { get; set; }
        public List<string> Reply { get; set; }
        public string Question { get; set; }
        public string Discription { get; set; }
    }
}
