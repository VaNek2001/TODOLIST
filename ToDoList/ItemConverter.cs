using System;
using System.Globalization;

namespace ToDoList
{
    public class ItemConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null && values.Length == 2)
            {
                string Title = values[0].ToString();
                string Color = values[1].ToString();
                Console.WriteLine(Title + " " + Color);
                return new Item { Title = Title, Color = Color };
            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

