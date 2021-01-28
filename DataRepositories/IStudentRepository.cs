using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication12.Models;

namespace WebApplication12.DataRepositories
{
    public interface IStudentRepository
    {
        /// <summary>
        /// 通过ID获取学生对象
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        Student GetStudentByID(int ID);

        /// <summary>
        /// 获取所有的学生信息
        /// </summary>
        /// <returns></returns>
        IEnumerable<Student> GetAllStudents();

        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="student">学生对象</param>
        /// <returns></returns>
        Student Add(Student student);

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="updateStudent"></param>
        /// <returns></returns>
        Student Update(Student updateStudent);

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        Student Delete(int ID);
    }
}
