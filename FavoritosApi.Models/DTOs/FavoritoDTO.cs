using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FavoritosApi.Models.Entidades;

namespace FavoritosApi.Models.DTOs
{
    public class FavoritoDTO
    {
        public string FavoritoId { get; set; }
        public int UsuarioId { get; set; }
        public int LivroIsbn { get; set; }

        public static List<FavoritoDTO> From(List<FavoritoEntidade> listaFavoritos)
        {
            var listaFavoritosDTO = new List<FavoritoDTO>();
            foreach (var favorito in listaFavoritos)
            {
                listaFavoritosDTO.Add(new FavoritoDTO
                {
                    FavoritoId = favorito.Id.ToString(),
                    LivroIsbn = favorito.LivroIsbn,
                    UsuarioId = favorito.UsuarioId
                });
            }
            return listaFavoritosDTO;
        }
    }
}
