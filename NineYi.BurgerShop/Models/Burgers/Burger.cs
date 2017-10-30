using System;
using NineYi.BurgerShop.Models.Breads;
using NineYi.BurgerShop.Models.Meats;
using NineYi.BurgerShop.Models.Veggies;

namespace NineYi.BurgerShop.Models.Burgers
{
    /// <summary>
    /// 漢堡。
    /// </summary>
    public abstract class Burger
    {
        /// <summary>
        /// 取得或設定名稱。
        /// </summary>
        /// <value>
        /// 名稱。
        /// </value>
        public string Name { get; set; }

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
        /// 烹飪漢堡。
        /// </summary>
        public void Cook()
        {
            Console.WriteLine("Cooking {0}! Bread used:{1}, Veggie used:{2}, Meat used:{3}...", this.Name, this.Bread, this.Veggie, this.Meat);

            Console.WriteLine("Your {0} is ready. Enjoy it!", this.Name);
        }
    }
}