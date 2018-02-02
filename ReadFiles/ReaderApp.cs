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

        private void OpenFile(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = _availableSources;

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _path = dialog.FileName;

            if (HasPermission(_path))
            {
                ReadFile(_path);
            }
            else
            {
                MessageBox.Show("You're not authorized to see this file content.");
            }
            


            textBox1.Text = _path;
 
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

        public bool HasPermission(string path)
        {
            if (!enableSecurity.Checked)
            {
                return true;
            }

            var fileName = Path.GetFileName(path);
            if (_selectedRole != "Admin")
            {
                return fileName != null && !fileName.StartsWith("secured");
            }

            return true;
        }
    }
}
