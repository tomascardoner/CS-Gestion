using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.IconApplication;
            this.Text = CardonerSistemas.My.Application.Info.Title;
            labelCompanyName.Text = CardonerSistemas.My.Application.Info.CompanyName;
            labelAppTitle.Text = CardonerSistemas.My.Application.Info.Title;
            labelLicensedTo.Text = "";
            labelStatus.Text = "Iniciando...";
            labelCopyright.Text = CardonerSistemas.My.Application.Info.Copyright;
        }
    }
}
