using Syncfusion.Windows.Forms.Tools;

namespace CS_Gestion
{
    static internal class CommandToolbar
    {
        internal const string PrincipalEntidades = "Entidades";

        internal const string TablasBancos = "Bancos";
        internal const string TablasSucursalesBancos = "Sucursales de bancos";
        internal const string TablasTiposDocumento = "Tipos de documento";
        internal const string TablasTiposDomicilio = "Tipos de domicilio";
        internal const string TablasTiposEmail = "Tipos de e-mail";
        internal const string TablasTiposCuentaBancaria = "Tipos de cuenta bancaria";
        internal const string TablasTiposMovimiento = "Tipos de movimiento";
        internal const string TablasTiposTelefono = "Tipos de teléfonos";
        internal const string TablasCategoriasEntidades = "Categorías de entidades";
        internal const string TablasGruposUsuarios = "Grupos de usuarios";
        internal const string TablasUsuarios = "Usuarios";

        static internal void AddCommands(FormMdi formMdi)
        {
            // Principal
            AddCommand(formMdi.groupviewPrincipal, PrincipalEntidades, 0);

            // Tablas
            AddCommand(formMdi.groupviewTablas, TablasBancos, -1);
            AddCommand(formMdi.groupviewTablas, TablasSucursalesBancos, -1);
            AddCommand(formMdi.groupviewTablas, TablasTiposDocumento, -1);
            AddCommand(formMdi.groupviewTablas, TablasTiposDomicilio, -1);
            AddCommand(formMdi.groupviewTablas, TablasTiposEmail, -1);
            AddCommand(formMdi.groupviewTablas, TablasTiposCuentaBancaria, -1);
            AddCommand(formMdi.groupviewTablas, TablasTiposMovimiento, -1);
            AddCommand(formMdi.groupviewTablas, TablasTiposTelefono, -1);
            AddCommand(formMdi.groupviewTablas, TablasCategoriasEntidades, -1);
            AddCommand(formMdi.groupviewTablas, TablasGruposUsuarios, -1);
            AddCommand(formMdi.groupviewTablas, TablasUsuarios, -1);
        }

        static private void AddCommand(GroupView groupView, string displayName, int imageIndex)
        {
            GroupViewItem item = new GroupViewItem(displayName, imageIndex);
            item.ToolTipText = displayName;
            groupView.GroupViewItems.Add(item);
        }

    }
}
