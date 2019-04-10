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
  public partial class Form1 : Form
  {

    private Paleta _mypaleta;

    public Paleta mypaleta
    {
      get { return _mypaleta; }
      set { _mypaleta = value; }
    }
    public Form1()
    {
      InitializeComponent();
    }

    private void btnMas_Click(object sender, EventArgs e)
    {
      FtrTempera frm = new FtrTempera();
      frm.Show();
      this._mypaleta += frm.mytempera;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
