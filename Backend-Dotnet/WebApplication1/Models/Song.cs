namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// Song
    /// </summary>
    public partial class Song
    {
        /// <summary>
        /// Song
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Song()
        {
            PlayListSongs = new HashSet<PlayListSong>();
        }
        /// <summary>
        /// SongId
        /// </summary>
        public int SongId { get; set; }

        /// <summary>
        /// SongTitle
        /// </summary>
        public string SongTitle { get; set; }

        /// <summary>
        /// Singers
        /// </summary>
        public string Singers { get; set; }

        /// <summary>
        /// Album
        /// </summary>
        public string Album { get; set; }
        /// <summary>
        /// PlayTime
        /// </summary>
        public TimeSpan? PlayTime { get; set; }
        /// <summary>
        /// IsActive
        /// </summary>
        public bool? IsActive { get; set; }
        /// <summary>
        /// CreatedDate
        /// </summary>
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// PlayListSongs
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayListSong> PlayListSongs { get; set; }
    }
}
