using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Desktop.Catalog {
    public partial class NewProviderForm : Form {
        public NewProviderForm() {
            InitializeComponent();
        }

        private void NewProviderForm_Load(object sender, EventArgs e) {

        }

        private void CancelarButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
