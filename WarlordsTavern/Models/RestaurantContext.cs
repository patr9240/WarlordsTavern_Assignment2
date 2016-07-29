namespace WarlordsTavern.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /*
     RestaurantContext.cs
     Patrick Ross - Ryan Jameson
     Worlds End Tavern
     This is model context of Worlds End Tavern

*/

    public partial class RestaurantContext : DbContext
    {
        public RestaurantContext()
            : base("name=RestaurantConnection")
        {
        }
        public virtual DbSet<FoodType> FoodTypes { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
    }
}
