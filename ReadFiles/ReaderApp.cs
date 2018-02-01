using System;
using System.Windows.Forms;

namespace ReadFiles
{
    public partial class ReaderApp : Form
    {
        private readonly ReadService _readService = new ReadService();
        private string _path;
        public ReaderApp()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _path = dialog.FileName;
                ReadFile(_path);

                textBox1.Text = _path;
            }
        }

        private void ReadFile(string path)
        {
            try
            {
                textBox2.Text = _readService.ReadTextFile(path);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error occured while reading file.Additional info {exception.Message}");
            }

        }
    }
}
