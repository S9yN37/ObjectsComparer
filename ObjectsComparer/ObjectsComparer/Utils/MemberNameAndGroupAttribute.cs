using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsComparer.Utils
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MemberNameAndGroupAttribute : Attribute, IMemberNameAndGroup
    {
        public string Group { get; set; }
        public string Name { get; set; }

        public MemberNameAndGroupAttribute(string group, string name)
        {
            Group = group;
            Name = name;
        }
    }
}
