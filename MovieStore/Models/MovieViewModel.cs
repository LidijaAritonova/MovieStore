using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieStore.Data.Entities;

namespace MovieStore.Models
{
    public class MovieViewModel
    {
        [Display(Name = "Movie ID")]
        public int MovieID { get; set; }

        [Display(Name = "Title")]
        [StringLength(350)]
        public string Title { get; set; }

        [Display(Name = "Traller")]
        [StringLength(350)]
        public string Traller{ get; set; }

        [Display(Name = "Cast")]
        [StringLength(550)]
        public string Cast { get; set; }

        [Display(Name = "Runtime")]
        public int Runtime { get; set; }

        [Display(Name = "Synopsis")]
        public string Synopsis { get; set; }

        [Display(Name = "Budget")]
        public string Budget { get; set; }

        [Display(Name = "Released")]
        public int Released { get; set; }

        [Display(Name = "Price For Rent")]
        public double PriceForRent { get; set; }

        [Display(Name = "Price For Buy")]
        public double PriceForBuy { get; set; }

        // GenreData
        [Display(Name = "Genre ID")]
        public int GenreID { get; set; }

        [Display(Name = "Genre")]
        [StringLength(150)]
        public string GenreName { get; set; }

        [Display(Name = "Genres List")]
        public IEnumerable<SelectListItem> Genres { get; set; }

        [Display(Name = "Genre")]
        public Genre Genre { get; set; }

        


        //DirectorData
        [Display(Name = "Director")]
        [StringLength(350)]
        public string DirectorName { get; set; }

        [Display(Name = "Director ID")]
        public int DirectorID { get; set; }

        [Display(Name = "Director")]
        public Director Director { get; set; }

        [Display(Name = "Directors List")]
        public IEnumerable<SelectListItem> Directors { get; set; }

        public string CreateDirectorName { get; set; }

        //ProducerData
        [Display(Name = "Producer")]
        [StringLength(350)]
        public string ProducerName { get; set; }

        [Display(Name = "Producer ID")]
        public int ProducerID { get; set; }

        [Display(Name = "Producer")]
        public Producer Producer { get; set; }

        [Display(Name = "Producers List")]
        public IEnumerable<SelectListItem> Producers{ get; set; }

        public string CreateProducerName { get; set; }

        //PublisherData
        [Display(Name = "Publisher")]
        [StringLength(350)]
        public string PublisherName { get; set; }

        [Display(Name = "Publisher ID")]
        public int PublisherID { get; set; }

        [Display(Name = "Publisher Country")]
        [StringLength(250)]
        public string PublisherCountry { get; set; }

        [Display(Name = "Publisher")]
        public Publisher Publisher { get; set; }

        [Display(Name = "Publishers List")]
        public IEnumerable<SelectListItem> Publishers { get; set; }

        public string CreatePublisherName { get; set; }
        public string CreatePublisherCountry { get; set; }

        // PhotosData
        [Display(Name = "Photo Cover")]
        public string PhotoURL { get; set; }
        public bool IsMainPhoto { get; set; }
        [Display(Name = "Photos")]
        public List<Photo> Photos { get; set; }

        // WishlistData
        public double WishlistTotalPrice { get; set; }

        // ShoppingCartData
        public int AddToCartTotalCounter { get; set; }


        // Other Landing Page Data
        public IEnumerable<Movie> TopPopularMovies { get; set; }
        public IEnumerable<Movie> TopPopularMovieByBestSellingDirector { get; set; }
        public IEnumerable<Movie> AllMovies { get; set; }
        public IEnumerable<Movie> AllMoviesFromWishlistByLoggedInUser { get; set; }


    }
}
