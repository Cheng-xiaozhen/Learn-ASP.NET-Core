using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Models
{
    public enum MajorEnum
    {
        [Display(Name ="未分配")]
        None,
        [Display(Name ="计算机科学")]
        ComputerScience,
        [Display(Name ="信安")]
        InformationSecurity,
        [Display(Name ="网工")]
        NetworkEngineering
    }
}
