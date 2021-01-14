using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication12.Models;

namespace WebApplication12.DataRepositories
{
    public interface IStudentRepository
    {
        Student GetStudent(int ID);
        IEnumerable<Student> GetAllStudents();
    }
}
