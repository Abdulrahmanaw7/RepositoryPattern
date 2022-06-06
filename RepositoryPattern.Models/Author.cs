using RepositoryPattern.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Author :BaseModel
    {
        [Required,MaxLength(150)]
        public string? Name { get; set; }    
    }
}
