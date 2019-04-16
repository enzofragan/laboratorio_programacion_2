using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clase6;

namespace paletaform
{
  public partial class FtrTempera : Form
  {
    private Tempera _mytempera;

    public Tempera mytempera
    {
      get { return _mytempera; }
    }

    public FtrTempera()
    {
      InitializeComponent();

      this.label1.Text = "marca: ";
      this.label2.Text = "color: ";
      this.label3.Text = "cantidad: ";
      this.btnAceptar.Text = "Aceptar";
      this.btnCancelar.Text = "Cancelar";
      this.cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
      foreach(ConsoleColor colores in Enum.GetValues(typeof(ConsoleColor)))
      {
        this.cmbColor.Items.Add(colores);
      }
      this.cmbColor.Items.Add("seleccionar uno");
      this.cmbColor.SelectedItem = "seleccionar uno";
    }

    private void FtrTempera_Load(object sender, EventArgs e)
    {

    }

    private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      this._mytempera = new Tempera(this.txtMarca.Text, (ConsoleColor)this.cmbColor.SelectedItem, sbyte.Parse(this.txtCantidad.Text));
      this.DialogResult = DialogResult.OK;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }
  }
}
