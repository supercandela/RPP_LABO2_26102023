namespace FrmView
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.AddRange(new object[] { "    +", "    -", "    *", "    /" });
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}