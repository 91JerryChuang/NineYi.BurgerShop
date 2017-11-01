using System;
using System.Text;
using NineYi.BurgerShop.Commons.Enums;
using NineYi.BurgerShop.Models.Interfaces;
using NineYi.BurgerShop.Services.Interfaces;

namespace NineYi.BurgerShop.Services
{
    /// <summary>
    /// 廚師抽象類別。
    /// </summary>
    /// <seealso cref="NineYi.BurgerShop.Services.Interfaces.ICookable" />
    public abstract class Chef : ICookable
    {
        /// <summary>
        /// 所屬分店。
        /// </summary>
        private readonly BranchStoreEnum _branchStore;

        /// <summary>
        /// 取得所屬分店。
        /// </summary>
        /// <value>
        /// 所屬分店。
        /// </value>
        public BranchStoreEnum BranchStore { get { return this._branchStore; } }

        /// <summary>
        /// 初始化 <see cref="Chef"/> 類別新的執行個體。
        /// </summary>
        /// <param name="branchStore">所屬分店。</param>
        /// <exception cref="ArgumentException">branchStore</exception>
        public Chef(BranchStoreEnum branchStore)
        {
            if (Enum.IsDefined(typeof(BranchStoreEnum), branchStore) == false)
            {
                throw new ArgumentException(nameof(branchStore));
            }

            this._branchStore = branchStore;
        }

        /// <summary>
        /// 烹飪指定的菜餚。
        /// </summary>
        /// <param name="dish"></param>
        /// <returns>
        /// 烹飪後的菜餚。
        /// </returns>
        public virtual string Cook(IDish dish)
        {
            var cookingMethod = dish.GetCookingMethod();

            var cookedDish = new StringBuilder()
                .AppendLine(cookingMethod)
                .AppendLine($"Your {dish.Name} is ready. Enjoy it!")
                .ToString();

            return cookedDish;
        }
    }
}