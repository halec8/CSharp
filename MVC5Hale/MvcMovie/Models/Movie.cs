using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

/***************************************************************
* Name        : Mvc Movie   
* Author      : Cody Hale
* Created     : 12/8/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : Created a website that stores movie data entered by the user into a database. Allows CRUD principals
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace MvcMovie.Models
{

    /***************************************************************
* Name        : Movie
* Author      : Cody Hale
* Created     : 12/08/2019
***************************************************************/

    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]

        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]


        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }


    /***************************************************************
* Name        : MovieDbContext
* Author      : FirstName LastName
* Created     : 4/24/2019
***************************************************************/

    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}