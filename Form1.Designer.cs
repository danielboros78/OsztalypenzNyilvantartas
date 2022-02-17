
namespace OsztalypenzNyilvantartas
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.lbAllapot = new System.Windows.Forms.ListBox();
      this.btnAllapotMentes = new System.Windows.Forms.Button();
      this.btnAllapotBetoltes = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.rbKifizetes = new System.Windows.Forms.RadioButton();
      this.rbBefizetes = new System.Windows.Forms.RadioButton();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblEgyenleg = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tbNev = new System.Windows.Forms.TextBox();
      this.tbOsszeg = new System.Windows.Forms.TextBox();
      this.dtpDatum = new System.Windows.Forms.DateTimePicker();
      this.tIdozito = new System.Windows.Forms.Timer(this.components);
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(94, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tranzakciók:";
      // 
      // lbAllapot
      // 
      this.lbAllapot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbAllapot.FormattingEnabled = true;
      this.lbAllapot.Location = new System.Drawing.Point(15, 30);
      this.lbAllapot.Name = "lbAllapot";
      this.lbAllapot.Size = new System.Drawing.Size(443, 316);
      this.lbAllapot.TabIndex = 1;
      // 
      // btnAllapotMentes
      // 
      this.btnAllapotMentes.Location = new System.Drawing.Point(15, 382);
      this.btnAllapotMentes.Name = "btnAllapotMentes";
      this.btnAllapotMentes.Size = new System.Drawing.Size(443, 39);
      this.btnAllapotMentes.TabIndex = 2;
      this.btnAllapotMentes.Text = "Állapot mentése";
      this.btnAllapotMentes.UseVisualStyleBackColor = true;
      this.btnAllapotMentes.Click += new System.EventHandler(this.btnAllapotMentes_Click);
      // 
      // btnAllapotBetoltes
      // 
      this.btnAllapotBetoltes.Location = new System.Drawing.Point(15, 433);
      this.btnAllapotBetoltes.Name = "btnAllapotBetoltes";
      this.btnAllapotBetoltes.Size = new System.Drawing.Size(443, 39);
      this.btnAllapotBetoltes.TabIndex = 3;
      this.btnAllapotBetoltes.Text = "Állapot betöltése";
      this.btnAllapotBetoltes.UseVisualStyleBackColor = true;
      this.btnAllapotBetoltes.Click += new System.EventHandler(this.btnAllapotBetoltes_Click);
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.rbKifizetes);
      this.panel1.Controls.Add(this.rbBefizetes);
      this.panel1.Location = new System.Drawing.Point(467, 30);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(204, 119);
      this.panel1.TabIndex = 4;
      // 
      // rbKifizetes
      // 
      this.rbKifizetes.AutoSize = true;
      this.rbKifizetes.Location = new System.Drawing.Point(39, 56);
      this.rbKifizetes.Name = "rbKifizetes";
      this.rbKifizetes.Size = new System.Drawing.Size(82, 22);
      this.rbKifizetes.TabIndex = 1;
      this.rbKifizetes.Text = "Kifizetés";
      this.rbKifizetes.UseVisualStyleBackColor = true;
      // 
      // rbBefizetes
      // 
      this.rbBefizetes.AutoSize = true;
      this.rbBefizetes.Checked = true;
      this.rbBefizetes.Location = new System.Drawing.Point(39, 18);
      this.rbBefizetes.Name = "rbBefizetes";
      this.rbBefizetes.Size = new System.Drawing.Size(87, 22);
      this.rbBefizetes.TabIndex = 0;
      this.rbBefizetes.TabStop = true;
      this.rbBefizetes.Text = "Befizetés";
      this.rbBefizetes.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(464, 176);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 18);
      this.label2.TabIndex = 5;
      this.label2.Text = "Név:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(464, 237);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 18);
      this.label3.TabIndex = 6;
      this.label3.Text = "Összeg:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(464, 293);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(52, 18);
      this.label4.TabIndex = 7;
      this.label4.Text = "Dátum";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(541, 382);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(72, 18);
      this.label5.TabIndex = 8;
      this.label5.Text = "Egyenleg:";
      // 
      // lblEgyenleg
      // 
      this.lblEgyenleg.AutoSize = true;
      this.lblEgyenleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEgyenleg.Location = new System.Drawing.Point(526, 419);
      this.lblEgyenleg.Name = "lblEgyenleg";
      this.lblEgyenleg.Size = new System.Drawing.Size(98, 31);
      this.lblEgyenleg.TabIndex = 9;
      this.lblEgyenleg.Text = "xxxx Ft";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(494, 19);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(142, 18);
      this.label6.TabIndex = 10;
      this.label6.Text = "Új tranzakció típusa:";
      // 
      // tbNev
      // 
      this.tbNev.Location = new System.Drawing.Point(467, 197);
      this.tbNev.Name = "tbNev";
      this.tbNev.Size = new System.Drawing.Size(204, 24);
      this.tbNev.TabIndex = 11;
      // 
      // tbOsszeg
      // 
      this.tbOsszeg.Location = new System.Drawing.Point(467, 258);
      this.tbOsszeg.Name = "tbOsszeg";
      this.tbOsszeg.Size = new System.Drawing.Size(204, 24);
      this.tbOsszeg.TabIndex = 12;
      // 
      // dtpDatum
      // 
      this.dtpDatum.Location = new System.Drawing.Point(467, 327);
      this.dtpDatum.Name = "dtpDatum";
      this.dtpDatum.Size = new System.Drawing.Size(204, 24);
      this.dtpDatum.TabIndex = 13;
      // 
      // tIdozito
      // 
      this.tIdozito.Enabled = true;
      this.tIdozito.Tick += new System.EventHandler(this.tIdozito_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(683, 492);
      this.Controls.Add(this.dtpDatum);
      this.Controls.Add(this.tbOsszeg);
      this.Controls.Add(this.tbNev);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.lblEgyenleg);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.btnAllapotBetoltes);
      this.Controls.Add(this.btnAllapotMentes);
      this.Controls.Add(this.lbAllapot);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Osztálypénz nyilvántartása";
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox lbAllapot;
    private System.Windows.Forms.Button btnAllapotMentes;
    private System.Windows.Forms.Button btnAllapotBetoltes;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.RadioButton rbKifizetes;
    private System.Windows.Forms.RadioButton rbBefizetes;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblEgyenleg;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbNev;
    private System.Windows.Forms.TextBox tbOsszeg;
    private System.Windows.Forms.DateTimePicker dtpDatum;
    private System.Windows.Forms.Timer tIdozito;
  }
}

