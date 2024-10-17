using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution
{
    public class Square : Rectangle
    {
        public Square()
        {
            
        }
        public Square(int side) 
        {
            _height =_width = side;
        }
        public void SetSquareHeight(int height)=>SetHeight(height);
        public void SetSquareWidth(int width) => SetWidth(width);
        public override int Height { set => base.Height=base.Width = value; }
        public override int Width { set => base.Height = base.Width = value; }
    }
}
