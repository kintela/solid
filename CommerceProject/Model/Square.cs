using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceProject.Model
{
    public class Square:Shape
    {
        public int SideLength { get; set; }

        public int Area()
        {
            return SideLength * SideLength;
        }
    }
}
