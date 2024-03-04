using Inventario.Application.Repositories;
using Inventario.Core.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Inventario.Desktop.Catalog;
public partial class ProductForm : Form {
    private readonly IRepository<Product> _repository;
    public IServiceProvider ServiceProvider;

    public ProductForm(IRepository<Product> repository) {
        InitializeComponent();
        _repository = repository;
    }

    private void ProductForm_Load(object sender, EventArgs e) {
        GetProducts();
    }

    private void GetProducts() {
        var products = _repository.GetAll().ToList();
        productBindingSource.DataSource = products;
    }

    private void NewTSB_Click(object sender, EventArgs e) {
        var form = ServiceProvider.GetRequiredService<NewProductForm>();
        form.UnitOfWork = ServiceProvider.GetRequiredService<IUnitOfWork>();
        form.ShowDialog();
        GetProducts();
    }
}