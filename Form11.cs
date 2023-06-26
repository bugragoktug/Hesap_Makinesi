// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp2.Form11
// Assembly: WindowsFormsApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D7D2246A-9B6F-4433-9685-422A7D5D940A
// Assembly location: C:\Users\Administrator\Downloads\Hesap_Makinesi.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public class Form11 : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;
    private Button button2;
    private Label label5;
    private TextBox textBox3;

    public Form11() => this.InitializeComponent();

    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e) => this.label5.Text = Convert.ToString(Convert.ToDouble(this.textBox1.Text) * Convert.ToDouble(this.textBox2.Text) * Convert.ToDouble(this.textBox3.Text));

    private void button2_Click(object sender, EventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.label5 = new Label();
      this.textBox3 = new TextBox();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(31, 73);
      this.label1.Name = "label1";
      this.label1.Size = new Size(51, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "1.kenarı :";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(31, 117);
      this.label2.Name = "label2";
      this.label2.Size = new Size(51, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "2.kenarı :";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(31, 166);
      this.label3.Name = "label3";
      this.label3.Size = new Size(61, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Yüksekliği :";
      this.label3.Click += new EventHandler(this.label3_Click);
      this.label4.AutoSize = true;
      this.label4.ForeColor = Color.Red;
      this.label4.Location = new Point(31, 236);
      this.label4.Name = "label4";
      this.label4.Size = new Size(47, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Sonuç =";
      this.textBox1.Location = new Point(107, 114);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 20);
      this.textBox1.TabIndex = 4;
      this.textBox2.Location = new Point(107, 70);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(100, 20);
      this.textBox2.TabIndex = 5;
      this.button1.Location = new Point(89, 276);
      this.button1.Name = "button1";
      this.button1.Size = new Size(118, 36);
      this.button1.TabIndex = 6;
      this.button1.Text = "Hesapla";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(12, 12);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 7;
      this.button2.Text = "Çıkış";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label5.AutoSize = true;
      this.label5.ForeColor = Color.Red;
      this.label5.Location = new Point(132, 236);
      this.label5.Name = "label5";
      this.label5.Size = new Size(0, 13);
      this.label5.TabIndex = 8;
      this.textBox3.Location = new Point(107, 166);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(100, 20);
      this.textBox3.TabIndex = 9;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.ClientSize = new Size(301, 364);
      this.Controls.Add((Control) this.textBox3);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (Form11);
      this.Text = "Dikdörtgen prizma hacim";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
