/*
 * implementasi protected, private
 * implementasi property get set
 * implementasi lambda
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSSandbox
{
  class Point2D
  {
    private int _x;
    private int _y;
    private int _r;
    private int _t;

    public int x
    {
      get { return _x; }
      protected set
      {
        if(value.GetType() == typeof(int)) _x = value ;
      }
    }
    public int y
    {
      get { return _y; }
      protected set
      {
        if( value.GetType() == typeof( int ) ) _y = value;
      }
    }
    public int r
    {
      get { return _r; }
      protected set
      {
        if( value.GetType() == typeof( int ) ) _r = value;
      }
    }
    public int t
    {
      get { return _t; }
      protected set
      {
        if( value.GetType() == typeof( int ) ) _t = value;
      }
    }

    public void Show()
    {
      Console.Write( "x : " ); Console.Write( x ); Console.Write( " y : " ); Console.Write( y );
      Console.Write( " r : " ); Console.Write( r ); Console.Write( " t : " ); Console.WriteLine( t );
    }
    public string value => $"x:{x} y:{y} r:{r} t:{t}";
    //static int kuadrat (int i) => i*i ; //lambda expression

    public static Point2D Resultant( Point2D a, Point2D b )
    {
      Point2D temp = new Point2D();
      temp.x = a.x + b.x;
      temp.y = a.y + b.y;
      temp.r = (int)Math.Sqrt( ( temp.x * temp.x ) + ( temp.y * temp.y ) );
      temp.t = (int)( Math.Atan2( temp.y, temp.x ) * ( 180 / Math.PI ) );


      return temp;
    }
  }
}
