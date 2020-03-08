using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    class Forum
    {
        public long MessageId { get; set; }
        public string TopicName { get; set; }
        public int Importance { get; set; }
        public string MessageBody { get; set; }
        public DateTime TimeStamp
        {
            get { return this.TimeStamp; }
            set { TimeStamp = DateTime.Now; }
        }
        public User ForumUser { get; set; }


    }
}
