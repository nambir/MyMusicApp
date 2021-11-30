namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    /// <summary>
    /// PlayListSong
    /// </summary>
    public partial class PlayListSong
    {
        /// <summary>
        /// PlayListSongsId
        /// </summary>
        [Key]
        public int PlayListSongsId { get; set; }
        /// <summary>
        /// PlayListId
        /// </summary>
        public int? PlayListId { get; set; }
        /// <summary>
        /// SongId
        /// </summary>
        public int? SongId { get; set; }
        /// <summary>
        /// IsActive
        /// </summary>
        public bool? IsActive { get; set; }
        /// <summary>
        /// CreatedDate
        /// </summary>
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// PlayList
        /// </summary>
        public virtual PlayList PlayList { get; set; }
        /// <summary>
        /// Song
        /// </summary>
        public virtual Song Song { get; set; }
    }
}
