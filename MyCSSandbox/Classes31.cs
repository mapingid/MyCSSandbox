using System;

namespace MyCSSandbox
{

  class Classes31
  {

    public static void PercobaanOut( out int x )
    {
      //biasanya digunakan untuk mereset value ke nilai default
      // x = x + 12; //ini error jika menggunakan out 

      x = 12;
      //nilainya dikembalikan ke variabel yang masuk di X
    }
    public static void PercobaanRef( ref int x )
    {

      x = x * x; //kalo seperti ini pake "ref" bukan "out"
      //nilainya dikembalikan ke variabel yang masuk di X
    }
    public static void PercobaanIn( in int x )
    {
      //x = x * x; //ini error karena in hanya boleh dibaca tidak boleh di write
      Console.WriteLine( x ); // ini bisa karena cuma read
    }


    public static void Overload( int a )
    {
      Console.WriteLine( "Overload w/ 1 variabel" );
    }
    public static void Overload( int a, int b )
    {
      Console.WriteLine( "Overload w/ 2 variabel" );
    }
    public Classes31( int a )
    {
      Console.WriteLine( "constructor w/ 1 var" );
    }
    public Classes31( int a, int b )
    {
      Console.WriteLine( "constructor w/ 2 var" );
    }
    public Classes31()
    {
    }
  }


  class ParentOV
  {
    public virtual int value => 1000;
  }
  class ChildOV : ParentOV
  {
    public int overrideValue;
    public override int value => overrideValue;
  }






}
