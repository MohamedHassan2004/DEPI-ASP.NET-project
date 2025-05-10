using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CinemaVault.BLL.DTOs.Movie
{
    public class CreateMovieDto
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Required]
        [FromForm]
        public IFormFile PosterImg { get; set; }
        [DataType(DataType.Url)]
        [StringLength(300)]
        public string TrailerUrl { get; set; }
        [StringLength(50)]
        public string? DirectorName { get; set; }
    }
}
