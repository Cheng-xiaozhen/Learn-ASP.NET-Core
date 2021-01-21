using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace WebApplication12.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 主修科目
        /// </summary>
        public MajorEnum Major { get; set; }

        public string Email { get; set; }
    }
}
