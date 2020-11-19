using FileHelpers;
using System.Drawing;

namespace RelationalCustomerProduct
{
    public class ColourConverter : ConverterBase
    {      
        public override object StringToField(string from)
        {
            return Color.FromArgb(int.Parse(from));
        }

        public override string FieldToString(object pColorToConvertFrom)
        {           
            Color colour = (Color)pColorToConvertFrom;
            int a = colour.ToArgb();
            return a.ToString();
        }
    }
}
