using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace RelationalCustomerProduct
{
    class ImageConversion
    {
        public string ImageToBase64(Image img)
        {
            if (img == null) return "";
            
            using (MemoryStream m = new MemoryStream())
            {
                Bitmap b = new Bitmap(img);

                b.Save(m, ImageFormat.Jpeg);
                byte[] imageBytes = m.ToArray();

                string base64String = Convert.ToBase64String(imageBytes);   // Convert byte[] to Base64 String
                return base64String;
            }
        }

        public Image Base64ToImage(string base64str)
        {
            if (!string.IsNullOrWhiteSpace(base64str))
            {
                byte[] bytes = Convert.FromBase64String(base64str);
                Image m = null;

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    m = Image.FromStream(ms);
                }
                return m;
            }
            return null;
        }
    }
}
