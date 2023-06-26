// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp2.Form9
// Assembly: WindowsFormsApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D7D2246A-9B6F-4433-9685-422A7D5D940A
// Assembly location: C:\Users\Administrator\Downloads\Hesap_Makinesi.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public class Form9 : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private Button button2;
    private TextBox textBox1;
    private Label label1;
    private Label label2;
    private Label label3;

    public Form9() => this.InitializeComponent();

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void button2_Click(object sender, EventArgs e) => this.label3.Text = Convert.ToString(Math.Log(Convert.ToDouble(this.textBox1.Text)));

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.button1 = new Button();
      this.button2 = new Button();
      this.textBox1 = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.SuspendLayout();
      this.button1.Location = new Point(12, 12);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Çıkış";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(64, 234);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Hesapla";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.textBox1.Location = new Point(55, 120);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 20);
      this.textBox1.TabIndex = 2;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 94);
      this.label1.Name = "label1";
      this.label1.Size = new Size(193, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Logaritması hesaplanacak sayıyı giriniz :";
      this.label2.AutoSize = true;
      this.label2.ForeColor = Color.Red;
      this.label2.Location = new Point(12, 175);
      this.label2.Name = "label2";
      this.label2.Size = new Size(47, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Sonuç =";
      this.label3.AutoSize = true;
      this.label3.ForeColor = Color.Red;
      this.label3.Location = new Point(105, 175);
      this.label3.Name = "label3";
      this.label3.Size = new Size(0, 13);
      this.label3.TabIndex = 5;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Lime;
      this.ClientSize = new Size(209, 283);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Name = nameof (Form9);
      this.Text = "Logaritma ";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
