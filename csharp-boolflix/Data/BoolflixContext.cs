using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Data
{
    public class BoolflixContext : DbContext
    {
        public BoolflixContext(DbContextOptions<BoolflixContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<TvSeries> TvSeries { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<MediaInfo> MediaInfos { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}
