using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Veggies;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.Factorys;

namespace NineYi.BurgerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. 使用者點餐

            Console.Write("Which shop do you like? (1)Taipei (2)NewYork: ");
            int shopChoice = int.Parse(Console.ReadLine());

            Console.Write("What burger would you like? (1)Chicken (2)Pork: ");
            int burgerChoice = int.Parse(Console.ReadLine());

            //// 2. 準備漢堡
            IFactoryMethod factory;
            Burger burger = null;

            if (shopChoice == 1 && burgerChoice == 1)
            {
                factory = new TaipeiChickenBurgerFactory();
            }
            else if (shopChoice == 1 && burgerChoice == 2)
            {
                factory = new TaipeiPorkBurgerFactory();
            }
            else if (shopChoice == 2 && burgerChoice == 1)
            {
                factory = new NewYorkChickenBurgerFactory();
            }
            else if(shopChoice == 2 && burgerChoice == 2)
            {
                factory = new NewYorkPorkBurgerFactory();
            }
            else
            {
                throw new AggregateException("No such shop or burger!");
            }

            burger = factory.CreateBurger();

            //// 3. 烹飪漢堡
            burger.Cook();
        }
    }
}
