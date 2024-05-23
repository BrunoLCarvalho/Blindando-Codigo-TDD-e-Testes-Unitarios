using NewTalents_Bruno;

namespace NewTalents_BrunoTest
{
    public class UnitTest1
    {
        public Calculadora ContruirClasse()
        {
            string data = "22/05/2024";
            Calculadora calc = new Calculadora("22/05/2024");
            
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = ContruirClasse();

            int resultadoCalculadora = calc.Somar(num1, num2);
            
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(6, 1, 5)]
        public void TestSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = ContruirClasse();

            int resultadoCalculadora = calc.Subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(4, 2, 8)]
        [InlineData(3, 5, 15)]
        public void TestMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = ContruirClasse();

            int resultadoCalculadora = calc.Multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(4, 2, 2)]
        public void TestDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = ContruirClasse();

            int resultadoCalculadora = calc.Dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ContruirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }
    }
}
