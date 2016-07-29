using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     FoodType.cs
     Patrick Ross - Ryan Jameson
     Worlds End Tavern
     This is the custom model class of type FoodType

*/
namespace WarlordsTavern.Models
{
    public class FoodType
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public FoodType()
        {
        }

        /// <summary>
        /// This constructor takes one parameter - Name
        /// </summary>
        /// <param name="Name"></param>
        public FoodType(string Name)
        {
            this.Name = Name;
        }
        public virtual int FoodTypeID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual List<Food> Foods { get; set; }
    }
}
