

using System.Collections.Generic;

class Coll
{
  void Learn() 
  {
    //one dimensional
    byte[] ages= {12,78,32,76,52};
    string[] names ={"Prakriti", "21", "ktm"};
    //multi dimensional
    int[,] studentsInClassRoom=new int[7,6];
    studentsInClassRoom[0,0]=0;
    studentsInClassRoom[0,0]=1;
    studentsInClassRoom[0,0]=10;

    //jagged array
    int[][] studentsInClassRoom2= [[1,2,3],[3,4],[2,4,5,6]];

    //Collections that are already generic
    List<int> ageList=[2,3,5,7,9];
    List<string> nameList=["Shraddha","Prapti","Prakriti"];

  }
}