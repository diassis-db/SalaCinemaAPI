using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalaCinemaAPI.Entity;
using SalaCinemaAPI.Infra;

namespace SalaCinemaAPI.Controllers
{
    [ApiController]
    [Route("salacinema/v1")]
    public class SalaController : ControllerBase
    {
        private readonly ConnectionDB _connectionDB;

        public SalaController(ConnectionDB connectionDB)
        {
            _connectionDB = connectionDB;
        }

        [HttpPost]
        [ProducesResponseType(200), ProducesResponseType(400), ProducesResponseType(500)]
        public async Task<ActionResult> CreateSala([FromBody] Sala sala)
        {
            try
            {
                _connectionDB.Salas.Add(sala);
                _connectionDB.SaveChanges();
                return Ok();
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("listar salas")]
        public ActionResult<IEnumerable<Sala>> GetSala()
        {
            try
            {
                return Ok(_connectionDB.Salas.Select(s => s.NomeSala));
            }
            catch (Exception) { return BadRequest(); }
        }


        [HttpPost]
        [Route("filmes")]
        public ActionResult<Filme> CreateFilme(Filme filme) {
            try
            {
                _connectionDB.Filmes.Add(filme);
                _connectionDB.SaveChanges();
                return Ok();
            }catch(Exception) { return BadRequest(); }
        }
        [HttpGet]
        [Route("listar filmes")]
        public ActionResult<IEnumerable<Filme>> GetFilmes()
        {
            try
            {
                return Ok(_connectionDB.Filmes.Select(f => f.NomeFilme));
            }catch (Exception) { return BadRequest(); }
        }

        [HttpPost]
        [Route("salafilme")]
        public ActionResult<SalaFilme> CreateSalaFilme(SalaFilme salaFilme)
        {
            try
            {
                _connectionDB.SalaFilme.Add(salaFilme);
                _connectionDB.SaveChanges();
                return Ok();
            }catch (Exception) { return BadRequest(); }
        }

        [HttpGet]
        [Route("listasalafilme")]
        public ActionResult<IList<SalaFilme>> GetFilmes(int idsalafilme)
        {
            try
            {
                return Ok(_connectionDB.SalaFilme.Where(s => s.SalaId == idsalafilme));
            }catch (Exception) { return BadRequest(); }
        }
    }
}
