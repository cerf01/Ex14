using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp14
{
    public partial class Form1 : Form
    {
        private Thread thread1;
        private Thread thread2;

        private bool isTimeToExit1;
        private bool isTimeToExit2;
        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(() => { });
            thread2 = new Thread(() => { });
            isTimeToExit1 = false;
            isTimeToExit2 = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!thread1.IsAlive)
            {
                isTimeToExit1 = false;
                thread1 = new Thread(primeNums);
                thread1.Start();
            }
            else
                MessageBox.Show("Is running!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!thread1.IsAlive)
                return;
            isTimeToExit1 = true;
        }
        private async void primeNums()
        {
            int min = (int)minPanel1.Value;
            int max = (int)maxPanel1.Value;
            if (min > max)
                return;
            if (max < 4)
                max = -1;
            if (min == 0)
                min = 2;
            int count;

            for (int i = min; max + 1 != i; i++)
            {
                if (isTimeToExit1)
                    return;
                count = 0;
                for (int j = 2; j <= i; j++)
                    if (i % j == 0) count++;
                if (count == 1)
                    if (label1.InvokeRequired)
                        label1.Invoke(delegate { label1.Text = $"{i}"; });
                Thread.Sleep(150);

            }
        }
        private void FibSeq()
        {
            int min = (int)minPanel2.Value;
            int max = (int)maxPanel2.Value;

            if (min > max)
                return;

            if (max < 1)
                return;

            if (min < 2)
                min = 2;

            List<int> fNums = new List<int>();

            fNums.Add(0);
            fNums.Add(1);

            for (int i = 0; i < max; i++)
            {
                if (isTimeToExit2)
                    return;
                if (i > 1)
                    fNums.Add(fNums[i - 1] + fNums[i - 2]);
                    if (label2.InvokeRequired)
                        label2.Invoke(delegate { label2.Text = $"{fNums[i]}"; });
                    Thread.Sleep(150);  
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!thread2.IsAlive)
            {
                isTimeToExit2 = false;
                thread2 = new Thread(FibSeq);
                thread2.Start();
            }
            else
                MessageBox.Show("Is running!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!thread2.IsAlive)
                return;
            isTimeToExit2 = true;
        }
    }
}