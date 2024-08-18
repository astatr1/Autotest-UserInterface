namespace UserInterface.Integration.Utils
{
    public static class ValueFormatter
    {
        public static string RemoveMeasure(string value, string measure)
        {
            try
            {
                return value.Replace(measure, string.Empty);
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
