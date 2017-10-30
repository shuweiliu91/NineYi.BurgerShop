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
            Burger burger = SimpleFactory.CreateBurger(shopChoice, burgerChoice);

            //// 3. 烹飪漢堡
            burger.Cook();
        }
    }
}
