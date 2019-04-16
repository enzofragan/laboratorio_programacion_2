using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paletaform
{
  public partial class frmPrincipal : Form
  {
    public frmPrincipal()
    {
      InitializeComponent();

      this.IsMdiContainer = true;
      this.WindowState = FormWindowState.Maximized;
    }

    private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form1 frmpaleta = new Form1();
      frmpaleta.MdiParent = this;
      frmpaleta.StartPosition = FormStartPosition.CenterScreen;
      frmpaleta.Show();
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.frmPrincipal_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, true));
    }

    private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
      if(MessageBox.Show("desea salir?","attencion",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
      {
        e.Cancel = true;
      }
    }
  }
}
