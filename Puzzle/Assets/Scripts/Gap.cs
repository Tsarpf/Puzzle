using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class Gap
    {
        Triangle top;
        Triangle left;
        Triangle right;

        public Boolean isComplete()
        {
            //if (top.bottomLine && left.rightLine && right.leftLine have same colour)
            // return true;

            return false;           
        }
    }
}
