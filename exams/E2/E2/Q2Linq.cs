
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Q2ChildMortailityStats
{
    public string data{get;set;}
    public Q2ChildMortailityStats(string filePath)
    {   
        data = filePath;
    }

    // public int Q21_HighestNeoNatalMortalityYear => File.ReadLines(@"ChildMortality.csv").Skip(2)
    // .Select(s => {
    //                 var toks = s.Split(',').Select(t => t.Trim(new char[]{'\"', ' '})).ToArray();
    //             return new {
    //                     Country = toks[0], 
    //                     Year = int.Parse(toks[1].Split(' ')[0]),
    //                     Both = double.Parse(toks[2].Split(' ')[0])
    //                 };
    //             }).GroupBy(y => y.Both).OrderBy(v => v.Max()).Select(v => v.y);
    
    
    public (string country, int year) Q22_HighestDifferenceBetweenMaleAndFemale => throw new NotImplementedException();
    public string Q23_CountryWithHighestNeoNatalImprovement => throw new NotImplementedException();
}