namespace paletaform
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.lstLista = new System.Windows.Forms.ListBox();
            this.btnMas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(12, 15);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(387, 173);
            this.lstLista.TabIndex = 0;
            // 
            // btnMas
            // 
            this.btnMas.AllowDrop = true;
            this.btnMas.Location = new System.Drawing.Point(134, 225);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(135, 23);
            this.btnMas.TabIndex = 1;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 275);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.lstLista);
            this.Name = "Form1";
            this.Text = "FtmPaleta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lstLista;
    private System.Windows.Forms.Button btnMas;
  }
}

