using System.Collections.Generic;
using FavoritosApi.Models.Entidades;
using FavoritosApi.Models.Interfaces;
using FavoritosApi.Serivces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FavoritosApi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListarPorUsuario_CaminhoFeliz_Favorito()
        {
            int idUsuario = 1;
            Mock<IFavoritosRepo> mock = new Mock<IFavoritosRepo>();
            mock.Setup(m => m.ListarPorUsuario(idUsuario)).Returns(
                new List<FavoritoEntidade>()
                {
                    new FavoritoEntidade()
                    {
                        LivroIsbn = 1,
                        UsuarioId = 1
                    }
                }   
            );
            FavoritosService _favoritosService = new FavoritosService(mock.Object);

            var result = _favoritosService.ListarPorUsuario(idUsuario);

            Assert.AreEqual(result.Count, 1);

        }
    }
}
