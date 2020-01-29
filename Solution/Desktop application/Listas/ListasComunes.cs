using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CS_Gestion
{
    static class ListasComunes
    {
        static internal void EsActivo(ComboBox comboBox, int selectElementNumber = -1)
        {
            comboBox.Items.AddRange(new string[]{Properties.Resources.StringItemAllMale, Properties.Resources.StringYes, Properties.Resources.StringNo});
            if (selectElementNumber > -1)
            {
                comboBox.SelectedIndex = selectElementNumber;
            }
        }

        static internal void DomicilioTipo(ComboBox comboBox, CSGestionContext context, bool mostrarNoEspecifica)
        {
            comboBox.ValueMember = "IdDomicilioTipo";
            comboBox.DisplayMember = "Nombre";

            List<DomicilioTipo> domiciliotipos = context.DomicilioTipo.OrderBy(dt => dt.Nombre).ToList();

            if (mostrarNoEspecifica)
            {
                DomicilioTipo noespecifica = new DomicilioTipo();
                noespecifica.IdDomicilioTipo = CardonerSistemas.Constants.ByteFieldValueNotSpecified;
                noespecifica.Nombre = Properties.Resources.StringItemNotSpecified;
                domiciliotipos.Insert(0, noespecifica);
            }

            comboBox.DataSource = domiciliotipos;
            domiciliotipos = null;
        }

        static internal void EmailTipo(ComboBox comboBox, CSGestionContext context, bool mostrarNoEspecifica)
        {
            comboBox.ValueMember = "IdEmailTipo";
            comboBox.DisplayMember = "Nombre";

            List<EmailTipo> Emailtipos = context.EmailTipo.OrderBy(dt => dt.Nombre).ToList();

            if (mostrarNoEspecifica)
            {
                EmailTipo noespecifica = new EmailTipo();
                noespecifica.IdEmailTipo = CardonerSistemas.Constants.ByteFieldValueNotSpecified;
                noespecifica.Nombre = Properties.Resources.StringItemNotSpecified;
                Emailtipos.Insert(0, noespecifica);
            }

            comboBox.DataSource = Emailtipos;
            Emailtipos = null;
        }

        static internal void TelefonoTipo(ComboBox comboBox, CSGestionContext context, bool mostrarNoEspecifica)
        {
            comboBox.ValueMember = "IdTelefonoTipo";
            comboBox.DisplayMember = "Nombre";

            List<TelefonoTipo> Telefonotipos = context.TelefonoTipo.OrderBy(dt => dt.Nombre).ToList();

            if (mostrarNoEspecifica)
            {
                TelefonoTipo noespecifica = new TelefonoTipo();
                noespecifica.IdTelefonoTipo = CardonerSistemas.Constants.ByteFieldValueNotSpecified;
                noespecifica.Nombre = Properties.Resources.StringItemNotSpecified;
                Telefonotipos.Insert(0, noespecifica);
            }

            comboBox.DataSource = Telefonotipos;
            Telefonotipos = null;
        }

        static internal void Banco(ComboBox comboBox, CSGestionContext context, bool mostrarNoEspecifica)
        {
            comboBox.ValueMember = "IdBanco";
            comboBox.DisplayMember = "Nombre";

            List<Banco> Bancos = context.Banco.OrderBy(dt => dt.Nombre).ToList();

            if (mostrarNoEspecifica)
            {
                Banco noespecifica = new Banco();
                noespecifica.IdBanco = CardonerSistemas.Constants.ByteFieldValueNotSpecified;
                noespecifica.Nombre = Properties.Resources.StringItemNotSpecified;
                Bancos.Insert(0, noespecifica);
            }

            comboBox.DataSource = Bancos;
            Bancos = null;
        }

        static internal void CuentaBancariaTipo(ComboBox comboBox, CSGestionContext context, bool mostrarNoEspecifica)
        {
            comboBox.ValueMember = "IdCuentaBancariaTipo";
            comboBox.DisplayMember = "Nombre";

            List<CuentaBancariaTipo> CuentaBancariatipos = context.CuentaBancariaTipo.OrderBy(dt => dt.Nombre).ToList();

            if (mostrarNoEspecifica)
            {
                CuentaBancariaTipo noespecifica = new CuentaBancariaTipo();
                noespecifica.IdCuentaBancariaTipo = CardonerSistemas.Constants.ByteFieldValueNotSpecified;
                noespecifica.Nombre = Properties.Resources.StringItemNotSpecified;
                CuentaBancariatipos.Insert(0, noespecifica);
            }

            comboBox.DataSource = CuentaBancariatipos;
            CuentaBancariatipos = null;
        }

        static internal void Provincia(ComboBox comboBox, CSGestionContext context, bool mostrarNoEspecifica)
        {
            comboBox.ValueMember = "IdProvincia";
            comboBox.DisplayMember = "Nombre";

            List<Provincia> provincias = context.Provincia.OrderBy(p => p.Nombre).ToList();

            if (mostrarNoEspecifica)
            {
                Provincia noespecifica = new Provincia();
                noespecifica.IdProvincia = CardonerSistemas.Constants.ByteFieldValueNotSpecified;
                noespecifica.Nombre = Properties.Resources.StringItemNotSpecified;
                provincias.Insert(0, noespecifica);
            }

            comboBox.DataSource = provincias;
            provincias = null;
        }

        static internal void Localidad(ComboBox comboBox, CSGestionContext context, byte idProvincia, bool mostrarNoEspecifica)
        {
            comboBox.ValueMember = "IdLocalidad";
            comboBox.DisplayMember = "Nombre";

            List<Localidad> localidades = context.Localidad.Where(p => p.IdProvincia == idProvincia).OrderBy(p => p.Nombre).ToList();

            if (mostrarNoEspecifica)
            {
                Localidad noespecifica = new Localidad();
                noespecifica.IdLocalidad = CardonerSistemas.Constants.ShortFieldValueNotSpecified;
                noespecifica.Nombre = Properties.Resources.StringItemNotSpecified;
                localidades.Insert(0, noespecifica);
            }

            comboBox.DataSource = localidades;
            localidades = null;
        }
    }
}
