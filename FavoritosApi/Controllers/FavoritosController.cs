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

        /// <summary>
        /// Retorna a Lista de Livros Favoritos de um Usuário por meio de seu ID.
        /// </summary>
        /// <remarks>
        /// Exemplo de entrada:
        /// 
        ///     {
        ///         "idUsuario": 1
        ///     }
        ///     
        /// </remarks>
        /// <param name="idUsuario">ID referente ao usuário.</param>
        [HttpGet]
        [Route("usuario/{idUsuario}")]
        public List<FavoritoDTO> GetByUserId(int idUsuario)
        {
            return _favoritosService.ListarPorUsuario(idUsuario);
        }

        /// <summary>
        /// Salva um livro na Lista de Livros Favoritos do Usuário.
        /// </summary>
        /// <param name="favorito">Objeto referente ao livro que será salvo como favorito.</param>
        [HttpPost]
        public void Post([FromBody]FavoritoDTO favorito)
        {
             _favoritosService.Inserir(favorito);
        }

        /// <summary>
        /// Deleta um livro da Lista de Favoritos do Usuário.
        /// </summary>
        /// <param name="favorito">Objeto referente ao livro que será deletado.</param>
        [HttpDelete]
        public void Delete(FavoritoDTO favorito)
        {
            _favoritosService.Remover(favorito);
        }
    }
}
