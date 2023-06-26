// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp2.Form5
// Assembly: WindowsFormsApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D7D2246A-9B6F-4433-9685-422A7D5D940A
// Assembly location: C:\Users\Administrator\Downloads\Hesap_Makinesi.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public class Form5 : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private Button button2;
    private Button button3;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBox1;
    private Button button4;

    public Form5() => this.InitializeComponent();

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void button4_Click(object sender, EventArgs e) => this.Close();

    private void button1_Click(object sender, EventArgs e) => this.label3.Text = Convert.ToString(Math.Sin(Math.PI * Convert.ToDouble(this.textBox1.Text) / 180.0));

    private void button2_Click(object sender, EventArgs e) => this.label3.Text = Convert.ToString(Math.Cos(Math.PI * Convert.ToDouble(this.textBox1.Text) / 180.0));

    private void button3_Click(object sender, EventArgs e) => this.label3.Text = Convert.ToString(Math.Tan(Math.PI * Convert.ToDouble(this.textBox1.Text) / 180.0));

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
      this.button3 = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.textBox1 = new TextBox();
      this.button4 = new Button();
      this.SuspendLayout();
      this.button1.Location = new Point(15, 218);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Sinüs";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(112, 218);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Kosinüs";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.Location = new Point(207, 218);
      this.button3.Name = "button3";
      this.button3.Size = new Size(75, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "Tanjant";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(40, 64);
      this.label1.Name = "label1";
      this.label1.Size = new Size(68, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Açııyı Giriniz ;";
      this.label2.AutoSize = true;
      this.label2.ForeColor = Color.Red;
      this.label2.Location = new Point(40, 152);
      this.label2.Name = "label2";
      this.label2.Size = new Size(50, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Sonuç = ";
      this.label2.Click += new EventHandler(this.label2_Click);
      this.label3.AutoSize = true;
      this.label3.ForeColor = Color.Red;
      this.label3.Location = new Point(165, 152);
      this.label3.Name = "label3";
      this.label3.Size = new Size(0, 13);
      this.label3.TabIndex = 5;
      this.label3.Click += new EventHandler(this.label3_Click);
      this.textBox1.Location = new Point(143, 61);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 20);
      this.textBox1.TabIndex = 6;
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.button4.Location = new Point(112, 12);
      this.button4.Name = "button4";
      this.button4.Size = new Size(75, 23);
      this.button4.TabIndex = 7;
      this.button4.Text = "Çıkış";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Cyan;
      this.ClientSize = new Size(297, 279);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Name = nameof (Form5);
      this.Text = "Trigonometri";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
