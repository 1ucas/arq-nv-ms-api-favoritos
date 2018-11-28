using System.Collections.Generic;
using FavoritosApi.Models.DTOs;
using FavoritosApi.Models.Interfaces;

namespace FavoritosApi.Serivces
{
    public class FavoritosService : IFavoritosService
    {
        private readonly IFavoritosRepo _favoritosRepo;
        public FavoritosService(IFavoritosRepo favoritosRepo)
        {
            _favoritosRepo = favoritosRepo;
        }

        public List<FavoritoDTO> ListarPorUsuario(int idUsuario)
        {
            var listaFavoritos = _favoritosRepo.ListarPorUsuario(idUsuario);
            var listaFavoritosDTO = FavoritoDTO.From(listaFavoritos);
            return listaFavoritosDTO;
        }

        public void Inserir(FavoritoDTO favorito)
        {
            _favoritosRepo.Inserir(favorito.UsuarioId, favorito.LivroIsbn);
        }

        public void Remover(FavoritoDTO favorito)
        {
            _favoritosRepo.Remover(favorito.FavoritoId);
        }
    }
}
