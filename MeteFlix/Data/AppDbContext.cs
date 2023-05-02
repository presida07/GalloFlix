using MeteFlix.Models;
using Microsoft.AspnNetCore.IDentity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MeteFlix.Data;

    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {   
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MoveComment> MovieComments { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<MovieRating> MovieRatings { get; set; }

        protected override OnModelCreating(ModelBuilder builder)
        {
            base.OnMOdelCreating(builder);
            // FluentAPI
            // Personalizar as tabelas do identity
            builder.Entity<IdentityUser>(
                iu => {iu.ToTable("Users");}
            );

            builder.Entity<IdentityUserClaim<string>>(
                iu => {iu.ToTable("UserClaims");}
            );

            builder.Entity<IdentityUserLogin<string>>(
                iu => {iu.ToTable("UserLogins");}
            );

            builder.Entity<IdentityUserToken<string>>(
                iu => {iu.ToTable("UserTokens");}
            );

            builder.Entity<IdentityRole>(
                iu => {iu.ToTable("Roles");}
            );
            
            builder.Entity<IdentityRoleClaim<string>>(
                iu => {iu.ToTable("RoleClaims");}
            );

            builder.Entity<IdentityUserRole<string>>(
                iu => {iu.ToTable("UserRoles");}
            );

            #region Many To Many - MovieComment.
            builder.Entity<MovieComment>()
                 .HasOne(mc => mc.Movie)
                 .WithMany(m => m.Comments)
                 .HasForeignKey(mc => mc.MovieId);
            
            builder.Entity<MovieComments>()
                .HasOne(mc => mc.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(mc => mc.UserId);
            #endregion

            #region Many To Many - MovieGenre

            builder.Entity<MovieGenres>().HasKey(
                mg => new { mg.MovieId, mg.GenreId}
            ); 
            
            builder.Entity<MovieGenres>()
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.Genres)
                .HasForeignKey(mg => mg.MovieId);

            builder.Entity<MovieGenres>()
                 .HasOne(mg => mg.Genre )
                 .WithMany(g => g.Movies)
                 .HasForeignKey(mg => mg.GenreId);

            #endregion

            #region Many to Many - MovieRating
            builder.Entity<MovieRating>().HasKey(
                mr => new { mr.MovieId, mr.UserId}
            );

             builder.Entity<MovieRating>()
                .HasOne(mr => mr.Movie)
                .WithMany(m => m.Ratings)
                .HasForeignKey(mr => mr.MovieId);

             builder.Entity<MovieRating>()
                .HasOne(mr => mr.Movie)
                .WithMany(u => u.Ratings)
                .HasForeignKey(mr => mr.UserId);
             
             #endregion
        }
         

 }
