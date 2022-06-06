using RepositoryPattern.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public class Book :BaseModel
    {
        [Required,MaxLength(250)]
        public string? Title { get; set; }

        [Required, MaxLength(500)]
        public string? Description { get; set; }

        public int AuthorID { get; set; }
        public Author? Author { get; set; }


    }
}
