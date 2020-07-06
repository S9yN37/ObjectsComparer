using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsComparer.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var _comparer = new Comparer<Element>();

            var e1 = new Element
            {
                Name = "N1",
                Items = new List<ElementItem>() {
                    new ElementItem() { ElementId = 101, Description = "D10", Price = new ElementPrice() { Value = 1.1m } },
                }
            };

            var e2 = new Element
            {
                Name = "N1",
                Items = new List<ElementItem>()
                {
                     new ElementItem() { ElementId = 102, Description = "D11", Price = new ElementPrice() { Value = 1.2m } },
                }
            };

            var isEqual = _comparer.Compare(e1, e2, out var differences);

            ResultToOutput(isEqual, differences);

            Console.Read();
        }

        public static void ResultToOutput(bool isEqual, IEnumerable<Difference> differenses)
        {
            Console.WriteLine(isEqual ? "Objects are equal" : string.Join(Environment.NewLine, differenses));
        }
    }
}
