namespace C__ParentForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clildFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Child_Form1 cf1= new Child_Form1();
            cf1.MdiParent = this;
            cf1.Show();
        }
    }
}
