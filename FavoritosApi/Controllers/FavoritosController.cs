using System.Collections.Generic;
using System.Web.Http;
using FavoritosApi.Models.DTOs;
using FavoritosApi.Models.Interfaces;

namespace FavoritosApi.Controllers
{
    [RoutePrefix("api/private/v1/favoritos")]
    public class FavoritosController : ApiController
    {
        private readonly IFavoritosService _favoritosService;
        public FavoritosController(IFavoritosService favoritosService)
        {
            _favoritosService = favoritosService;        
        
        }

        [HttpGet]
        [Route("usuario/{idUsuario}")]
        public List<FavoritoDTO> GetByUserId(int idUsuario)
        {
            return _favoritosService.ListarPorUsuario(idUsuario);
        }

        [HttpPost]
        public void Post([FromBody]FavoritoDTO favorito)
        {
             _favoritosService.Inserir(favorito);
        }

        [HttpDelete]
        public void Delete(FavoritoDTO favorito)
        {
            _favoritosService.Remover(favorito);
        }
    }
}
