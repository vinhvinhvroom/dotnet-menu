using System;

namespace dotnet_DinerMax3000Console {
    class Program {
        static void Main (string[] args) {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem ("Salmon", "Fresh Norwegian Salmon with butter", 25.50);
            summerMenu.AddMenuItem("Taco", "Al Pastor Taco with corn tortilla", 10);
            summerMenu.HospitalDirections = "Right around the corner";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Name = "Drink Menu";
            outsideDrinks.Disclaimer = "Do not drink and code.";
            outsideDrinks.AddMenuItem("Old Fashioned", "A classic.", 10); 
            outsideDrinks.AddMenuItem("Mojito", "Fresh!", 12); 
            outsideDrinks.AddMenuItem("Pina Colada", "Refreshing!", 11); 

            Order hungryGuestOrder = new Order(); 

            for(int x = 0; x <= summerMenu.items.Count;)
        }
    }
}