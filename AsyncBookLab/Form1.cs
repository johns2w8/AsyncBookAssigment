namespace AsyncBookLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile1.Text = openFileDialog1.FileName.Split("\\").LastOrDefault();
            }
        }

        private async Task btnSubmit_Click(object sender, EventArgs e)
        {
            lstReport1.Items.Clear();
            List<Task> tasks = new List<Task>();
            var file = openFileDialog1.FileName;
            var wordTask = ReadBook(file);
            tasks.Add(wordTask);
            await Task.WhenAll(tasks);
        }
    }
}
