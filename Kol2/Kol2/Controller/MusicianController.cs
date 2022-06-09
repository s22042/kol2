using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kol2.Services;
using Kol2.Models.DTO;
namespace Kol2.Controller
{   [ApiController]
    [Route("api")]
    public class MusicianController : ControllerBase
    {
        private readonly IDbService _dbService;
        public MusicianController(IDbService dbService)
        {
            _dbService = dbService;
        
        }

        [HttpGet]
        [Route("albums")]
        public async Task<IActionResult> GetAlbum(string id)
        {
            var albums = await _dbService.GetAlbums(id);
            return Ok(albums);
        }

        [HttpDelete]
        [Route("musician")]
        public async Task<IActionResult> DeleteMusician([FromBody] DeleteMusician deleteMusician)
        {

            var deleted = await _dbService.DeleteMusician(deleteMusician);
            if (deleted)
                return Ok("Muzyk usuniety ");
            else
                return BadRequest("Muzyka nie mozna usunac");
        }
    }
}
