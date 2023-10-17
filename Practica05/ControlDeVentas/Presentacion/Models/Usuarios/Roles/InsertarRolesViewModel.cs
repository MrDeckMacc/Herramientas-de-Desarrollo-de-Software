﻿using System.ComponentModel.DataAnnotations;

namespace Presentacion.Models.Usuarios.Roles
{
    public class InsertarRolesViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre no debe de tener menos de 3 caracteres, ni más de 100")]
        public string NombreRol { get; set; } = string.Empty;
        [Required]
        [StringLength(250)]
        public string DescripcionRol { get; set; } = string.Empty;
        public bool Estado { get; set; }
    }
}
