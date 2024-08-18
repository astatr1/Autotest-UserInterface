using System.Globalization;

namespace UserInterface.Integration.Utils
{
    public static class ValueParser
    {
        public static double ParseDoubleCulture(string value)
        {
            try
            {
                return double.Parse(value, CultureInfo.InvariantCulture);
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException(nameof(value), "Полученная строка не может быть пустой");
            }
            catch (FormatException)
            {
                throw new ArgumentException("Полученная строка имеет неверный формат", nameof(value));
            }
            catch (OverflowException)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    "Полученная строка представляет собой слишком большое или слишком маленькое число");
            }
        }
    }
}
