using Inventario.Application.Repositories;
using Inventario.Core.Entities;

namespace Inventario.Desktop.Catalog;
public partial class NewProductForm : Form {
    private readonly IRepository<Product> _repository;
    public IUnitOfWork UnitOfWork { get; set; }
    public Product Product { get; set; }
    private bool IsNew = false;

    public NewProductForm(IRepository<Product> repository) {
        InitializeComponent();
        _repository = repository;
        LlenarCatalogos();
    }

    public void LlenarCatalogos() {
        var categorias = new object[] { "Herramientas", "Maquinaria", "Eletronicos" };
        CategoriaCB.Items.AddRange(categorias);
        var proveedores = new object[] { "Sinsa", "Fetesa", "Blando Moreno" };
        ProveedorCB.Items.AddRange(proveedores);
    }

    private void GuardarButton_Click(object sender, EventArgs e) {
        if (string.IsNullOrEmpty(NameTextBox.Text)) {
            MessageBox.Show("El nombre es requerido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (UnitPriceNumericUpDown.Value <= 0) {
            MessageBox.Show("Ingrese el precio del artículo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (CategoriaCB.SelectedItem is null) {
            MessageBox.Show("Seleccione una categoría", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (ProveedorCB.SelectedItem is null) {
            MessageBox.Show("Seleccione una proveedor", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Product.Name = NameTextBox.Text;
        Product.Description = DescriptionTextBox.Text;
        Product.UnitPrice = UnitPriceNumericUpDown.Value;
        Product.Stock = (int)StockNumericUpDown.Value;
        Product.MinStock = Convert.ToInt16(MinStockTextBox.Text);

        if (IsNew)
            _repository.Insert(Product);
        else
            _repository.Modify(Product);
        UnitOfWork.CommitAsync();
        this.Close();
    }

    private void CancelarButton_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void NewProductForm_Load(object sender, EventArgs e) {
        if (Product is null) {
            Product = new();
            IdTextBox.Enabled = false;
            IsNew = true;
        }
    }
}