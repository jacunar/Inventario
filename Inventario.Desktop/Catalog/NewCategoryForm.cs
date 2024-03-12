using Inventario.Application.Repositories;
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
    public partial class NewCategoryForm : Form {
        public IUnitOfWork UnitOfWork;

        public NewCategoryForm() {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void GuardarButton_Click(object sender, EventArgs e) {

        }
    }
}
