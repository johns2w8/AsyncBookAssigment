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

        //Wes Johnson
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
            lstReport2.Items.Clear();
            List<Task> tasks = new List<Task>();
            var file = openFileDialog1.FileName;
            var file2 = openFileDialog2.FileName;
            var wordTask = ReadBook(file, lstReport);
            tasks.Add(wordTask);
            var wordTask2 = ReadBook(file2, lstReport2);
            tasks.Add(wordTask2);
            await Task.WhenAll(tasks);
        }

        //Wes Johnson
        private async Task ReadBook(string fileName, ListBox listBox)
        {
            var lines = await File.ReadAllLinesAsync(fileName);

            //process lines and removes spaces and punctuation

            var arrayLinesCleaned = lines.Where(x => x != string.Empty)
                                         .AsParallel()
                                         .Select(x => x.ToLower()
                                         .Trim()
                                         .Replace(",", "")
                                         .Replace("!", "")
                                         .Replace("?", "")
                                         .Replace(".", "")
                                         .Replace("'", ""));
            //flattening out the array into one array

            var arraywords = arrayLinesCleaned.SelectMany(x => x.Split(" "));

            Dictionary<string, int> wordDic = new Dictionary<string, int>();

            arraywords.ToList().ForEach(x =>
            {
                if (wordDic.ContainsKey(x))
                {
                    wordDic[x]++;
                }
                else
                {
                    wordDic.Add(x, 1);
                }
            });

            var top10 = wordDic.Where(x => !string.IsNullOrWhiteSpace(x.Key))
                                   .OrderByDescending(x => x.Value).Take(10);


            foreach (var word in top10)
            {
                listBox.Items.Add(word.Key + " - " + word.Value);
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile2.Text = openFileDialog2.FileName.Split("\\").LastOrDefault();
            }
        }
    }
}
