using System.Runtime.CompilerServices;
using Calculadora.Services;// fazer o import

namespace calculadoratestes;

public class CalculadoraTestes//PARA CADA CLASSE UM TESTE
{// é praticamente um método

    private CalculadoraImp _calc; 
    public CalculadoraTestes(){ 
        _calc=new CalculadoraImp();
    }
    [Fact]//este método aqui é um cenário de teste e deve ser válidado de acordo
    public void DeveSomar5com10eRetornar15()//descritivo e com detalhes oq está testando
    {        
        //arrange: montar o cenário;  
        int num1 = 5;
        int num2 = 10;
        //Act :vamo chamar para o que tem que fazer; 
        int resultado = _calc.Somar(num1,num2);
        //assert : VALIDAR se tudo isso tem o resultado esperado;
        Assert.Equal(15,resultado); 
        //primeiro parametro: resultadoEsperado
        //tenho que estar dentro da pasta de test
        //DOTNET TEST
    } 

    [Fact]//este método aqui é um cenário de teste e deve ser válidado de acordo
    public void DeveSomar10com10eRetornar20()//descritivo e com detalhes oq está testando
    {        
        //arrange: montar o cenário;  
        int num1 = 10;
        int num2 = 10;
        //Act :vamo chamar para o que tem que fazer; 
        int resultado = _calc.Somar(num1,num2);
        //assert : VALIDAR se tudo isso tem o resultado esperado;
        Assert.Equal(20,resultado); 
        //primeiro parametro: resultadoEsperado
        //tenho que estar dentro da pasta de test
        //DOTNET TEST
    }
    [Fact] 
    public void DeveVerificarSe4ehParERetornarVerdadeiro(){ 
        //arrange 
        int num =4; 
        //act 
        bool resultado = _calc.EhPar(num); 
        //assert 
        Assert.True(resultado);
    }

    //THEORY 
    [Theory] //conjunto de cenários que vão passar pelo mesmo teste
    [InlineData(2)] 
    [InlineData(4)] 
    [InlineData(6)] 
    [InlineData(8)] 
    [InlineData(10)]
    public void VerificarSeParReturnTRUE(int num) { 
        //ACT 
        bool resultado = _calc.EhPar(num);
        //ASSERT
        Assert.True(resultado);
    } 

    [Theory] //conjunto de cenários que vão passar pelo mesmo teste
    [InlineData(new int[]{4,6,8,10})]
    public void VerificarSeParReturntRUE(int []numeros) { 
        //ACT /ASSERT
        /* foreach(var item in numeros) { 
            Assert.True(_calc.EhPar(item));
        } */ 
        Assert.All(numeros,num =>Assert.True(_calc.EhPar(num)));
    }

}