using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NineYi.BurgerShop.Commons.Enums;
using NineYi.BurgerShop.Models.Breads;
using NineYi.BurgerShop.Models.Burgers;
using NineYi.BurgerShop.Models.Meats;
using NineYi.BurgerShop.Models.Veggies;

namespace NineYi.BurgerShop.Services.Factories
{
    /// <summary>
    /// 廚師工廠。
    /// </summary>
    public class ChefFactory
    {
        /// <summary>
        /// 漢堡食譜。
        /// </summary>
        private static readonly IReadOnlyDictionary<Func<BranchStoreEnum, BurgerEnum, bool>, Burger> _burgerRecipes =
            new Dictionary<Func<BranchStoreEnum, BurgerEnum, bool>, Burger>
            {
                {
                    (branch, burger) => branch == BranchStoreEnum.Taipei && burger == BurgerEnum.Chicken,
                    new TaipeiChickenBurger(new WhiteBread(), new Tomato(), new TaiwanChicken())
                },
                {
                    (branch, burger) => branch == BranchStoreEnum.Taipei && burger == BurgerEnum.Pork,
                    new TaipeiPorkBurger(new WhiteBread(), new Tomato(), new Tenderloin())
                },
                {
                    (branch, burger) => branch == BranchStoreEnum.NewYork && burger == BurgerEnum.Chicken,
                    new NewYorkChickenBurger(new WheatBread(), new Onion(), new Turkey())
                },
                {
                    (branch, burger) => branch == BranchStoreEnum.NewYork && burger == BurgerEnum.Pork,
                    new NewYorkPorkBurger(new WheatBread(), new Onion(), new Bacon())
                },
            };

        /// <summary>
        /// 分店食譜。
        /// </summary>
        private static readonly IReadOnlyDictionary<BranchStoreEnum, ReadOnlyDictionary<BurgerEnum, Burger>> _branchRecipes;

        /// <summary>
        /// 初始化 <see cref="ChefFactory"/> 類別新的執行個體。
        /// </summary>
        static ChefFactory()
        {
            _branchRecipes = GetBranchRecipes();
        }

        /// <summary>
        /// 取得分店的食譜集合。
        /// </summary>
        /// <returns>分店的食譜集合。</returns>
        private static IReadOnlyDictionary<BranchStoreEnum, ReadOnlyDictionary<BurgerEnum, Burger>> GetBranchRecipes()
        {
            var branchRecipes = Enum.GetValues(typeof(BranchStoreEnum))
                .Cast<BranchStoreEnum>().ToDictionary(
                branch => branch,
                branch => new ReadOnlyDictionary<BurgerEnum, Burger>(
                    Enum.GetValues(typeof(BurgerEnum)).Cast<BurgerEnum>()
                    .ToDictionary(
                        burger => burger,
                        burger => _burgerRecipes.FirstOrDefault(x => x.Key(branch, burger) == true).Value)));

            return branchRecipes;
        }

        /// <summary>
        /// 新建指定分店的廚師。
        /// </summary>
        /// <param name="branchStore">分店。</param>
        /// <returns>指定分店的廚師。</returns>
        public static Chef Create(BranchStoreEnum branchStore)
        {
            var recipes =
                _branchRecipes.Where(x => x.Key == branchStore).SelectMany(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            var chef = new Chef(recipes);

            return chef;
        }
    }
}