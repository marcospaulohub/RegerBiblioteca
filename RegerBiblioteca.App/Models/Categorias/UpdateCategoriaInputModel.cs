﻿using RegerBiblioteca.Core.Enums;

namespace RegerBiblioteca.App.Models.Categorias
{
    public class UpdateCategoriaInputModel
    {
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public Genero Genero { get; set; }
        public bool Ativo { get; set; }
    }
}
