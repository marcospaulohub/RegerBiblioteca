using System.Globalization;
using System.Resources;

namespace RegerBiblioteca.Core.Messages
{
    public static class BaseMsgs
    {
        private const string language = "BR";

        public static string GetLanguage()
        {
            return language;
        }

        public static string GetResource(string key, string FileNameResx)
        {
            var rm = new ResourceManager(FileNameResx, typeof(BaseMsgs).Assembly);

            var text = rm.GetString(key, CultureInfo.CurrentCulture);

            if (text != null)
                return text;
            else
                return "null";
        }
    }
}
