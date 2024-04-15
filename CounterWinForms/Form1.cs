namespace CounterWinForms
{
    public partial class Form1 : Form
    {
        Counter counter = new Counter(0);

        public Form1()
        {
            InitializeComponent();
            updateCounterLabel();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            counter.Reset();
            updateCounterLabel();
        }

        private void buttonIncr_Click(object sender, EventArgs e)
        {
            counter.Increment();
            updateCounterLabel();
        }

        private void updateCounterLabel()
        {
            label1.Text = counter.GetValue().ToString();
        }
    }
}