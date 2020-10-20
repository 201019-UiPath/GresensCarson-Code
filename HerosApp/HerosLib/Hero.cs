using System;

namespace HerosLib
{
  public class Hero
  {
    public int id; // value type -> System.int32
                   // int id = 1 or int id; id = 1 are ways to assign values
    public string name; // reference type 

    // Constructor
    public Hero()
    {
      id = 1;
      name = "Superman";

    }

  }
}
