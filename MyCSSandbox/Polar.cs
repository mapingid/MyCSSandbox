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
  class Polar : Point
  {
    public Polar( int _r, int _t )
    {
      r = _r;
      t = _t;
      x = _r * (int)Math.Cos( ( Math.PI / 180 ) * _t );
      y = _r * (int)Math.Sin( ( Math.PI / 180 ) * _t );
    }
  }
}
