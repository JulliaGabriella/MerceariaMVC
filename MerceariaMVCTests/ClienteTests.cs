using MerceariaMVC.Models;

namespace MerceariaMVCTests;
public class ClienteTests
{
    [Fact]
    public void Verificar_Nome_Nulo()
    {
        //Arrange
        var cliente = new Cliente
        {
            Nome = "",
            Email = "julia@gmail.com",
            Idade = 26,
            Ativo = false
        };

        //Act
        var resultado = cliente.Validacao();

        //Assert
        Assert.False(resultado);
    }

    [Fact]
    public void Verificar_Nome_Espacos_Vazios()
    {
        //Arrange
        var cliente = new Cliente
        {
            Nome = "    ",
            Email = "julia@gmail.com",
            Idade = 26,
            Ativo = false
        };

        //Act
        var resultado = cliente.Validacao();

        //Assert
        Assert.False(resultado);
    }

    [Fact]
    public void Verificar_Email_Valido()
    {
        //Arrange
        var cliente = new Cliente
        {
            Nome = "João",
            Email = "joaozinhogmail.com",
            Idade = 20,
            Ativo = false
        };

        //Act
        var resultado = cliente.Validacao();

        //Assert
        Assert.False(resultado);

    }

    [Fact]
    public void Verificar_Maior_Idade_Valida()
    {
        //Arrange
        var cliente = new Cliente
        {
            Nome = "Mariana",
            Email = "mariana@gmail.com",
            Idade = 17,
            Ativo = false
        };

        //Act
        var resultado = cliente.Validacao();

        //Assert
        Assert.False(resultado);
    }


    [Fact]
    public void Verificar_Idade_Igual_18()
    {
        //Arrange
        var cliente = new Cliente
        {
            Nome = "Mariana",
            Email = "mariana@gmail.com",
            Idade = 18,
            Ativo = true
        };

        //Act
        var resultado = cliente.Validacao();

        //Assert
        Assert.True(resultado);
    }

    [Fact]
    public void Verificar_Cliente_Invalido()
    {
        //Arrange
        var cliente = new Cliente
        {
            Nome = "Gabriela",
            Email = "gabriela@gmail,com",
            Idade = 19,
            Ativo = false
        };

        //Act
        var resultado = cliente.Validacao();

        //Assert
        Assert.False(resultado);
    }

    [Fact]
    public void Verificar_Cliente_Apto_para_Compra()
    {
        //Arrange
        var cliente = new Cliente
        {
            Nome = "Victor",
            Email = "victor@gmail.com",
            Idade = 25,  
            Ativo = true
        };

        //Act
        var resultado = cliente.Permissao();

        //Assert
        Assert.True(resultado);
    }
}