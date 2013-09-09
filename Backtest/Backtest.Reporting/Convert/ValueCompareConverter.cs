using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CoastalClientWPF.Converters
{
    public class ValueCompareConverter : IValueConverter
    {
        public double ReferenceValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool returnValue = false;
            if (parameter.ToString() == "LessThan")
            {
                if (value.ToString() == "Short")
                { 
                    value = -1; 
                }
                else if (value.ToString() == "Long")
                {
                    value = 1;
                }
                else if (value.ToString() == "Other" || value.ToString() == "")
                {
                    value = 0;
                }
                returnValue = System.Convert.ToDouble(value) < ReferenceValue;
            }
            else
            {
                if (value.ToString() == "Short")
                { 
                    value = -1; 
                }
                else if (value.ToString() == "Long")
                { 
                    value = 1; 
                }
                else if (value.ToString() == "Other" || value.ToString() == "")
                { 
                    value = 0; 
                }
                returnValue = System.Convert.ToDouble(value) > ReferenceValue;
            }



            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
