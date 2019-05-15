using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace clase_15
{
  public partial class FrmPrincipal : Form
  {
    public FrmPrincipal()
    {
      InitializeComponent();
    }

    private void FrmPrincipal_Load(object sender, EventArgs e)
    {

    }

    private void BtnEnter_Click(object sender, EventArgs e)
    {
      try
      {
        StreamWriter archivo = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory+"\\miArchivo.txt",true);
        //StreamWriter archivo = new StreamWriter("D:\\miArchivo.txt",true);
        archivo.WriteLine(TxtValor.Text);
        TxtValor.Clear();
        archivo.Close();
      }
      catch (Exception f)
      {
        MessageBox.Show(f.Message);
      }
    }
  }
}
