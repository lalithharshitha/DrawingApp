namespace DrawingApp;

class Program
{
    static void Main(string[] args)
    {
        Canvas canvas = new Canvas();

        canvas.add(new Square("Square", 3, 5, 10,10));
        canvas.add(new Rectangle("Rectangle", 5, 6, 7, 8));
        canvas.add(new Circle("Circle", 8, 7, 9));
        canvas.add(new Ellipse("Ellipse", 3, 14, 20, 4));
        canvas.add(new TextBox("TextBox", 4, 5, 6, 7, "green","Hello, Welcome to Drawing App"));
        canvas.add(new TextBox("TextBox", 10, 90, 30, 40, "yellow"));

        canvas.print();
    }
}

