using FFP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace FFP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminRole> AdminRoles { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchRating> MatchesRatings { get; set; }
        public DbSet<MatchRatingReport> MatchRatingReports { get; set; }
        public DbSet<MatchSave> MatchSaves { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostCommentLike> PostCommentLikes { get; set; }
        public DbSet<PostCommentReport> PostCommentReports { get; set; }
        public DbSet<PostLike> PostLikes { get; set; }
        public DbSet<PostReport> PostReports { get; set; }
        public DbSet<PostSave> PostSaves { get; set; }
        public DbSet<Prediction> Predictions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCart> ProductsCarts { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<ProductSave> ProductSaves { get; set; }
        public DbSet<ReportType> ReportTypes { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreProduct> StoresProducts { get; set; }
        public DbSet<StoreSave> StoreSaves { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSave> UserSaves { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Data
            //modelBuilder.Entity<PlatformItemType>().HasData(
            //    new PlatformItemType
            //    {
            //        Title = ""
            //    }
            //);

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = 1,
                    AppartmentNo = 60,
                    City = "Riyadh",
                    Country = "Saudi Arabia",
                    Street = "Tahlia Street",
                    ZipCode = null,
                },
                new Address
                {
                    Id = 2,
                    AppartmentNo = 30,
                    City = "Riyadh",
                    Country = "Saudi Arabia",
                    Street = "Al Sahafa Street",
                    ZipCode = null,
                },
                new Address
                {
                    Id = 3,
                    AppartmentNo = 25,
                    City = "Jeddah",
                    Country = "Saudi Arabia",
                    Street = "Hira Street",
                    ZipCode = null,
                }
            );
            modelBuilder.Entity<AdminRole>().HasData(
                new AdminRole
                {
                    Id = 1,
                    Title = "Super Admin"
                }
            );
            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    Id = 1,
                    FirstName = "Mazen",
                    SecondName = "Ameen",
                    ThirdName = "Hamid",
                    LastName = "Salah",
                    AddressId = 1,
                    AdminRoleId = 1,
                    BirthDate = new DateTime(2000, 12, 16),
                    Email = "masalah.tech@gmail.com",
                    PhoneNumber = "00967774806897",
                    EncPassword = "M@zen852",
                    Nationality = "Yemen",
                    PersonalPhotoPath = "/uploads/mazen.jpg",
                    Status = true,
                    Username = "masalah-tech",
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Mohammed",
                    LastName = "Hamza",
                    EncPassword = "slSe@#VSs1532",
                    PhotoPath = null,
                    Gender = "Male",
                    Status = true,
                    Username = "mohammedhamza"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Shaimaa",
                    LastName = "Salim",
                    EncPassword = "23@fSF3@Fs",
                    PhotoPath = null,
                    Status = true,
                    Gender = "Female",
                    Username = "shaimaasalim"
                },
                new User
                {
                    Id = 3,
                    FirstName = "Osama",
                    LastName = "Sameer",
                    EncPassword = "@#$FSAF@#",
                    PhotoPath = null,
                    Gender = "Male",
                    Status = true,
                    Username = "osamasameer"
                },
                new User
                {
                    Id = 4,
                    FirstName = "Mohammed",
                    LastName = "Naser",
                    EncPassword = "sF3#$Gs%#ss",
                    PhotoPath = null,
                    Gender = "Male",
                    Status = true,
                    Username = "mohammednaser"
                },
                new User
                {
                    Id = 5,
                    FirstName = "Khalid",
                    LastName = "Amer",
                    EncPassword = "Sfe34%#2#5%",
                    PhotoPath = null,
                    Gender = "Male",
                    Status = true,
                    Username = "khalidamer"
                },
                new User
                {
                    Id = 6,
                    FirstName = "Mahmoud",
                    LastName = "Mansour",
                    EncPassword = "@#FsdE323#",
                    PhotoPath = null,
                    Gender = "Male",
                    Status = true,
                    Username = "mahmoudmansour"
                },
                new User
                {
                    Id = 7,
                    FirstName = "Abdullah",
                    LastName = "Saleh",
                    EncPassword = "234SDFe3#$",
                    PhotoPath = null,
                    Gender = "Male",
                    Status = true,
                    Username = "abdullahsaleh"
                },
                new User
                {
                    Id = 8,
                    FirstName = "Nazar",
                    LastName = "Hamoud",
                    EncPassword = "SDe2#@43S",
                    PhotoPath = null,
                    Gender = "Male",
                    Status = true,
                    Username = "nazarhamoud"
                },
                new User
                {
                    Id = 9,
                    FirstName = "Abdulaziz",
                    LastName = "Sultan",
                    EncPassword = "SSEFE23fs@#",
                    PhotoPath = null,
                    Gender = "Male",
                    Status = true,
                    Username = "abdulazizsultan"
                },
                new User
                {
                    Id = 10,
                    FirstName = "Hattan",
                    LastName = "Faisal",
                    EncPassword = "&%sdfSE323",
                    PhotoPath = null,
                    Gender = "Male",
                    Status = true,
                    Username = "hattanfaisal"
                },
                new User
                {
                    Id = 11,
                    FirstName = "Thunaian",
                    LastName = "Khalid",
                    EncPassword = "@##@SDFss3",
                    PhotoPath = null,
                    Gender = "Male",
                    Status = true,
                    Username = "thunaiankhalid"
                },
                new User
                {
                    Id = 12,
                    FirstName = "Mohammed",
                    LastName = "Hamza",
                    EncPassword = "!!324sdSdfF43",
                    PhotoPath = null,
                    Gender = "Male",
                    Status = true,
                    Username = "mohammedhamza"
                },
                new User
                {
                    Id = 13,
                    FirstName = "Somayah",
                    LastName = "Omar",
                    EncPassword = "((^77456FDg3",
                    PhotoPath = null,
                    Gender = "Female",
                    Status = true,
                    Username = "somayahomar"
                },
                new User
                {
                    Id = 14,
                    FirstName = "Kholod",
                    LastName = "Ahmed",
                    EncPassword = "@@342SDfe2",
                    PhotoPath = null,
                    Gender = "Female",
                    Status = true,
                    Username = "kholodahmed"
                },
                new User
                {
                    Id = 15,
                    FirstName = "Taha",
                    LastName = "Abdulghafour",
                    EncPassword = "!@#SDFdf323",
                    PhotoPath = null,
                    Gender = "Male",
                    Status = true,
                    Username = "tahaabdulghafour"
                },
                new User
                {
                    Id = 16,
                    FirstName = "Salma",
                    LastName = "Adel",
                    EncPassword = "Ssdfe@#234S",
                    PhotoPath = null,
                    Gender = "Female",
                    Status = true,
                    Username = "salmaadel"
                }
            );

            modelBuilder.Entity<Cart>().HasData(
                new Cart
                {
                    Id = 1,
                    UserId = 1,
                }
            );

            modelBuilder.Entity<Club>().HasData(
                new Club
                {
                    Id = 1,
                    Name = "Al-Hilal",
                    LogoPath = "/uploads/al-hilal-club-logo.png"
                },
                new Club
                {
                    Id = 2,
                    Name = "Al-Ra'ed",
                    LogoPath = "/uploads/al-raed-club-logo.png"
                },
                new Club
                {
                    Id = 3,
                    Name = "Al-Shabab",
                    LogoPath = "/uploads/al-shabab-club-logo.png"
                },
                new Club
                {
                    Id = 4,
                    Name = "Al-Ittihad",
                    LogoPath = "/uploads/al-ittihad-club-logo.png"
                },
                new Club
                {
                    Id = 5,
                    Name = "Al-Ettifaq",
                    LogoPath = "/uploads/al-ettifaq-club-logo.png"
                },
                new Club
                {
                    Id = 7,
                    Name = "Al-Nassr",
                    LogoPath = "/uploads/al-nassr-club-logo.png"
                },
                new Club
                {
                    Id = 8,
                    Name = "Al-Khaleej",
                    LogoPath = "/uploads/al-khaleej-club-logo.png"
                },
                new Club
                {
                    Id = 9,
                    Name = "Dortmund",
                    LogoPath = "/uploads/dortmund-club-logo.png"
                },
                new Club
                {
                    Id = 10,
                    Name = "Newcastle",
                    LogoPath = "/uploads/newcastle-club-logo.png"
                },
                new Club
                {
                    Id = 11,
                    Name = "Shakhtar Donetsk",
                    LogoPath = "/uploads/shakhtar-donetsk-club-logo.png"
                },
                new Club
                {
                    Id = 12,
                    Name = "Barcelona",
                    LogoPath = "/uploads/barcelona-club-logo.png"
                },
                new Club
                {
                    Id = 13,
                    Name = "Real Madrid",
                    LogoPath = "/uploads/real-madrid-club-logo.png"
                },
                new Club
                {
                    Id = 14,
                    Name = "Lazio",
                    LogoPath = "/uploads/lazio-club-logo.png"
                },
                new Club
                {
                    Id = 15,
                    Name = "Feyenoord",
                    LogoPath = "/uploads/feyenoord-club-logo.png"
                },
                new Club
                {
                    Id = 16,
                    Name = "Porto",
                    LogoPath = "/uploads/porto-club-logo.png"
                },
                new Club
                {
                    Id = 17,
                    Name = "Antwerp",
                    LogoPath = "/uploads/antwerp-club-logo.png"
                }
            );

            modelBuilder.Entity<League>().HasData(
                new League
                {
                    Id = 1,
                    Name = "Roshn Saudi League",
                    Color = "rgb(57 94 172)"
                },
                new League
                {
                    Id = 2,
                    Name = "Champions League",
                    Color = "rgb(107 50 147)"
                },
                new League
                {
                    Id = 3,
                    Name = "La Liga",
                    Color = "rgb(0 158 161)"
                },
                new League
                {
                    Id = 4,
                    Name = "Premier League",
                    Color = "rgb(0 158 161)"
                },
                new League
                {
                    Id = 5,
                    Name = "Seria A",
                    Color = "rgb(65 181 70)"
                }
            );

            modelBuilder.Entity<Match>().HasData(
                new Match
                {
                    Id = 1,
                    LeagueId = 1,
                    Club1Id = 1,
                    Club1Goals = 3,
                    Club2Id = 2,
                    Club2Goals = 2,
                    DateTime = new DateTime(2023, 5, 31, 21, 0, 0)
                },
                new Match
                {
                    Id = 2,
                    LeagueId = 1,
                    Club1Id = 3,
                    Club1Goals = null,
                    Club2Id = 4,
                    Club2Goals = null,
                    DateTime = new DateTime(2030, 12, 16, 16, 0, 0)
                },
                new Match
                {
                    Id = 3,
                    LeagueId = 1,
                    Club1Id = 5,
                    Club1Goals = null,
                    Club2Id = 2,
                    Club2Goals = null,
                    DateTime = new DateTime(2030, 12, 16, 16, 0, 0)
                },
                new Match
                {
                    Id = 4,
                    LeagueId = 1,
                    Club1Id = 7,
                    Club1Goals = null,
                    Club2Id = 8,
                    Club2Goals = null,
                    DateTime = new DateTime(2030, 12, 16, 16, 0, 0)
                },
                new Match
                {
                    Id = 5,
                    LeagueId = 2,
                    Club1Id = 9,
                    Club1Goals = null,
                    Club2Id = 10,
                    Club2Goals = null,
                    DateTime = new DateTime(2030, 12, 16, 16, 0, 0)
                },
                new Match
                {
                    Id = 6,
                    LeagueId = 2,
                    Club1Id = 11,
                    Club1Goals = null,
                    Club2Id = 12,
                    Club2Goals = null,
                    DateTime = new DateTime(2030, 12, 16, 16, 0, 0)
                },
                new Match
                {
                    Id = 7,
                    LeagueId = 2,
                    Club1Id = 14,
                    Club1Goals = null,
                    Club2Id = 15,
                    Club2Goals = null,
                    DateTime = new DateTime(2030, 12, 16, 16, 0, 0)
                },
                new Match
                {
                    Id = 8,
                    LeagueId = 2,
                    Club1Id = 16,
                    Club1Goals = null,
                    Club2Id = 17,
                    Club2Goals = null,
                    DateTime = new DateTime(2030, 12, 16, 16, 0, 0)
                }
            );

            modelBuilder.Entity<MatchRating>().HasData(
                new MatchRating
                {
                    Id = 1,
                    MatchId = 1,
                    UserId = 1,
                    Value = 4,
                    Comment = "Bla Bla Bla",
                    Date = new DateTime(2023, 6, 2)
                }
            );

            modelBuilder.Entity<ReportType>().HasData(
                new ReportType
                {
                    Id = 1,
                    Title = "Spam"
                },
                new ReportType
                {
                    Id = 2,
                    Title = "Hate speach or graphic violence"
                },
                new ReportType
                {
                    Id = 3,
                    Title = "Harassment or bullying"
                },
                new ReportType
                {
                    Id = 4,
                    Title = "Misinformation"
                }
            );

            modelBuilder.Entity<MatchRatingReport>().HasData(
                new MatchRatingReport
                {
                    Id = 1,
                    MatchRatingId = 1,
                    ReportTypeId = 4,
                    UserId = 2,
                    Date = new DateTime(2023, 6, 4)
                }
            );

            modelBuilder.Entity<MatchSave>().HasData(
                new MatchSave
                {
                    Id = 1,
                    MatchId = 1,
                    UserId = 1,
                    Date = new DateTime(2023, 6, 1),
                }
            );

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    UserId = 1,
                    HTMLContent = 
                        "<p>What are the best football games? That question is not only guaranteed to spark plenty of debate but will also generate lots of different answers.</p><p>With that in mind, we have racked our brains to come up with what we believe are the best four football games for fans of all ages.</p><h4 class='mt-3'>Football Quizzer</h4><p>If you fancy testing the depth of your football knowledge, the hugely immersive FootballQuizzer.com is well worth checking out.</p><p>The site contains dozens of different quizzes about clubs, players, stadiums, derby games and more, each of which can be tackled alone or with family and friends.</p><p>The site contains dozens of different quizzes about clubs, players, stadiums, derby games and more, each of which can be tackled alone or with family and friends. Alternatively, if you think you know all there is to know about Thierry Henry, there are quizzes devoted to the Gunners legend. Football Quizzer is great fun for people of all ages!</p><h4 class='mt-3'>EA Sports FC 24</h4><p>Millions of fans worldwide believe the FIFA series is THE definitive football video game and it is difficult to argue with their viewpoint. Scheduled to be rebranded as EA Sports FC 24, this iconic game has sold more copies globally than any other sports-themed video game franchise.</p><p>The beauty of the game is it can be played by children and adults – sons and daughters can go head-to-head with their parents in a battle for family supremacy. With a massive global community behind it, FC 24 will remain the pinnacle of football video games for many more years. </p><h4 class='mt-3'>Football Billionaire</h4><p>If online gaming leaves you feeling underwhelmed, there are plenty of football-themed board games you could consider playing instead. </p><p>The pick of the bunch is Football Billionaire – a fast-moving football trading game that will test your ability to become a successful club owner. </p><p>Your task is to take your chosen team to the top by negotiating sponsorship deals, winning trophies and increasing the value of your club. </p><p>Suitable for ages six to adult and for two to six players, the Football Billionaire board game has the capacity to provide you with endless hours of fun. </p><h4 class='mt-3'>Football Manager</h4><p>We head back to the digital arena for our final recommendation, and this one is another game which has become an integral part of the football universe. It feels churlish to describe Football Manager as a ‘game’, as it is essentially an accurate simulator of what it feels like to manage a professional football club. </p><p>The challenges are endless in Football Manager. You can start in non-league and guide your team up the pyramid, or start with a big-hitter to test yourself against the best. The increasingly expansive nature of Football Manager means this is a game you will need to dedicate plenty of time to but the rewards are well worth the effort you put in. </p>",
                    PosterPath = "/uploads/post1.jpg",
                    Title = "The best football games for fans of all ages",
                    Date = new DateTime(2023, 11, 1),
                }
            );

            modelBuilder.Entity<PostComment>().HasData(
                new PostComment
                {
                    Id = 1,
                    UserId = 2,
                    Content = "I believe it is gonna be the best season ever. I'm really excited and cannot wait to see my best team take the cup.",
                    Date = new DateTime(2023, 11, 1),
                    PostId = 1
                }
            );

            modelBuilder.Entity<PostCommentLike>().HasData(
                new PostCommentLike
                {
                    Id = 1,
                    UserId = 2,
                    PostCommentId = 1,
                    Date = new DateTime(2023, 11, 2),
                }
            );

            modelBuilder.Entity<PostCommentReport>().HasData(
                new PostCommentReport
                {
                    Id = 1,
                    UserId = 1,
                    ReportTypeId = 4,
                    PostCommentId = 1,
                    Date = new DateTime(2023, 11, 3)
                }
            );

            modelBuilder.Entity<PostLike>().HasData(
                new PostLike
                {
                    Id = 1,
                    PostId = 1,
                    UserId = 1,
                    Date = new DateTime(2023, 12, 1)
                }
            );

            modelBuilder.Entity<PostReport>().HasData(
                new PostReport
                {
                    Id = 1,
                    UserId = 2,
                    PostId = 1,
                    ReportTypeId = 4,
                    Date = new DateTime(2023, 12, 1)
                }
            );

            modelBuilder.Entity<PostSave>().HasData(
                new PostSave
                {
                    Id = 1,
                    PostId = 1,
                    UserId = 2,
                    Date = new DateTime(2023, 12, 2)
                }
            );

            modelBuilder.Entity<Prediction>().HasData(
                new Prediction
                {
                    Id = 1,
                    UserId = 1,
                    MatchId = 2,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 2,
                    UserId = 2,
                    MatchId = 2,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 3,
                    UserId = 3,
                    MatchId = 2,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 4,
                    UserId = 4,
                    MatchId = 2,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 5,
                    UserId = 5,
                    MatchId = 2,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 6,
                    UserId = 6,
                    MatchId = 2,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 7,
                    UserId = 7,
                    MatchId = 2,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 8,
                    UserId = 8,
                    MatchId = 2,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 9,
                    UserId = 9,
                    MatchId = 2,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 10,
                    UserId = 10,
                    MatchId = 2,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 11,
                    UserId = 11,
                    MatchId = 2,
                    PredictedWinnerClub = 0
                },
                new Prediction
                {
                    Id = 12,
                    UserId = 12,
                    MatchId = 2,
                    PredictedWinnerClub = 0
                },
                new Prediction
                {
                    Id = 13,
                    UserId = 13,
                    MatchId = 2,
                    PredictedWinnerClub = 0
                },
                new Prediction
                {
                    Id = 14,
                    UserId = 14,
                    MatchId = 2,
                    PredictedWinnerClub = 2
                },
                new Prediction
                {
                    Id = 15,
                    UserId = 15,
                    MatchId = 2,
                    PredictedWinnerClub = 2
                },
                new Prediction
                {
                    Id = 16,
                    UserId = 16,
                    MatchId = 2,
                    PredictedWinnerClub = 2
                },
                new Prediction
                {
                    Id = 17,
                    UserId = 11,
                    MatchId = 3,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 18,
                    UserId = 12,
                    MatchId = 3,
                    PredictedWinnerClub = 2
                },
                new Prediction
                {
                    Id = 19,
                    UserId = 13,
                    MatchId = 3,
                    PredictedWinnerClub = 0
                },
                new Prediction
                {
                    Id = 20,
                    UserId = 1,
                    MatchId = 5,
                    PredictedWinnerClub = 2
                },
                new Prediction
                {
                    Id = 21,
                    UserId = 2,
                    MatchId = 5,
                    PredictedWinnerClub = 2
                },
                new Prediction
                {
                    Id = 22,
                    UserId = 3,
                    MatchId = 5,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 23,
                    UserId = 4,
                    MatchId = 5,
                    PredictedWinnerClub = 1
                },
                new Prediction
                {
                    Id = 24,
                    UserId = 5,
                    MatchId = 5,
                    PredictedWinnerClub = 1
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Nike Vapor Grip3 Goalkeeper Gloves – Black & Hyper Turq with Rush Fuschia with White",
                    MainPosterPath = "/uploads/product1.jpg",
                    OldPrice = null,
                    NewPrice = 118.80
                }
            );

            modelBuilder.Entity<ProductCart>().HasData(
                new ProductCart
                {
                    Id = 1,
                    CartId = 1,
                    ProductId = 1,
                }
            );

            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto
                {
                    Id = 1,
                    ProductId = 1,
                    Path = "/uploads/product1_img1.jpg",
                },
                new ProductPhoto
                {
                    Id = 2,
                    ProductId = 1,
                    Path = "/uploads/product1_img2.jpg"
                }
            );

            modelBuilder.Entity<ProductReview>().HasData(
                new ProductReview
                {
                    Id = 1,
                    UserId = 2,
                    ProductId = 1,
                    Value = 5,
                    Date = new DateTime(2023, 11, 2),
                    Comment = "Awesome product. I really liked it"
                }
            );

            modelBuilder.Entity<ProductSave>().HasData(
                new ProductSave
                {
                    Id = 1,
                    ProductId = 1,
                    UserId = 2,
                    Date = new DateTime(2023, 11, 2)
                }
            );

            modelBuilder.Entity<Store>().HasData(
                new Store
                {
                    Id = 1,
                    Name = "Just High Quality Items",
                    OwnerId = 1,
                    PosterPath = "/uploads/store1-poster.jpg",
                    Status = true,
                }
            );

            modelBuilder.Entity<StoreProduct>().HasData(
                new StoreProduct
                {
                    Id = 1,
                    ProductId = 1,
                    StoreId = 1,
                    InStock = 7
                }
            );

            modelBuilder.Entity<Sale>().HasData(
                new Sale
                {
                    Id = 1,
                    CustomerId = 2,
                    StoreProductId = 1,
                    Date = new DateTime(2023, 11, 1)
                }
            );

            modelBuilder.Entity<StoreSave>().HasData(
                new StoreSave
                {
                    Id = 1,
                    StoreId = 1,
                    UserId = 2,
                    Date = new DateTime(2023, 11, 1)
                }
            );

            modelBuilder.Entity<UserSave>().HasData(
                new UserSave
                {
                    Id = 1,
                    SavedUserId = 2,
                    SavingUserId = 1,
                    Date = new DateTime(2024, 1, 1)
                }
            );

            // End of Seed Data


            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.GetForeignKeys()
                    .Where(fk => fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
