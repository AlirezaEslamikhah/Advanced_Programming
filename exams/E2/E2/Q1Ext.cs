using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public record Point(double x, double y);

public static class QExt
{    
    public static double Q01EuclideanDistance(Point p1, Point p2)
    {
        double x1 = p1.x;
        double y1 = p1.y;
        double x2 = p2.x;
        double y2 = p2.y;
        double w = Math.Pow(x2,2)-Math.Pow(x1,2);
        double z = Math.Pow(y2,2)-Math.Pow(y1,2);
        double result = Math.Sqrt(w+z);
        return result;
    }

    public static double Q02ManhatanDistance(Point p1, Point p2) 
    {
        return p1.x+p1.y+p2.x+p2.y;
    }

    public static double Q03StringDistance(string s1, string s2)
    {
        double bigger = s1.Length;
        double taf = 0;
        if (s2.Length > bigger )
        {
            bigger = s2.Length;
            taf = bigger - s1.Length;
        }
        else
        {
            taf = s1.Length - s2.Length;
        }
        return taf;
    }

    public static (int min, int max) Q11GetRange(this int[] nums)
    {
        if (nums.Length == 0)
        {
            throw new InvalidOperationException();
        }
        int smallest = nums[0];
        int biggest = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > biggest)
            {
                biggest = nums[i];
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < smallest)
            {
                smallest = nums[i];
            }
        }
        return (smallest,biggest);
    }

    public static int Q12GetRange(this int[] nums) => (nums.Max()-nums.Min());

    public static (T min, T max) Q13GetRange<T>(this T[] vals) where T: IComparable<T>
    {
        T[] w = vals;
        T big = vals[0]; T small = vals[0];
        foreach (var item in vals)
        {
            if (item.CompareTo(big) >0 )
            {
                big = item;
            }
            if (item.CompareTo(small) < 0)
            {
                small = item;
            }
        }
        return (small,big);
    }

    public static (T min, T max) Q14GetRange<T>(this T[] vals, Func<T, T, double> diff) 
    {
        double difference = diff(vals[0],vals[1]);
        T min = vals[0];
        T max = vals[0];

        for (int i = 1; i < vals.Length-1; i++)
        {
            if (diff(vals[i],vals[i+1]) > difference)
            {
                min = vals[i];
                max = vals[i+1];
            }
        }
        return (min,max);
    }


    public static double Q15GetRange<T>(this T[] vals, Func<T, T, double> diff) => throw new NotImplementedException();
}