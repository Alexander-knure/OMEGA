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
}
