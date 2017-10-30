using System;
using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.Veggies;


namespace NineYi.BurgerShop.Factorys
{
    public class SimpleFactory
    {
        public static Burger CreateBurger(int shopChoice, int burgerChoice)
        {
            if (shopChoice == 1 && burgerChoice == 1)
            {
                return new TaipeiChickenBurger()
                {
                    //// 備料
                    Bread = new WhiteBread(),
                    Veggie = new Tomato(),
                    Meat = new TaiwanChicken()
                };
            }
            else if (shopChoice == 1 && burgerChoice == 2)
            {
                return new TaipeiPorkBurger()
                {
                    //// 備料
                    Bread = new WhiteBread(),
                    Veggie = new Tomato(),
                    Meat = new Tenderloin()
                };
            }
            else if (shopChoice == 2 && burgerChoice == 1)
            {
                return new NewYorkChickenBurger()
                {
                    //// 備料
                    Bread = new WheatBread(),
                    Veggie = new Onion(),
                    Meat = new Turkey()
                };
            }
            else if (shopChoice == 2 && burgerChoice == 2)
            {
                return new NewYorkPorkBurger()
                {
                    //// 備料
                    Bread = new WheatBread(),
                    Veggie = new Onion(),
                    Meat = new Bacon()
                };
            }
            else
            {
                throw new AggregateException("No such shop or burger!");
            }
        }
    }
}
