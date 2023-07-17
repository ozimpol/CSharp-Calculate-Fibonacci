namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k;
            i = 1;
            j = 1;

            listBox1.Items.Add(i);
            listBox1.Items.Add(j);


            for (int l=0; l<=8; l++)
            {
                k = i + j;
                listBox1.Items.Add(k);
                i = j;
                j = k;

            }
        }
    }
}