using System;
namespace DrawingApp
{
	public class Rectangle : Widgets
	{
        public int height;
        public int width;
        public int size;

        public Rectangle(string name, int x, int y, int h, int w) : base(name, x, y)
        {
            height = h;
            width = w;
        }

        public override void Draw()
        {
            size = height * width;
            Console.WriteLine($"{widgetname} - (x:{xCoordinate},y:{yCoordinate}), height;{height},width:{width},size:{size}");
        }
    }
}

