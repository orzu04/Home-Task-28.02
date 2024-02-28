


using Domain;
using Infrastructure;

var teacherService = new TeacherServece();


while (true)
{
    System.Console.WriteLine($"Ruyhati Muallimaho : get");
    System.Console.WriteLine($"Kabuli muallimai nav : add");
    System.Console.WriteLine($"Tagiri muallima : updete");
    System.Console.WriteLine($"Horiji muallima : delete");
     System.Console.WriteLine($"Muallimro  bo istifodai Id ash barored : byid");

    string command = Console.ReadLine();
    if (command == "add")
    {

        var updeteTeacher = new Teacher();
        updeteTeacher.Id = Convert.ToInt32(Console.ReadLine());
        updeteTeacher.Nom = Console.ReadLine();
        updeteTeacher.Nasab = Console.ReadLine();
        updeteTeacher.Jins = Console.ReadLine();
        updeteTeacher.Tajriba = Convert.ToInt32(Console.ReadLine());
        updeteTeacher.Fannidarsi = Console.ReadLine();

        teacherService.UpdeteTeacher(updeteTeacher);


    }

    else if (command == "delete")
    {
             var teacher1 = new Teacher();
        System.Console.Write($"Nom:");
        teacher1.Nom = Console.ReadLine();
        System.Console.Write($"Nasab:");
        teacher1.Nasab = Console.ReadLine();
        System.Console.Write($"Id:");
        teacher1.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write($"FanniDarsi:");
        teacher1.Fannidarsi = Console.ReadLine();
        System.Console.Write($"Jins:");
        teacher1.Jins = Console.ReadLine();
        System.Console.Write($"Tajriba:");
        teacher1.Tajriba = Convert.ToInt32(Console.ReadLine());



        var teacher2 = new Teacher();
        System.Console.Write($"Nom:");
        teacher2.Nom = Console.ReadLine();
        System.Console.Write($"Nasab:");
        teacher2.Nasab = Console.ReadLine();
        System.Console.Write($"Id:");
        teacher2.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write($"FanniDarsi:");
        teacher2.Fannidarsi = Console.ReadLine();
        System.Console.Write($"Jins:");
        teacher2.Jins = Console.ReadLine();
        System.Console.Write($"Tajriba:");
        teacher2.Tajriba = Convert.ToInt32(Console.ReadLine());



        var teacher3 = new Teacher();
        System.Console.Write($"Nom:");
        teacher3.Nom = Console.ReadLine();
        System.Console.Write($"Nasab:");
        teacher3.Nasab = Console.ReadLine();
        System.Console.Write($"Id:");
        teacher3.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write($"FanniDarsi:");
        teacher3.Fannidarsi = Console.ReadLine();
        System.Console.Write($"Jins:");
        teacher3.Jins = Console.ReadLine();
        System.Console.Write($"Tajriba:");
        teacher3.Tajriba = Convert.ToInt32(Console.ReadLine());
        teacherService.CreatTeach(teacher1);
        teacherService.CreatTeach(teacher2);
        teacherService.CreatTeach(teacher3);

        teacherService.DeleteTeacher(3);
    }
    else if(command=="byid")
    {
          
        var teacher2 = new Teacher();
        System.Console.Write($"Nom:");
        teacher2.Nom = Console.ReadLine();
        System.Console.Write($"Nasab:");
        teacher2.Nasab = Console.ReadLine();
        System.Console.Write($"Id:");
        teacher2.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write($"FanniDarsi:");
        teacher2.Fannidarsi = Console.ReadLine();
        System.Console.Write($"Jins:");
        teacher2.Jins = Console.ReadLine();
        System.Console.Write($"Tajriba:");
        teacher2.Tajriba = Convert.ToInt32(Console.ReadLine());



        var teacher3 = new Teacher();
        System.Console.Write($"Nom:");
        teacher3.Nom = Console.ReadLine();
        System.Console.Write($"Nasab:");
        teacher3.Nasab = Console.ReadLine();
        System.Console.Write($"Id:");
        teacher3.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write($"FanniDarsi:");
        teacher3.Fannidarsi = Console.ReadLine();
        System.Console.Write($"Jins:");
        teacher3.Jins = Console.ReadLine();
        System.Console.Write($"Tajriba:");
        teacher3.Tajriba = Convert.ToInt32(Console.ReadLine());
        teacherService.CreatTeach(teacher2);
        teacherService.CreatTeach(teacher3);
    teacherService.GetById(2);


    }
    break;
}


