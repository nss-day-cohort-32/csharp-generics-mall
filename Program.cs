using System;

namespace TheMall
{
    class Program
    {
        static void Main(string[] args)
        {
            DollarStore Dollarama = new DollarStore();

            DollarItem MultiColorPen = new DollarItem(){
                Name = "Multi Colored Pen with 12 Colors"
            };

            Dollarama.AddToInventory("mcp", MultiColorPen);

            FoodStore Cinnabon = new FoodStore();

            FoodItem ClassicRoll = new FoodItem(){
                Name = "The Classic Roll",
                Price = 3.50,
                Calories = 880
            };
            
            FoodItem CaramelPecanbon = new FoodItem(){
                Name = "Caramel Pecanbon",
                Price = 6,
                Calories = 1080
            };

            Cinnabon.AddToInventory("tcr", ClassicRoll);
            Cinnabon.AddToInventory("cp", CaramelPecanbon);

            Console.WriteLine(Dollarama.GetFromInventory("mcp").Name);
            Console.WriteLine(Cinnabon.GetFromInventory("tcr").Name);
        }
    }
}
