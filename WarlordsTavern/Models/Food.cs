using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Food.cs
     Patrick Ross - Ryan Jameson
     Worlds End Tavern
     This is the custom model class of type Food

*/
namespace WarlordsTavern.Models
{
    public class Food
    {
        /// <summary>
        /// This is the empty constrcutor
        /// </summary>
        public Food()
        {
        }
        /// <summary>
        /// This constructor takes one parameter - Name
        /// </summary>
        /// <param name="Name"></param>
        public Food(string Name)
        {
            this.Name = Name;
        }
        public virtual int FoodID { get; set; }
        public virtual int FoodTypeID { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string Description { get; set; }
        public virtual string DishPictureUrl { get; set; }
        public virtual FoodType FoodType { get; set; }


    }
}
