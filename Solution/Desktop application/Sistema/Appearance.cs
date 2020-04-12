using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CS_Gestion
{
    internal class Appearance
    {
        private Font _GridFont;

        public Font GridFont { get => _GridFont; }

        internal Appearance()
        {
            _GridFont = Parametros.GetStringAsFont(CS_Gestion.Parametros.AppearanceGridFont, Constantes.DefaultFontString);
        }

        internal void DataGrid(DataGridView dataGridView)
        {
            dataGridView.DefaultCellStyle.Font = GridFont;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = GridFont;

            dataGridView.DefaultCellStyle.BackColor = SystemColors.Window;
            dataGridView.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            dataGridView.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridView.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = SystemColors.ControlText;
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
        }

        private string SetFontToString(Font font)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
            return converter.ConvertToString(font);
        }
    }
}
