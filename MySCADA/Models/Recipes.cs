using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NURESCADA.DB
{
    public class Recipe
    {

        public uint ID { get; set; }
        public string Name { get; set; }
        public DateTime TimeStamp { get; set; }
        public float K1 { get; set; }
        public float K2 {get; set;}
        public float K3 {get; set;}
        public string Comment { get; set; }


        public Recipe(uint id, string name, DateTime timeStamp, float k1, float k2,  float k3,string comment)
        {
            this.ID = id;
            this.Name = name;
            this.TimeStamp = timeStamp;
            this.K1 = k1;
            this.K2 = k2;
            this.K3 = k3;
            this.Comment = comment;
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
