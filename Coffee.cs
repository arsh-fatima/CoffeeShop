using System;

namespace CoffeeShopSC
{
    public class Coffee
    {
        public static int coffeemaxAmount = 10;
        public int coffeeleft = coffeemaxAmount;
        public int coffeeBought = 0;
        public int coffeeAdded = 0;
        public static string[] coffee = { "Latte", "Cappuccino", "Mocha", "Americano", "Black", "Espresso" };

        public bool CoffeeOut()
        {
            if (coffeemaxAmount == coffeeBought)
            { return true; }
            else
            { return false; }
        }
        public void BuyCoffee()
        {
            if (CoffeeOut() == false)
            {
                if (coffeeBought <= coffeemaxAmount)
                {
                    coffeeBought += 1;
                    coffeeleft -= 1;
                }
            }
        }
        public bool CoffeeIn()
        {
            if (coffeeAdded == coffeemaxAmount)
            { return true; }
            else
            { return false; }
        }
        public void AddCoffee()
        {
            if (CoffeeIn() == false)
            { coffeeAdded += 1; }
        }
        public void sortCoffee(string[] coffee, int n) 
        {
            {
                if (n == 1)
                    return;
                for (int i = 0; i < n - 1; i++)
                    if (coffee[i].CompareTo(coffee[i + 1])>0)
                    {
                        string temp = coffee[i];
                        coffee[i] = coffee[i + 1];
                        coffee[i + 1] = temp;
                    }
                sortCoffee(coffee, n - 1);
            }
        }
    }
}
