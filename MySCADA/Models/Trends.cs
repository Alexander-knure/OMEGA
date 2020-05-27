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
        private uint id { get; set; }
        private DateTime timestamp { get; set; }
        private float value { get; set; }
        private short quality { get; set; }

        public uint ID { get; set; }
        public DateTime Timestamp { get; set; }
        public float Value { get; set; }
        public short Quality { get; set; }


        public Trend(uint id, DateTime timestamp, float  value, short  quality)
        {
            this.id = id;
            this.timestamp = timestamp;
            this.value = value;
            this.quality = quality;
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
