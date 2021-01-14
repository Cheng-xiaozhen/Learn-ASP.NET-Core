using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication12.Models;

namespace WebApplication12.DataRepositories
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _studentList;
        public StudentRepository()
        {
            _studentList = new List<Student>() {
                new Student(){ID=1,Name="张三",Major="计科",Email="zhangsan@qq.com"},
                new Student(){ID=2,Name="李四",Major="信安",Email="lisi@outlook.com"},
                new Student(){ID=3,Name="王五",Major="网工",Email="wangwu@foxmail.com"}
            };
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentList;
        }

        public Student GetStudent(int ID)
        {
            return _studentList.FirstOrDefault(a => a.ID == ID);
        }
    }
}
