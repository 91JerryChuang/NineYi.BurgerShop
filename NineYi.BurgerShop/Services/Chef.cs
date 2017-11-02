using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineYi.BurgerShop.Commons.Enums;
using NineYi.BurgerShop.Models.Burgers;
using NineYi.BurgerShop.Services.Interfaces;

namespace NineYi.BurgerShop.Services
{
    /// <summary>
    /// 廚師類別。
    /// </summary>
    /// <seealso cref="NineYi.BurgerShop.Services.Interfaces.ICookable" />
    public class Chef : ICookable
    {
        /// <summary>
        /// 漢堡食譜。
        /// </summary>
        private readonly IReadOnlyDictionary<BurgerEnum, Burger> _burgerRecipes;

        /// <summary>
        /// 初始化 <see cref="Chef" /> 類別新的執行個體。
        /// </summary>
        /// <param name="burgerRecipes">漢堡食譜。</param>
        /// <exception cref="ArgumentException">burgerRecipes</exception>
        public Chef(IReadOnlyDictionary<BurgerEnum, Burger> burgerRecipes)
        {
            if (burgerRecipes == null || burgerRecipes.Any() == false)
            {
                throw new ArgumentException(nameof(burgerRecipes));
            }

            this._burgerRecipes = burgerRecipes;
        }

        /// <summary>
        /// 烹飪指定的菜餚。
        /// </summary>
        /// <param name="burgerType">漢堡的種類。</param>
        /// <returns>
        /// 烹飪後的菜餚。
        /// </returns>
        public string Cook(BurgerEnum burgerType)
        {
            Burger burger;

            if (this._burgerRecipes.TryGetValue(burgerType, out burger) == false)
            {
                return "菜單上沒有這個漢堡。";
            }

            var cookingMethod = burger.GetCookingMethod();

            var cookedBurger = new StringBuilder()
                .AppendLine(cookingMethod)
                .AppendLine($"Your {burger.Name} is ready. Enjoy it!")
                .ToString();

            return cookedBurger;
        }
    }
}