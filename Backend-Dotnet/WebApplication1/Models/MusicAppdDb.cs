namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public partial class MusicAppdDb : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public MusicAppdDb()
            : base("name=MusicAppdDb")
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<PlayList> PlayLists { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<PlayListSong> PlayListSongs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<Song> Songs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayList>()
                .Property(e => e.PlayListName)
                .IsUnicode(false);

            modelBuilder.Entity<Song>()
                .Property(e => e.SongTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Song>()
                .Property(e => e.Singers)
                .IsUnicode(false);

            modelBuilder.Entity<Song>()
                .Property(e => e.Album)
                .IsUnicode(false);
        }
    }
}
