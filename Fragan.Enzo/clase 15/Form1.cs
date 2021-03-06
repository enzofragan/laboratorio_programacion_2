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
      string ruta="";
      InitializeComponent();

    }

    private void FrmPrincipal_Load(object sender, EventArgs e)
    {
      this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      this.openFileDialog1.Title = "selecione un archivo";
      this.openFileDialog1.Multiselect = true;
      this.openFileDialog1.DefaultExt = ".txt";
      this.openFileDialog1.AddExtension = true;
      this.openFileDialog1.Filter = "(*.txt)|*.TXT";
    }

    private void BtnEnter_Click(object sender, EventArgs e)
    {
      try
      {
        StreamWriter archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\miArchivo.txt", true);
        //StreamWriter archivo = new StreamWriter("C:\\Users\\alumno\\Desktop\\miArchivo.txt", true);
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

    private void BtnTraer_Click(object sender, EventArgs e)
    {
      try
      {
        StreamReader archivo = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\miArchivo.txt");
        string l;
        //MessageBox.Show(archivo.ReadToEnd());
        LstVisor.Items.Clear();
        while ((l=archivo.ReadLine())!= null)
        {
          LstVisor.Items.Add(l);
          //MessageBox.Show(l);
        }
        archivo.Close();
      }
      catch (Exception f)
      {
        MessageBox.Show(f.Message);
      }
    }

    private void BtnBuscar_Click(object sender, EventArgs e)
    {
      
      try
      {
        if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
        {
          
          MessageBox.Show(this.openFileDialog1.FileName);
        }
      }
      catch (Exception f)
      {
        MessageBox.Show(f.Message);
      }
    }
  }
}
