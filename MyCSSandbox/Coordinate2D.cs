using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSSandbox
{
  class Point
  {
    public int x;
    public int y;
    public int r;
    public int t;
    public void Show()
    {
      Console.Write( "x : " ); Console.Write( x ); Console.Write( " y : " ); Console.Write( y );
      Console.Write( " r : " ); Console.Write( r ); Console.Write( " t : " ); Console.WriteLine( t );
    }
  }
}
