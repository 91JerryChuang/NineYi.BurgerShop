using NineYi.BurgerShop.Models.Breads;
using NineYi.BurgerShop.Models.Meats;
using NineYi.BurgerShop.Models.Veggies;

namespace NineYi.BurgerShop.Models.Burgers
{
    /// <summary>
    /// 台北豬肉堡。
    /// </summary>
    /// <seealso cref="NineYi.BurgerShop.Models.Burgers.Burger" />
    public class TaipeiPorkBurger : Burger
    {
        /// <summary>
        /// 初始化 <see cref="TaipeiPorkBurger"/> 類別新的執行個體。
        /// </summary>
        public TaipeiPorkBurger(Bread bread, Veggie veggie, Meat meat)
            : base("Taipei Pork Burger", bread, veggie, meat)
        {
        }
    }
}