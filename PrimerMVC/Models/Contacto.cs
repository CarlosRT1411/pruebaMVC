using System;
using System.Collections.Generic;

namespace PrimerMVC.Models;

public partial class Contacto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Telefono { get; set; } = null!;
}
