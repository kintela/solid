using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceProject.Model
{
    public class Rectangle:Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public int Area()
        {
            return Height * Width;
        }
    }
}
