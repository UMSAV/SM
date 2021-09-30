using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _students = null;

        public MockStudentRepository()
        {
            _students = new List<Student>()
            {
                new Student() {Id = 1, FirstName = "Muhammadqodir", LastName = "To'ychiboyev", MiddleName = "Jumaboy o'g'li", PassportNumber = "AB 8625949", Login = "admin", Parol = "111" },
                new Student() {Id = 2, FirstName = "Fayzullo", LastName = "Xabibullayev", MiddleName = " o'g'li", PassportNumber = "AB 0000000", Login = "user1", Parol = "222" },
                new Student() {Id = 3, FirstName = "Nodirbek", LastName = "Maxmudjonov", MiddleName = "Ulug'bek o'g'li", PassportNumber = "AB 0000000", Login = "user2", Parol = "333" }
            };
        }

        public Student Delete(int id)
        {
            Student student = _students.FirstOrDefault(e => e.Id == id);
            if(student != null)
            {
                _students.Remove(student);
            }
            return student;
        }

        public Student Get(int id)
        {
            return _students.FirstOrDefault(staff => staff.Id.Equals(id));
        }

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student Register(Student student)
        {
            student.Id = _students.Max(s => s.Id) + 1;
            _students.Add(student);
            return student;
        }

        public Student Update(Student studentChanges)
        {
            Student student = _students.FirstOrDefault(e => e.Id == studentChanges.Id);
            if (student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
                student.MiddleName = studentChanges.MiddleName;
                student.PassportNumber = studentChanges.PassportNumber;
                student.Login = studentChanges.Login;
                student.Parol = studentChanges.Parol;
                student.Department = studentChanges.Department;
            }
            return student;
        }
    }
}
