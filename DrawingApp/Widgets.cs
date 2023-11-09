using System;
namespace DrawingApp
{
	public class Widgets
	{
		public string widgetname;

		public int xCoordinate;

		public int yCoordinate;

		public Widgets(string name, int x, int y)
		{
			widgetname = name;
			xCoordinate = x;
			yCoordinate = y;
		}

		public virtual void Draw()
		{
			Console.WriteLine($"{widgetname},(x:{xCoordinate},y:{yCoordinate})");
		}
	}
}

