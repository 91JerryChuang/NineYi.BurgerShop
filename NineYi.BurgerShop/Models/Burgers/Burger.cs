using NineYi.BurgerShop.Models.Breads;
using NineYi.BurgerShop.Models.Interfaces;
using NineYi.BurgerShop.Models.Meats;
using NineYi.BurgerShop.Models.Veggies;

namespace NineYi.BurgerShop.Models.Burgers
{
    /// <summary>
    /// 漢堡。
    /// </summary>
    /// <seealso cref="NineYi.BurgerShop.Models.Interfaces.IDish" />
    public abstract class Burger : IDish
    {
        /// <summary>
        /// 取得或設定名稱。
        /// </summary>
        /// <value>
        /// 名稱。
        /// </value>
        public string Name { get; protected set; }

        /// <summary>
        /// 取得或設定麵包。
        /// </summary>
        /// <value>
        /// 麵包。
        /// </value>
        public Bread Bread { get; set; }

        /// <summary>
        /// 取得或設定蔬菜。
        /// </summary>
        /// <value>
        /// 蔬菜。
        /// </value>
        public Veggie Veggie { get; set; }

        /// <summary>
        /// 取得或設定肉類。
        /// </summary>
        /// <value>
        /// 肉類。
        /// </value>
        public Meat Meat { get; set; }

        /// <summary>
        /// 取得烹飪的方法。
        /// </summary>
        /// <returns>
        /// 烹飪方法的字串。
        /// </returns>
        public string GetCookingMethod()
        {
            var cookingMethod =
                $"Cooking {this.Name}! Bread used:{this.Bread}, Veggie used:{this.Veggie}, Meat used:{this.Meat}...";

            return cookingMethod;
        }
    }
}