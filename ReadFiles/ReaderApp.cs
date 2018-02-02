using System;
using System.IO;
using System.Windows.Forms;

namespace ReadFiles
{
    public partial class ReaderApp : Form
    {
        private readonly ReadService _readService = new ReadService();
        private string _path;
        private string _selectedRole;
        private string _availableSources = "txt files (*.txt)|*.txt";
        public ReaderApp()
        {
            InitializeComponent();
            roleBox.Items.AddRange(new object[] {"User", "Admin" });
            roleBox.SelectedItem = roleBox.Items[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = _availableSources;
            
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
                var filetype = Path.GetExtension(_path)?.TrimStart('.');
                
                textBox2.Text = isEncrypted.Checked? _readService.ReadEncryptedFile(path, filetype): _readService.ReadFile(path, filetype);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error occured while reading file.Additional info {exception.Message}");
            }

        }

        private void RoleChanged(object sender, EventArgs e)
        {
            _selectedRole = roleBox.SelectedItem.ToString();
            // Admin can see any files, user only txt
            // Just as an example
            switch (_selectedRole)
            {
                case "User": SetUserResources();
                    break;
                case "Admin":SetAdminResources();
                    break;

            }
        }

        private void SetAdminResources()
        {
            _availableSources = "txt files (*.txt)|*.txt|Xml files (*.xml)|*.xml|All files (*.*)|*.*";
        }

        private void SetUserResources()
        {
            _availableSources = "txt files(*.txt)| *.txt";
            
        }
    }
}
