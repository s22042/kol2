using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kol2.Models;
using Kol2.Models.DTO;
namespace Kol2.Services
{
    public interface IDbService
    {
        Task<ICollection<GetAlbum>> GetAlbums(string id);
        Task<bool> DeleteMusician(DeleteMusician deleteMusician);
    }
}
