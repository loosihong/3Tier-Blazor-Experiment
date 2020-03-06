using System;
using System.Collections.Generic;

namespace EntityFrameworkLibrary
{
    public class Dummy
    {
        public Guid? ID { get; set; }
        public string TextFieldValue { get; set; }
        public string TextAreaValue { get; set; }
        public DateTime? DateTimeValue { get; set; }
        public string SelectStringValue { get; set; }
        public int? SelectIntValue { get; set; }
        public string RadioStringValue { get; set; }
        public int? RadioIntValue { get; set; }
        public List<string> CheckboxStringValues { get; set; }
        public List<int?> CheckboxIntValues { get; set; }
        public List<DummyItem> DummyItems { get; set; }
    }
}
