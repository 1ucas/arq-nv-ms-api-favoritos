using System.Collections.Generic;
using System.Linq;
using FavoritosApi.Models.Entidades;
using FavoritosApi.Models.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FavoritosApi.Repos
{
    public class FavoritosRepo : IFavoritosRepo
    {
        private IMongoDatabase DbFavoritos { get; }
        private IMongoCollection<FavoritoEntidade> Favoritos { get; }

        public FavoritosRepo()
        {
            string connectionString = "{connectionString}";
            MongoClient client = new MongoClient(connectionString);
            DbFavoritos =  client.GetDatabase("favoritos-db");
            Favoritos = DbFavoritos.GetCollection<FavoritoEntidade>("favoritos");
        }

        public List<FavoritoEntidade> ListarPorUsuario(int idUsuario)
        {
            return Favoritos.FindSync(f => f.UsuarioId == idUsuario).ToList();
        }

        public void Remover(string favoritoId)
        {
            Favoritos.DeleteOne(f => f.Id == ObjectId.Parse(favoritoId));
        }

        public void Inserir(int idUsuario, int idLivro)
        {
            var novoFavorito = new FavoritoEntidade
            {
                LivroIsbn = idLivro,
                UsuarioId = idUsuario
            };

            Favoritos.InsertOne(novoFavorito);
        }
    }
}
