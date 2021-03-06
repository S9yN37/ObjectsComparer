﻿using ObjectsComparer.CustomComparers;
using ObjectsComparer.Utils;
using System.Collections.Generic;

namespace ObjectsComparer.Examples.Example7
{
    public class Element
    {
        public string Name { get; set; }

        [MemberNameAndGroup("Reservation", "Rooms")]
        public IList<ElementItem> Items { get; set; }
    }

    public class ElementItem : IComparableEnumerableItem
    {
        public int ElementId { get; set; }
        public string Description { get; set; }
        [MemberNameAndGroup("RoomPrice", null)]
        public ElementPrice Price { get; set; }

        public string Key => ElementId.ToString();
    }

    public class ElementPrice
    {
        public decimal Value { get; set; }
    }
}
