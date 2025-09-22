using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225458_PhamHuuPhuoc_Real11_Flyweight
{
    public class CharacterZ : Character
    {
        // Constructor
        public CharacterZ()
        {
            symbol = 'Z';
            height = 100;
            width = 100;
            ascent = 68;
            descent = 0;
        }
        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(this.symbol +
                " (pointsize " + this.pointSize + ")");
        }
    }
}
