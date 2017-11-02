namespace NineYi.BurgerShop.Models.Breads
{
    /// <summary>
    /// 麵包類。
    /// </summary>
    public abstract class Bread
    {
        /// <summary>
        /// 取得或設定名稱。
        /// </summary>
        /// <value>
        /// 名稱。
        /// </value>
        public string Name { get; protected set; }
    }
}