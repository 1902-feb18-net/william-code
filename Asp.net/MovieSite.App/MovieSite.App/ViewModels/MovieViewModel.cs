using MovieSite.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSite.App.ViewModels
{
    /// <summary>
    /// a "view model" is a type of model in the mvc pattern
    /// that is tightly bound to a particular view
    /// 
    /// basically when the business logic models that we have in our application
    /// don't match exactly what the veiw needs in order to have its data,
    /// then we make a new class meant for that view to use
    /// 
    /// often, with layered architecture (multiple projects with seperated concerns)
    /// the mvc layer is not really using our business logic classes and definitely not
    /// our ef entity classes. instead it's using view models to be each  view's model
    /// </summary>
    public class MovieViewModel
    {
        public int Id { get; set; }

        /// <summary>
        /// we use attributes from DataAnnotations.Library to tell MVC
        /// what things to check for automatic client-side validation
        /// (using jQuery Unobtrusive js library, behind the scenes)
        /// and server-side validation (using Model)
        /// </summary>

        [Required]
        [MaxLength(30)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        //here we can provide other info the view may need
        public string LoggedInUser { get; set; }
    }
}
