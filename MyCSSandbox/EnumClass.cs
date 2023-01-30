using System;

namespace MyCSSandbox
{
  class EnumClass
  {
    [Flags]
    enum FoodMenu
    {
      NasiGoreng = 1,
      Bakwan = 2,
      Bihun = 3
    }

    public static void main()
    {


      //GET THE ENUM INTEGER FROM NAME
      FoodMenu menu = FoodMenu.Bakwan;
      Console.WriteLine( menu ); //return Bakwan

      menu |= FoodMenu.NasiGoreng;
      Console.WriteLine( menu ); //return Bakwan


      Console.WriteLine( menu ); //return Bakwan
      Console.WriteLine( (int)menu ); // kalo mau return angka harus di cast ke int

      //GET ENUM NAME FROM INTEGER
      int enumint = 2;
      Console.WriteLine( (FoodMenu)enumint ); // angkanya yang di cast ke enum
      Console.WriteLine( menu.ToString() ); // cara lain

      //GET ENUM FROM STRING
      string datain = "Bakwan";
      FoodMenu GetMenu;
      bool isFound = Enum.TryParse( datain, out GetMenu );
      Console.WriteLine( isFound ); // kalo gaada false , otherwise true
      Console.WriteLine( GetMenu ); // kalo gaada 0




    }
  }
}
