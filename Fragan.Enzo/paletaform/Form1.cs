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

    Paleta _mypaleta;

    public Form1()
    {
      _mypaleta = 5;
      InitializeComponent();
      this.btnMas.Text = "+";
      this.btnCancelar.Text = "-";
    }

    private void btnMas_Click(object sender, EventArgs e)
    {
      FtrTempera frm = new FtrTempera();
      frm.ShowDialog();
      if(frm.DialogResult == DialogResult.OK)
      {
        this._mypaleta += frm.mytempera;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
  }
}
