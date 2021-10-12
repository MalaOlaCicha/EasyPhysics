using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPhysics_.Models
{
    class ItemsSpec
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Png { get; set; }

        internal static object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
