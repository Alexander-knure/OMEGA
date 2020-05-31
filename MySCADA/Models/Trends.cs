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


        public uint ID { get; set; }
        public DateTime Timestamp { get; set; }
        public float Value { get; set; }
        public short Quality { get; set; }


        public Trend(uint id, DateTime timestamp, float  value, short  quality)
        {
            this.ID = id;
            this.Timestamp = timestamp;
            this.Value = value;
            this.Quality = quality;
        }
    }
    public class Trends
    {
        public List<Trend> list { get; set; }

        public Trends()
        {
            this.list = new List<Trend>();
        }
        public void Add(Trend trend)
        {
            list.Add(trend);
        }
        public List<DateTime> GetTimestamp()
        {
            return list.Select(i => i.Timestamp).ToList();
        }
        public List<float> GetValue()
        {
            return list.Select(i => i.Value).ToList();
        }
        public List<short> GetQuality()
        {
            return list.Select(i => i.Quality).ToList();
        }
    }
}
