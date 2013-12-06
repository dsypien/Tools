using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;
using System.IO;

namespace DeColor
{
    public partial class DeColorForm : Form
    {
        private ObservableCollection<KnownColor> _colors = new ObservableCollection<KnownColor>();
        private string _extendedFileName = "_deColorD.png";
        private Color _selectedColor = Color.White;
        private bool _isRecursive;

        #region Properties

        private Color SelectedColor
        {
            get
            {
                return _selectedColor;
            }
        }

        private string DirectoryPath
        {
            get
            {
                return _directoryTextBox.Text;
            }
        }
        #endregion

        public DeColorForm()
        {
            InitializeComponent();
            InitComboBoxes();
        }

        private void InitComboBoxes()
        {
            Array colorArray = Enum.GetValues(typeof(KnownColor));

            foreach (KnownColor color in colorArray)
            {
                _colors.Add(color);
            }

            _colorComboBox.DataSource = _colors;
            _colorComboBox.SelectedItem = KnownColor.White;
        }

        private void _browseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.ShowDialog();
                var path = dialog.SelectedPath;

                _directoryTextBox.Text = path;
            }
        }

        private void DecolorizeImage(string filename)
        {
           
        }

        private void _colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedColor();
            UpdatePanelColor( SelectedColor );
        }

        private void DisableDeColorizeControls()
        {
            SetControlVisible(_loaderImage);

            SetControlEnabled(_colorComboBox, false);
            SetControlEnabled(_directoryTextBox, false);
            SetControlEnabled(_groupBox, false);
        }

        private void EnableDeColorizeControls()
        {
            SetControlVisible(_loaderImage, false);

            SetControlEnabled(_colorComboBox);
            SetControlEnabled(_directoryTextBox);
            SetControlEnabled(_groupBox);

            MessageBox.Show("Files Decolorized!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DirectoryPath))
            {
                MessageBox.Show("Please browse to a directory");
                return;
            }

            Task.Factory.StartNew(() => DeColorize());
        }

        private void DeColorize()
        {
            DisableDeColorizeControls();

            // Flatten png images in current directory
            var currentFiles = Directory.GetFiles(DirectoryPath);
            foreach(var curFile in currentFiles)
            {
                var curFileName = curFile.ToString();
                DecolorizeImage(curFileName);
            }

            //If not recursive, enable controls and return here
            if(!_isRecursive)
            {
                EnableDeColorizeControls();
                return;
            }

            // Iterate through all subdirectories
            foreach (var directory in Directory.GetDirectories(DirectoryPath))
            {
                var files = Directory.GetFiles(directory);

                foreach (var file in files)
                {
                    var filename = file.ToString();
                }
            }

            EnableDeColorizeControls();
        }

        #region Cross-Threaded Calls

        private void SetControlVisible(Control ctrl, bool isVisible = true)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    ctrl.Visible = isVisible;
                });
            }
            else
            {
                ctrl.Visible = isVisible;
            }
        }

        private void SetControlEnabled(Control ctrl, bool isEnabled = true)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    ctrl.Enabled = isEnabled;
                });
            }
            else
            {
                ctrl.Enabled = isEnabled;
            }
        }

        private void UpdateSelectedColor()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker) delegate
                {
                    _selectedColor = Color.FromKnownColor(
                        (KnownColor)_colorComboBox.SelectedItem
                    );
                });
            }
            else
            {
                _selectedColor = Color.FromKnownColor(
                    (KnownColor)_colorComboBox.SelectedItem
                );
            }
        }

        private void UpdatePanelColor(Color color)
        {
            if(this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    _colorPanel.BackColor = color;
                });
            }
            else
            {
                _colorPanel.BackColor = color;
            }
        }

        #endregion

        private void _recursiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    _isRecursive = _recursiveCheckBox.Checked;
                });
            }
            else
            {
                _isRecursive = _recursiveCheckBox.Checked;
            }
        }
    }
}
