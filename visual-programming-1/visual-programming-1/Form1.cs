namespace visual_programming_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnStudent")
            {
                label1.Text = "Hello Students!";
            }
            else if (btn.Name == "btnProfessor")
            {
                label1.Text = "Hello Professor!";
            }

            //label1.Text = "Hello Professor!";
        }
    }
}
