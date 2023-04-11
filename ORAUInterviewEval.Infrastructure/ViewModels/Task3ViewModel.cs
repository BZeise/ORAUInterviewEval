using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORAUInterviewEval.Infrastructure.ViewModels
{
    public class Task3ViewModel
    {
        [Required(ErrorMessage = "comment is required")]
        [MaxLength(100, ErrorMessage ="comment is required and must be under 100 characters")]
        public string Comment { get; set; }

    }
}
