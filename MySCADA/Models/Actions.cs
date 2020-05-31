using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NURESCADA.Models
{
    public class ActionData
    {
        public DateTime TimeStamp { get; set; }
        public int UserID { get; set; }
        public string Text { get; set; }

        public ActionData(DateTime timeStamp, int userID, string text)
        {
            this.TimeStamp = timeStamp;
            this.UserID = userID;
            this.Text = text;
        }
    }
    public class Actions
    {
        public List<ActionData> list;

        public Actions()
        {
            list = new List<ActionData>();
        }
        public void Add(ActionData ad)
        {
            list.Add(ad);
        }
        public List<DateTime> GetTimestamp()
        {
            return list.Select(i => i.TimeStamp).ToList();
        }
        public List<int> GetUserID()
        {
            return list.Select(i => i.UserID).ToList();
        }
        public List<string> GetText()
        {
            return list.Select(i => i.Text).ToList();
        }
    }
}
