using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.Veggies;

namespace NineYi.BurgerShop.Factorys
{
    public class NewYorkChickenBurgerFactory : IFactoryMethod
    {
        public Burger CreateBurger()
        {
            return new NewYorkChickenBurger()
            {
                //// 備料
                Bread = new WheatBread(),
                Veggie = new Onion(),
                Meat = new Turkey()
            };
        }
    }
}
