using System;

namespace MyCSSandbox
{
  class GenericClass
  {



    static void print<T>( T[] invalue )
    {
      foreach( T item in invalue )
      {
        Console.Write( item );
      }
    }

    public static void main()
    {
      int[] valueInt = { 12 };
      double[] valueDouble = { 4.0 };
      String valueString = "A";

      print( valueInt );
    }
  }
}
