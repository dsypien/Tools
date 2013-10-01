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

                _directoryTextBox.Text = dialog.SelectedPath;
            }
        }
    }
}
