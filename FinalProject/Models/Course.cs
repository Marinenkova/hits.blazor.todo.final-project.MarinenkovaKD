﻿using System.Collections.Generic;
using FinalProject.Models;
namespace FinalProject.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<Lesson> Lessons { get; set; } = new List<Lesson>();
    }


}
