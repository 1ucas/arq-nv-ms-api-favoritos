using System.Collections.Generic;
using FavoritosApi.Models.DTOs;

namespace FavoritosApi.Models.Interfaces
{
    public interface IFavoritosService
    {
        List<FavoritoDTO> ListarPorUsuario(int idUsuario);

        void Inserir(FavoritoDTO favorito);

        void Remover(FavoritoDTO favorito);
    }
}
