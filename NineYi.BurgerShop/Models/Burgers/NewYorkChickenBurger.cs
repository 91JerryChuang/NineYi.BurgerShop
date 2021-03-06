﻿using NineYi.BurgerShop.Models.Breads;
using NineYi.BurgerShop.Models.Meats;
using NineYi.BurgerShop.Models.Veggies;

namespace NineYi.BurgerShop.Models.Burgers
{
    /// <summary>
    /// 紐約香雞堡。
    /// </summary>
    /// <seealso cref="NineYi.BurgerShop.Models.Burgers.Burger" />
    public class NewYorkChickenBurger : Burger
    {
        /// <summary>
        /// 初始化 <see cref="NewYorkChickenBurger"/> 類別新的執行個體。
        /// </summary>
        /// <param name="bread">麵包。</param>
        /// <param name="veggie">蔬菜。</param>
        /// <param name="meat">肉類。</param>
        public NewYorkChickenBurger(Bread bread, Veggie veggie, Meat meat)
            : base("NewYork Chicken Burger", bread, veggie, meat)
        {
        }
    }
}