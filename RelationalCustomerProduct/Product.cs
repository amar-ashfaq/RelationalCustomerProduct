using System;
using System.Drawing;
using FileHelpers;
using FileHelpers.Events;

namespace RelationalCustomerProduct
{
    [IgnoreEmptyLines]
    [DelimitedRecord(",")]
    public class Product : INotifyRead
    {
        public int id { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int depth { get; set; }

        [FieldConverter(typeof(ColourConverter))]
        public Color colour { get; set; }

        [FieldConverter(typeof(ImageConverter))]
        public Image image { get; set; }
        public string category { get; set; }

        [FieldHidden]
        public bool isSelected { get; set; }
        public bool IsNewRecord()
        {
            return id == 0;
        }

        public void BeforeRead(BeforeReadEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.RecordLine))
            {
                e.SkipThisRecord = true;
            }
        }

        public void AfterRead(AfterReadEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new Exception("Product code is missing!");
            }
        }
    }
}