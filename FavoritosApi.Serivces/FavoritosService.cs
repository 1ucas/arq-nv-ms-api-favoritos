using FavoritosApi.Models.DTOs;
using FavoritosApi.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritosApi.Serivces
{
    public class FavoritosService
    {
        public List<FavoritoDTO> ListarPorUsuario(int idUsuario)
        {
            var listaFavoritos = new FavoritosRepo().ListarPorUsuario(idUsuario);
            var listaFavoritosDTO = FavoritoDTO.From(listaFavoritos);
            return listaFavoritosDTO;
        }

        public void Inserir(FavoritoDTO favorito)
        {
            new FavoritosRepo().Inserir(favorito.UsuarioId, favorito.LivroIsbn);
        }

        public void Remover(FavoritoDTO favorito)
        {
            new FavoritosRepo().Remover(favorito.FavoritoId);
        }
    }
}
