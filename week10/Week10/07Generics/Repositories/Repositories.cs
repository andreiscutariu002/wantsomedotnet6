using System;
using System.Collections.Generic;
using System.Text;

namespace _07Generics.Repositories
{
    public interface IStudentManager
    {
        int Create(Student s);

        Student Read(int id);

        int Update(Student s);

        int Delete(int id);
    }

    public interface IDirectorManager
    {
        int Create(Director s);

        Student Read(int id);

        int Update(Director s);

        int Delete(int id);
    }

    public interface IProfessorManager
    {
        int Create(Professor s);

        Student Read(int id);

        int Update(Professor s);

        int Delete(int id);
    }

    public interface IDatabaseManager<T>
    {
        int Create(T s);

        Student Read(int id);

        int Update(T s);

        int Delete(int id);
    }
}
