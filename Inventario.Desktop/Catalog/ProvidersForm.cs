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
    public partial class ProvidersForm : Form {
        public IServiceProvider ServiceProvider;
        public ProvidersForm() {
            InitializeComponent();
        }

        private void AddTSB_Click(object sender, EventArgs e) {
            var form = ServiceProvider.GetRequiredService<NewProviderForm>();
            //form.UnitOfWork = ServiceProvider.GetRequiredService<IUnitOfWork>();
            form.ShowDialog();
            //GetProducts();
        }
    }
}
