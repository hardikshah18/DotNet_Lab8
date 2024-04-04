namespace Week11_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstBoxFibonacci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateUI(int number)
        {
            if (lstBoxFibonacci.InvokeRequired)
            {
                lstBoxFibonacci.Invoke(new MethodInvoker(delegate { lstBoxFibonacci.Items.Add(number.ToString()); }));
            }
            else
            {
                lstBoxFibonacci.Items.Add(number.ToString());
            }
        }


        private int FibonacciNumber(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
            }
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBoxGenerate.Text, out int count) || count <= 0)
            {
                MessageBox.Show("Please enter a valid positive integer.");
            }
            else
            {
                lstBoxFibonacci.Items.Clear();
                await Task.Run(async () =>
                {
                    for (int i = 0; i < count; i++)
                    {
                        int fibo = FibonacciNumber(i);
                        UpdateUI(fibo);
                        await Task.Delay(100); // 100 milliseconds = 0.1 second
                    }
                });
            }
        }
    }
}