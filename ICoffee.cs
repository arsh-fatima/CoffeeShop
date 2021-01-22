namespace CoffeeShopSC
{
    public interface ICoffee
    {
        int CoffeeAdded { get; set; }
        int CoffeeBought { get; set; }
        bool CoffeeIn { get; }
        int Coffeeleft { get; set; }

        int AddCoffee();
        int BuyCoffee();
        bool Equals(object obj);
        int GetCoffeeBought();
        bool GetCoffeeOut();
        int GetHashCode();
        void SetCoffeeBought(int value);
        string ToString();
    }
}