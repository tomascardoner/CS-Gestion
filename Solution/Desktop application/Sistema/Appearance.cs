using System.Drawing;
using System.Windows.Forms;

namespace CS_Gestion
{
    static internal class Appearance
    {
        static internal void DataGrid(DataGridView dataGridView)
        {
            // dataGridView.DefaultCellStyle.Font = Properties.Settings.Default.GridsAndListsFont;
            // dataGridView.ColumnHeadersDefaultCellStyle.Font = Properties.Settings.Default.GridsAndListsFont;

            dataGridView.DefaultCellStyle.BackColor = SystemColors.Window;
            dataGridView.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            dataGridView.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridView.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = SystemColors.ControlText;
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
        }
    }
}
