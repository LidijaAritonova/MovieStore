using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Data.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(350)]
        public string Title { get; set; }

        [StringLength(350)]
        public string Traller { get; set; }

        public int DirectorID{ get; set; }
        [StringLength(250)]
        public string DirectorName { get; set; }
        public Director Director { get; set; }

        public int ProducerID { get; set; }
        [StringLength(250)]
        public string ProducerName { get; set; }
        public Producer Producer { get; set; }

        public int PublisherID { get; set; }
        [StringLength(250)]
        public string PublisherName { get; set; }
        public Publisher Publisher { get; set; }

        public int GenreID { get; set; }
        [StringLength(150)]
        public string GenreName { get; set; }
        public Genre Genre { get; set; }

        public string Cast { get; set; }
        public int Runtime { get; set; }

        public string Synopsis { get; set; }
        public int Released { get; set; }
        public string Budget { get; set; }

        public double PriceForRent { get; set; }
        public double PriceForBuy { get; set; }

        public int SoldItems { get; set; }

        public string PhotoURL { get; set; }

        public ICollection<Photo> Photos { get; set; }




    }
}
