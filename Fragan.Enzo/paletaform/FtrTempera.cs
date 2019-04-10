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

      //Enum.GetValues(typeof(ConsoleColor));

      foreach (ConsoleColor item in Enum.GetValues(typeof(ConsoleColor)))
      {
        cmbColor.Items.Add(item);
      }



    }

    private void FtrTempera_Load(object sender, EventArgs e)
    {

    }

    private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      Tempera nuevo = new Tempera(txtMarca.Text, (ConsoleColor)this.cmbColor.SelectedItem, Convert.ToSByte(txtCantidad));
      // MessageBox.Show(Tempera.mostrar(nuevo));

      this._mytempera = nuevo;
    }

    private void txtMarca_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtCantidad_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
