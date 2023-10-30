using NewTalents;

namespace NewTalentsTestes
{
    public class NewTalentsTestes
    {
        public Calculadora ConstruirClasse()
        {
            string data = "30/10/2023";
            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData(11, 22, 33)]
        [InlineData(15, 15, 30)]
        public void TestarSomar(int val1, int val2, int resultado)
        {
            //Arrange
            Calculadora calc = ConstruirClasse();

            //Act
            int resultadoCalculadora = calc.somar(val1, val2);

            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(33, 10, 23)]
        [InlineData(25,20, 5)]
        public void TestarSubtrair(int val1, int val2, int resultado)
        {
            //Arrange
            Calculadora calc = ConstruirClasse();

            //Act
            int resultadoCalculadora = calc.subtrair(val1, val2);

            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(10, 20, 200)]
        [InlineData(3, 10, 30)]
        public void TestarMultiplicar(int val1, int val2, int resultado)
        {
            //Arrange
            Calculadora calc = ConstruirClasse();

            //Act
            int resultadoCalculadora = calc.multiplicar(val1, val2);

            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(48, 6, 8)]
        [InlineData(80, 10, 8)]
        public void TestarDividir(int val1, int val2, double resultado)
        {
            //Arrange
            Calculadora calc = ConstruirClasse();

            //Act
            int resultadoCalculadora = calc.dividir(val1, val2);

            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            //Arrange
            Calculadora calc = ConstruirClasse();

            //Act
            //Assert
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }


        [Fact]
        public void TestarHistorico()
        {
            //Arrange
            Calculadora calc = ConstruirClasse();

            //Act

            calc.somar(10, 25);
            calc.somar(39, 48);
            calc.somar(58, 61);
            calc.somar(74, 84);

            var lista = calc.historico();
            //Assert

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}