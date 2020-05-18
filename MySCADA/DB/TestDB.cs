using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NURESCADA
{
    //auth user
    public class Row
    {
        public uint id { get; set; }
        public string password { get; set; }
        public DateTime last_login { get; set; }
        public String username { get; set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String email { get; set; }
        public DateTime date_joined { get; set; }

        public Row()
        {

        }
    }
    public class TestDB
    {
        public List<Row> list { get; set; }

        public TestDB()
        {
            this.list = new List<Row>();
        }
        public List<uint> GetListID()
        {
            return list.Select(i => i.id).ToList();
        }
        public List<string> GetListPassword()
        {
            return list.Select(i => i.password).ToList();
        }
        public List<DateTime> GetListLastLogin()
        {
            return list.Select(i => i.last_login).ToList();
        }
        public List<String> GetListUsername()
        {
            return list.Select(i => i.username).ToList();
        }
        public List<String> GetListFirstname()
        {
            return list.Select(i => i.first_name).ToList();
        }
        public List<String> GetListLastame()
        {
            return list.Select(i => i.last_name).ToList();
        }
        public List<String> GetListEmail()
        {
            return list.Select(i => i.email).ToList();
        }
        public List<DateTime> GetListDateJoined()
        {
            return list.Select(i => i.date_joined).ToList();
        }
    }
}
