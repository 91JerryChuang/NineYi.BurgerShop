namespace NineYi.BurgerShop.Models.Interfaces
{
    /// <summary>
    /// 定義菜餚的方法。
    /// </summary>
    public interface IDish
    {
        /// <summary>
        /// 取得烹飪的方法。
        /// </summary>
        /// <returns>
        /// 烹飪方法的字串。
        /// </returns>
        string GetCookingMethod();
    }
}