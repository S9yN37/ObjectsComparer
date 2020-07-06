using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsComparer.Utils
{
    public interface IMemberNameAndGroup
    {
        string Group { get; set; }
        string Name { get; set; }
    }
}
