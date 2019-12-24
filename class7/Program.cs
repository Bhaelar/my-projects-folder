 // Fig. 20.8: StackTest.cs
 // Testing generic class Stack.
 using System;

 class StackTest
 {
	 // create arrays of doubles and ints
	 private static double[] doubleElements =
	 	new double[]{ 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
	 private static int[] intElements =
	 	new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
	
	private static Stack< double > doubleStack; // stack stores doubles
	private static Stack< int > intStack; // stack stores int objects
	
	 public static void Main( string[] args )
	 {
	 	doubleStack = new Stack< double >( 5 ); // stack of doubles
	 	intStack = new Stack< int >( 10 ); // stack of ints
	 	
	 	TestPushDouble(); // push doubles onto doubleStack
	 	TestPopDouble(); // pop doubles from doubleStack
	 	TestPushInt(); // push ints onto intStack
	 	TestPopInt(); // pop ints from intStack
	 } // end Main
 }