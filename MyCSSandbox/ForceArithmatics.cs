/*
 * PERCOBAAN IMPLEMENTASI STATIC
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSSandbox
{
  class ForceArithmatics
  {

    public static Point Resultant( Point a, Point b)
    {
      int x = a.x + b.x;
      int y = a.y + b.y;
      Cartesian temp = new Cartesian( x, y );
      
      return temp;
    }

    
  }
}
