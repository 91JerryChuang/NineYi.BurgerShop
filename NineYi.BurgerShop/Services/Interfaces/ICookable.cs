using NineYi.BurgerShop.Models.Interfaces;

namespace NineYi.BurgerShop.Services.Interfaces
{
    /// <summary>
    /// 定義可以烹飪的方法。
    /// </summary>
    public interface ICookable
    {
        /// <summary>
        /// 烹飪指定的菜餚。
        /// </summary>
        /// <param name="food">菜餚。</param>
        /// <returns>烹飪後的菜餚。</returns>
        string Cook(IDish dish);
    }
}