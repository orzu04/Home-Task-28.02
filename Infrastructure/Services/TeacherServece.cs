using Domain;

namespace Infrastructure;

public class TeacherServece
{

  List<Teacher> _teach = new List<Teacher>();


  public List<Teacher> GetTeacher()
  {

   return _teach;


  }
  public void  GetById(int Id)
  {

    var bd = _teach.FirstOrDefault(e => e.Id==Id);
    System.Console.WriteLine(bd.Id);
    System.Console.WriteLine(bd.Nom);
System.Console.WriteLine(bd.Nasab);
System.Console.WriteLine(bd.Tajriba);
System.Console.WriteLine(bd.Fannidarsi);
System.Console.WriteLine(bd.Jins);
    
    
    
    


  }

  public void CreatTeach(Teacher teacher)
  {

    _teach.Add(teacher);

  }

  public void UpdeteTeacher(Teacher teacher)
  {
    var up= _teach.FirstOrDefault(e => e.Id ==teacher.Id);
    up.Nom = teacher.Nom;
    up.Nasab = teacher.Nasab;
    up.Jins =teacher.Jins;
    up.Fannidarsi = teacher.Fannidarsi;
   up.Tajriba = teacher.Tajriba;  

  }

  public void DeleteTeacher(int Id)
  {

       var del = _teach.FirstOrDefault(e => e.Id==Id) ;
       _teach.Remove(del) ;
       System.Console.WriteLine($"muallim horij shud");
       System.Console.WriteLine(del.Id);
         System.Console.WriteLine(del.Nom);
           System.Console.WriteLine(del.Nasab);
             System.Console.WriteLine(del.Tajriba);
               System.Console.WriteLine(del.Fannidarsi);
                 System.Console.WriteLine(del.Jins);
  }

}
