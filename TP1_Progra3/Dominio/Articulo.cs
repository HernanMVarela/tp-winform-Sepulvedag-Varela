﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public string Codigo
        { get; set; }
        public string Nombre
        { get; set; }
        public string Descripcion
        { get; set; }
        public Marca NomMarca
        { get; set; }
        public Categoria NomCategoria
        { get; set; }
        public string ImagenURL
        { get; set; }
        public float Precio
        { get; set; }
    }
}
