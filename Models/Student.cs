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

        [Display(Name ="名字")]
        [Required(ErrorMessage ="请输入名字，它不能为空")]
        public string Name { get; set; }

        /// <summary>
        /// 主修科目
        /// </summary>
        [Display(Name ="主修科目")]
        [Required(ErrorMessage ="请选择主修科目")]
        public MajorEnum? Major { get; set; }

        [Display(Name ="电子邮箱")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",ErrorMessage ="邮箱格式不正确")]
        [Required(ErrorMessage ="请输入邮箱地址，它不能为空")]
        public string Email { get; set; }
    }
}
