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
        private ObservableCollection<KnownColor> _fromColors = new ObservableCollection<KnownColor>();
        private ObservableCollection<KnownColor> _intoColors = new ObservableCollection<KnownColor>();

        public DeColorForm()
        {
            
            InitializeComponent();
            Array colorArray = Enum.GetValues(typeof(KnownColor));

            foreach (KnownColor color in colorArray)
            {
                _fromColors.Add(color);
                _intoColors.Add(color);
            }

            _turnComboBox.DataSource = _fromColors;
            _intoComboBox.DataSource = _intoColors;

            //default values
            _turnComboBox.SelectedItem = KnownColor.Transparent;
            _intoComboBox.SelectedItem = KnownColor.White;
        }

        private void _browseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.ShowDialog();
                var path = dialog.SelectedPath;

                _directoryTextBox.Text = path;

                foreach (var directory in Directory.GetDirectories(path))
                {
                    var files = Directory.GetFiles(directory);

                    foreach (var file in files)
                    {
                        var filename = file.ToString();
                        
                        if(!filename.EndsWith(".png"))
                        {
                            continue;
                        }

                        using (Bitmap img = Image.FromFile(file.ToString()) as Bitmap)
                        {

                            for (int x = 0; x < img.Width; x++)
                            {
                                for (int y = 0; y < img.Height; y++)
                                {
                                    Color pixelColor = img.GetPixel(x, y);

                                    img.SetPixel(x, y, Color.FromArgb(
                                        pixelColor.A,
                                        255,
                                        255,
                                        255
                                    ));
                                }
                            }

                            img.Save(filename.Substring(0, filename.Length - 4) + "_white.png");
                        }
                    }
                }
            }
        }
    }
}
