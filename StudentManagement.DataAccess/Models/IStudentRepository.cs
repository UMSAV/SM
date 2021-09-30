using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public interface IStudentRepository
    {
        Student Get(int id);

        IEnumerable<Student> GetAll();

        Student Register(Student student);

        Student Update(Student studentChanges);

        Student Delete(int id);
    }
}
