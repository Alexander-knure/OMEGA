using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NURESCADA.DB
{
    public class Variable
    {
        private uint id;
        private string name;
        private string description;

        public uint ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Variable(uint id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }

    public class Variables
    {
        public List<Variable> list { get; set; }

        public Variables()
        {
            this.list = new List<Variable>();
        }
        public List<uint> GetID()
        {
            return list.Select(i => i.ID).ToList();
        }
        public List<string> GetName()
        {
            return list.Select(i => i.Name).ToList();
        }
        public List<string> GetDescrition()
        {
            return list.Select(i => i.Description).ToList();
        }
        public void Add(uint _id, string _name, string _description)
        {
            list.Add(new Variable(_id, _name, _description));
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
