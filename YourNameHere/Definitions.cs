using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNameHere
{
    public class Definitions
    {
        public class Lettere
        {
            public string Letters { get; set; }
            public string Color { get; set; }
            public bool NumPad { get; set; }

        }
        public class AllLetters
        {
            public Lettere[] Text { get; set; }
        }
    }
}
