public class Point
{
    public Point(int x, int y){}
    int X;
    int Y;    
}

public class PointXComparer //IMyComparer<>
{}

public class PointYComparer
{}

public class PointMagnitudeComparer
{}

public static class PointComparer
{
    public static PointXComparer PointXComparer = new PointXComparer();
    public static PointYComparer PointYComparer = new PointYComparer();
    public static PointMagnitudeComparer PointMagnitudeComparer = new PointMagnitudeComparer();
}
