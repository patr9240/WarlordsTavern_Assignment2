using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WarlordsTavern.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<RestaurantContext>
    {
        protected override void Seed(RestaurantContext context)
        {
            var FoodTypes = new List<FoodType>
            {
                new FoodType { Name = "Feast" },
                new FoodType { Name = "Critical Strike" },
                new FoodType { Name = "Mastery" },
                new FoodType { Name = "Versatillity" },
                new FoodType { Name = "Stamina" },
                new FoodType { Name = "Haste" },
            };

            new List<Food>
            {
                new Food { Name = "Blackrock Barbecue", Description = "Delightful blackrock Ham, Grilled Gulper and a sprig of Fireweed on a stick.", FoodType = FoodTypes.Single(g => g.Name == "Critical Strike"), Price = 12.89M, DishPictureUrl = "/Assets/Images/DishPhotos/blackrockbarbeque.jpg" },
                new Food { Name = "Calamari Crepe", Description = "Succulent Rylak Crepe topped with Fiery Calamari, sprinkled with Nagrand Arrowbloom.", FoodType = FoodTypes.Single(g => g.Name == "Critical Strike"), Price = 9.70M, DishPictureUrl = "/Assets/Images/DishPhotos/calamaricrepes.jpg" },
                new Food { Name = "Frosty Stew", Description = "Refreshing stew with pan-seared Talbuk, Sturgeon, and Frostweed.", FoodType = FoodTypes.Single(g => g.Name == "Haste"), Price = 11.00M, DishPictureUrl = "/Assets/Images/DishPhotos/frostystew.jpg" },
                new Food { Name = "Gorgrond Chowder", Description = "Skulker Chowder with hearty chunks of Clefthoof Sausages.", FoodType = FoodTypes.Single(g => g.Name == "Versatillity"), Price = 11.59M, DishPictureUrl = "/Assets/Images/DishPhotos/gorgronchowder.jpg" },
                new Food { Name = "Sleeper Surprise", Description = "Braised Riverbeast on a Sleeper Cake, garnished with Starflowers.", FoodType = FoodTypes.Single(g => g.Name == "Mastery"), Price = 15.99M, DishPictureUrl = "/Assets/Images/DishPhotos/sleepersurprise.jpg" },
                new Food { Name = "Talador Surf and Turf", Description = "A Hearty Elekk Steak with a side of Steamed Scorpion and Talador Orchids.", FoodType = FoodTypes.Single(g => g.Name == "Stamina"), Price = 19.66M, DishPictureUrl = "/Assets/Images/DishPhotos/taladorsurfandturf.jpg" },
                new Food { Name = "Pickled Eel", Description = "A Pickled Gulper Eel in a jar. Why would you eat this?", FoodType = FoodTypes.Single(g => g.Name == "Critical Strike"), Price = 5.99M, DishPictureUrl = "/Assets/Images/DishPhotos/pickledeel.jpg" },
                new Food { Name = "Salty Squid Roll", Description = "Ammonite tentacles wrapped in a doughy breading.", FoodType = FoodTypes.Single(g => g.Name == "Critical Strike"), Price = 2.70M, DishPictureUrl = "/Assets/Images/DishPhotos/saltysquidroll.jpg" },
                new Food { Name = "Buttered Sturgeon", Description = "Baked Sturgeon slathered in herb butter.", FoodType = FoodTypes.Single(g => g.Name == "Haste"), Price = 14.55M, DishPictureUrl = "/Assets/Images/DishPhotos/butteredsturgeon.jpg" },
                new Food { Name = "Jumbo Sea Dog", Description = "Delightful Jawless Skulker in a bun with the toppings of your choice.", FoodType = FoodTypes.Single(g => g.Name == "Versatillity"), Price = 8.00M, DishPictureUrl = "/Assets/Images/DishPhotos/jumboseadog.jpg" },
                new Food { Name = "Sleeper Sushi", Description = "Slices of Fat Sleeper on a bed of rice, wrapped with baked seaweed.", FoodType = FoodTypes.Single(g => g.Name == "Mastery"), Price = 3.28M, DishPictureUrl = "/Assets/Images/DishPhotos/sleepersushi.jpg" },
                new Food { Name = "Whiptail Fillet", Description = "A gourmet Whiptail Fillet cooked to perfection.", FoodType = FoodTypes.Single(g => g.Name == "Stamina"), Price = 9.98M, DishPictureUrl = "/Assets/Images/DishPhotos/whiptailfillet.jpg" },
                new Food { Name = "Feast of the Waters", Description = "Lavish feast including all of the seafood we have to offer, cooked to perfection.", FoodType = FoodTypes.Single(g => g.Name == "Feast"), Price = 98.88M, DishPictureUrl = "/Assets/Images/DishPhotos/feastofthewaters.jpg" },
                new Food { Name = "Bountiful Feast", Description = "A plentiful feast with all of the fixings for a perfect Thanksgiving.", FoodType = FoodTypes.Single(g => g.Name == "Feast"), Price = 70.31M, DishPictureUrl = "/Assets/Images/DishPhotos/bountifulfeast.jpg" },
                new Food { Name = "Savage Feast", Description = "A feast prepared with the most savage beasts we have to offer.", FoodType = FoodTypes.Single(g => g.Name == "Feast"), Price = 129.39M, DishPictureUrl = "/Assets/Images/DishPhotos/savagefeast.jpg" }
            }.ForEach(a => context.Foods.Add(a));
        }
    }
}