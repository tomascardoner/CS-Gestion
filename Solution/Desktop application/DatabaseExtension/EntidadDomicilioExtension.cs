using System.Linq;

namespace CS_Gestion
{
    public partial class EntidadDomicilio
    {
        private const string RutaPrefijo = "RUTA ";
        private const string RutaLeyendaKilometro = " Km. ";

        private const string CallePrefijo = "CALLE ";
        private const string CalleLeyendaNumero = " Nº ";

        private const string PisoPrefijo = " P.";
        private const string PisoSufijo = "º";

        private const string DepartamentoPrefijo = " Dto. \"";
        private const string DepartamentoSufijo = "\"";

        private const string Calles2Separador = " esq. ";

        private const string Calles3PrimerSeparador = " entre ";
        private const string Calles3SegundoSeparador = " y ";

        internal string DomicilioParaMostrarLocal
        {
            get
            {
                string domicilioCompleto;

                domicilioCompleto = Calle1;
                if (Calle1 != null)
                {
                    if (Numero != null)
                    {
                        if (Numero.TrimStart().ToUpper().StartsWith(RutaPrefijo))
                        {
                            domicilioCompleto += RutaLeyendaKilometro + Numero;
                        }
                        else if (Numero.TrimStart().ToUpper().StartsWith(CallePrefijo))
                        {
                            domicilioCompleto += CalleLeyendaNumero + Numero;
                        }
                        else
                        {
                            domicilioCompleto += " " + Numero;
                        }
                    }

                    if (Piso != null)
                    {
                        if (Piso.All(char.IsNumber))
                        {
                            domicilioCompleto += PisoPrefijo + Piso + PisoSufijo;
                        }
                        else
                        {
                            domicilioCompleto += " " + Piso;
                        }
                    }

                    if (Departamento != null)
                    {
                        domicilioCompleto += DepartamentoPrefijo + Departamento + DepartamentoSufijo;
                    }

                    if (Calle2 != null)
                    {
                        if (Calle3 != null)
                        {
                            domicilioCompleto += Calles3PrimerSeparador + Calle2 + Calles3SegundoSeparador + Calle3;
                        }
                        else
                        {
                            domicilioCompleto += Calles2Separador + Calle2;
                        }
                    }
                }

                return domicilioCompleto;
            }
        }
    }
}
