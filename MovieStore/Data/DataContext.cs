using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieStore.Data.Entities;

namespace MovieStore.Data
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public IConfiguration Configuration { get; }

        //tables names
        public DbSet<Movie> Movies { get; set; }   
        public DbSet<Director> Directors { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            const string ADMIN_ID = "02ca419c-4868-4f03-9b0f-8f8a4dd4a564";
            const string ROLE_ID = ADMIN_ID;
            const string password = "Admin123!";

            builder.Entity<IdentityRole>().HasData(
               new IdentityRole
               {
                   Id = ROLE_ID,
                   Name = "admin",
                   NormalizedName = "ADMIN"
               },
               new IdentityRole
               {
                   Id = "02ca419c-4868-4f03-9b0f-8f8a4dd4a565",
                   Name = "editor",
                   NormalizedName = "EDITOR"
               },
               new IdentityRole
               {
                   Id = "02ca419c-4868-4f03-9b0f-8f8a4dd4a566",
                   Name = "guest",
                   NormalizedName = "GUEST"
               }
           );
            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = ADMIN_ID,
                UserName = "admin@onlinemoviestore.com",
                NormalizedUserName = "ADMIN@ONLINEMOVIESTORE.COM",
                Email = "admin@onlinemoviestore.com",
                NormalizedEmail = "ADMIN@ONLINEMOVIESTORE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, password),
                SecurityStamp = string.Empty,
                ConcurrencyStamp = "482c714d-ef91-4281-8f23-c88a9b257f8c"
            });

          builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });


            // Genre Seed Data
            builder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Action"
                },
               new Genre
               {
                   Id = 2,
                   Name = "Adventure"
               },
                new Genre
                {
                    Id = 3,
                    Name = "Animation"
                },
                new Genre
                {
                    Id = 4,
                    Name = "Classics"
                },
                new Genre
                {
                    Id = 5,
                    Name = "Comedy"
                },
                 new Genre
                 {
                     Id = 6,
                     Name = "Crime & Thrillers"
                 },
                 new Genre
                 {
                     Id = 7,
                     Name = "Documentary"
                 },
                 new Genre
                 {
                     Id = 8,
                     Name = "Drama"
                 },
                 new Genre
                 {
                     Id = 9,
                     Name = "Horror"
                 },
                  new Genre
                  {
                      Id = 10,
                      Name = "Romance"
                  },
                   new Genre
                   {
                       Id = 11,
                       Name = "Sci - Fi"
                   },
                    new Genre
                    {
                        Id = 12,
                        Name = "Musical"
                    });

            // Director Seed Data
            builder.Entity<Director>().HasData(
                new Director
                {
                    Id = 1,
                    Name = "Steven Spielberg",
                    Popularity = true
                },
                new Director
                {
                    Id = 2,
                    Name = "Martin Scorsese",
                    Popularity = true
                },
                new Director
                {
                    Id = 3,
                    Name = "Joe Russo",
                    Popularity = false
                },
                new Director
                {
                    Id = 4,
                    Name = "Christopher Nolan",
                    Popularity = true
                },
                new Director
                {
                    Id = 5,
                    Name = "Quentin Tarantino",
                    Popularity = true
                },
                 new Director
                 {
                     Id = 6,
                     Name = "Richard Linklater",
                     Popularity = false
                 },
                  new Director
                  {
                      Id = 7,
                      Name = "Denis Villeneuve",
                      Popularity = false
                  },
                   new Director
                   {
                       Id = 8,
                       Name = "David Fincher",
                       Popularity = false
                  },
                    new Director
                    {
                        Id = 9,
                        Name = " Ron Clements",
                        Popularity = true
                    }
                  
                   );

            // Producer Seed Data
            builder.Entity<Producer>().HasData(
                new Producer
                {
                    Id = 1,
                    Name = "Donald De Line",
                    Popularity = true
                },
                new Producer
                {
                    Id = 2,
                    Name = "Robert De Niro",
                    Popularity = true
                },
                 new Producer
                 {
                     Id = 3,
                     Name = "Kevin Feige",
                     Popularity = false
                 },
                 new Producer
                 {
                     Id = 4,
                     Name = "Emma Thomas",
                     Popularity = true
                 },
                  new Producer
                  {
                      Id = 5,
                      Name = "David Heyman",
                      Popularity = true
                  },
                    new Producer
                    {
                        Id = 6,
                        Name = "Christos V. Konstantakopoulos",
                        Popularity = false
                    },
                    new Producer
                    {
                        Id = 7,
                        Name = "Broderick Johnson",
                        Popularity = true
                    },
                    new Producer
                    {
                        Id = 8,
                        Name = "Scott Rudin",
                        Popularity = true
                    },
                    new Producer
                    {
                        Id = 9,
                        Name = "  Osnat Shurer",
                        Popularity = true
                    },
                     new Producer
                     {
                         Id = 10,
                         Name = "Roy Conli",
                         Popularity = true
                     },
                      new Producer
                      {
                          Id = 11,
                          Name = "Lawrence Bender",
                          Popularity = false
                      },
                      new Producer
                      {
                          Id = 12,
                          Name = "Kathleen Kennedy",
                          Popularity = true
                      },
                       new Producer
                       {
                           Id = 13,
                           Name = "Walter F.Parkes",
                           Popularity = true
                       }

                       

                );

            // Publisher Seed Data
            builder.Entity<Publisher>().HasData(
                new Publisher
                {
                    Id = 1,
                    Name = "Warner Bros",
                    Country = "USA"
                },
                 new Publisher
                 {
                     Id = 2,
                     Name = "TriBeCa Productions",
                     Country = "USA"
                 },
                   new Publisher
                   {
                       Id = 3,
                       Name = "Marvel Studios",
                       Country = "USA"
                   },
                   new Publisher
                   {
                       Id = 4,
                       Name = "Columbia Pictures",
                       Country = "USA"
                   },
                   new Publisher
                   {
                       Id = 5,
                       Name = "Castle Rock Entertainment",
                       Country = "USA"
                   },
                    new Publisher
                    {
                        Id = 6,
                        Name = "Walt Disney Pictures",
                        Country = "USA"
                    },
                    new Publisher
                    {
                        Id = 7,
                        Name = " Universal Pictures",
                        Country = "USA"
                    },
                     new Publisher
                     {
                         Id = 8,
                         Name = "20th Century Fox",
                         Country = "USA"
                     },
                     new Publisher
                     {
                         Id = 9,
                         Name = " DreamWorks Pictures",
                         Country = "USA"
                     }

                    
                );

            // Movies Seed Data
            builder.Entity<Movie>().HasData(
                new Movie
                {
                   Id=1,
                   Title= "Ready Player One",
                   DirectorID=1,
                   DirectorName= "Steven Spielberg",
                   ProducerID=1,
                   ProducerName= "Donald De Line",
                   PublisherID= 1,
                   PublisherName= "Warner Bros",
                   GenreID=11,
                   GenreName= "Sci-Fi",
                   Cast = "Tye Sheridan,Olivia Cooke,Ben Mendelsohn,T.J.Miller,Simon Pegg,Mark Rylance",
                   Runtime=140,
                   Synopsis= "Ready Player One is a 2018 American science fiction adventure film directed by Steven Spielberg," +
                   " from a screenplay by Zak Penn and Ernest Cline based on Cline's 2011 novel of the same name. " +
                   "It stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, T.J. Miller, Simon Pegg, and Mark Rylance. " +
                   "It takes place in 2045, when much of humanity uses the virtual reality software OASIS (Ontologically Anthropocentric Sensory" +
                   " Immersive Simulation) to escape the desolation of the real world. Orphaned teenager Wade Watts (Sheridan) finds clues to a hidden" +
                   " game that promises OASIS's ownership to the winner, and he and four allies try to complete it before a corporation run by" +
                   " businessman Nolan Sorrento (Mendelsohn) can do so.",
                   Released = 2018,
                   Budget= "$ 155–175 million",
                   PriceForRent =4.99,
                   PriceForBuy= 19.99,
                   PhotoURL= "Ready_Player_One.png",
                   Traller= "https://www.youtube.com/embed/ixWL1BWi44U"
                },
                 new Movie
                 {
                     Id = 2,
                     Title = "The Irishman",
                     DirectorID = 2,
                     DirectorName = "Martin Scorsese",
                     ProducerID = 2,
                     ProducerName = "Robert De Niro",
                     PublisherID = 2,
                     PublisherName = "TriBeCa Productions",
                     GenreID =6,
                     GenreName = "Crime & Thrillers",
                     Cast = "Robert De Niro, Al Pacino, Joe Pesci,Ray Romano,Bobby Cannavale, Anna Paquin",
                     Runtime = 209,
                     Synopsis = "The Irishman (titled onscreen as I Heard You Paint Houses) is a 2019 American epic crime" +
                     " film directed and produced by Martin Scorsese and written by Steven Zaillian, based on the 2004 nonfiction " +
                     "book I Heard You Paint Houses by Charles Brandt. It stars Robert De Niro, Al Pacino, and Joe Pesci, with Ray Romano, Bobby Cannavale," +
                     " Anna Paquin, Stephen Graham, Stephanie Kurtzuba, Jesse Plemons, and Harvey Keitel in supporting roles. " +
                     "The film follows Frank Sheeran (De Niro), a truck driver who becomes a hitman involved with mobster Russell Bufalino (Pesci)" +
                     " and his crime family, including his time working for the powerful Teamster Jimmy Hoffa (Pacino).",
                     Released = 2019,
                     Budget= "$ 159–200 million",
                     PriceForRent = 4.99,
                     PriceForBuy = 24.99,
                     PhotoURL = "The_Irishman.jpg",
                     Traller= "https://www.youtube.com/embed/WHXxVmeGQUc"
                 },
                 new Movie
                 {
                     Id = 3,
                     Title = "Captain America:The Winter Soldier",
                     DirectorID = 3,
                     DirectorName = "Joe Russo",
                     ProducerID = 3,
                     ProducerName = "Kevin Feige",
                     PublisherID = 3,
                     PublisherName = "Marvel Studios",
                     GenreID = 1,
                     GenreName = "Action",
                     Cast = "Chris Evans,Scarlett Johansson,Sebastian Stan,Anthony Mackie,Cobie Smulders,Frank Grillo,Emily VanCamp",
                     Runtime = 136,
                     Synopsis = "In the film, Captain America joins forces with Black Widow and Falcon to uncover a conspiracy within the spy agency" +
                     " S.H.I.E.L.D. while facing a mysterious assassin known as the Winter Soldier. Markus and McFeely began writing the sequel around " +
                     "the release of The First Avenger in July 2011.The script draws from the Winter Soldier story arc in the comic books written by Ed Brubaker" +
                     " as well as conspiracy fiction from the 1970s such as Three Days of the Condor (1975). The film explores S.H.I.E.L.D., similarly to how the" +
                     " first film explored the U.S. military, after Rogers was shown working for the agency in the MCU crossover film The Avengers (2012).",
                     Released = 2014,
                     Budget = "$ 170–177 million",
                     PriceForRent =7,
                     PriceForBuy = 19.99,
                     PhotoURL = "Captain_America_The_Winter_Soldier.jpg",
                     Traller= "https://www.youtube.com/embed/tbayiPxkUMM"
                 },
                 new Movie
                 {
                     Id = 4,
                     Title = "Dunkirk",
                     DirectorID = 4,
                     DirectorName = "Christopher Nolan",
                     ProducerID = 4,
                     ProducerName = "Emma Thomas",
                     PublisherID = 1,
                     PublisherName = "Warner Bross",
                     GenreID = 8,
                     GenreName = "Drama",
                     Cast = "Fionn Whitehead,Tom Glynn - Carney,Jack Lowden,Harry Styles,Aneurin Barnard,James D'Arcy,Barry Keoghan",
                     Runtime = 106,
                     Synopsis = "In 1940, during the Battle of France, Allied soldiers have retreated to Dunkirk. Tommy, a young British private, " +
                     "is the sole survivor of a German ambush. At the beach, he finds thousands of troops awaiting evacuation and meets Gibson, who is" +
                     " burying a body. After a Luftwaffe dive-bomber attack, they find a wounded man. They rush his stretcher onto a hospital ship, hoping " +
                     "to get aboard, but are ordered off. The ship is sunk by dive bombers; Tommy saves another soldier, Alex. They leave at night on a" +
                     " destroyer, but are torpedoed by a U-boat. Gibson saves Tommy and Alex from the sinking ship, and they get back to the beach.",
                     Released = 2017,
                     Budget = "$ 100-150 million",
                     PriceForRent = 11.99,
                     PriceForBuy = 24.99,
                     PhotoURL = "Dunkirk.jpg",
                     Traller= "https://www.youtube.com/embed/T7O7BtBnsG4"
                 },
                 new Movie
                 {
                     Id = 5,
                     Title = " Once Upon a Time in Hollywood",
                     DirectorID = 5,
                     DirectorName = "Quentin Tarantino",
                     ProducerID = 5,
                     ProducerName = "David Heyman",
                     PublisherID = 4,
                     PublisherName = "Columbia Pictures",
                     GenreID = 5,
                     GenreName = "Comedy",
                     Cast = "Leonardo DiCaprio,Brad Pitt,Margot Robbie,Emile Hirsch,Margaret Qualley,Timothy Olyphant",
                     Runtime = 161,
                     Synopsis = "In February 1969, veteran Hollywood actor Rick Dalton (DiCaprio), star of 1950s Western television series Bounty Law," +
                     " fears his career is waning. Casting agent Marvin Schwarz (Pacino) recommends he make Spaghetti Westerns in Italy, which Dalton" +
                     " feels are beneath him. Dalton's best friend and stunt double, Cliff Booth (Pitt)—a war veteran skilled in hand-to-hand combat[10]" +
                     " who lives in a tiny trailer with his pit bull, Brandy—drives Dalton around Los Angeles because Dalton's driver's license has been " +
                     "suspended due to DUI. Booth struggles to find stunt work in Hollywood because of rumors he murdered his wife. Actress Sharon Tate " +
                     "(Robbie) and her husband, director Roman Polanski (Zawierucha), have moved next door to Dalton. He dreams of befriending them to" +
                     " revive his declining acting career. That night, Tate and Polanski attend a celebrity-filled party at the Playboy Mansion.",
                     Released = 2019,
                     Budget = "$ 90-96 million",
                     PriceForRent = 7.99,
                     PriceForBuy = 14.99,
                     PhotoURL = "Once_Upon_a_Time_in_Hollywood_poster.png",
                     Traller= "https://www.youtube.com/embed/ELeMaP8EPAA"
                 },
                   new Movie
                   {
                       Id = 6,
                       Title = "Before Midnight",
                       DirectorID = 6,
                       DirectorName = "Richard Linklater",
                       ProducerID = 6,
                       ProducerName = "Christos V. Konstantakopoulos",
                       PublisherID = 5,
                       PublisherName = "Castle Rock Entertainment",
                       GenreID = 10,
                       GenreName = "Romance",
                       Cast = "Ethan Hawke,Julie Delpy, Seamus Davey-Fitzpatrick,Jennifer Prior",
                       Runtime = 109,
                       Synopsis = "Before Midnight is a 2013 American romantic drama film, the third in a trilogy featuring two characters, following" +
                       " Before Sunrise (1995) and Before Sunset (2004).Nine years have passed since Before Sunset. Jesse and Céline have become a couple " +
                       "and parents to twin girls. Jesse struggles to maintain his relationship with his teenage son, Hank, who lives in Chicago with his" +
                       " mother, Jesse's ex-wife. Jesse is now a successful novelist, while Céline is at a career crossroads, considering a job with the" +
                       " French government. After Hank spends the summer with Jesse and Céline on the Greek Peloponnese peninsula, Jesse experiences a" +
                       " disconnect with Hank when he drops him off at the airport to fly home and reflects on his inability to be a good father to him.",
                       Released = 2013,
                       Budget = "$ 3 million",
                       PriceForRent = 4.99,
                       PriceForBuy = 9.99,
                       PhotoURL = "Before_Midnight.jpg",
                       Traller= "https://www.youtube.com/embed/Kv6JWoVKlGY"
                   },
                    new Movie
                    {
                        Id = 7,
                        Title = "Blade Runner 2049",
                        DirectorID = 7,
                        DirectorName = "Denis Villeneuve",
                        ProducerID = 7,
                        ProducerName = "Broderick Johnson",
                        PublisherID = 4,
                        PublisherName = "Columbia Pictures",
                        GenreID = 11,
                        GenreName = "Sci-Fi",
                        Cast = "Ryan Gosling,Harrison Ford,Ana de Armas,Sylvia Hoeks,Robin Wright,Mackenzie Davis",
                        Runtime = 163,
                        Synopsis = "In 2049, bioengineered humans known as replicants are slaves. K, a replicant, works for the Los " +
                        "Angeles Police Department (LAPD) as a blade runner,an officer who hunts and 'retires' (kills) rogue replicants. At a protein farm, he retires Sapper Morton and finds a " +
                        "box buried under a tree. The box contains the remains of a female replicant who died during a caesarean section, demonstrating" +
                        " that replicants can reproduce biologically, previously thought impossible. K's superior, Lt. Joshi, fears that this could lead " +
                        "to a war between humans and replicants. She orders K to find and retire the replicant child to hide the truth.",
                        Released = 2017,
                        Budget = "$ 150-185 million",
                        PriceForRent = 7.99,
                        PriceForBuy = 14.99,
                        PhotoURL = "Blade_Runner_2049.png",
                        Traller= "https://www.youtube.com/embed/gCcx85zbxz4"
                    },
                 
                    new Movie
                    {
                        Id = 8,
                        Title = "The Girl with the Dragon Tattoo ",
                        DirectorID = 8,
                        DirectorName = "David Fincher",
                        ProducerID = 8,
                        ProducerName = "Scott Rudin",
                        PublisherID = 4,
                        PublisherName = "Columbia Pictures",
                        GenreID = 6,
                        GenreName = "Crime & Thrillers",
                        Cast = "Daniel Craig,Rooney Mara,Christopher Plummer,Stellan Skarsgård,Steven Berkoff",
                        Runtime = 158,
                        Synopsis = "The Girl with the Dragon Tattoo is a 2011 psychological crime thriller film based on the 2005 novel by Swedish writer" +
                        " Stieg Larsson.In Stockholm, disgraced journalist Mikael Blomkvist is recovering from the legal and professional fallout of a" +
                        " libel suit brought against him by businessman Hans-Erik Wennerström, straining Blomkvist's relationship with his business partner" +
                        " and married lover, Erika Berger. Lisbeth Salander, a young, brilliant but antisocial investigator and hacker," +
                        " compiles an extensive background check on Blomkvist for the wealthy Henrik Vanger, who offers Blomkvist evidence against " +
                        "Wennerström in exchange for an unusual task: investigate the 40-year-old disappearance and presumed murder of Henrik's " +
                        "grandniece, Harriet. Blomkvist agrees, and moves into a cottage on the Vanger family estate on Hedestad Island.",
                        Released = 2011,
                        Budget = "$ 90 million",
                        PriceForRent = 4.99,
                        PriceForBuy = 11.99,
                        PhotoURL = "The_Girl_with_the_Dragon_Tattoo.jpg",
                        Traller= "https://www.youtube.com/embed/DqQe3OrsMKI"

                    },
                     new Movie
                     {
                         Id = 9,
                         Title = "Moana",
                         DirectorID = 9,
                         DirectorName = " Ron Clements",
                         ProducerID = 9,
                         ProducerName = "Osnat Shurer",
                         PublisherID = 6,
                         PublisherName = "Walt Disney Pictures",
                         GenreID = 3,
                         GenreName = "Animation",
                         Cast = "Auliʻi Cravalho,Dwayne Johnson,Rachel House,Temuera Morrison,Jemaine Clement,Nicole Scherzinger",
                         Runtime = 107,
                         Synopsis = "On the Polynesian island of Motunui, the inhabitants worship the goddess Te Fiti, who brought life to the ocean " +
                         "using a pounamu stone as her heart and the source of her power. Maui, the shape-shifting demigod and master of sailing, steals" +
                         " the heart to give humanity the power of creation. However, Te Fiti disintegrates, and Maui is attacked by another who seeks the" +
                         " heart: Te Kā, a volcanic demon. Maui is blasted out of the sky, losing both his magical giant fishhook and the heart to the" +
                         " depths of the sea.",
                         Released = 2016,
                         Budget = "$ 150-175 million",
                         PriceForRent = 4.99,
                         PriceForBuy = 11.99,
                         PhotoURL = "Moana.jpg",
                         Traller= "https://www.youtube.com/embed/LKFuXETZUsI"

                     },
                      new Movie
                      {
                          Id = 10,
                          Title = "Treasure Planet",
                          DirectorID = 9,
                          DirectorName = " Ron Clements",
                          ProducerID = 10,
                          ProducerName = "Roy Conli",
                          PublisherID = 6,
                          PublisherName = "Walt Disney Pictures",
                          GenreID = 3,
                          GenreName = "Animation",
                          Cast = "Joseph Gordon-Levitt,Brian Murray,Emma Thompson",
                          Runtime = 95,
                          Synopsis = "On the planet Montressor, a young Jim Hawkins is enchanted by stories of the legendary pirate Captain Nathaniel" +
                          " Flint and his ability to appear from out of nowhere, raid passing ships, and disappear in order to hide the loot on the" +
                          " mysterious 'Treasure Planet'. Twelve years later, having been abandoned by his father at a young age, Jim has grown into " +
                          "an aloof and isolated troublemaker. He reluctantly helps his mother Sarah run the family's Benbow Inn, and derives amusement" +
                          " from 'Alponian solar cruising', skysurfing atop a rocket-powered sailboard.",
                          Released = 2002,
                          Budget = "$ 140 million",
                          PriceForRent = 4.99,
                          PriceForBuy = 9.99,
                          PhotoURL = "Treasure_Planet.jpg",
                          Traller= "https://www.youtube.com/embed/DJNT7C61NrE"
                      },
                        new Movie
                        {
                            Id = 11,
                            Title = "You, Me and Dupree",
                            DirectorID = 3,
                            DirectorName = "Joe Russo",
                            ProducerID = 8,
                            ProducerName = "Scott Rudin",
                            PublisherID = 7,
                            PublisherName = "Universal Pictures",
                            GenreID = 5,
                            GenreName = "Comedy",
                            Cast = "Owen Wilson,Kate Hudson,Matt Dillon,Seth Rogen",
                            Runtime = 109,
                            Synopsis = "Molly (Kate Hudson) and Carl (Matt Dillon) are preparing for their wedding day in Hawaii, until Carl's friend Neil " +
                            "(Seth Rogen) interrupts to say that Randolph Dupree (Owen Wilson) got lost. They drive off together to pick up Dupree," +
                            " who appeared to have hitched a ride with a light plane after landing on the wrong island. A day before the wedding, Molly's " +
                            "father, Bob Thompson (Michael Douglas), who is also CEO of the company that Carl works for, makes a toast with rude jokes " +
                            "about Carl, foreshadowing a conflict between the two. Later at a pre-celebration at a bar, Carl neglects Dupree to be with" +
                            " Molly. Carl and Dupree later make up on the beach, as Dupree apologizes for laughing at Bob's jokes. Carl and Molly get" +
                            " married. When Carl returns to work, he is surprised to find that Bob has promoted him to be in charge of a design" +
                            " he proposed, though it had been altered somewhat.",
                            Released = 2006,
                            Budget = "$ 54 million",
                            PriceForRent = 4.99,
                            PriceForBuy = 9.99,
                            PhotoURL = "Dupreeposter.jpg",
                            Traller= "https://www.youtube.com/embed/edUJ3bp48u0"
                        },
                         new Movie
                         {
                             Id = 12,
                             Title = "Pulp Fiction",
                             DirectorID = 5,
                             DirectorName = "Quentin Tarantino",
                             ProducerID = 11,
                             ProducerName = "Lawrence Bender",
                             PublisherID = 7,
                             PublisherName = "Universal Pictures",
                             GenreID = 6,
                             GenreName = "Crime & Thrillers",
                             Cast = "John Travolta,Samuel L.Jackson,Uma Thurman,Harvey Keitel,Tim Roth,Amanda Plummer",
                             Runtime = 154,
                             Synopsis = "Tarantino wrote Pulp Fiction in 1992 and 1993, incorporating scenes that Avary originally wrote for True Romance" +
                             " (1993). Its plot occurs out of chronological order. The film is also self-referential from its opening moments, beginning " +
                             "with a title card that gives two dictionary definitions of 'pulp'. Considerable screen time is devoted to monologues and" +
                             " casual conversations with eclectic dialogue revealing each character's perspectives on several subjects, and the film " +
                             "features an ironic combination of humor and strong violence. TriStar Pictures reportedly turned down the script as " +
                             "'too demented'. Miramax co-chairman Harvey Weinstein was enthralled, however, and the film became the first that" +
                             " Miramax fully financed.",
                             Released = 1994,
                             Budget = "$ 8 million",
                             PriceForRent = 7.99,
                             PriceForBuy = 12.99,
                             PhotoURL = "Pulp_Fiction.jpg",
                             Traller= "https://www.youtube.com/embed/s7EdQ4FqbhY"
                         },
                          new Movie
                          {
                              Id = 13,
                              Title = "Lincoln",
                              DirectorID = 1,
                              DirectorName = "Steven Spielberg",
                              ProducerID = 12,
                              ProducerName = "Kathleen Kennedy",
                              PublisherID = 8,
                              PublisherName = "20th Century Fox",
                              GenreID = 8,
                              GenreName = "Drama",
                              Cast = "Daniel Day-Lewis,Sally Field,David Strathairn,Joseph Gordon - Levitt",
                              Runtime = 150,
                              Synopsis = "In January 1865, United States President Abraham Lincoln expects the Civil War to end soon, with the defeat of the Confederate States. " +
                              "He is concerned that his 1863 Emancipation Proclamation may be discarded by the courts after the war, and the proposed Thirteenth Amendment will be " +
                              "defeated by the returning slave states. He feels it imperative to pass the amendment beforehand, to remove any possibility that freed slaves might be" +
                              " re-enslaved.",
                              Released =2012,
                              Budget = "$ 65 million",
                              PriceForRent = 4.99,
                              PriceForBuy = 9.99,
                              PhotoURL = "Lincoln_2012.jpg",
                              Traller= "https://www.youtube.com/embed/KJVuqYkI2jQ"
                          },
                          new Movie
                          {
                              Id = 14,
                              Title = "Catch Me If You Can",
                              DirectorID = 1,
                              DirectorName = "Steven Spielberg",
                              ProducerID = 13,
                              ProducerName = "Walter F. Parkes",
                              PublisherID =9 ,
                              PublisherName = "DreamWorks Pictures",
                              GenreID = 6,
                              GenreName = "Crime & Thrillers",
                              Cast = "Leonardo DiCaprio,Tom Hanks,Christopher Walken,Martin Sheen",
                              Runtime = 141,
                              Synopsis = "In 1963, teenager Frank Abagnale lives in New Rochelle, New York with his father Frank Abagnale, Sr., " +
                              "and French mother, Paula. When Frank Sr. encounters tax problems with the IRS, his family is forced to move from their " +
                              "large home to a small apartment. Paula carries on an affair with Jack Barnes, her husband's friend. Meanwhile, Frank has " +
                              "to transfer to public school and gets into trouble when he begins posing as a substitute French teacher on his first day " +
                              "there. Frank runs away when his parents divorce. Needing money, he turns to confidence scams to survive, and his cons grow" +
                              " bolder. He impersonates an airline pilot and forges Pan Am payroll checks. Soon, his forgeries are worth millions of" +
                              " dollars.",
                              Released = 2002,
                              Budget = "$ 52 million",
                              PriceForRent = 4.99,
                              PriceForBuy = 9.99,
                              PhotoURL = "CatchMeIfYouCan.jpg",
                              Traller= "https://www.youtube.com/embed/xas1UyTiVUw"
                          }

                );

            base.OnModelCreating(builder);
        }
    }
}
