namespace NineYi.BurgerShop.Models.Sauces
{
    /// <summary>
    /// 醬汁。
    /// </summary>
    public abstract class Sauce
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