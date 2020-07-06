using ObjectsComparer.CustomComparers;
using ObjectsComparer.Utils;
using System.Collections.Generic;

namespace ObjectsComparer.ConsoleTest
{
    public class Element
    {
        public Element()
        {
            Items = new List<ElementItem>();
        }

        public string Name { get; set; }

        [MemberNameAndGroup("Reservation", "Rooms")]
        public IList<ElementItem> Items { get; set; }
    }

    public class ElementItem : IComparableEnumerableItem
    {
        public ElementItem()
        {
            Price = new ElementPrice();
        }

        public int ElementId { get; set; }
        public string Description { get; set; }
        [MemberNameAndGroup("RoomPrice", null)]
        public ElementPrice Price { get; set; }

        public string Key => ElementId.ToString();
    }

    public class ElementPrice : IComparableEnumerableItem
    {
        public decimal Value { get; set; }
        public string Key => Value.ToString();
    }
}
