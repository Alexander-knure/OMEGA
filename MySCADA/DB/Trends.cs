using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NURESCADA
{
    //auth user
    public class Trend
    {
        public uint id { get; set; }
        public DateTime timestamp { get; set; }
        public float value { get; set; }
        public ushort quality { get; set; }

        public Trend()
        {
        }
    }
    public class Trends
    {
        public List<Trend> list { get; set; }

        public Trends()
        {
            this.list = new List<Trend>();
        }
        public List<DateTime> GetTimestamp()
        {
            return list.Select(i => i.timestamp).ToList();
        }
        public List<float> GetValue()
        {
            return list.Select(i => i.value).ToList();
        }
        public List<ushort> GetQuality()
        {
            return list.Select(i => i.quality).ToList();
        }
    }
}
