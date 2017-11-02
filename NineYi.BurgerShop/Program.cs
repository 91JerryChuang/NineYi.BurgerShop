using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineYi.BurgerShop.Commons.Enums;
using NineYi.BurgerShop.Commons.Helpers;
using NineYi.BurgerShop.Services.Factories;

namespace NineYi.BurgerShop
{
    /// <summary>
    /// 主控台程式。
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 主程式。
        /// </summary>
        /// <param name="args">參數集合。</param>
        private static void Main(string[] args)
        {
            var againChoice = YesNoEnum.No;

            do
            {
                // 1. 使用者點餐。
                var choiceBranchStoreQuestion = GenerateMultipleChoiceQuestion<BranchStoreEnum>("你喜歡哪個分店？");
                var shopChoice = GetUserInput(
                    choiceBranchStoreQuestion,
                    (input) => (BranchStoreEnum)Enum.Parse(typeof(BranchStoreEnum), input),
                    (result) => Enum.IsDefined(typeof(BranchStoreEnum), result));

                var choiceBurgerQuestion = GenerateMultipleChoiceQuestion<BurgerEnum>("你想要什麼漢堡？");
                var burgerChoice = GetUserInput(
                    choiceBurgerQuestion,
                    (input) => (BurgerEnum)Enum.Parse(typeof(BurgerEnum), input),
                    (result) => Enum.IsDefined(typeof(BurgerEnum), result));

                // 2. 聘請廚師。
                var chef = ChefFactory.Create(shopChoice);

                // 3. 烹飪漢堡。
                Console.WriteLine(chef.Cook(burgerChoice));

                // 4. 再點一份漢堡。
                var againQuestion = GenerateMultipleChoiceQuestion<YesNoEnum>("要再點一份漢堡？");
                againChoice = GetUserInput(
                    againQuestion,
                    (input) => (YesNoEnum)Enum.Parse(typeof(YesNoEnum), input),
                    (result) => Enum.IsDefined(typeof(YesNoEnum), result));
            } while (againChoice == YesNoEnum.Yes);

            Console.WriteLine("銘謝惠顧。");
        }

        /// <summary>
        /// 產生選擇題的問題文字。
        /// </summary>
        /// <typeparam name="TEnum">列舉型別。</typeparam>
        /// <param name="question">問題。</param>
        /// <returns>選擇題的問題文字。</returns>
        /// <exception cref="ArgumentException"></exception>
        private static string GenerateMultipleChoiceQuestion<TEnum>(string question)
            where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            var enumType = typeof(TEnum);
            var paramsChecklist = new Dictionary<string, Func<bool>>
            {
                { nameof(TEnum), () => enumType.IsEnum == false },
                { nameof(question), () => string.IsNullOrWhiteSpace(question) }
            };

            var paramName = paramsChecklist.FirstOrDefault(x => x.Value() == true).Key;
            if (string.IsNullOrWhiteSpace(paramName) == false)
            {
                throw new ArgumentException(paramName);
            }

            var choiceOptions = GetChoiceOptions<TEnum>();

            var multipleChoiceQuestion = new StringBuilder()
                .AppendLine(question)
                .AppendLine(choiceOptions)
                .ToString();

            return multipleChoiceQuestion;
        }

        /// <summary>
        /// 取得選項文字。
        /// </summary>
        /// <typeparam name="TEnum">列舉型別。</typeparam>
        /// <returns>選項文字。</returns>
        /// <exception cref="ArgumentException">TEnum</exception>
        private static string GetChoiceOptions<TEnum>()
            where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            var enumType = typeof(TEnum);
            if (enumType.IsEnum == false)
            {
                throw new ArgumentException(nameof(TEnum));
            }

            var descriptions = EnumHelper.GetDescriptions<TEnum>();

            var choiceOptions = string.Join("、", descriptions.Select(x =>
                $"({Convert.ChangeType(x.Key, enumType.GetEnumUnderlyingType()).ToString()}){x.Value}"));

            return choiceOptions.ToString();
        }

        /// <summary>
        /// 取得使用者輸入值。
        /// </summary>
        /// <typeparam name="TResult">回傳值的型別。</typeparam>
        /// <param name="question">問題。</param>
        /// <param name="converter">輸入值的轉換器。</param>
        /// <param name="validator">輸入值的驗證器。</param>
        /// <returns>使用者輸入值。</returns>
        /// <exception cref="ArgumentException">question</exception>
        private static TResult GetUserInput<TResult>(
            string question, Func<string, TResult> converter, Func<TResult, bool> validator)
        {
            if (string.IsNullOrWhiteSpace(question))
            {
                throw new ArgumentException(nameof(question));
            }

            TResult result = default(TResult);
            var isInputError = true;

            do
            {
                try
                {
                    Console.Write(question);
                    var input = Console.ReadLine();
                    result = converter(input);
                    isInputError = validator(result) == false;

                    if (isInputError)
                    {
                        Console.WriteLine($"輸入錯誤請重新輸入。{Environment.NewLine}");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"輸入錯誤請重新輸入。{Environment.NewLine}");
                }
            } while (isInputError);

            return result;
        }
    }
}