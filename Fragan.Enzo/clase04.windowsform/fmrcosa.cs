using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clase_04;

namespace clase04.windowsform
{
  public partial class fmrcosa : Form
  {
    public fmrcosa()
    {
      InitializeComponent();
      MessageBox.Show("hola mundo");
      
    }

    private void button1_Click(object sender, EventArgs e)
    {
      cosa obj = new cosa();
      
      MessageBox.Show(obj.mostrar());
      this.button1.Text = "crear una cosa bonita";
    }
  }
}
