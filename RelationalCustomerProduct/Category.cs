using System;
using FileHelpers;
using FileHelpers.Events;

namespace RelationalCustomerProduct
{
    [IgnoreEmptyLines]
    [DelimitedRecord(",")]
    public class Category : INotifyRead
    {
        public Category()
        {
            IsNewRecord = true;
        }

        [FieldHidden]
        public bool IsNewRecord { get; set; }

        public string code { get; set; }
        public string description { get; set; }

        public void BeforeRead(BeforeReadEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.RecordLine)) e.SkipThisRecord = true;         
        }

        public void AfterRead(AfterReadEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(code)) throw new Exception("Category code is missing!");           
        }
    }
}