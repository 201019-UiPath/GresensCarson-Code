using System;

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
    public string[] superPowers = new string[10];
    // public string[,]  2darr = new string[10,10];    //2d array
    // public string[,,] 3darr = new string[10,10,10]; //3d array
    public int[][] jagarr = new int[3][]; // jagged array

  }
}
