using System.ComponentModel;

namespace NineYi.BurgerShop.Commons.Enums
{
    /// <summary>
    /// 漢堡列舉。
    /// </summary>
    public enum BurgerEnum
    {
        /// <summary>
        /// 香雞堡。
        /// </summary>
        [Description("香雞堡")]
        Chicken = 0,

        /// <summary>
        /// 豬肉堡。
        /// </summary>
        [Description("豬肉堡")]
        Pork = 1
    }
}