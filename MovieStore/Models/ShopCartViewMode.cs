using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;

namespace MovieStore.Models
{
    public class ShopCartViewMode
    {

        public int MovieID { get; set; }

        public string Title { get; set; }

        public string Cast { get; set; }

        public int Runtime { get; set; }

        public string Synopsis { get; set; }

        public string Budget { get; set; }

        public int Released { get; set; }

        public double PriceForRent { get; set; }

        public double PriceForBuy { get; set; }
        public string PhotoURL { get; set; }

        // GenreData
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        //DirectorData
        public string DirectorName { get; set; }

        public int DirectorID { get; set; }

        //ProducerData
        public string ProducerName { get; set; }
        public int ProducerID { get; set; }

        //PublisherData

        public string PublisherName { get; set; }
        public int PublisherID { get; set; }
        public string PublisherCountry { get; set; }


        // Wishlist Data
        public double WishlistTotalPrice { get; set; }

        // Order Data
        public double SubTotal { get; set; }
        public double ShippingTotal { get; set; }
        public double TotalPrice { get; set; }
        public double AddToCartTotalCounter { get; set; }

        // Other Landing Page Data
        public IEnumerable<Movie> AllMovie { get; set; }
        public IEnumerable<Movie> AllMoviesAddedToCartByLoggedInUser { get; set; }
        public IEnumerable<Movie> AllMoviesFromWishlistByLoggedInUser { get; set; }

    }
}

