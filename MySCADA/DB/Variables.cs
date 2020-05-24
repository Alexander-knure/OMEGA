using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NURESCADA.DB
{
    public class Variable
    {
        public uint id;
        public String name;
        public String description;

        public Variable()
        {

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
            return list.Select(i => i.id).ToList();
        }
        public List<String> GetName()
        {
            return list.Select(i => i.name).ToList();
        }
        public List<String> GetDescrition()
        {
            return list.Select(i => i.description).ToList();
        }
    }
}
