using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormEntidades : Form
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

        public FormEntidades()
        {
            InitializeComponent();

            SetAppearance();

            skipFilterData = true;

            ListasComunes.EsActivo(comboboxActivo.ComboBox, 1);

            skipFilterData = false;

            ordenColumna = columnNombreParaMostrar;
            ordenTipo = SortOrder.Ascending;

            RefreshData();
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(Properties.Resources.ImageEntidad16);

            Program.Appearance.DataGrid(datagridviewMain);
        }

        private void this_FormClosed(object sender, FormClosedEventArgs e)
        {
            listEntidades = null;
            listEntidadesFiltradaYOrdenada = null;
        }

        #endregion

        #region Load and Set Data

        internal void RefreshData(int positionIdEntidad = 0, bool restorePosition = false)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                using (CSGestionContext context = new CSGestionContext(true))
                {
                    listEntidades = context.Entidad.ToList();
                }
            }
            catch (System.Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ex, "Error al leer las Entidades.");
                return;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

            if (restorePosition)
            {
                if (datagridviewMain.CurrentRow == null)
                {
                    positionIdEntidad = 0;
                }
                else
                {
                    positionIdEntidad = ((Entidad)datagridviewMain.SelectedRows[0].DataBoundItem).IdEntidad;
                }
            }

            FilterData();

            if (positionIdEntidad != 0)
            {
                foreach (DataGridViewRow row  in datagridviewMain.Rows)
                {
                    if (((Entidad)row.DataBoundItem).IdEntidad == positionIdEntidad)
                    {
                        datagridviewMain.CurrentCell = row.Cells[columnNombreParaMostrar.Name];
                        break;
                    }
                }
            }
        }

        private void FilterData()
        {
            if (!skipFilterData)
            {
                this.Cursor = Cursors.WaitCursor;

                try
                {
                    listEntidadesFiltradaYOrdenada = listEntidades;

                    // Filtro por Activo
                    switch (comboboxActivo.SelectedIndex)
                    {
                        case 0:     // Todos
                            break;
                        case 1:     // Sí
                            listEntidadesFiltradaYOrdenada = listEntidadesFiltradaYOrdenada.Where(ent => ent.EsActivo).ToList();
                            break;
                        case 2:     // No
                            listEntidadesFiltradaYOrdenada = listEntidadesFiltradaYOrdenada.Where(ent => !ent.EsActivo).ToList();
                            break;
                        default:
                            break;
                    }

                    // Filtro por Búsqueda en Apellido y Nombre
                    if (busquedaAplicada)
                    {
                        listEntidadesFiltradaYOrdenada = listEntidadesFiltradaYOrdenada.Where(ent => ent.NombreParaMostrar.ToLower().Contains(textboxBuscar.Text.ToLower().Trim())).ToList();
                    }

                    // Actualizo la cantidad
                    switch (listEntidadesFiltradaYOrdenada.Count)
                    {
                        case 0:
                            statuslabelMain.Text = "No hay Entidades para mostrar.";
                            break;
                        case 1:
                            statuslabelMain.Text = "Se muestra 1 Entidad.";
                            break;
                        default:
                            statuslabelMain.Text = string.Format("Se muestran {0} Entidades.", listEntidadesFiltradaYOrdenada.Count);
                            break;
                    }

                }
                catch (System.Exception ex)
                {
                    CardonerSistemas.Error.ProcessError(ex, "Error al filtrar los datos.");
                    this.Cursor = Cursors.Default;
                    return;
                }

                OrderData();

                this.Cursor = Cursors.Default;
            }
        }

        private void OrderData()
        {
            if (ordenColumna.Name == columnNombreParaMostrar.Name)
            {
                if (ordenTipo == SortOrder.Ascending)
                {
                    listEntidadesFiltradaYOrdenada = listEntidadesFiltradaYOrdenada.OrderBy(ent => ent.NombreParaMostrar).ToList();
                }
                else
                {
                    listEntidadesFiltradaYOrdenada = listEntidadesFiltradaYOrdenada.OrderByDescending(ent => ent.NombreParaMostrar).ToList();
                }
            }
            else if (ordenColumna.Name == columnCuit.Name)
            {
                if (ordenTipo == SortOrder.Ascending)
                {
                    listEntidadesFiltradaYOrdenada = listEntidadesFiltradaYOrdenada.OrderBy(ent => ent.Cuit).ToList();
                }
                else
                {
                    listEntidadesFiltradaYOrdenada = listEntidadesFiltradaYOrdenada.OrderByDescending(ent => ent.Cuit).ToList();
                }
            }

            datagridviewMain.AutoGenerateColumns = false;
            datagridviewMain.DataSource = listEntidadesFiltradaYOrdenada;

            //  Muestro el ícono de orden en la columna correspondiente
            ordenColumna.HeaderCell.SortGlyphDirection = ordenTipo;
        }

        #endregion

        #region Controls behavior

        private void TextBoxs_Enter(object sender, System.EventArgs e)
        {
            ((ToolStripTextBox)sender).SelectAll();
        }

        private void this_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!textboxBuscar.Focused)
            {
                if (char.IsLetter(e.KeyChar))
                {
                    foreach (DataGridViewRow row in datagridviewMain.Rows)
                    {
                        if (row.Cells[columnNombreParaMostrar.Name].Value.ToString().StartsWith(e.KeyChar.ToString(), System.StringComparison.CurrentCultureIgnoreCase))
                        {
                            row.Cells[columnNombreParaMostrar.Name].Selected = true;
                            datagridviewMain.Focus();
                            return;
                        }
                    }
                }
            }
        }

        private void Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (textboxBuscar.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Se deben especificar al menos 3 letras para buscar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textboxBuscar.Focus();
                }
                else
                {
                    busquedaAplicada = true;
                    FilterData();
                }
                e.Handled = true;
            }
        }

        private void BuscarBorrar_Click(object sender, System.EventArgs e)
        {
            if (busquedaAplicada)
            {
                textboxBuscar.Clear();
                busquedaAplicada = false;
                FilterData();
            }
        }

        private void Activo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FilterData();
        }

        private void Grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = (DataGridViewColumn)datagridviewMain.Columns[e.ColumnIndex];

            if (column.Name == columnNombreParaMostrar.Name | column.Name == columnCuit.Name)
            {
                if (column == ordenColumna)
                {
                    // La columna clickeada es la misma por la que ya estaba ordenado, así que cambio la dirección del orden
                    if (ordenTipo == SortOrder.Ascending)
                    {
                        ordenTipo = SortOrder.Descending;
                    }
                    else
                    {
                        ordenTipo = SortOrder.Ascending;
                    }
                }
                else
                {
                    // La columna clickeada es diferencte a la que ya estaba ordenada.
                    // En primer lugar saco el ícono de orden de la columna vieja
                    if (ordenColumna != null)
                    {
                        ordenColumna.HeaderCell.SortGlyphDirection = SortOrder.None;
                    }

                    // Preparo todo para la nueva columna
                    ordenTipo = SortOrder.Ascending;
                    ordenColumna = column;
                }
            }

            OrderData();
        }

        #endregion

        #region Main toolbar

        private void Agregar_Click(object sender, System.EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadAgregar))
            {
                this.Cursor = Cursors.WaitCursor;

                datagridviewMain.Enabled = false;
                // formPersona
                datagridviewMain.Enabled = true;

                this.Cursor = Cursors.Default;
            }
        }

        private void Editar_Click(object sender, System.EventArgs e)
        {
            if (datagridviewMain.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna Entidad para editar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadEditar))
                {
                    this.Cursor = Cursors.WaitCursor;

                    datagridviewMain.Enabled = false;
                    // formPersona
                    datagridviewMain.Enabled = true;

                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void Borrar_Click(object sender, System.EventArgs e)
        {
            if (datagridviewMain.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna Entidad para borrar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadBorrar))
                {
                    string mensaje = string.Format("Se eliminará la Entidad seleccionada.{0}{0}Nombre: {1}{0}CUIT: {2}{0}{0}¿Confirma la eliminación definitiva?", System.Environment.NewLine, ((Entidad)datagridviewMain.CurrentRow.DataBoundItem).NombreParaMostrar, ((Entidad)datagridviewMain.CurrentRow.DataBoundItem).Cuit);
                    if (MessageBox.Show(mensaje, CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        try
                        {
                            using (CSGestionContext context = new CSGestionContext(true))
                            {
                                Entidad entidad = context.Entidad.Find(((Entidad)datagridviewMain.SelectedRows[0].DataBoundItem).IdEntidad);

                                context.Entidad.Attach(entidad);
                                context.Entidad.Remove(entidad);
                                context.SaveChanges();
                            }
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException dbuex)
                        {
                            switch (CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex))
                            {
                                case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity:
                                    MessageBox.Show("No se puede borrar la Entidad porque tiene datos relacionados.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch (System.Exception ex)
                        {
                            CardonerSistemas.Error.ProcessError(ex, "Error al borrar la Entidad.");
                        }

                        RefreshData();

                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void Verr_Click(object sender, System.EventArgs e)
        {
            if (datagridviewMain.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna Entidad para ver.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadEditar))
                {
                    this.Cursor = Cursors.WaitCursor;

                    datagridviewMain.Enabled = false;
                    // formPersona
                    datagridviewMain.Enabled = true;

                    this.Cursor = Cursors.Default;
                }
            }
        }

        #endregion

    }
}
