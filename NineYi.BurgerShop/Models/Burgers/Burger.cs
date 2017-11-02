using System;
using System.Collections.Generic;
using System.Linq;
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
        /// 名稱。
        /// </summary>
        private readonly string _name;

        /// <summary>
        /// 取得名稱。
        /// </summary>
        /// <value>
        /// 名稱。
        /// </value>
        public string Name { get { return _name; } }

        /// <summary>
        /// 麵包。
        /// </summary>
        private readonly Bread _bread;

        /// <summary>
        /// 取得麵包。
        /// </summary>
        /// <value>
        /// 麵包。
        /// </value>
        public Bread Bread { get { return _bread; } }

        /// <summary>
        /// 蔬菜。
        /// </summary>
        private readonly Veggie _veggie;

        /// <summary>
        /// 取得蔬菜。
        /// </summary>
        /// <value>
        /// 蔬菜。
        /// </value>
        public Veggie Veggie { get { return _veggie; } }

        /// <summary>
        /// 肉類。
        /// </summary>
        private readonly Meat _meat;

        /// <summary>
        /// 取得肉類。
        /// </summary>
        /// <value>
        /// 肉類。
        /// </value>
        public Meat Meat { get { return _meat; } }

        public Burger(string name, Bread bread, Veggie veggie, Meat meat)
        {
            var paramsChecklist = new Dictionary<string, Func<bool>>
            {
                { nameof(name), () => string.IsNullOrWhiteSpace(name) },
                { nameof(bread), () => bread == null },
                { nameof(veggie), () => veggie == null },
                { nameof(meat), () => meat == null }
            };

            var paramName = paramsChecklist.FirstOrDefault(x => x.Value() == true).Key;
            if (string.IsNullOrWhiteSpace(paramName) == false)
            {
                throw new ArgumentException(paramName);
            }

            this._name = name;
            this._bread = bread;
            this._veggie = veggie;
            this._meat = meat;
        }

        /// <summary>
        /// 取得烹飪的方法。
        /// </summary>
        /// <returns>
        /// 烹飪方法的字串。
        /// </returns>
        public virtual string GetCookingMethod()
        {
            var cookingMethod =
                $"Cooking {this.Name}! Bread used: {this.Bread.Name}, Veggie used: {this.Veggie.Name}, Meat used: {this.Meat.Name}...";

            return cookingMethod;
        }
    }
}