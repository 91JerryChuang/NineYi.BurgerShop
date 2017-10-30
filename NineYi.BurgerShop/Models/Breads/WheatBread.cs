namespace NineYi.BurgerShop.Models.Breads
{
    /// <summary>
    /// 全麥麵包。
    /// </summary>
    /// <seealso cref="NineYi.BurgerShop.Models.Breads.Bread" />
    public class WheatBread : Bread
    {
        /// <summary>
        /// 初始化 <see cref="WheatBread"/> 類別新的執行個體。
        /// </summary>
        public WheatBread()
        {
            this.Name = "Wheat Bread";
        }
    }
}