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

        private Color SelectedColor
        {
            get
            {
                return Color.FromKnownColor((KnownColor)_colorComboBox.SelectedValue);
            }
        }

        private string DirectoryPath
        {
            get
            {
                return _directoryTextBox.Text;
            }
        }

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
            using (Bitmap img = Image.FromFile(filename) as Bitmap)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        Color pixelColor = img.GetPixel(x, y);

                        img.SetPixel(x, y, Color.FromArgb(
                            pixelColor.A,
                            SelectedColor
                        ));
                    }
                }

                string fileName = filename.Substring(0, filename.Length - 4) + _extendedFileName;

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                img.Save(fileName);
            }
        }

        private void _colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _colorPanel.BackColor = SelectedColor;
        }

        private void BeginDecolorize()
        {
            SetControlVisible(_loaderImage);

            SetControlEnabled(_colorComboBox, false);
            SetControlEnabled(_directoryTextBox, false);
            SetControlEnabled(_groupBox, false);
        }

        private void EndDecolorize()
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
            BeginDecolorize();

            // Iterate through all subdirectories
            foreach (var directory in Directory.GetDirectories(DirectoryPath))
            {
                var files = Directory.GetFiles(directory);

                foreach (var file in files)
                {
                    var filename = file.ToString();

                    if (!filename.EndsWith(".png") || filename.EndsWith(_extendedFileName))
                    {
                        continue;
                    }

                    DecolorizeImage(filename);
                }
            }

            EndDecolorize();
        }

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

    }
}
