using System;
public class Shape
{
    public Shape(string name, int cornerCount)
    {
        Corners = new Point[cornerCount];
    }

    public void UpdateCorner(int i, Point p)
    {
        Corners[i]=p;
    }

    public Point GetCorner(int i)
    {
        return Corners[i];
        throw new NotImplementedException();

    }

    public void SwitchXY( Point p)
    {
        tmp = p.X;
        p.X = p.Y;
        p.Y = tmp;
    }

    public void ExchangeCorners(int i, int j)
    {
        x = Corners[i];
        Corners[i] = Corners[j];
        Corners[j]=x;
    }

    public void PrintCorners()
    {
        for (int i = 0; i < Corners.Length ; i++)
        {
            Corners[i].print();
        }
    }
    private Point[] Corners;
    private int tmp;
    private Point x;

}
