using NineYi.BurgerShop.Models.Breads;
using NineYi.BurgerShop.Models.Meats;
using NineYi.BurgerShop.Models.Veggies;

namespace NineYi.BurgerShop.Models.Burgers
{
    /// <summary>
    /// 台北香雞堡。
    /// </summary>
    /// <seealso cref="NineYi.BurgerShop.Models.Burgers.Burger" />
    public class TaipeiChickenBurger : Burger
    {
        /// <summary>
        /// 初始化 <see cref="TaipeiChickenBurger"/> 類別新的執行個體。
        /// </summary>
        public TaipeiChickenBurger(Bread bread, Veggie veggie, Meat meat)
            : base("Taipei Chicken Burger", bread, veggie, meat)
        {
        }
    }
}