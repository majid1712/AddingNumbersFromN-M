namespace AddingNumbersFromN_M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    richTextBox1.Text += "fizzBuzz\n";

                }
                else if (i % 3 == 0)
                {
                    richTextBox1.Text += "fizz\n";
                }
               else  if (i % 5 == 0)
                {
                    richTextBox1.Text += "buzz\n";
                }
                else
                {
                    richTextBox1.Text += i.ToString() + "\n";

                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumFrom = 0;
            int NumTo = 0;
            int Sum  = 0;
           NumFrom = Convert.ToInt32(textBox1.Text);
            NumTo = Convert.ToInt32(textBox2.Text);
            
       


            while (NumFrom <= NumTo)
            {
                Sum += NumFrom;
                NumFrom++;

            }
            richTextBox1.Text = Sum.ToString();
        }
    }
}