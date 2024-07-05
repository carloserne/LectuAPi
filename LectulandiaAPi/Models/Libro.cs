using System;
using System.Collections.Generic;

namespace LectulandiaAPi.Models;

public partial class Libro
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Precio { get; set; }

    public string Imagen { get; set; } = null!;

    public string Categoria { get; set; } = null!;
}
