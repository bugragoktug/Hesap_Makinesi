// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp2.Form2
// Assembly: WindowsFormsApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D7D2246A-9B6F-4433-9685-422A7D5D940A
// Assembly location: C:\Users\Administrator\Downloads\Hesap_Makinesi.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public class Form2 : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button5;

    public Form2() => this.InitializeComponent();

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e) => this.label4.Text = Convert.ToString(double.Parse(this.textBox1.Text) + double.Parse(this.textBox2.Text));

    private void button2_Click(object sender, EventArgs e) => this.label4.Text = Convert.ToString(double.Parse(this.textBox1.Text) - double.Parse(this.textBox2.Text));

    private void button3_Click(object sender, EventArgs e) => this.label4.Text = Convert.ToString(double.Parse(this.textBox1.Text) * double.Parse(this.textBox2.Text));

    private void button4_Click(object sender, EventArgs e) => this.label4.Text = Convert.ToString(double.Parse(this.textBox1.Text) / double.Parse(this.textBox2.Text));

    private void button5_Click(object sender, EventArgs e) => this.Close();

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
      this.button4 = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.button5 = new Button();
      this.SuspendLayout();
      this.button1.Location = new Point(39, 238);
      this.button1.Name = "button1";
      this.button1.Size = new Size((int) sbyte.MaxValue, 44);
      this.button1.TabIndex = 0;
      this.button1.Text = "Toplama";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(209, 237);
      this.button2.Name = "button2";
      this.button2.Size = new Size(122, 45);
      this.button2.TabIndex = 1;
      this.button2.Text = "Çıkartma";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.Location = new Point(39, 301);
      this.button3.Name = "button3";
      this.button3.Size = new Size((int) sbyte.MaxValue, 44);
      this.button3.TabIndex = 2;
      this.button3.Text = "Çarpma";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.Location = new Point(209, 301);
      this.button4.Name = "button4";
      this.button4.Size = new Size(122, 46);
      this.button4.TabIndex = 3;
      this.button4.Text = "Bölme";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.label1.AutoSize = true;
      this.label1.ForeColor = SystemColors.ControlLightLight;
      this.label1.Location = new Point(51, 70);
      this.label1.Name = "label1";
      this.label1.Size = new Size(39, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "1. Sayı";
      this.label1.Click += new EventHandler(this.label1_Click);
      this.label2.AutoSize = true;
      this.label2.ForeColor = SystemColors.ControlLightLight;
      this.label2.Location = new Point(51, 123);
      this.label2.Name = "label2";
      this.label2.Size = new Size(39, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "2. Sayı";
      this.label3.AutoSize = true;
      this.label3.ForeColor = Color.Red;
      this.label3.Location = new Point(54, 184);
      this.label3.Name = "label3";
      this.label3.Size = new Size(50, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Sonuç = ";
      this.label4.AutoSize = true;
      this.label4.ForeColor = Color.Red;
      this.label4.Location = new Point(156, 184);
      this.label4.Name = "label4";
      this.label4.Size = new Size(16, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "\u200F\u200F\u200F\u200F\u200F\u200F\u200F\u200F   ";
      this.textBox1.Location = new Point(110, 70);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(135, 20);
      this.textBox1.TabIndex = 8;
      this.textBox2.Location = new Point(110, 123);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(135, 20);
      this.textBox2.TabIndex = 9;
      this.button5.Location = new Point(266, 2);
      this.button5.Name = "button5";
      this.button5.Size = new Size(104, 31);
      this.button5.TabIndex = 10;
      this.button5.Text = "Çıkış";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(64, 64, 64);
      this.ClientSize = new Size(372, 393);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Name = nameof (Form2);
      this.Text = "4 İşlem";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
