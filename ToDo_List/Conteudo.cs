using ToDo_List.UserControls;

namespace ToDo_List
{
    public partial class Conteudo : Form
    {
        public Conteudo()
        {
            InitializeComponent();
        }

        private void adicionarUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Conteudo_Load(object sender, EventArgs e)
        {
            UC_Login log = new UC_Login();
            UC_Home h = new UC_Home();
            
            adicionarUserControl(log);
        }
    }
}
