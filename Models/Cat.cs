using System;
using System.ComponentModel.DataAnnotations;

namespace CatBlog.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string Color { get; set; }
    }
}