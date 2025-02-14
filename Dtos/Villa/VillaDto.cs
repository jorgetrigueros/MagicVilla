﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Dtos.Villa
{
    public class VillaDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; } = string.Empty;
        public string Detalle { get; set; }
        [Required]
        public Double Tarifa { get; set; }
        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
        public string ImagenUrl { get; set; }
        public string Amenidad { get; set; }
    }
}
