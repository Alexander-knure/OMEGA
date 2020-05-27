using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NURESCADA.DB
{
    public class Recipe
    {
        private uint id;
        private string name;
        private DateTime timeStamp;
        private float k1;
        private float k2;
        private float k3;

        public uint ID { get; set; }
        public string Name { get; set; }
        public DateTime TimeStamp { get; set; }
        public float K1 { get; set; }
        public float K2 {get; set;}
        public float K3 {get; set;}


        public Recipe(uint id, string name, DateTime timeStamp, float k1, float k2,  float k3)
        {
            this.id = id;
            this.name = name;
            this.timeStamp = timeStamp;
            this.k1 = k1;
            this.k2 = k2;
            this.k3 = k3;
        }
    }
    public class Recipes
    {
        public List<Recipe> list { get; set; }

        public Recipes()
        {
            this.list = new List<Recipe>();
        }
        public void Add(Recipe recipe)
        {
            list.Add(recipe);
        }
        public List<uint> GetID()
        {
            return list.Select(i => i.ID).ToList();
        }
        public List<string> GetName()
        {
            return list.Select(i => i.Name).ToList();
        }
        public List<DateTime> GetTimeStamp()
        {
            return list.Select(i => i.TimeStamp).ToList();
        }
        public List<float> GetK1()
        {
            return list.Select(i => i.K1).ToList();
        }
        public List<float> GetK2()
        {
            return list.Select(i => i.K2).ToList();
        }
        public List<float> GetK3()
        {
            return list.Select(i => i.K3).ToList();
        }

    }
}
