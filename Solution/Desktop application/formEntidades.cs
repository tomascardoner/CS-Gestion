using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class formEntidades : Form
    {

        #region Declarations

        private List<Entidad> listEntidades;
        private List<Entidad> listEntidadesFiltradaYOrdenada;

        private bool skipFilterData = false;
        private bool busquedaAplicada = false;

        private DataGridViewColumn ordenColumna;
        private SortOrder ordenTipo;

        #endregion

        #region Form stuff

        public formEntidades()
        {
            InitializeComponent();

            SetAppearance();

            skipFilterData = true;

            // Program.FillAndRefreshLists.Cuartel(comboboxCuartel.ComboBox, True, False)
            // Program.FillAndRefreshLists.PersonaEstadoActual(comboboxEstadoActual.ComboBox, True)

            skipFilterData = false;

            ordenColumna = columnRazonSocial;
            ordenTipo = SortOrder.Ascending;

            // RefreshData();
        }

        private void SetAppearance()
        {
            Appearance.DataGrid(datagridviewMain);
        }

        #endregion

    }
}
