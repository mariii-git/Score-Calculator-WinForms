namespace score_calculator
{
    public partial class Form1 : Form
    {
        List<double> scores = new List<double>();
        public Form1()
        {
            InitializeComponent();

        }
        private void addscore()
        {
            if (double.TryParse(txtscore.Text, out double score))
            {
                scores.Add(score);
                listBox1.Items.Add(score);
                txtscore.Clear();

            }
            else
            {
                MessageBox.Show("لطفا یک نمره معتبر وارد کنید.");
            }
        }
        private void clearall()
        {
            scores.Clear();
            listBox1.Items.Clear();
            lblaverage.Text = "";
            lblmax.Text = "";
            lblmin.Text = "";
        }
        private void calculate()
        {
            if (scores.Count == 0)
            {
                MessageBox.Show("ابتدا نمره وارد کنید.");
                return;
            }
            double average = scores.Average();
            double max = scores.Max();
            double min = scores.Min();

            lblaverage.Text = "میانگین : " + average.ToString();
            lblmax.Text = "بیشترین : " + max;
            lblmin.Text = "کمترین : " + min;
        }

        private void txtscore_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            addscore();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            calculate();
        }
    }
}
