namespace NineYi.BurgerShop.Models.Meats
{
    /// <summary>
    /// 肉類。
    /// </summary>
    public abstract class Meat
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