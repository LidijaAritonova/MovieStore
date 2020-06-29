using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStore.Migrations
{
    public partial class _3migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Popularity = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Popularity = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    MovieId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    MovieId = table.Column<int>(nullable: false),
                    PublisherId = table.Column<int>(nullable: false),
                    DirectorId = table.Column<int>(nullable: false),
                    ProducerId = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 350, nullable: true),
                    DirectorID = table.Column<int>(nullable: false),
                    DirectorName = table.Column<string>(maxLength: 250, nullable: true),
                    ProducerID = table.Column<int>(nullable: false),
                    ProducerName = table.Column<string>(maxLength: 250, nullable: true),
                    PublisherID = table.Column<int>(nullable: false),
                    PublisherName = table.Column<string>(maxLength: 250, nullable: true),
                    GenreID = table.Column<int>(nullable: false),
                    GenreName = table.Column<string>(maxLength: 150, nullable: true),
                    Cast = table.Column<string>(nullable: true),
                    Runtime = table.Column<int>(nullable: false),
                    Synopsis = table.Column<string>(nullable: true),
                    Released = table.Column<int>(nullable: false),
                    Budget = table.Column<string>(nullable: true),
                    PriceForRent = table.Column<double>(nullable: false),
                    PriceForBuy = table.Column<double>(nullable: false),
                    SoldItems = table.Column<int>(nullable: false),
                    PhotoURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Directors_DirectorID",
                        column: x => x.DirectorID,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Publishers_PublisherID",
                        column: x => x.PublisherID,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IsMain = table.Column<bool>(nullable: false),
                    MovieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02ca419c-4868-4f03-9b0f-8f8a4dd4a564", "d9749efc-4535-40e6-a320-f94d4beefb5b", "admin", "ADMIN" },
                    { "02ca419c-4868-4f03-9b0f-8f8a4dd4a565", "9f4f4630-8488-48a7-a6e1-5e9dce981561", "editor", "EDITOR" },
                    { "02ca419c-4868-4f03-9b0f-8f8a4dd4a566", "1e5db413-4326-40e9-990c-beeb1af0667e", "guest", "GUEST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "02ca419c-4868-4f03-9b0f-8f8a4dd4a564", 0, "482c714d-ef91-4281-8f23-c88a9b257f8c", "admin@onlinemoviestore.com", true, false, null, "ADMIN@ONLINEMOVIESTORE.COM", "ADMIN", "AQAAAAEAACcQAAAAEI1WH45FjYiJDMHK94KRp9H1qCvUdPmOq7D7nLdp5ScYtUhzk/M0Syj5zBn8gAqjIg==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Name", "Popularity" },
                values: new object[,]
                {
                    { 9, " Ron Clements", true },
                    { 8, "David Fincher", false },
                    { 7, "Denis Villeneuve", false },
                    { 6, "Richard Linklater", false },
                    { 5, "Quentin Tarantino", true },
                    { 4, "Christopher Nolan", true },
                    { 3, "Joe Russo", false },
                    { 2, "Martin Scorsese", true },
                    { 1, "Steven Spielberg", true }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 12, "Musical" },
                    { 10, "Romance" },
                    { 9, "Horror" },
                    { 8, "Drama" },
                    { 7, "Documentary" },
                    { 11, "Sci - Fi" },
                    { 5, "Comedy" },
                    { 4, "Classics" },
                    { 3, "Animation" },
                    { 2, "Adventure" },
                    { 1, "Action" },
                    { 6, "Crime & Thrillers" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Name", "Popularity" },
                values: new object[,]
                {
                    { 13, "Walter F.Parkes", true },
                    { 12, "Kathleen Kennedy", true },
                    { 11, "Lawrence Bender", false },
                    { 10, "Roy Conli", true },
                    { 9, "  Osnat Shurer", true },
                    { 7, "Broderick Johnson", true },
                    { 8, "Scott Rudin", true },
                    { 5, "David Heyman", true },
                    { 4, "Emma Thomas", true },
                    { 3, "Kevin Feige", false },
                    { 2, "Robert De Niro", true },
                    { 1, "Donald De Line", true },
                    { 6, "Christos V. Konstantakopoulos", false }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[,]
                {
                    { 8, "USA", "20th Century Fox" },
                    { 1, "USA", "Warner Bros" },
                    { 2, "USA", "TriBeCa Productions" },
                    { 3, "USA", "Marvel Studios" },
                    { 4, "USA", "Columbia Pictures" },
                    { 5, "USA", "Castle Rock Entertainment" },
                    { 6, "USA", "Walt Disney Pictures" },
                    { 7, "USA", " Universal Pictures" },
                    { 9, "USA", " DreamWorks Pictures" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "02ca419c-4868-4f03-9b0f-8f8a4dd4a564", "02ca419c-4868-4f03-9b0f-8f8a4dd4a564" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Budget", "Cast", "DirectorID", "DirectorName", "GenreID", "GenreName", "PhotoURL", "PriceForBuy", "PriceForRent", "ProducerID", "ProducerName", "PublisherID", "PublisherName", "Released", "Runtime", "SoldItems", "Synopsis", "Title" },
                values: new object[,]
                {
                    { 1, "$ 155–175 million", "Tye Sheridan,Olivia Cooke,Ben Mendelsohn,T.J.Miller,Simon Pegg,Mark Rylance", 1, "Steven Spielberg", 11, "Sci-Fi", "Ready_Player_One.png", 19.989999999999998, 4.9900000000000002, 1, "Donald De Line", 1, "Warner Bros", 2018, 140, 0, "Ready Player One is a 2018 American science fiction adventure film directed by Steven Spielberg, from a screenplay by Zak Penn and Ernest Cline based on Cline's 2011 novel of the same name. It stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, T.J. Miller, Simon Pegg, and Mark Rylance. It takes place in 2045, when much of humanity uses the virtual reality software OASIS (Ontologically Anthropocentric Sensory Immersive Simulation) to escape the desolation of the real world. Orphaned teenager Wade Watts (Sheridan) finds clues to a hidden game that promises OASIS's ownership to the winner, and he and four allies try to complete it before a corporation run by businessman Nolan Sorrento (Mendelsohn) can do so.", "Ready Player One" },
                    { 4, "$ 100-150 million", "Fionn Whitehead,Tom Glynn - Carney,Jack Lowden,Harry Styles,Aneurin Barnard,James D'Arcy,Barry Keoghan", 4, "Christopher Nolan", 8, "Drama", "Dunkirk.jpg", 24.989999999999998, 11.99, 4, "Emma Thomas", 1, "Warner Bross", 2017, 106, 0, "In 1940, during the Battle of France, Allied soldiers have retreated to Dunkirk. Tommy, a young British private, is the sole survivor of a German ambush. At the beach, he finds thousands of troops awaiting evacuation and meets Gibson, who is burying a body. After a Luftwaffe dive-bomber attack, they find a wounded man. They rush his stretcher onto a hospital ship, hoping to get aboard, but are ordered off. The ship is sunk by dive bombers; Tommy saves another soldier, Alex. They leave at night on a destroyer, but are torpedoed by a U-boat. Gibson saves Tommy and Alex from the sinking ship, and they get back to the beach.", "Dunkirk" },
                    { 2, "$ 159–200 million", "Robert De Niro, Al Pacino, Joe Pesci,Ray Romano,Bobby Cannavale, Anna Paquin", 2, "Martin Scorsese", 6, "Crime & Thrillers", "The_Irishman.jpg", 24.989999999999998, 4.9900000000000002, 2, "Robert De Niro", 2, "TriBeCa Productions", 2019, 209, 0, "The Irishman (titled onscreen as I Heard You Paint Houses) is a 2019 American epic crime film directed and produced by Martin Scorsese and written by Steven Zaillian, based on the 2004 nonfiction book I Heard You Paint Houses by Charles Brandt. It stars Robert De Niro, Al Pacino, and Joe Pesci, with Ray Romano, Bobby Cannavale, Anna Paquin, Stephen Graham, Stephanie Kurtzuba, Jesse Plemons, and Harvey Keitel in supporting roles. The film follows Frank Sheeran (De Niro), a truck driver who becomes a hitman involved with mobster Russell Bufalino (Pesci) and his crime family, including his time working for the powerful Teamster Jimmy Hoffa (Pacino).", "The Irishman" },
                    { 3, "$ 170–177 million", "Chris Evans,Scarlett Johansson,Sebastian Stan,Anthony Mackie,Cobie Smulders,Frank Grillo,Emily VanCamp", 3, "Joe Russo", 1, "Action", "Captain_America_The_Winter_Soldier.jpg", 19.989999999999998, 7.0, 3, "Kevin Feige", 3, "Marvel Studios", 2014, 136, 0, "In the film, Captain America joins forces with Black Widow and Falcon to uncover a conspiracy within the spy agency S.H.I.E.L.D. while facing a mysterious assassin known as the Winter Soldier. Markus and McFeely began writing the sequel around the release of The First Avenger in July 2011.The script draws from the Winter Soldier story arc in the comic books written by Ed Brubaker as well as conspiracy fiction from the 1970s such as Three Days of the Condor (1975). The film explores S.H.I.E.L.D., similarly to how the first film explored the U.S. military, after Rogers was shown working for the agency in the MCU crossover film The Avengers (2012).", "Captain America:The Winter Soldier" },
                    { 5, "$ 90-96 million", "Leonardo DiCaprio,Brad Pitt,Margot Robbie,Emile Hirsch,Margaret Qualley,Timothy Olyphant", 5, "Quentin Tarantino", 5, "Comedy", "Once_Upon_a_Time_in_Hollywood_poster.png", 14.99, 7.9900000000000002, 5, "David Heyman", 4, "Columbia Pictures", 2019, 161, 0, "In February 1969, veteran Hollywood actor Rick Dalton (DiCaprio), star of 1950s Western television series Bounty Law, fears his career is waning. Casting agent Marvin Schwarz (Pacino) recommends he make Spaghetti Westerns in Italy, which Dalton feels are beneath him. Dalton's best friend and stunt double, Cliff Booth (Pitt)—a war veteran skilled in hand-to-hand combat[10] who lives in a tiny trailer with his pit bull, Brandy—drives Dalton around Los Angeles because Dalton's driver's license has been suspended due to DUI. Booth struggles to find stunt work in Hollywood because of rumors he murdered his wife. Actress Sharon Tate (Robbie) and her husband, director Roman Polanski (Zawierucha), have moved next door to Dalton. He dreams of befriending them to revive his declining acting career. That night, Tate and Polanski attend a celebrity-filled party at the Playboy Mansion.", " Once Upon a Time in Hollywood" },
                    { 7, "$ 150-185 million", "Ryan Gosling,Harrison Ford,Ana de Armas,Sylvia Hoeks,Robin Wright,Mackenzie Davis", 7, "Denis Villeneuve", 11, "Sci-Fi", "Blade_Runner_2049.png", 14.99, 7.9900000000000002, 7, "Broderick Johnson", 4, "Columbia Pictures", 2017, 163, 0, "In 2049, bioengineered humans known as replicants are slaves. K, a replicant, works for the Los Angeles Police Department (LAPD) as a blade runner,an officer who hunts and 'retires' (kills) rogue replicants. At a protein farm, he retires Sapper Morton and finds a box buried under a tree. The box contains the remains of a female replicant who died during a caesarean section, demonstrating that replicants can reproduce biologically, previously thought impossible. K's superior, Lt. Joshi, fears that this could lead to a war between humans and replicants. She orders K to find and retire the replicant child to hide the truth.", "Blade Runner 2049" },
                    { 8, "$ 90 million", "Daniel Craig,Rooney Mara,Christopher Plummer,Stellan Skarsgård,Steven Berkoff", 8, "David Fincher", 6, "Crime & Thrillers", "The_Girl_with_the_Dragon_Tattoo.jpg", 11.99, 4.9900000000000002, 8, "Scott Rudin", 4, "Columbia Pictures", 2011, 158, 0, "The Girl with the Dragon Tattoo is a 2011 psychological crime thriller film based on the 2005 novel by Swedish writer Stieg Larsson.In Stockholm, disgraced journalist Mikael Blomkvist is recovering from the legal and professional fallout of a libel suit brought against him by businessman Hans-Erik Wennerström, straining Blomkvist's relationship with his business partner and married lover, Erika Berger. Lisbeth Salander, a young, brilliant but antisocial investigator and hacker, compiles an extensive background check on Blomkvist for the wealthy Henrik Vanger, who offers Blomkvist evidence against Wennerström in exchange for an unusual task: investigate the 40-year-old disappearance and presumed murder of Henrik's grandniece, Harriet. Blomkvist agrees, and moves into a cottage on the Vanger family estate on Hedestad Island.", "The Girl with the Dragon Tattoo " },
                    { 6, "$ 3 million", "Ethan Hawke,Julie Delpy, Seamus Davey-Fitzpatrick,Jennifer Prior", 6, "Richard Linklater", 10, "Romance", "Before_Midnight.jpg", 9.9900000000000002, 4.9900000000000002, 6, "Christos V. Konstantakopoulos", 5, "Castle Rock Entertainment", 2013, 109, 0, "Before Midnight is a 2013 American romantic drama film, the third in a trilogy featuring two characters, following Before Sunrise (1995) and Before Sunset (2004).Nine years have passed since Before Sunset. Jesse and Céline have become a couple and parents to twin girls. Jesse struggles to maintain his relationship with his teenage son, Hank, who lives in Chicago with his mother, Jesse's ex-wife. Jesse is now a successful novelist, while Céline is at a career crossroads, considering a job with the French government. After Hank spends the summer with Jesse and Céline on the Greek Peloponnese peninsula, Jesse experiences a disconnect with Hank when he drops him off at the airport to fly home and reflects on his inability to be a good father to him.", "Before Midnight" },
                    { 9, "$ 150-175 million", "Auliʻi Cravalho,Dwayne Johnson,Rachel House,Temuera Morrison,Jemaine Clement,Nicole Scherzinger", 9, " Ron Clements", 3, "Animation", "Moana.jpg", 11.99, 4.9900000000000002, 9, "Osnat Shurer", 6, "Walt Disney Pictures", 2016, 107, 0, "On the Polynesian island of Motunui, the inhabitants worship the goddess Te Fiti, who brought life to the ocean using a pounamu stone as her heart and the source of her power. Maui, the shape-shifting demigod and master of sailing, steals the heart to give humanity the power of creation. However, Te Fiti disintegrates, and Maui is attacked by another who seeks the heart: Te Kā, a volcanic demon. Maui is blasted out of the sky, losing both his magical giant fishhook and the heart to the depths of the sea.", "Moana" },
                    { 10, "$ 140 million", "Joseph Gordon-Levitt,Brian Murray,Emma Thompson", 9, " Ron Clements", 3, "Animation", "Treasure_Planet.jpg", 9.9900000000000002, 4.9900000000000002, 10, "Roy Conli", 6, "Walt Disney Pictures", 2002, 95, 0, "On the planet Montressor, a young Jim Hawkins is enchanted by stories of the legendary pirate Captain Nathaniel Flint and his ability to appear from out of nowhere, raid passing ships, and disappear in order to hide the loot on the mysterious 'Treasure Planet'. Twelve years later, having been abandoned by his father at a young age, Jim has grown into an aloof and isolated troublemaker. He reluctantly helps his mother Sarah run the family's Benbow Inn, and derives amusement from 'Alponian solar cruising', skysurfing atop a rocket-powered sailboard.", "Treasure Planet" },
                    { 11, "$ 54 million", "Owen Wilson,Kate Hudson,Matt Dillon,Seth Rogen", 3, "Joe Russo", 5, "Comedy", "Dupreeposter.jpg", 9.9900000000000002, 4.9900000000000002, 8, "Scott Rudin", 7, "Universal Pictures", 2006, 109, 0, "Molly (Kate Hudson) and Carl (Matt Dillon) are preparing for their wedding day in Hawaii, until Carl's friend Neil (Seth Rogen) interrupts to say that Randolph Dupree (Owen Wilson) got lost. They drive off together to pick up Dupree, who appeared to have hitched a ride with a light plane after landing on the wrong island. A day before the wedding, Molly's father, Bob Thompson (Michael Douglas), who is also CEO of the company that Carl works for, makes a toast with rude jokes about Carl, foreshadowing a conflict between the two. Later at a pre-celebration at a bar, Carl neglects Dupree to be with Molly. Carl and Dupree later make up on the beach, as Dupree apologizes for laughing at Bob's jokes. Carl and Molly get married. When Carl returns to work, he is surprised to find that Bob has promoted him to be in charge of a design he proposed, though it had been altered somewhat.", "You, Me and Dupree" },
                    { 12, "$ 8 million", "John Travolta,Samuel L.Jackson,Uma Thurman,Harvey Keitel,Tim Roth,Amanda Plummer", 5, "Quentin Tarantino", 6, "Crime & Thrillers", "Pulp_Fiction.jpg", 12.99, 7.9900000000000002, 11, "Lawrence Bender", 7, "Universal Pictures", 1994, 154, 0, "Tarantino wrote Pulp Fiction in 1992 and 1993, incorporating scenes that Avary originally wrote for True Romance (1993). Its plot occurs out of chronological order. The film is also self-referential from its opening moments, beginning with a title card that gives two dictionary definitions of 'pulp'. Considerable screen time is devoted to monologues and casual conversations with eclectic dialogue revealing each character's perspectives on several subjects, and the film features an ironic combination of humor and strong violence. TriStar Pictures reportedly turned down the script as 'too demented'. Miramax co-chairman Harvey Weinstein was enthralled, however, and the film became the first that Miramax fully financed.", "Pulp Fiction" },
                    { 13, "$ 65 million", "Daniel Day-Lewis,Sally Field,David Strathairn,Joseph Gordon - Levitt", 1, "Steven Spielberg", 8, "Drama", "Lincoln_2012.jpg", 9.9900000000000002, 4.9900000000000002, 12, "Kathleen Kennedy", 8, "20th Century Fox", 2012, 150, 0, "In January 1865, United States President Abraham Lincoln expects the Civil War to end soon, with the defeat of the Confederate States. He is concerned that his 1863 Emancipation Proclamation may be discarded by the courts after the war, and the proposed Thirteenth Amendment will be defeated by the returning slave states. He feels it imperative to pass the amendment beforehand, to remove any possibility that freed slaves might be re-enslaved.", "Lincoln" },
                    { 14, "$ 52 million", "Leonardo DiCaprio,Tom Hanks,Christopher Walken,Martin Sheen", 1, "Steven Spielberg", 6, "Crime & Thrillers", "CatchMeIfYouCan.jpg", 9.9900000000000002, 4.9900000000000002, 13, "Walter F. Parkes", 9, "DreamWorks Pictures", 2002, 141, 0, "In 1963, teenager Frank Abagnale lives in New Rochelle, New York with his father Frank Abagnale, Sr., and French mother, Paula. When Frank Sr. encounters tax problems with the IRS, his family is forced to move from their large home to a small apartment. Paula carries on an affair with Jack Barnes, her husband's friend. Meanwhile, Frank has to transfer to public school and gets into trouble when he begins posing as a substitute French teacher on his first day there. Frank runs away when his parents divorce. Needing money, he turns to confidence scams to survive, and his cons grow bolder. He impersonates an airline pilot and forges Pan Am payroll checks. Soon, his forgeries are worth millions of dollars.", "Catch Me If You Can" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorID",
                table: "Movies",
                column: "DirectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreID",
                table: "Movies",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerID",
                table: "Movies",
                column: "ProducerID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_PublisherID",
                table: "Movies",
                column: "PublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_MovieId",
                table: "Photos",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
