using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.BurgerShop.Burgers;

namespace NineYi.BurgerShop.Factorys
{
    public interface IFactoryMethod
    {
        Burger CreateBurger();
    }
}
