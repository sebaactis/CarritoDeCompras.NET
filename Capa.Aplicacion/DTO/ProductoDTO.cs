﻿using System.ComponentModel.DataAnnotations;

namespace Capa.Aplicacion.DTO
{
    public class ProductoDTO
    {
        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "El nombre del producto debe tener minimo 4 caracteres y maximo 25 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripcion del producto es obligatoria.")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "La descripcion del producto debe tener minimo 10 caracteres y maximo 100 caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El precio debe ser minimo 1")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El stock es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El stock debe ser minimo 1")]
        public int Stock { get; set; }
        public CategoriaDTO Categoria { get; set; }
    }
}
