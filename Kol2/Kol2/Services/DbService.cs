using Kol2.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kol2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kol2.Services
{
    public class DbService : IDbService
    {
        readonly MainDbContext _mainDbContext;
        public DbService(MainDbContext dbContext)
        {
            _mainDbContext = dbContext;
        }

        public async Task<bool> DeleteMusician(DeleteMusician deleteMusician)
        {
            var mus =  _mainDbContext.Musicians.Where(e => e.LastName == deleteMusician.LastName && e.Nickname == deleteMusician.Nickname && e.FirstName == deleteMusician.FirstName).FirstOrDefault();
            if (!(mus == null))
            {
                _mainDbContext.Remove(mus);
                await _mainDbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<ICollection<GetAlbum>> GetAlbums(string id)
        {
            var list= _mainDbContext.Albums.Where(e => e.IdAlbum == int.Parse(id)).Select(x=>
            {
                new GetAlbum { AlbumName = x.AlbumName, TracksNames = x.Tracks.Select(p => new GetTrack { TrackName = p.TrackName, Duration = p.Duration }).ToList() };
            });

            return list;
        }
    }
}
