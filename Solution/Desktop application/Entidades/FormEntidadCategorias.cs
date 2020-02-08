using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormEntidadCategorias : Form
    {

        #region Declarations

        private List<EntidadCategoria> listEntidadCategorias;
        private List<EntidadCategoria> listEntidadCategoriasFiltradaYOrdenada;

        private bool skipFilterData = false;
        private bool busquedaAplicada = false;

        private DataGridViewColumn ordenColumna;
        private SortOrder ordenTipo;

        #endregion

        #region Form stuff

        public FormEntidadCategorias(bool modoSeleccion)
        {
            InitializeComponent();

            SetAppearance();

            skipFilterData = true;

            ListasComunes.EsActivo(comboboxActivo.ComboBox, 1);

            skipFilterData = false;

            ordenColumna = columnNombre;
            ordenTipo = SortOrder.Ascending;

            if (modoSeleccion)
            {
                FormBorderStyle = FormBorderStyle.FixedDialog;
                MinimizeBox = false;
                MaximizeBox = false;
                datagridviewMain.MultiSelect = true;
                statusstripMain.SizingGrip = false;
                datagridviewMain.DoubleClick += new System.EventHandler(Seleccionar);
            }
            else
            {
                buttonSeleccionar.Visible = false;
                datagridviewMain.DoubleClick += new System.EventHandler(Ver);
            }

            RefreshData();
        }

        private void SetAppearance()
        {
            Program.Appearance.DataGrid(datagridviewMain);
        }

        private void this_FormClosed(object sender, FormClosedEventArgs e)
        {
            listEntidadCategorias = null;
            listEntidadCategoriasFiltradaYOrdenada = null;
        }

        #endregion

        #region Load and Set Data

        internal void RefreshData(short positionIdEntidadCategoria = 0, bool restorePosition = false)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                using (CSGestionContext context = new CSGestionContext(true))
                {
                    listEntidadCategorias = context.EntidadCategoria.ToList();
                }
            }
            catch (System.Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ex, "Error al leer las Categorías de Entidades.");
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
                    positionIdEntidadCategoria = 0;
                }
                else
                {
                    positionIdEntidadCategoria = ((EntidadCategoria)datagridviewMain.SelectedRows[0].DataBoundItem).IdEntidadCategoria;
                }
            }

            FilterData();

            if (positionIdEntidadCategoria != 0)
            {
                foreach (DataGridViewRow row  in datagridviewMain.Rows)
                {
                    if (((EntidadCategoria)row.DataBoundItem).IdEntidadCategoria == positionIdEntidadCategoria)
                    {
                        datagridviewMain.CurrentCell = row.Cells[columnNombre.Name];
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
                    listEntidadCategoriasFiltradaYOrdenada = listEntidadCategorias;

                    // Filtro por Activo
                    switch (comboboxActivo.SelectedIndex)
                    {
                        case 0:     // Todos
                            break;
                        case 1:     // Sí
                            listEntidadCategoriasFiltradaYOrdenada = listEntidadCategoriasFiltradaYOrdenada.Where(ent => ent.EsActivo).ToList();
                            break;
                        case 2:     // No
                            listEntidadCategoriasFiltradaYOrdenada = listEntidadCategoriasFiltradaYOrdenada.Where(ent => !ent.EsActivo).ToList();
                            break;
                        default:
                            break;
                    }

                    // Filtro por Búsqueda en Apellido y Nombre
                    if (busquedaAplicada)
                    {
                        listEntidadCategoriasFiltradaYOrdenada = listEntidadCategoriasFiltradaYOrdenada.Where(ent => ent.Nombre.ToLower().Contains(textboxBuscar.Text.ToLower().Trim())).ToList();
                    }

                    // Actualizo la cantidad
                    switch (listEntidadCategoriasFiltradaYOrdenada.Count)
                    {
                        case 0:
                            statuslabelMain.Text = "No hay Categorías de Entidades para mostrar.";
                            break;
                        case 1:
                            statuslabelMain.Text = "Se muestra 1 Categoría de Entidad.";
                            break;
                        default:
                            statuslabelMain.Text = string.Format("Se muestran {0} Categorías de Entidades.", listEntidadCategoriasFiltradaYOrdenada.Count);
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
            if (ordenColumna.Name == columnNombre.Name)
            {
                if (ordenTipo == SortOrder.Ascending)
                {
                    listEntidadCategoriasFiltradaYOrdenada = listEntidadCategoriasFiltradaYOrdenada.OrderBy(ent => ent.Nombre).ToList();
                }
                else
                {
                    listEntidadCategoriasFiltradaYOrdenada = listEntidadCategoriasFiltradaYOrdenada.OrderByDescending(ent => ent.Nombre).ToList();
                }
            }

            datagridviewMain.AutoGenerateColumns = false;
            datagridviewMain.DataSource = listEntidadCategoriasFiltradaYOrdenada;

            //  Muestro el ícono de orden en la columna correspondiente
            ordenColumna.HeaderCell.SortGlyphDirection = ordenTipo;
        }

        #endregion

        #region Controls behavior

        private void TextBoxs_Enter(object sender, EventArgs e)
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
                        if (row.Cells[columnNombre.Name].Value.ToString().StartsWith(e.KeyChar.ToString(), System.StringComparison.CurrentCultureIgnoreCase))
                        {
                            row.Cells[columnNombre.Name].Selected = true;
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

        private void BuscarBorrar_Click(object sender, EventArgs e)
        {
            if (busquedaAplicada)
            {
                textboxBuscar.Clear();
                busquedaAplicada = false;
                FilterData();
            }
        }

        private void Activo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void Grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = (DataGridViewColumn)datagridviewMain.Columns[e.ColumnIndex];

            if (column.Name == columnNombre.Name)
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

        private void Agregar(object sender, EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadCategoriaAgregar))
            {
                this.Cursor = Cursors.WaitCursor;

                datagridviewMain.Enabled = false;
                FormEntidadCategoria entidadCategoria = new FormEntidadCategoria();
                entidadCategoria.LoadAndShow(true, this, 0);
                datagridviewMain.Enabled = true;

                this.Cursor = Cursors.Default;
            }
        }

        private void Editar(object sender, EventArgs e)
        {
            if (datagridviewMain.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna Categoría de Entidad para editar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadCategoriaEditar))
                {
                    this.Cursor = Cursors.WaitCursor;

                    datagridviewMain.Enabled = false;
                    FormEntidadCategoria entidadCategoria = new FormEntidadCategoria();
                    entidadCategoria.LoadAndShow(true, this, ((EntidadCategoria)datagridviewMain.CurrentRow.DataBoundItem).IdEntidadCategoria);
                    datagridviewMain.Enabled = true;

                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void Borrar(object sender, EventArgs e)
        {
            if (datagridviewMain.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna Categoría de Entidad para borrar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadCategoriaBorrar))
                {
                    string mensaje = string.Format("Se borrará la Categoría de Entidad seleccionada.{0}{0}Nombre: {1}{0}{0}¿Confirma el borrado definitivo?", System.Environment.NewLine, ((EntidadCategoria)datagridviewMain.CurrentRow.DataBoundItem).Nombre);
                    if (MessageBox.Show(mensaje, CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        try
                        {
                            using (CSGestionContext context = new CSGestionContext(true))
                            {
                                EntidadCategoria entidadCategoria = context.EntidadCategoria.Find(((EntidadCategoria)datagridviewMain.SelectedRows[0].DataBoundItem).IdEntidadCategoria);

                                context.EntidadCategoria.Attach(entidadCategoria);
                                context.EntidadCategoria.Remove(entidadCategoria);
                                context.SaveChanges();
                            }
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException dbuex)
                        {
                            switch (CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex))
                            {
                                case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity:
                                    MessageBox.Show("No se puede borrar la Categoría de Entidad porque tiene datos relacionados.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch (System.Exception ex)
                        {
                            CardonerSistemas.Error.ProcessError(ex, "Error al borrar la Categoría de Entidad.");
                        }

                        RefreshData();

                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void Ver(object sender, EventArgs e)
        {
            if (datagridviewMain.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna Categoría de Entidad para ver.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                datagridviewMain.Enabled = false;
                FormEntidadCategoria entidadCategoria = new FormEntidadCategoria();
                entidadCategoria.LoadAndShow(false, this, ((EntidadCategoria)datagridviewMain.CurrentRow.DataBoundItem).IdEntidadCategoria);
                datagridviewMain.Enabled = true;

                this.Cursor = Cursors.Default;
            }
        }

        private void Seleccionar(object sender, EventArgs e)
        {
            if (datagridviewMain.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna Categoría de Entidad seleccionada.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        #endregion

    }
}
