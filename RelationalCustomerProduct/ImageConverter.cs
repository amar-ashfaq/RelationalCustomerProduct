using FileHelpers;
using System.Drawing;

namespace RelationalCustomerProduct
{
    public class ImageConverter : ConverterBase
    {
        ImageConversion images = new ImageConversion();
        public override object StringToField(string from)
        {
            return images.Base64ToImage(from);
        }

        public override string FieldToString(object from)
        {
            return (string)images.ImageToBase64((Bitmap)from);
        }
    }
}
