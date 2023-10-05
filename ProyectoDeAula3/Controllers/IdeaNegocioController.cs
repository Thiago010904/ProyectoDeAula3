using System;
using System.Collections.Generic;
using System.Web.Mvc;

public class IdeaNegocioController : Controller
{
    private static List<IdeaNegocioModel> ideasDeNegocio = new List<IdeaNegocioModel>();

    [HttpPost]
    public ActionResult ProcesarFormulario(IdeaNegocioModel ideaNegocio)
    {
        // Aquí puedes acceder a los datos recibidos de la idea de negocio
        // Por ejemplo:
        string nombreIdea = ideaNegocio.Nombre;
        string impactoSocial = ideaNegocio.ImpactoSocial;
        double inversion = ideaNegocio.Inversion;
        double ingresos = ideaNegocio.Ingresos;
        string herramientas4RI = ideaNegocio.Herramientas4RI;
        List<Departamento> departamentos = ideaNegocio.Departamentos;
        List<IntegrantesEquipo> integrantes = ideaNegocio.Equipos;

        // Procesar los datos y realizar acciones necesarias...
        // Por ejemplo, almacenarlos en una base de datos

        ideasDeNegocio.Add(ideaNegocio);

        // Redireccionar a una página de confirmación u otra acción
        return RedirectToAction("AccionConfirmacion");
    }

    public ActionResult AccionConfirmacion()
    {
        // Acción de confirmación después de procesar los datos
        return View();
    }
}
