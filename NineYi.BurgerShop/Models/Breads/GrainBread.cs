namespace NineYi.BurgerShop.Models.Breads
{
    /// <summary>
    /// 穀類麵包。
    /// </summary>
    /// <seealso cref="NineYi.BurgerShop.Models.Breads.Bread" />
    public class GrainBread : Bread
    {
        /// <summary>
        /// 初始化 <see cref="GrainBread"/> 類別新的執行個體。
        /// </summary>
        public GrainBread()
        {
            this.Name = "Grain Bread";
        }
    }
}