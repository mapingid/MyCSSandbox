using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSSandbox
{
  class Cartesian : Point
  {
    public Cartesian(int _x, int _y)
    {
      x = _x;
      y = _y;
    }
    public void Show()
    {
      Console.Write( "x : " ); Console.Write( x ); Console.Write( " y : " ); Console.Write( y );
    }

  }
}
