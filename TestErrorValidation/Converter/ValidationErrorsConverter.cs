using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace TestErrorValidation.Converter
{

    /*
     此转换器是为了
       <!--<TextBlock Margin="0 3" Text="{Binding Path=(Validation.Errors)[0].ErrorContent,
                    RelativeSource={RelativeSource AncestorType=TextBox,Mode=FindAncestor},StringFormat=*{0}}"
                    Name="errorTxt" Grid.Row="1" />-->
    的
       Path=(Validation.Errors)[0].ErrorContent 会出现为null的情况
     */

    /// <summary>
    /// 该转换器检查Validation.Errors集合是否为空，
    /// 并根据需要返回适当的字符串
    /// </summary>
    public class ValidationErrorsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is ReadOnlyObservableCollection<ValidationError> errors && errors.Count > 0)
            {
                return errors[0].ErrorContent.ToString();
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
