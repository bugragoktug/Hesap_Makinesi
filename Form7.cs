// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp2.Form7
// Assembly: WindowsFormsApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D7D2246A-9B6F-4433-9685-422A7D5D940A
// Assembly location: C:\Users\Administrator\Downloads\Hesap_Makinesi.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public class Form7 : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;

    public Form7() => this.InitializeComponent();

    private void button4_Click(object sender, EventArgs e) => new Form17().Show();

    private void button5_Click(object sender, EventArgs e) => this.Close();

    private void button1_Click(object sender, EventArgs e) => new Form14().Show();

    private void button2_Click(object sender, EventArgs e) => new Form15().Show();

    private void button3_Click(object sender, EventArgs e) => new Form16().Show();

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
      this.SuspendLayout();
      this.button1.Location = new Point(12, 74);
      this.button1.Name = "button1";
      this.button1.Size = new Size(124, 42);
      this.button1.TabIndex = 0;
      this.button1.Text = "Daire Alan Hesaplayıcıyı Aç";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(168, 74);
      this.button2.Name = "button2";
      this.button2.Size = new Size(124, 42);
      this.button2.TabIndex = 1;
      this.button2.Text = "Dikdörtgen Alan Hesaplayıcıyı Aç";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.Location = new Point(12, 154);
      this.button3.Name = "button3";
      this.button3.Size = new Size(124, 42);
      this.button3.TabIndex = 2;
      this.button3.Text = "Üçgen Alan Hesaplayıcıyı Aç";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.Location = new Point(168, 154);
      this.button4.Name = "button4";
      this.button4.Size = new Size(124, 42);
      this.button4.TabIndex = 3;
      this.button4.Text = "Beşgen Alan Hesaplayıcıyı Aç";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button5.Location = new Point(1, 2);
      this.button5.Name = "button5";
      this.button5.Size = new Size(107, 34);
      this.button5.TabIndex = 4;
      this.button5.Text = "Çıkış";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.OrangeRed;
      this.ClientSize = new Size(302, 234);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Name = nameof (Form7);
      this.Text = "Çokgen alan hesaplayıcı";
      this.ResumeLayout(false);
    }
  }
}
