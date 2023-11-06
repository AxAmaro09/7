namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int rangoinferior, rangosuperior, suma = 0;
            rangoinferior = int.Parse(textBox1.Text);
            rangosuperior = int.Parse(textBox2.Text);
            for (int i = rangoinferior; i <= rangosuperior; i++)
            {
                listBox1.Items.Add(i);
                suma = suma + i;
            }
            textBox3.Text = suma.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            // Borra los elementos de la ListBox
            listBox1.Items.Clear();
        }
    }
}