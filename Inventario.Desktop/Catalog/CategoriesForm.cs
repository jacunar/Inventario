using Inventario.Application.Repositories;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class CategoriesForm : Form {
        public IServiceProvider ServiceProvider;

        public CategoriesForm() {
            InitializeComponent();
        }

        private void AddTSB_Click(object sender, EventArgs e) {
            var form = ServiceProvider.GetRequiredService<NewCategoryForm>();
            form.UnitOfWork = ServiceProvider.GetRequiredService<IUnitOfWork>();
            form.ShowDialog();
            //GetCategories();
        }
    }
}
