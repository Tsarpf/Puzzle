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

        public Gap(Triangle left, Triangle right, Triangle top)
        {
            this.top = top;
            this.right = right;
            this.left = left;
        }

        public Boolean isComplete()
        {
            //if (top.bottomLine && left.rightLine && right.leftLine have same colour)
            // return true;

            return false;           
        }
    }
}
