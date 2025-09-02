namespace RegerBiblioteca.Core.Messages.AutorMessages
{
    public static class AutorMsgs
    {
        private const string fileNameResx = "RegerBiblioteca.Core.Messages.AutorMessages.AutorMsgsResource";

        public static string GetNomeNotEmpty()
        {
            return BaseMsgs.GetResource("NomeNotEmpty", fileNameResx);
        }

        public static string GetNomeMaxLength()
        {
            return BaseMsgs.GetResource("NomeMaxLength", fileNameResx);
        }
        
        public static string GetNacionalidadeMaxLength()
        {
            return BaseMsgs.GetResource("NacionalidadeMaxLength", fileNameResx);
        }

        public static string GetNascimentoInvalid()
        {
            return BaseMsgs.GetResource("NascimentoInvalid", fileNameResx);
        }

        public static string GetFotoUrlMaxLength()
        {
            return BaseMsgs.GetResource("FotoUrlMaxLength", fileNameResx);
        }

        public static string GetSiteUrlMaxLength()
        {
            return BaseMsgs.GetResource("SiteUrlMaxLength", fileNameResx);
        }
    }
}
