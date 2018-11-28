using System.Collections.Generic;
using FavoritosApi.Models.Entidades;

namespace FavoritosApi.Models.Interfaces
{
    public interface IFavoritosRepo
    {
        List<FavoritoEntidade> ListarPorUsuario(int idUsuario);

        void Remover(string favoritoId);

        void Inserir(int idUsuario, int idLivro);
    }
}
