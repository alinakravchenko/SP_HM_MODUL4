namespace SP_HM_MODUL4
{
    //Task 1
    public partial class Form1 : Form
    {
        Random random = new Random();
        Semaphore semaphore = new Semaphore(3, 3);
        public Form1()
        {
            InitializeComponent();
            buttonStart.Click += buttonStart_Click;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(GenerateNumber);
                threads[i].Name = "Поток " + i;
                threads[i].Start();
            }
        }
        private void GenerateNumber()
        {
            semaphore.WaitOne();
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                int number = random.Next(1, 100);
                if (listBoxNumber.InvokeRequired)
                {
                    listBoxNumber.Invoke(new Action<int>((threadId) => listBoxNumber.Items.Add($"Id потока: {threadId}. Число {number}")), Thread.CurrentThread.ManagedThreadId);
                }
            }
            semaphore.Release();
        }
    }



}