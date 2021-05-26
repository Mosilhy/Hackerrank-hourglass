using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(List<List<int>> arr)
    {
        int maxGlassHour = -100;
        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                int sumofGlass = arr[0 + i][0 + j] + arr[0 + i][1 + j] + arr[0 + i][2 + j] 
               + arr[1 + i][1 + j]
               + arr[2 + i][0 + j] + arr[2 + i][1 + j] + arr[2 + i][2 + j]; 


                //Console.WriteLine(arr[0 + i][0 + j].ToString() +" "+arr[0 + i][1 + j].ToString() + " " +arr[0 + i][2 + j].ToString());

                //Console.WriteLine(" "+arr[1 + i][1 + j].ToString());

                //Console.WriteLine(arr[2 + i][0 + j].ToString() +" " +arr[2 + i][1 + j].ToString() +" "+ arr[2 + i][2 + j].ToString());


                //Console.WriteLine("************************");
                if (sumofGlass > maxGlassHour)
                {
                    maxGlassHour = sumofGlass;
                }
            }
           
        }
        return maxGlassHour;
       
    }

}

class Solution
{
    public static void Main(string[] args)
    {
      //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);

        Console.WriteLine(result);

    //    textWriter.Flush();
      //  textWriter.Close();
    }
}
