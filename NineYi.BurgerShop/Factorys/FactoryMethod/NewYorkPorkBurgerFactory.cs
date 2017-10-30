using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.Veggies;

namespace NineYi.BurgerShop.Factorys
{
    public class NewYorkPorkBurgerFactory : IFactoryMethod
    {
        public Burger CreateBurger()
        {
            return new NewYorkPorkBurger()
            {
                //// 備料
                Bread = new WheatBread(),
                Veggie = new Onion(),
                Meat = new Bacon()
            };
        }
    }
}
