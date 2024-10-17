using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution
{
     public class Rectangle
    {        
        protected int _height, _width;
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
        public int GetWidth() 
            => _width;

        public int GetHeight() 
            => _height;

        public void SetWidth(int width) 
            => _width=width;

        public void SetHeight(int height) 
            => _height = height;

        public int GetArea() 
            => _width * _height;
            public Rectangle()
        {
            
        }

        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;
        }
    }
}
