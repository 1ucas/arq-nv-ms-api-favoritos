using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritosApi.Models.Entidades
{
    public class FavoritoEntidade
    {
        public ObjectId Id { get; set; }

        [BsonElement("usuarioId")]
        public int UsuarioId { get; set; }

        [BsonElement("livroId")]
        public int LivroIsbn { get; set; }
    }
}
