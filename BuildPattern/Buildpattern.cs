using System;

namespace PracticeForDesignPattern
{
    class BuilderPattern
    {
        //actual order a Pizza from customer
        class BuilderExample
        {
        }
        //"product"
        class Pizza
        {
            private String dough = "";
            private String sauce = "";
            private String topping = "";

            public void setDough(String dough) { this.dough = dough; }
            public void setSauce(String sauce) { this.sauce = sauce; }
            public void setTopping(String topping) { this.topping = topping; }
        }
        //"Abstract Builder"
        abstract class PizzaBuilder
        {
            protected Pizza pizza;

            public Pizza getPizza() { return pizza; }
            public void createNewPizzaProduct() { pizza = new Pizza(); }

            public abstract void buildDough();
            public abstract void buildSauce();
            public abstract void buildTopping();
        }

        //"ConcreteBuilder"
        class KimchiPizzaBuilder : PizzaBuilder
        {
            public override void buildDough() { pizza.setDough("cross"); }
            public override void buildSauce() { pizza.setDough("GoChuJang"); }
            public override void buildTopping() { pizza.setTopping("Redpaper"); }
        }
        class SeaFoodPizzaBuilder : PizzaBuilder
        {
            public override void buildDough() { pizza.setDough("Pancake"); }
            public override void buildSauce() { pizza.setDough("soy"); }
            public override void buildTopping() { pizza.setTopping("squeed"); }
        }
        //"Director"
        class Jumo
        {
            private PizzaBuilder pizzaBuilder;
            public void setPizzaBuilder(PizzaBuilder pb) { pizzaBuilder = pb; }
            public Pizza getPizza() { return pizzaBuilder.getPizza(); }

            public void constructPizza()
            {
                pizzaBuilder.createNewPizzaProduct();
                pizzaBuilder.buildDough();
                pizzaBuilder.buildSauce();
                pizzaBuilder.buildTopping();
            }
        }
        static void Main(string[] args)
        {
            Jumo jumo = new Jumo();
            PizzaBuilder kimchi_Pizzabuilder = new KimchiPizzaBuilder();
            PizzaBuilder SeaFood_Pizzabuilder = new SeaFoodPizzaBuilder();

            jumo.setPizzaBuilder(kimchi_Pizzabuilder);
            jumo.constructPizza();

            Pizza pizza = jumo.getPizza();
        }
    }
}
