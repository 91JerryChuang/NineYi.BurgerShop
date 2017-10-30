namespace NineYi.BurgerShop.Models.Meats
{
    /// <summary>
    /// 台灣土雞。
    /// </summary>
    /// <seealso cref="NineYi.BurgerShop.Models.Meats.Meat" />
    public class TaiwanChicken : Meat
    {
        /// <summary>
        /// 初始化 <see cref="TaiwanChicken"/> 類別新的執行個體。
        /// </summary>
        public TaiwanChicken()
        {
            this.Name = "Taiwan Chicken";
        }
    }
}