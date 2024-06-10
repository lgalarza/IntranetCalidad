namespace IntranetCalidad.Shared.Constants
{
    public class EndPoints
    {
        #region EndPoints Seguridad
        public static string validarUsuario = "Seguridad/ValidarUsuarioWeb";
        public static string obtieneMenuUsuario = "Seguridad/ObtieneMenuWeb";
        public static string verificarPermisos = "Seguridad/MantenimientoObtienePermiso";
        #endregion

        #region EndPoints Mantenimientos
        public static string obtenerTipoCacao = "Configuracion/MantenimientoObtenerTipoCacao";
        public static string grabarTipoCacao = "Configuracion/MantenimientoGrabarTipoCacao";
        public static string listarTipoCacao = "Configuracion/ObtenerTipoCacao";
        public static string obtenerGrupos = "Configuracion/MantenimientoObtenerGrupo";
        public static string grabarGrupos = "Configuracion/MantenimientoGrabarGrupo";
        public static string listarGrupos= "Configuracion/ObtenerGrupo";
        public static string obtenerProgramas = "Configuracion/MantenimientoObtenerGrupoVendorFactura";
        public static string grabarProgramas = "Configuracion/MantenimientoMantenimientoGrabarVendorFactura";
        public static string listarProgramas = "Configuracion/ObtenerProgramas";
        public static string obtenerCertificaciones = "Configuracion/MantenimientoObtenerCertificaciones";
        public static string grabarCertificaciones = "Configuracion/MantenimientoGrabarCertificaciones";
        public static string listarCertificaciones = "Configuracion/ObtenerCertificaciones";
        public static string obtenerPronosticoCosecha = "Configuracion/MantenimientoObtenerPronosticoCosecha";
        public static string grabarPronosticoCosecha = "Configuracion/MantenimientoGrabarPronosticoCosecha";


        #endregion


        #region EndPoints Store Check
        public static string obtenerNovedades = "Mantenimiento/MantenimientoObtenerNovedades";
        public static string grabarNovedades = "Mantenimiento/MantenimientoGrabarNovedades";
        public static string listarNovedades = "Mantenimiento/ObtenerNovedades";
        public static string obtenerSecciones = "Mantenimiento/MantenimientoObtenerSecciones";
        public static string grabarSecciones = "Mantenimiento/MantenimientoGrabarSecciones";
        public static string listarSecciones = "Mantenimiento/ObtenerSecciones";
        public static string obtenerPreguntas = "Mantenimiento/MantenimientoObtenerPreguntas";
        public static string grabarPreguntas = "Mantenimiento/MantenimientoGrabarPreguntas";
        public static string cargarPreguntasSeccion = "Mantenimiento/ObtenerPreguntas";
        //public static string grabarCuestionario = "StoreCheck/LlenarFormulario";
        //public static string obtenerCuestionarioIngresado = "StoreCheck/ConsultarFormularioIngresado";
        //public static string obtieneZonasPorSupervisor = "StoreCheck/ObtieneZonasPorSupervisor";
        //public static string consultarFormulariosporPOS = "StoreCheck/ConsultarFormulariosporPOS";
        //public static string ConsultarFormulariosRevisadosporPOS = "StoreCheck/ConsultarFormulariosRevisadosporPOS";
        //public static string consultarFormularioIngresado = "StoreCheck/ConsultarFormularioIngresado";
        //public static string obtenerResumenGerencialZonas = "StoreCheck/ObtieneResumenGerencialZonas";
        //public static string consultarFormularioConNovedades = "StoreCheck/ConsultarFormularioConNovedades";

        #endregion
    }
}
