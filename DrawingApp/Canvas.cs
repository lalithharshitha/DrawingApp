using System;
namespace DrawingApp
{
	public class Canvas
	{
		List<Widgets> widgets = new List<Widgets>();

		public void add(Widgets widget)
		{
			widgets.Add(widget);
		}

		public void print()
		{
			foreach(var widget in widgets)
			{
				widget.Draw();
			}
		}
	}
}

