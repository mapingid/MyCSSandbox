using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSSandbox
{
  class GCTest
  {
    public void BrutePointGeneration(int howmany)
    {
      var point2Ds = new List<Point2D>();

      for(int i = 0; i<howmany; i++ )
      {
        point2Ds.Add( new Point2D() );
        Console.WriteLine( i );
      }

    }
  }
}
