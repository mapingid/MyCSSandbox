using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSSandbox
{
  struct Point2DStruct
  {
    public int[] x;
    public int y;
    
    public string value => $"x:{x[0]} y:{y}";
  }
}
