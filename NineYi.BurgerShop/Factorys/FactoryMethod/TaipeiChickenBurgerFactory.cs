using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.Veggies;

namespace NineYi.BurgerShop.Factorys
{
    public class TaipeiChickenBurgerFactory : IFactoryMethod
    {
        public Burger CreateBurger()
        {
            return new TaipeiChickenBurger()
            {
                //// 備料
                Bread = new WhiteBread(),
                Veggie = new Tomato(),
                Meat = new TaiwanChicken()
            };
        }
    }
}
