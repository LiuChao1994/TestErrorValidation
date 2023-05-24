using System;
using System.Globalization;
using System.Windows.Controls;

namespace TestErrorValidation.Validation
{
    public class CustomValidationRule : ValidationRule
    {
        /// <summary>
        /// 待校验数据类型
        /// </summary>
        public string ValidateType { get; set; }

        /// <summary>
        /// 数据校验
        /// </summary>
        /// <param name="value">待校验数据</param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                string valueString = value?.ToString().Trim();

                if (string.IsNullOrEmpty((value ?? "").ToString()))
                {
                    return new ValidationResult(false, "*不能为空！");
                }

                //Int值校验
                if (ValidateType == "IntPlusVdt")
                {
                    if (!int.TryParse(valueString, out int res) || res <= 0)
                    {
                        return new ValidationResult(false, "*该数据应为正整数！");
                    }

                    return new ValidationResult(true, null);
                }

                return new ValidationResult(true, null);
            }
            catch (Exception e)
            {
                return new ValidationResult(false, e.Message);
            }
        }
    }
}
