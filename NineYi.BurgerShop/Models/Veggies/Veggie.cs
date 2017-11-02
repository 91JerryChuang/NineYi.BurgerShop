namespace NineYi.BurgerShop.Models.Veggies
{
    /// <summary>
    /// 蔬菜類。
    /// </summary>
    public abstract class Veggie
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