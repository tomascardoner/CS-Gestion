using System.Reflection;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormAboutBox : Form
    {
        public FormAboutBox()
        {
            InitializeComponent();
        }

        private void this_Load(object sender, System.EventArgs e)
        {
            this.Text = $"Acerca de {CardonerSistemas.My.Application.Info.Title}";

            labelApplicationTitle.Text = CardonerSistemas.My.Application.Info.Title;
            labelVersion.Text = $"Version {CardonerSistemas.My.Application.Info.Version.ToString()} - ({System.IO.File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location)})";
            labelCopyright.Text = CardonerSistemas.My.Application.Info.Copyright;
            labelLicensedTo.Text = Program.LicensedTo;

            // Propiedades
            ListViewItem newItem;

            newItem = new ListViewItem();
            newItem.Text = "DB - DataSource";
            newItem.SubItems.Add(Program.Database.Datasource);
            listviewPropiedades.Items.Add(newItem);

            newItem = new ListViewItem();
            newItem.Text = "DB - Database";
            newItem.SubItems.Add(Program.Database.InitialCatalog);
            listviewPropiedades.Items.Add(newItem);

            //newItem = new ListViewItem();
            //newItem.Text = "Reports Path";
            //newItem.SubItems.Add(Properties.Settings.Default.ReportsPath);
            //listviewPropiedades.Items.Add(newItem);

        }

        private void OKButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
