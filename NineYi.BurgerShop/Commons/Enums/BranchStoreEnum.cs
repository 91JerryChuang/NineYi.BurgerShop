using System.ComponentModel;

namespace NineYi.BurgerShop.Commons.Enums
{
    /// <summary>
    /// 分店列舉。
    /// </summary>
    public enum BranchStoreEnum
    {
        /// <summary>
        /// 台北。
        /// </summary>
        [Description("台北")]
        Taipei = 0,

        /// <summary>
        /// 紐約。
        /// </summary>
        [Description("紐約")]
        NewYork = 1,

        /// <summary>
        /// 東京。
        /// </summary>
        [Description("東京")]
        Tokyo = 2
    }
}