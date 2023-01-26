/*
 * PERCOBAAN IMPLEMENTASI INHERIT
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSSandbox
{
  class Cartesian : Point
  {
    public Cartesian( int _x, int _y )
    {
      x = _x;
      y = _y;
      r = (int)Math.Sqrt( ( _x * _x ) + ( _y * _y ) );
      t = (int)(Math.Atan2( y, x )*( 180 / Math.PI ));
    }
  }
}
