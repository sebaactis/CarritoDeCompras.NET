﻿using System.ComponentModel.DataAnnotations;

namespace Capa.Aplicacion.DTI
{
    public class CategoriaDTI
    {
        [Required(ErrorMessage = "El nombre de la categoría es obligatorio.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El nombre de la categoria debe tener minimo 3 caracteres y maximo 20 caracteres.")]
        public string NombreCategoria { get; set; }
    }
}
