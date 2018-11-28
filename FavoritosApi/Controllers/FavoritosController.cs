using FavoritosApi.Models.DTOs;
using FavoritosApi.Serivces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FavoritosApi.Controllers
{
    [RoutePrefix("api/private/v1/favoritos")]
    public class FavoritosController : ApiController
    {
        [HttpGet]
        [Route("usuario/{idUsuario}")]
        public List<FavoritoDTO> GetByUserId(int idUsuario)
        {
            return new FavoritosService().ListarPorUsuario(idUsuario);
        }

        [HttpPost]
        public void Post([FromBody]FavoritoDTO favorito)
        {
            new FavoritosService().Inserir(favorito);
        }

        [HttpDelete]
        public void Delete(FavoritoDTO favorito)
        {
            new FavoritosService().Remover(favorito);
        }
    }
}
