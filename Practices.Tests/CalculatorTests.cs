namespace Practices.Tests
{
    /// <summary>
    /// �������� ����� ��� �������� ���������������� ������ Calculator.
    /// </summary>
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        /// <summary>
        /// ��������� ����� Additional ������ Calculator �� ������������ �������� �����.
        /// </summary>
        [TestCase(5, 3, 8)]
        [TestCase(-5, 3, -2)]
        [TestCase(0, 0, 0)]
        public void Additional_MustReturnsCorrectResult(int a, int b, int expected)
        {
            int result = _calculator.Additional(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        /// <summary>
        /// ��������� ����� Subtraction ������ Calculator �� ������������ ��������� �����.
        /// </summary>
        [TestCase(10, 4, 6)]
        [TestCase(-5, -3, -2)]
        [TestCase(0, 0, 0)]
        public void Subtraction_MustReturnsCorrectResult(int a, int b, int expected)
        {
            int result = _calculator.Subtraction(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        /// <summary>
        /// ��������� ����� Miltiplication ������ Calculator �� ������������ ��������� �����.
        /// </summary>
        [TestCase(6, 7, 42)]
        [TestCase(-6, 7, -42)]
        [TestCase(0, 5, 0)]
        public void Miltiplication_MustReturnsCorrectResult(int a, int b, int expected)
        {
            int result = _calculator.Miltiplication(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        /// <summary>
        /// ��������� ����� Division ������ Calculator �� ������������ ������� �����,
        /// ������� �������� �������������� �������.
        /// </summary>
        [TestCase(20, 5, 4)]
        [TestCase(-20, 5, -4)]
        [TestCase(0, 5, 0)]
        [TestCase(7, 2, 3)] // �������� �������������� �������
        public void Division_MustReturnsCorrectResult(int a, int b, int expected)
        {
            int result = _calculator.Division(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        /// <summary>
        /// ���������, ��� ����� Division ����������� ���������� DivideByZeroException
        /// ��� ������� ������� �� ����.
        /// </summary>
        [Test]
        public void Division_WhenDividingByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Division(10, 0));
        }

        /// <summary>
        /// ���������, ��� ����� Additional ����������� ���������� OverflowException
        /// ��� ������������ ���������� ��������.
        /// </summary>
        [Test]
        public void Additional_WhenResultOverflows_ThrowsOverflowException()
        {
            Assert.Throws<OverflowException>(() => _calculator.Additional(int.MaxValue, 1));
        }

        /// <summary>
        /// ���������, ��� ����� Subtraction ����������� ���������� OverflowException
        /// ��� ������������ ���������� ��������� � ������������� �������.
        /// </summary>
        [Test]
        public void Subtraction_WhenResultUnderflows_ThrowsOverflowException()
        {
            Assert.Throws<OverflowException>(() => _calculator.Subtraction(int.MinValue, 1));
        }

        /// <summary>
        /// ���������, ��� ����� Miltiplication ����������� ���������� OverflowException
        /// ��� ������������ ���������� ���������.
        /// </summary>
        [Test]
        public void Miltiplication_WhenResultOverflows_ThrowsOverflowException()
        {
            Assert.Throws<OverflowException>(() => _calculator.Miltiplication(int.MaxValue, 2));
        }
    }
}