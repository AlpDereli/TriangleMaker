// See https://aka.ms/new-console-template for more information
triangleMaker make = new triangleMaker();
int h = make.dim1();
int l = make.dim2();
make.make(h, l);

class triangleMaker
{
    public int dim1()
    {
        Console.WriteLine("Integer Height: ");
        int h = int.Parse(Console.ReadLine());
        return h;
    }
    public int dim2() 
    {
        Console.WriteLine("Integer Length: ");
        int l = int.Parse(Console.ReadLine());
        return l;
    }
    public void make(int h, int l)
    {
        for (int i = 0; i < l; i++) 
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for (int i = 0;i < h; i++)
        {
            Console.Write("*");
            Console.Write(string.Concat(Enumerable.Repeat(" ",l-3)));
            Console.WriteLine("*");
            l -= 2;
            if (l <= 2)
            {
                Console.WriteLine("*");
                break;
            }
        }
    }
}