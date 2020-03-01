using System;

namespace ForumModel
{
    public class Questions
    {
        public int QuestionID { get; set; }
        public string Question { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsEnable { get; set; }
    }
}
