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
    public class Messages
    {
        public List<MessageData> list { get; set; }

        public Messages()
        {
            this.list = new List<MessageData>();
        }
        public void Add(MessageData md)
        {
            list.Add(md);
        }
        public List<DateTime> GetTimeStamp()
        {
            return list.Select(i => i.TimeStamp).ToList();
        }
        public List<int> GetGroupID()
        {
            return list.Select(i => i.GroupID).ToList();
        }
        public List<int> GetMessageID()
        {
            return list.Select(i => i.MessageID).ToList();
        }
        public List<int> GetKind()
        {
            return list.Select(i => i.Kind).ToList();
        }
        public List<string> GetText()
        {
            return list.Select(i => i.Text).ToList();
        }
    }
}
