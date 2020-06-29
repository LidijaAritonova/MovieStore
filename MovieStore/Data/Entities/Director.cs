using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Data.Entities
{
    public class Director
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }

        public bool Popularity { get; set; }

        public virtual ICollection<Movie> Movies{ get; set; }
    }
}
