using System;
using NineYi.BurgerShop.Models.Breads;
using NineYi.BurgerShop.Models.Meats;
using NineYi.BurgerShop.Models.Sauces;
using NineYi.BurgerShop.Models.Veggies;

namespace NineYi.BurgerShop.Models.Burgers
{
    /// <summary>
    /// 東京千島醬豬肉堡。
    /// </summary>
    /// <seealso cref="NineYi.BurgerShop.Models.Burgers.Burger" />
    public class TokyoPorkBurger : Burger
    {
        /// <summary>
        /// 醬料。
        /// </summary>
        private readonly Sauce _sauce;

        /// <summary>
        /// 取得醬料。
        /// </summary>
        /// <value>
        /// 醬料。
        /// </value>
        public Sauce Sauce { get { return _sauce; } }

        /// <summary>
        /// 初始化 <see cref="TokyoChickenBurger"/> 類別新的執行個體。
        /// </summary>
        /// <param name="bread">麵包。</param>
        /// <param name="veggie">蔬菜。</param>
        /// <param name="meat">肉類。</param>
        /// <param name="sauce">醬汁。</param>
        /// <exception cref="ArgumentNullException">sauce</exception>
        public TokyoPorkBurger(Bread bread, Veggie veggie, Meat meat, Sauce sauce)
            : base("Tokyo Pork Burger", bread, veggie, meat)
        {
            if (sauce == null)
            {
                throw new ArgumentNullException(nameof(sauce));
            }

            this._sauce = sauce;
        }

        /// <summary>
        /// 取得烹飪的方法。
        /// </summary>
        /// <returns>
        /// 烹飪方法的字串。
        /// </returns>
        public override string GetCookingMethod()
        {
            var cookingMethod =
                $"Cooking {this.Name}! Bread used: {this.Bread.Name}, Veggie used: {this.Veggie.Name}, Meat used: {this.Meat.Name}, Sauce used: {this.Sauce.Name}...";

            return cookingMethod;
        }
    }
}