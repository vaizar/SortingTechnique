using System;
using System.Collections;
using System.Collections.Generic;
public class MyApplication
{
    public static void Main(string[] args)
    {
        int[] arr = { 92, 243, 11, 2, 105, 4202566, 34 };
        lexSort(arr);
    }
    
    public static void lexSort (int[] array)
        {
          String[] sarr = new String[array.Length];
          for (int i = 0; i < sarr.Length; i++) {
            sarr[i] = array[i].ToString();
          }
         
          Array.Sort(sarr);
          
          for (int i = 0; i < sarr.Length; i++) {
            Console.WriteLine(sarr[i]);
          }
    }
}
