using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerceariaMVC.Models;

namespace MerceariaMVCTests
{
    public class ProdutoTests
    {
        [Fact]
        public void Verificar_Preco_Invalido_seForMenorQueZero()
        {
            //Arrange
           var produto = new Produto
           {
               Nome = "Biscoito",
               Preco = 0,
               Estoque = 10
           };

            //Act
            var resultado = produto.Validacao();
            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void Estoque_Invalido_se_Valor_MenorqueZero()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "Macarrão",
                Preco = 5,
                Estoque = -1
            };
            //Act
            var resultado = produto.Validacao();
            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void Verificar_Nome_Nulo_ou_Vazio_Invalido()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "",
                Preco = 50,
                Estoque = 60,
            };

            //Act
            var resultado = produto.Validacao();

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void Verifica_PrecoMaiorqueZero_Estoque_MaiorqueZero_NomeProdutoExistente()
        {
            var produto = new Produto
            {
                Nome = "Arroz",
                Preco = 10,
                Estoque = 20
            };
            //Act
            var resultado = produto.Validacao();
            //Assert
            Assert.True(resultado);
        }
    }
}
