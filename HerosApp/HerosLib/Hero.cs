using System;
using System.Collections.Generic;

namespace HerosLib
{
  public class Hero // default modifier for class is internal
  {

    #region Old way of creating class members
    /*    // default modifier for member is private
        int id; // value type -> System.int32
                // int id = 1 or int id; id = 1 are ways to assign values

        public int Id
        {
          get
          {
            return id;
          }
          set
          {
            id = value;
          }
        }


        //public int Id(){get;set;};

        public string name; // reference type 

        // Constructor
        public Hero()
        {
          //id = 1;
          Id = id;
          name = "Superman";

        }

        // ctor + tab = constructor shortcut

        public Hero(int id, string name)
        {
          this.id = id;
          this.name = name;

        }*/
    #endregion

    public int Id { get; set; }
    public string Name { get; set; }

    //1darray
    //public string[] superPowers = new string[10];
    #region Arrays
    // public string[,]  2darr = new string[10,10];    //2d array
    // public string[,,] 3darr = new string[10,10,10]; //3d array
    // int[,,,,,,,] darr = new int[10, 10, 10, 10, 10, 10, 10, 10]; //Nd array follows the pattern

    //public int[][] jagarr = new int[3][]; // jagged array
    #endregion

    #region List
    /*     public List<string> superPowers = new List<string>();

        public Hero()
        {
          superPowers.Add("Strength");
          superPowers.Add("Flying");
          superPowers.Add("Xray Vision");
          superPowers.Add("Durability");

        }
        public static List<string> GetDefaultPowers()
        {
          Hero h1 = new Hero();
          return h1.superPowers;

        }

        public void RemoveSuperPower(string sp)
        {
          if (superPowers.Contains(sp))
          {
            superPowers.Remove(sp);
          }
        }
     */
    #endregion


    public Stack<string> superPowers = new Stack<string>();

    public Hero()
    {
      superPowers.Push("Strength");
      superPowers.Push("Flying");
      superPowers.Push("Xray Vision");
      superPowers.Push("Durability");

    }
    public static Stack<string> GetDefaultPowers()
    {
      Hero h1 = new Hero();
      return h1.superPowers;

    }

    public void RemoveSuperPower()
    {
      //as a stack this pops the removes the last power added
      superPowers.Pop();
    }


  }

}
