using System;

namespace PracticeForDesignpattern
{
    public abstract class Pizza
    {
        public abstract decimal GetPrice();

        public enum PizzaType
        {
            RedPaper, Kimchi
        }
        public static Pizza PizzaFactory(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.RedPaper:
                    return new RedPaperPizza();
                case PizzaType.Kimchi:
                    return new KimchiPizza();
            }
            throw new System.NotSupportedException("The pizza type " +
            pizzaType.ToString() + " is not recognized.");
        }

    }
    public class RedPaperPizza : Pizza
    {
        private decimal price = 8.5M;
        public override decimal GetPrice() { return price; }
    }
    public class KimchiPizza : Pizza
    {
        private decimal price = 10.5M;
        public override decimal GetPrice() { return price; }
    }

    class MainApp
    {
        static void Main()
        {
            Console.WriteLine(Pizza.PizzaFactory(Pizza.PizzaType.Kimchi).GetPrice().ToString("C3"));

        }
    }
}