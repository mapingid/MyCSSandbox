using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSSandbox
{
  class Program
  {

    static void Main( string[] args )
    {
      Cartesian p1 = new Cartesian( 3, 0 );
      Polar p2 = new Polar( 3, 90 );
      Point p3 = ForceArithmatics.Resultant( p1, p2 );

      
      Console.Write( "p1 : " ); p1.Show();
      Console.Write( "p2 : " ); p2.Show();
      Console.Write( "p3 : " ); p3.Show();
      
      Console.ReadLine();
    }
  }
}
