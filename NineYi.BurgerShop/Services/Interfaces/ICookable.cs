namespace NineYi.BurgerShop.Services.Interfaces
{
    /// <summary>
    /// 定義可以烹飪的方法。
    /// </summary>
    public interface ICookable
    {
        /// <summary>
        /// 烹飪指定的食物。
        /// </summary>
        /// <typeparam name="TFood">食物的型別。</typeparam>
        /// <param name="food">食物。</param>
        /// <returns>烹飪後的食物。</returns>
        string Cook<TFood>(TFood food);
    }
}