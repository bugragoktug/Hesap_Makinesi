// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp2.Form8
// Assembly: WindowsFormsApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D7D2246A-9B6F-4433-9685-422A7D5D940A
// Assembly location: C:\Users\Administrator\Downloads\Hesap_Makinesi.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public class Form8 : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBox1;
    private Button button1;
    private Button button2;

    public Form8() => this.InitializeComponent();

    private void button1_Click(object sender, EventArgs e)
    {
      double num1 = Convert.ToDouble(this.textBox1.Text);
      double num2 = 1.0;
      for (int index = 1; (double) index <= num1; ++index)
        num2 *= (double) index;
      this.label3.Text = Convert.ToString(num2);
    }

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
      this.textBox1 = new TextBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 85);
      this.label1.Name = "label1";
      this.label1.Size = new Size(160, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Faktöriyeli alınacak sayıyı giriniz :";
      this.label2.AutoSize = true;
      this.label2.ForeColor = Color.Red;
      this.label2.Location = new Point(43, 150);
      this.label2.Name = "label2";
      this.label2.Size = new Size(47, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Sonuç =";
      this.label3.AutoSize = true;
      this.label3.ForeColor = Color.Red;
      this.label3.Location = new Point(201, 150);
      this.label3.Name = "label3";
      this.label3.Size = new Size(0, 13);
      this.label3.TabIndex = 2;
      this.textBox1.Location = new Point(184, 82);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 20);
      this.textBox1.TabIndex = 3;
      this.button1.Location = new Point(97, 204);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Hesapla";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(97, 12);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 5;
      this.button2.Text = "Çıkış";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.ClientSize = new Size(305, 274);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (Form8);
      this.Text = "Faktöriyel hesaplayıcı";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
