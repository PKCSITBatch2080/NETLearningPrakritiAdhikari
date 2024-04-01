// single in
using System.ComponentModel.DataAnnotations;

class CSstudent /*child */: Student /*parent*/, IGradable
{
    public CSstudent(string name, byte rn, String pTitle): 
          base(name, rn)  //base is used to call parent class
    {
        ProjectTitle = pTitle;
    }
    public string ProjectTitle { get; set; }

    public string Internwork { get; set; }
    public double GetGrade() => 3.6;
}
//ctor => shortcut for constructor