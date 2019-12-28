using System;
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
            _GridFont = GetFontFromParametro(CS_Gestion.Parametros.AppearanceGridFont);
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

        private Font GetFontFromParametro(string idParametro, string defaultFont = Constantes.DefaultFontString)
        {
            string valorParametro = CS_Gestion.Parametros.GetString(idParametro);
            if (valorParametro == null || valorParametro.Length == 0)
            {
                valorParametro = defaultFont;
            }

            try
            {
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
                Font font = (Font)converter.ConvertFromString(valorParametro);
                return font;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string SetFontToString(Font font)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
            return converter.ConvertToString(font);
        }
    }
}
