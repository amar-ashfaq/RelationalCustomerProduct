using System;
using FileHelpers;
using FileHelpers.Events;

namespace RelationalCustomerProduct
{
    [IgnoreEmptyLines]
    [DelimitedRecord(",")]
    public class Customer : INotifyRead
    {
        public int id { get; set; }
        public string account { get; set; }
        public string name { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string address_line_3 { get; set; }
        public string address_line_4 { get; set; }
        public string address_postcode { get; set; }

        public bool IsNewRecord()
        {
            return id == 0;
        }

        public void BeforeRead(BeforeReadEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.RecordLine)) e.SkipThisRecord = true;
        }

        public void AfterRead(AfterReadEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(account)) throw new Exception("Customer account is missing!");
        }
    }
}
