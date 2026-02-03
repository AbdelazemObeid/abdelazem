using ConsoleApp1;
Circle c = new Circle(5);
c.area();
Rectangle r = new Rectangle(4, 6);
r.area();
Square s = new Square(4);
s.area();
Console.Write("Enter num of shapes in picture : ");
int n = int.Parse(Console.ReadLine());
Shape[] shapes = new Shape[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter shape {i+1} type (1-Circle, 2-Rectangle, 3-Square) : ");
    int shapeType = int.Parse(Console.ReadLine());
    switch (shapeType)
    {
        case 1:
            Console.Write("Enter radius of circle : ");
            int radius = int.Parse(Console.ReadLine());
            shapes[i] = new Circle(radius);
            break;
        case 2:
            Console.Write("Enter length of rectangle : ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter width of rectangle : ");
            int width = int.Parse(Console.ReadLine());
            shapes[i] = new Rectangle(length, width);
            break;
        case 3:
            Console.Write("Enter side of square: ");
            int side = int.Parse(Console.ReadLine());
            shapes[i] = new Square(side);
            break;
        default:
            Console.WriteLine("Invalid shape type.");
            i--;
            break;
    }
}
Picture p = new Picture(shapes);
p.area();
