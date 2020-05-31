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
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Variable(uint id, string name, string description)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
        }
    }

    public class Variables
    {
        public List<Variable> list { get; set; }

        public Variables()
        {
            this.list = new List<Variable>();
        }
        public void Add(Variable variable)
        {
            list.Add(variable);
        }
        public void Clear()
        {
            list.Clear();
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
    }
}
