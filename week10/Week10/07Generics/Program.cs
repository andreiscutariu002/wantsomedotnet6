using _07Generics.Repositories;
using System;

namespace _07Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var displayType = new DisplayType();

            // on compile type, T is replaced with actual type
            var displayTypeV2 = new DisplayTypeV2<Student>();
            displayTypeV2.DisplayTypeFor(new Student());

            var displayTypeV2a = new DisplayTypeV2<string>();
            displayTypeV2a.DisplayTypeFor("data");

            // database manager usage

            IStudentManager studentManager = null;
            IProfessorManager professorManager = null;
            IDirectorManager directorManager = null;

            IDatabaseManager<Student> studentManager2 = null;
            IDatabaseManager<Professor> professorManager2 = null;
            IDatabaseManager<Director> directorManager2 = null;
            IDatabaseManager<SuperProfessor> superProfDatabaseManager = null;

            // generic at class level vs method level
            var dtv2a = new DisplayTypeV2<Student>();
            dtv2a.DisplayTypeFor(new Student());

            var dtv2b = new DisplayTypeV2<string>();
            dtv2b.DisplayTypeFor("data");


            var dtv3 = new DisplayTypeV3();
            dtv3.DisplayTypeFor<Student>(new Student());
            dtv3.DisplayTypeFor<string>("data");

            // multimple T
            var mt = new DisplayTypeV4<string, int>();
        }
    }
}
