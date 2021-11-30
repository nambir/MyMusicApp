using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    /// <summary>
    /// SongsDTO
    /// </summary>
    public class SongsDTO
    {
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
    }
}