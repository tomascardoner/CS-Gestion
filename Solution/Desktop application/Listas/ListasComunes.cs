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
    }
}
