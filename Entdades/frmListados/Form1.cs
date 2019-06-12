using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entdades;

namespace frmListados
{
  public partial class FrmListados : Form
  {
    private List<Persona> _personas;

    private DataTable _tabla = new DataTable();

    private accesoDatos access = new accesoDatos();

    public FrmListados()
    {
      InitializeComponent();

      this._tabla = access.traerTablaPersonas();
      this._personas = access.traerDatos();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      
    }

    private void FrmListados_Load(object sender, EventArgs e)
    {
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.DataSource = this._personas;
    }
  }
}
