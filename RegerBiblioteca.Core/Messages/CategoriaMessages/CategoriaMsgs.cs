namespace RegerBiblioteca.Core.Messages.CategoriaMessages
{
    public static class CategoriaMsgs
    {
        private const string fileNameResx = "RegerBiblioteca.Core.Messages.CategoriaMessages.CategoriaMsgsResource";

        public static string GetNomeNotEmpty()
        {
            return BaseMsgs.GetResource("NomeNotEmpty", fileNameResx);
        }

        public static string GetNomeMaxLength()
        {
            return BaseMsgs.GetResource("NomeMaxLength", fileNameResx);
        }

        public static string GetDescricaoMaxLength()
        {
            return BaseMsgs.GetResource("DescricaoMaxLength", fileNameResx);
        }

        public static string GetGeneroInvalid()
        {
            return BaseMsgs.GetResource("GeneroInvalid", fileNameResx);
        }

        public static string GetAtivoNotNull()
        {
            return BaseMsgs.GetResource("AtivoNotNull", fileNameResx);
        }

        public static string GetAtivoInvalid()
        {
            return BaseMsgs.GetResource("AtivoInvalid", fileNameResx);
        }
    }
}
