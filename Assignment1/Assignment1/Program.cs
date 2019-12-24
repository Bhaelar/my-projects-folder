using System;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// A program that sorts an array of generic type using insertion sort
/// </summary>
public class Program {
	static void Main(string [] args) {
		
		String[] array = {"Ade", "George", "Bale", "Santi", "Chris"};
		Console.WriteLine("Array before sorting: ");
		foreach(var item in array)
		{
		    Console.WriteLine(item.ToString());
		}
		
		Console.WriteLine("\n\n");
		generic<string> intGeneric = new generic<string>(array);
		intGeneric.arrayInsertionSort(array);
		Console.WriteLine("Array after sorting: ");
		foreach(var item in array)
		{
		    Console.WriteLine(item.ToString());
		}
		Console.ReadLine();
	}
}

class generic<T> where T : IComparable<T> {
	/// <summary>
	/// 
	/// </summary>
	public T[] data;
	
	/// <summary>
	/// public variable 'data' is passed the value of 'value'
	/// </summary>
	/// <param name="value"> Array of generic type </param>
	public generic(T[] value)
    {
        data = value;
    }
	
	/// <summary>
	/// Swaps array elements at different positions
	/// </summary>
	/// <param name="data"> An array of generic type </param>
	/// <param name="m"> Index of first element to be swapped </param>
	/// <param name="n"> Index of second element to be swapped </param>
	public static void exchange (T[] data, int m, int n)
      {
         T temporary;
		
         temporary = data [m];
         data [m] = data [n];
         data [n] = temporary;
      }
	
	/// <summary>
	/// Implements the insertion sort algorithm
	/// </summary>
	/// <param name="data"> Array of generic type to be sorted </param>
	public void arrayInsertionSort (T[] data)
      {
         int i, j;
         int N = data.Length;

         for (j=1; j<N; j++) {
         	for (i=j; i>0 && data[i].CompareTo(data[i-1]) < 0; i--) {
               exchange (data, i, i - 1);
            }
         }
      }
	
}