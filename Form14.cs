// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp2.Form14
// Assembly: WindowsFormsApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D7D2246A-9B6F-4433-9685-422A7D5D940A
// Assembly location: C:\Users\Administrator\Downloads\Hesap_Makinesi.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public class Form14 : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox textBox1;
    private Button button1;
    private Button button2;

    public Form14() => this.InitializeComponent();

    private void label4_Click(object sender, EventArgs e)
    {
    }

    private void Form14_Load(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e) => this.Close();

    private void button1_Click(object sender, EventArgs e)
    {
      double num = Convert.ToDouble(this.textBox1.Text);
      this.label3.Text = Convert.ToString(num * num * 3.14);
    }

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
      this.button1 = new Button();
      this.button2 = new Button();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(24, 75);
      this.label1.Name = "label1";
      this.label1.Size = new Size(128, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Dairenin yarıçapını giriniz :";
      this.label1.Click += new EventHandler(this.label1_Click);
      this.label2.AutoSize = true;
      this.label2.ForeColor = Color.Red;
      this.label2.Location = new Point(59, 123);
      this.label2.Name = "label2";
      this.label2.Size = new Size(50, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Sonuç = ";
      this.label3.AutoSize = true;
      this.label3.ForeColor = Color.Red;
      this.label3.Location = new Point(210, 123);
      this.label3.Name = "label3";
      this.label3.Size = new Size(0, 13);
      this.label3.TabIndex = 2;
      this.label4.AutoSize = true;
      this.label4.BackColor = Color.Red;
      this.label4.Location = new Point(24, 9);
      this.label4.Name = "label4";
      this.label4.Size = new Size(137, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Pi=3.14 alınarak hesaplandı";
      this.label4.Click += new EventHandler(this.label4_Click);
      this.textBox1.Location = new Point(175, 72);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 20);
      this.textBox1.TabIndex = 4;
      this.button1.Location = new Point(99, 197);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Hesapla";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(184, 4);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 6;
      this.button2.Text = "Çıkış";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Silver;
      this.ClientSize = new Size(280, 251);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (Form14);
      this.Text = "Daire alan hesaplayıcı";
      this.Load += new EventHandler(this.Form14_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
