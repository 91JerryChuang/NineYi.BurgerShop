namespace NineYi.BurgerShop.Models.Burgers
{
    /// <summary>
    /// 紐約豬肉堡。
    /// </summary>
    /// <seealso cref="NineYi.BurgerShop.Models.Burgers.Burger" />
    public class NewYorkPorkBurger : Burger
    {
        /// <summary>
        /// 初始化 <see cref="NewYorkPorkBurger"/> 類別新的執行個體。
        /// </summary>
        public NewYorkPorkBurger()
        {
            this.Name = "NewYork Pork Burger";
        }
    }
}