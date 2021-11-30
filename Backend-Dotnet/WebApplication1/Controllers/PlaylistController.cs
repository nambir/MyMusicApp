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
    public class PlaylistController : ApiController
    {
        MusicAppdDb _dbContext = new MusicAppdDb();
        /// <summary>
        /// Get All Songs for playlist
        /// </summary>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetSongsForPlaylist")]
        public HttpResponseMessage GetSongsForPlaylist(int playListId)
        {
            try
            {
                _dbContext = new MusicAppdDb();
                var allsongs =
                    (from PLSongs in _dbContext.PlayListSongs
                     join songs in _dbContext.Songs on PLSongs.SongId equals songs.SongId
                     where (PLSongs.PlayListId == playListId && PLSongs.IsActive == true && songs.IsActive == true)

                     select new SongsDTO
                     {
                         SongId = songs.SongId,
                         SongTitle = songs.SongTitle,
                         Singers = songs.Singers,
                         Album = songs.Album,
                         PlayTime = songs.PlayTime,
                         IsActive = songs.IsActive,
                         CreatedDate = songs.CreatedDate
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


        /// <summary>
        /// Get All Playlist
        /// </summary>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetAllPlaylist")]
        public HttpResponseMessage GetAllPlaylist()
        {
            try
            {
                _dbContext = new MusicAppdDb();
                var allPlaylist = _dbContext.PlayLists.Where(x => x.IsActive == true).Select(item =>
                    new 
                    {
                        PlayListId = item.PlayListId,
                        PlayListName = item.PlayListName,                      
                        CreatedDate = item.CreatedDate
                    }).ToList();


                return this.Request.CreateResponse(HttpStatusCode.OK, allPlaylist);

            }
            catch (Exception ex)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError, "error");
            }
        }

        /// <summary>
        /// Save Play List
        /// </summary>
        /// <param name="playListName"></param>
        /// <returns></returns>
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("PlayList")]
        public HttpResponseMessage SavePlayList(string playListName)
        {
            PlayList playList = new PlayList()
            {
                 PlayListName= playListName,
                  IsActive=true,
                  CreatedDate=DateTime.Now
            };
            try
            {
                _dbContext.PlayLists.Add(playList);
                _dbContext.SaveChanges();
                 return this.Request.CreateResponse(HttpStatusCode.OK, playList);
            }
            catch(Exception exc)
            {
                return this.Request.CreateResponse(HttpStatusCode.NotFound, exc.Message);
            }
           
        }
        /// <summary>
        /// Save Play List Songs
        /// </summary>
        /// <param name="songId"></param>
        /// <param name="playListId"></param>
        /// <returns></returns>
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("PlayListSongs")]
        public HttpResponseMessage SavePlayListSongs(int songId,int playListId)
        {
            PlayListSong playListSong = new PlayListSong()
            {
                 SongId=songId,
                 PlayListId=playListId,
                 IsActive=true,
                 CreatedDate=DateTime.Now
            };
            try
            {
                _dbContext.PlayListSongs.Add(playListSong);
                _dbContext.SaveChanges();
                return this.Request.CreateResponse(HttpStatusCode.OK, "PlayListSongs Saved Sucessfully!");
            }
            catch (Exception exc)
            {
                return this.Request.CreateResponse(HttpStatusCode.NotFound, exc.Message);
            }

        }
    }
}
