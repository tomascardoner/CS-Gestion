using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace CS_Gestion
{
    static public class Parametros
    {
        // Appearance
        internal const string AppearanceGridFont = "AppearanceGridFont";

        // Aplicación
        public const string ApplicationDatabaseGuid = "ApplicationDatabaseGuid";
        public const string LicenseCompanyName = "LicenseCompanyName";
        public const string UserPasswordMinimumLenght = "UserPasswordMinimumLenght";
        public const string UserPasswordSecureRequired = "UserPasswordSecureRequired";
        public const string EmailValidationRegularExpression = "EmailValidationRegularExpression";

        // Valores predeterminados
        public const string DefaultProvinciaId = "DefaultProvinciaId";
        public const string DefaultLocalidadId = "DefaultLocalidadId";
        public const string DefaultCodigoPostal = "DefaultCodigoPostal";
        public const string DefaultCategoriaIvaId = "DefaultCategoriaIvaId";
        public const string DefaultMonedaId = "DefaultMonedaId";
        public const string DefaultDocumentoTipoId = "DefaultDocumentoTipoId";

        // Varios
        public const string ComprobanteEntidadMayusculas = "ComprobanteEntidadMayusculas";
        public const string ConsumidorFinalDocumentoTipoId = "ConsumidorFinalDocumentoTipoId";
        public const string ConsumidorFinalDocumentoNumero = "ConsumidorFinalDocumentoNumero";

        // AFIP Web Services
        public const string AfipWSAAHomologacion = "AfipWSAAHomologacion";
        public const string AfipWSAAProduccion = "AfipWSAAProduccion";
        public const string AfipWSFEHomologacion = "AfipWSFEHomologacion";
        public const string AfipWSFEProduccion = "AfipWSFEProduccion";

        // Empresa
        public const string EmpresaCuit = "EmpresaCuit";
        public const string EmpresaRazonSocial = "EmpresaRazonSocial";
        public const string EmpresaDomicilioFiscalDireccion = "EmpresaDomicilioFiscalDireccion";
        public const string EmpresaDomicilioFiscalCodigoPostal = "EmpresaDomicilioFiscalCodigoPostal";
        public const string EmpresaDomicilioFiscalLocalidadId = "EmpresaDomicilioFiscalLocalidadId";
        public const string EmpresaDomicilioFiscalProvinciaId = "EmpresaDomicilioFiscalProvinciaId";
        public const string EmpresaCategoriaIvaId = "EmpresaCategoriaIvaId";
        public const string EmpresaIibbNumero = "EmpresaIibbNumero";
        public const string EmpresaInicioActividad = "EmpresaInicioActividad";

        static public bool CargarTodos()
        {
            try
            {
                using (CSGestionContext dbContext = new CSGestionContext(true))
                {
                    Program.Parametros = dbContext.Parametro.ToList();
                }
                return true;
            }
            catch (System.Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ex, "Error al conectarse a la base de datos.");
                return false;
            }
        }

        static public string GetString(string idParametro, string defaultValue = null)
        {
            Parametro parametro;

            parametro = Program.Parametros.Find(param => param.IdParametro.TrimEnd() == idParametro);
            if (parametro == null || parametro.Texto == null)
            {
                return defaultValue;
            }
            else
            {
                return parametro.Texto.Trim();
            }
        }

        static public Font GetStringAsFont(string idParametro, string defaultValue = null)
        {
            Parametro parametro;
            string fontString;

            parametro = Program.Parametros.Find(param => param.IdParametro.TrimEnd() == idParametro);
            if (parametro == null || parametro.Texto == null)
            {
                fontString = defaultValue;
            }
            else
            {
                fontString = parametro.Texto;
            }

            try
            {
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
                Font font = (Font)converter.ConvertFromString(parametro.Texto);
                return font;
            }
            catch (Exception)
            {
                return null;
            }
        }

        static public byte GetIntegerAsByte(string idParametro, byte defaultValue = 0)
        {
            Parametro parametro;

            parametro = Program.Parametros.Find(param => param.IdParametro.TrimEnd() == idParametro);
            if (parametro == null || parametro.NumeroEntero == null)
            {
                return defaultValue;
            }
            else
            {
                return (byte)parametro.NumeroEntero.Value;
            }
        }

        static public short GetIntegerAsShort(string idParametro, short defaultValue = 0)
        {
            Parametro parametro;

            parametro = Program.Parametros.Find(param => param.IdParametro.TrimEnd() == idParametro);
            if (parametro == null || parametro.NumeroEntero == null)
            {
                return defaultValue;
            }
            else
            {
                return (short)parametro.NumeroEntero.Value;
            }
        }

        static public int GetIntegerAsInteger(string idParametro, int defaultValue = 0)
        {
            Parametro parametro;

            parametro = Program.Parametros.Find(param => param.IdParametro.TrimEnd() == idParametro);
            if (parametro == null || parametro.NumeroEntero == null)
            {
                return defaultValue;
            }
            else
            {
                return parametro.NumeroEntero.Value;
            }
        }

        static public decimal GetDecimal(string idParametro, decimal defaultValue = 0)
        {
            Parametro parametro;

            parametro = Program.Parametros.Find(param => param.IdParametro.TrimEnd() == idParametro);
            if (parametro == null || parametro.NumeroDecimal == null)
            {
                return defaultValue;
            }
            else
            {
                return parametro.NumeroDecimal.Value;
            }
        }

        static public DateTime GetDate(string idParametro, DateTime defaultValue)
        {
            Parametro parametro;

            parametro = Program.Parametros.Find(param => param.IdParametro.TrimEnd() == idParametro);
            if (parametro == null || parametro.FechaHora == null)
            {
                return defaultValue;
            }
            else
            {
                return parametro.FechaHora.Value;
            }
        }

        static public bool GetBoolean(string idParametro, bool defaultValue = false)
        {
            Parametro parametro;

            parametro = Program.Parametros.Find(param => param.IdParametro.TrimEnd() == idParametro);
            if (parametro == null || parametro.SiNo == null)
            {
                return defaultValue;
            }
            else
            {
                return parametro.SiNo.Value;
            }
        }
    }
}