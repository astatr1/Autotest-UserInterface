using System.Text;

namespace UserInterface.Integration.Utils
{
    public static class RandomUtility
    {
        private readonly static Random random = new();
        private const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LowerCase = "abcdefghijklmnopqrstuvwxyz";
        private const string Cyrillic = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private const string Digits = "0123456789";

        public static string RandomString(int length, string chars)
        {
            return new string(Enumerable.Repeat(chars, length)
                .Select(randomString => randomString[random.Next(randomString.Length)]).ToArray());
        }

        public static K[] RandomDictionaryKey<K,V>(Dictionary<K, V> dictionary, int countKey)
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            if (countKey > dictionary.Count)
            {
                throw new ArgumentException("Количество выбираемых ключей превышает количество ключей в словаре.");
            }

            return dictionary.Keys.OrderBy(key => random.Next()).Take(countKey).ToArray();
        }

        public static void GeneratorRandomEmailAndPass(int passwordLength, int nameEmailLength, int domainNameLength, string[] topLevelDomain,
            out string password, out string nameEmail, out string domainName, out string domain)
        {
            domain = topLevelDomain[random.Next(topLevelDomain.Length)];
            nameEmail = RandomUtility.RandomString(nameEmailLength, LowerCase);
            domainName = RandomUtility.RandomString(domainNameLength, LowerCase);

            var email = $"{nameEmail}@{domainName}{domain}";
            password = GenerateRandomPassword(email, passwordLength);
        }

        private static string GenerateRandomPassword(string email, int passwordLength)
        {
            var password = new StringBuilder();
            password.Append(UpperCase[random.Next(UpperCase.Length)]);
            password.Append(Digits[random.Next(Digits.Length)]);
            password.Append(email[random.Next(email.Length)]);
            password.Append(Cyrillic[random.Next(Cyrillic.Length)]);

            var allChars = UpperCase + LowerCase + Digits + Cyrillic;

            while (password.Length < passwordLength)
            {
                password.Append(allChars[random.Next(allChars.Length)]);
            }

            return new string(password.ToString().OrderBy(c => random.Next()).ToArray());
        }
    }
}
