using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor {
    public partial class FontForm : Form {
        public FontForm() {
            InitializeComponent();
        }

        private void fontStyleList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void setFontButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void fonNametList_SelectedValueChanged(object sender, EventArgs e) { }

        private void fonNametList_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                fontNameBox.Text = fonNametList.SelectedItem.ToString();
                fontLabel.Font = new Font(fontNameBox.Font.Name, fontLabel.Font.Size,FontStyle.Regular);                
            }
            catch {
                MessageBox.Show("Something went wrong :(");
            }
        }
    }
}
