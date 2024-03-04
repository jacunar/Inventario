using Inventario.Desktop.Catalog;
using Microsoft.Extensions.DependencyInjection;
using Modern.Forms;

namespace Inventario.Desktop {
    public partial class MainForm : System.Windows.Forms.Form {
        private readonly IServiceProvider serviceProvider;

        public MainForm(IServiceProvider serviceProvider) {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
        }

        private void ProductosTSMI_Click(object sender, EventArgs e) {
            var form = serviceProvider.GetRequiredService<ProductForm>();
            form.ServiceProvider = serviceProvider;
            form.MdiParent = this;
            form.Show();
        }

        private void SalirTSBI_Click(object sender, EventArgs e) {
            Close();
        }

        private void CategoriasTSMI_Click(object sender, EventArgs e) {
            var form = serviceProvider.GetRequiredService<CategoriesForm>();
            form.ServiceProvider = serviceProvider;
            form.MdiParent = this;
            form.Show();
        }

        private void ProveedoresTSMI_Click(object sender, EventArgs e) {
            var form = serviceProvider.GetRequiredService<ProvidersForm>();
            form.ServiceProvider = serviceProvider;
            form.MdiParent = this;
            form.Show();
        }
    }
}