using System;
namespace DrawingApp
{
	public class TextBox:Rectangle
	{
		public string backgroundColor;
		public string text;

		public TextBox(string name, int x, int y, int h, int w,string bgcolor,string t=null) : base(name, x, y,h,w)
        {
			backgroundColor = string.IsNullOrEmpty(t) ? "red": bgcolor;
			text = t;
		}

        public override void Draw()
		{
			size = height * width;
            Console.WriteLine($"{widgetname} -  height:{height},width:{width},(x:{xCoordinate},y:{yCoordinate}),BackGround Color:{backgroundColor} {text}");
        }
        
    }
}

