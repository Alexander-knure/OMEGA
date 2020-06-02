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
}
