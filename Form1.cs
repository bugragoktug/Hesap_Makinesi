// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp2.Form1
// Assembly: WindowsFormsApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D7D2246A-9B6F-4433-9685-422A7D5D940A
// Assembly location: C:\Users\Administrator\Downloads\Hesap_Makinesi.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;

    public Form1() => this.InitializeComponent();

    private void button7_Click(object sender, EventArgs e) => new Form7().Show();

    private void button1_Click(object sender, EventArgs e) => new Form2().Show();

    private void button2_Click(object sender, EventArgs e) => new Form3().Show();

    private void button3_Click(object sender, EventArgs e) => new Form4().Show();

    private void button6_Click(object sender, EventArgs e) => new Form5().Show();

    private void button8_Click(object sender, EventArgs e) => new Form6().Show();

    private void button4_Click(object sender, EventArgs e) => new Form8().Show();

    private void button5_Click(object sender, EventArgs e) => new Form9().Show();

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
      this.button5 = new Button();
      this.button6 = new Button();
      this.button7 = new Button();
      this.button8 = new Button();
      this.SuspendLayout();
      this.button1.Location = new Point(214, 34);
      this.button1.Name = "button1";
      this.button1.Size = new Size(154, 46);
      this.button1.TabIndex = 0;
      this.button1.Text = "4 İşlem sayfasını aç";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(417, 34);
      this.button2.Name = "button2";
      this.button2.Size = new Size(154, 48);
      this.button2.TabIndex = 1;
      this.button2.Text = "Kuvvet hesaplama sayfasını aç";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.Location = new Point(213, 122);
      this.button3.Name = "button3";
      this.button3.Size = new Size(154, 52);
      this.button3.TabIndex = 2;
      this.button3.Text = "Karekök hesaplama sayfasını aç";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.Location = new Point(214, 303);
      this.button4.Name = "button4";
      this.button4.Size = new Size(153, 52);
      this.button4.TabIndex = 3;
      this.button4.Text = "Faktöriyel hesaplama sayfasını aç";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button5.Location = new Point(417, 303);
      this.button5.Name = "button5";
      this.button5.Size = new Size(151, 52);
      this.button5.TabIndex = 4;
      this.button5.Text = "Logaritma hesaplama sayfasını aç";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button6.Location = new Point(417, 123);
      this.button6.Name = "button6";
      this.button6.Size = new Size(153, 50);
      this.button6.TabIndex = 5;
      this.button6.Text = "Trigonometri sayfasını aç";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.button7.Location = new Point(417, 211);
      this.button7.Name = "button7";
      this.button7.Size = new Size(151, 53);
      this.button7.TabIndex = 6;
      this.button7.Text = "Çokgenlerin(ve çemberin) alanını hesaplama sayfasını aç";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.button8.Location = new Point(214, 211);
      this.button8.Name = "button8";
      this.button8.Size = new Size(150, 54);
      this.button8.TabIndex = 7;
      this.button8.Text = "Bazı prizmaların alanını hesaplama sayfasını aç";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.ClientSize = new Size(800, 450);
      this.Controls.Add((Control) this.button8);
      this.Controls.Add((Control) this.button7);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Name = nameof (Form1);
      this.Text = "Hesap Makinesi";
      this.ResumeLayout(false);
    }
  }
}
