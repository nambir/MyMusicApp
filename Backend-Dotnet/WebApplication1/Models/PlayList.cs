namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    /// <summary>
    /// PlayList
    /// </summary>
    [Table("PlayList")]
    public partial class PlayList
    {
        /// <summary>
        /// PlayList
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlayList()
        {
            PlayListSongs = new HashSet<PlayListSong>();
        }
        /// <summary>
        /// PlayListId
        /// </summary>
        public int PlayListId { get; set; }

        /// <summary>
        /// PlayListName
        /// </summary>
        public string PlayListName { get; set; }
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
