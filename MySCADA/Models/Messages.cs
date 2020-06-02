using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;

namespace NURESCADA.DB
{
    public class MessageData
    {
        public DateTime TimeStamp{ get; set; }
        public int GroupID { get; set; }
        public int MessageID { get; set; }
        public int Kind { get; set; }
        public string Text { get; set; }

        public MessageData(DateTime timeStamp, int groupID, int messageID, int kind, string text)
        {
            this.TimeStamp = timeStamp;
            this.GroupID = groupID;
            this.MessageID = messageID;
            this.Kind = kind;
            this.Text = text;
        }
    }
}
