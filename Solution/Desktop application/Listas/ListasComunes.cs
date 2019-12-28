using System.Windows.Forms;

namespace CS_Gestion
{
    static class ListasComunes
    {
        static internal void EsActivo(ComboBox comboBox, int selectElementNumber = -1)
        {
            comboBox.Items.AddRange(new string[]{Properties.Resources.STRING_ITEM_ALL_MALE, Properties.Resources.STRING_YES, Properties.Resources.STRING_NO});
            if (selectElementNumber > -1)
            {
                comboBox.SelectedIndex = selectElementNumber;
            }
        }
    }
}
