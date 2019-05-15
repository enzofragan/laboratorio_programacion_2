namespace clase_15
{
  partial class FrmPrincipal
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
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnTraer = new System.Windows.Forms.Button();
            this.LstVisor = new System.Windows.Forms.ListBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(198, 12);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(111, 23);
            this.BtnEnter.TabIndex = 0;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnTraer
            // 
            this.BtnTraer.Location = new System.Drawing.Point(12, 165);
            this.BtnTraer.Name = "BtnTraer";
            this.BtnTraer.Size = new System.Drawing.Size(128, 23);
            this.BtnTraer.TabIndex = 1;
            this.BtnTraer.Text = "Traer";
            this.BtnTraer.UseVisualStyleBackColor = true;
            // 
            // LstVisor
            // 
            this.LstVisor.FormattingEnabled = true;
            this.LstVisor.Location = new System.Drawing.Point(12, 38);
            this.LstVisor.Name = "LstVisor";
            this.LstVisor.Size = new System.Drawing.Size(297, 121);
            this.LstVisor.TabIndex = 2;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(12, 12);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(180, 20);
            this.TxtValor.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 199);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.LstVisor);
            this.Controls.Add(this.BtnTraer);
            this.Controls.Add(this.BtnEnter);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnEnter;
    private System.Windows.Forms.Button BtnTraer;
    private System.Windows.Forms.ListBox LstVisor;
    private System.Windows.Forms.TextBox TxtValor;
  }
}

