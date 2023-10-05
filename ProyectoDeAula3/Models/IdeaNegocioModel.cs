using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class IdeaNegocioModel
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public string ImpactoSocial { get; set; }
    public List<Departamento> Departamentos { get; set; } = new List<Departamento>();
    public double Inversion { get; set; }
    public double Ingresos { get; set; }
    public List<IntegrantesEquipo> Equipos { get; set; } = new List<IntegrantesEquipo>();
    public string Herramientas4RI { get; set; }
}

public class Departamento
{
    public int Codigo { get; set; }
    public String Nombre { get; set; }
}

public class IntegrantesEquipo
{
    public String Identificacion { get; set; }
    public String Nombre { get; set; }
    public String Apellidos { get; set; }
    public String Rol { get; set; }
    public String Email { get; set; }

}