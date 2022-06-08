using System;
using System.Collections;
using System.Collections.Generic;

public interface IShape
{
    void Move(int x, int y);
    string Name { get; }
}

public class Triangle : IShape // Constructor?
{
    public Triangle(string name , Point a, Point b, Point c)
    {
        p1 = a; p2 = b; p3 = c;Name = name;
    }
    public Point p1;
    public Point p2;
    public Point p3;
    public void Move(int x, int y)
    {
        p1.x = x + p1.x;
        p2.x = x + p2.x;
        p3.x = x + p3.x;
        p1.y = y + p1.y;
        p2.y = y + p2.y;
        p3.y = y + p3.y;
    }
    public string Name { get; }

}
public class Point
{
    public Point(int a , int b)
    {
        x = a;y=b;
    }
    public int x;
    public int y;
}
public class Circle : IShape
{
    public Circle(string name, Point a, int R)
    {
        Name = name;
        Pc = a;
        r = R;
    }
    public void Move(int x, int y)
    {
        Pc.x = Pc.x + x;
        Pc.y = Pc.y + y;

        
    }

    public string Name { get; }
    public Point Pc;
    private int r;
}

public class Square : IShape // Constructor?
{
    public Square(string name, Point d,int e)
    {
        Name = name;
        a = d;
        z = e;
        p4 = new Point(a.x,z);
        p3 = new Point(a.x + z,a.y + z);
        p2 =  new Point(a.x + z,a.y);
        p1 = new Point(a.x,a.y);
        
        // add();
    }
    // public void add()
    // {
    //     p4.x = a.x;
    //     p4.y = a.y+z;
    //     p3.x = a.x + z;
    //     p3.y = a.y + z;
    //     p2.x = a.x + z;
    //     p2.y = a.y ;
    //     p1.x = a.x;
    //     p1.y = a.y;
    // }

    

    public void Move(int x, int y)
    {
        p1.x = x + p1.x;
        p2.x = x + p2.x;
        p3.x = x + p3.x;
        p1.y = y + p1.y;
        p2.y = y + p2.y;
        p3.y = y + p3.y;
        p4.x = x + p4.x;
        p4.y = y + p4.y;
    }
    public Point p1 ;
    public Point p2;
    public Point p3;
    public Point p4;
    public Point a;
    int z;
    public Square(string name)
    {
        this.Name = name;

    }
    public string Name { get; }

}

public class Board : IEnumerable<IShape>
{

    public void MoveAllShapes(int x, int y)
    {
        foreach (IShape shape in total)
            shape.Move(x, y);
    }

    public IEnumerable<IShape> Shapes { get; }

    public void AddShape(IShape s)
    {
        total.Add(s);
    }

    public IEnumerator<IShape> GetEnumerator()
    {
        // throw new NotImplementedException();
        return new boardenumerator(this);

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        // throw new NotImplementedException();
        return new boardenumerator(this);

    }
    // public IShape[] total;
    public  List<IShape> total = new List<IShape>();
}
public class boardenumerator : IEnumerator<IShape>
{
    private Board s;
    private Board r;
    public boardenumerator(Board c)
    {
        this.s = c;
    }
    private int Pos = -1;
    public IShape Current 
    {
        get
            {
                // if (Pos == 0)
                //     return s.total[0];
                // else if (Pos < s.total.Count + 1)
                //     return s.total[Pos-1];
                // else 
                //     return s.total[Pos-s.total.Count-1];
                return s.total[Pos];
            }
    }

    object IEnumerator.Current 
    {
        get
            {
                return this.Pos;
            }
    }

    public void Dispose()
    {
        
    }

    public bool MoveNext()
    {
        this.Pos++;
        return Pos < s.total.Count;
        // return true;
        
    }

    public void Reset()
    {
        this.Pos = -1;
    }
}

public class BoardProgram
{
    public static void Main(string[] args)
    {
        // Point a1 = new Point() { x = 2, y = 5 };
        // Point b1 = new Point() { x = 4, y = 3 };
        // Point c1 = new Point() { x = 7, y = 1 };
        // Point d1 = new Point() { x = 10, y = 8 };

        // Board b = new Board();
        // Circle c = new Circle("ball", 1, 2, 3);
        // Circle c2 = new Circle("target", 1, 2, 3);
        // Square s1 = new Square("window", a1, b1, c1, d1);//("target", 1, 2, 3);
        // b.AddShape(c);
        // b.AddShape(c2);
        // b.AddShape(s1);
        // foreach (IShape s in b)
        // {
        //     Console.WriteLine(s.Name);
        // }
    }
}