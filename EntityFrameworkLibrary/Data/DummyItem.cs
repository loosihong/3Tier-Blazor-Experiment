using System;

namespace EntityFrameworkLibrary
{
    public class DummyItem
    {
        public Guid? ID { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitCost { get; set; }
    }
}
