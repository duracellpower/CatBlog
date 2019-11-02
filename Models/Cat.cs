using System;
using System.ComponentModel.DataAnnotations;

namespace CatBlog.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public string Color { get; set; }

        public string BestFail { get; set; }
    }
}