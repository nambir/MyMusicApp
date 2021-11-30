using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Songs Controller
    /// </summary>
    [System.Web.Http.RoutePrefix("api/MusicApp")]
    //[Authorize] //for Authoization of APIs
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-My-Header")]
    public class SongsController : ApiController
    {
        MusicAppdDb _dbContext = new MusicAppdDb();
        /// <summary>
        /// Get All Songs
        /// </summary>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetAllSongs")]
        public HttpResponseMessage GetAllSongs()
        {
            try
            {
                _dbContext = new MusicAppdDb();
                var allsongs = _dbContext.Songs.Where(x => x.IsActive == true).Select(item =>
                    new SongsDTO
                    {
                        SongId = item.SongId,
                        SongTitle = item.SongTitle,
                        Singers = item.Singers,
                        Album = item.Album,
                        PlayTime = item.PlayTime,
                        IsActive = item.IsActive,
                        CreatedDate = item.CreatedDate
                    }).ToList();

                if (allsongs == null)
                {
                    return this.Request.CreateResponse(HttpStatusCode.NotFound, allsongs);
                }
                return this.Request.CreateResponse(HttpStatusCode.OK, allsongs);
            }
            catch(Exception ex)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError, "error");
            }
        }
        
    }
}
