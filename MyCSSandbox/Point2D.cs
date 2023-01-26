using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSSandbox
{
  class Point2D
  {
    protected int x;
    protected int y;
    protected int r;
    protected int t;
    public void Show()
    {
      Console.Write( "x : " ); Console.Write( x ); Console.Write( " y : " ); Console.Write( y );
      Console.Write( " r : " ); Console.Write( r ); Console.Write( " t : " ); Console.WriteLine( t );
    }
    public static Point2D Resultant( Point2D a, Point2D b )
    {
      Point2D temp = new Point2D();
      temp.x = a.x + b.x;
      temp.y = a.y + b.y;
      temp.r = (int)Math.Sqrt( ( temp.x * temp.x ) + ( temp.y * temp.y ) );
      temp.t = (int)(Math.Atan2( temp.y, temp.x ) * ( 180 / Math.PI ) );


      return temp;
    }
  }
}
