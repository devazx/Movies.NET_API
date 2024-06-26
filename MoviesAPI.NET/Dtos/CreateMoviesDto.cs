﻿using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.NET.Dtos
{
    public class CreateMoviesDto
    {
        [StringLength(100)]
        [Required(ErrorMessage = "The Title is required ")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Category if required")]
        [StringLength(50, ErrorMessage = "Category is not to exceed 50 character")]
        public string Category { get; set; }
        [Required]
        [Range(70, 600, ErrorMessage = "A Duration must have between 70 and 600 minutes")]
        public int Duration { get; set; }
    }
}
