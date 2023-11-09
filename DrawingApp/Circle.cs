using System;
using System.Drawing;

namespace DrawingApp
{
	public class Circle:Widgets
	{
		public int radius;
		public double area;

		public Circle(string name,int x,int y,int r):base(name,x,y)
		{
			radius = r;
		}

        public override void Draw()
        {
			area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{widgetname} - (x:{xCoordinate},y:{yCoordinate}), Area:{area}");
        }
    }
}

