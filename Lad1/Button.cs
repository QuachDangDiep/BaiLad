using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lad1
{
    class Button : Window
    {
        public Button (int top, int left) : base(top, left)
        {
        }
        // an override version (not keyword) because in the
        // derived method we change the behavior
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top,left);
        }
    }
}