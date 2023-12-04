using MetodoDeExtensao;

namespace TestesUnitarios;

public class TesteDeExtensaoData
{
    [Fact]
    public void TesteDaExtesao()
    {
        //Arrange
        var data = new DateTime(1959, 01, 01);

        //Act
        var dataConvertida = data.DateToInt();

        //Assert
        Assert.Equal(195901, dataConvertida);
    }
}
