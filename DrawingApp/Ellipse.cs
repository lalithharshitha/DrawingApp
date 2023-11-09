using System;
namespace DrawingApp
{
	public class Ellipse:Widgets
	{
        public double horizontalDiameter;
        public double verticalDiameter;
        public double area;

		public Ellipse(string name, int x, int y, int a, int b) : base(name, x, y)
        {
            horizontalDiameter = a;
            verticalDiameter= b;
        }

        public override void Draw()
        {
            area = horizontalDiameter * verticalDiameter * Math.PI;
            Console.WriteLine($"{widgetname} - Horizontal Diameter:{horizontalDiameter}, Vertical Diameter:{verticalDiameter},(x:{xCoordinate},y:{yCoordinate}),Area:{area}");
        }
    }
}

