// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp2.Form6
// Assembly: WindowsFormsApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D7D2246A-9B6F-4433-9685-422A7D5D940A
// Assembly location: C:\Users\Administrator\Downloads\Hesap_Makinesi.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public class Form6 : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;

    public Form6() => this.InitializeComponent();

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void button5_Click(object sender, EventArgs e) => this.Close();

    private void button3_Click(object sender, EventArgs e) => new Form10().Show();

    private void button4_Click(object sender, EventArgs e) => new Form11().Show();

    private void button2_Click(object sender, EventArgs e) => new Form12().Show();

    private void button1_Click(object sender, EventArgs e) => new Form13().Show();

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
      this.button1.Location = new Point(235, 218);
      this.button1.Name = "button1";
      this.button1.Size = new Size(116, 51);
      this.button1.TabIndex = 0;
      this.button1.Text = "Üçgenler Prizması Hacim Hesaplayıcıyı Aç";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(73, 218);
      this.button2.Name = "button2";
      this.button2.Size = new Size(114, 51);
      this.button2.TabIndex = 1;
      this.button2.Text = "Beşgenler Prizması Hacim Hesaplayıcıyı  Aç";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.Location = new Point(73, 125);
      this.button3.Name = "button3";
      this.button3.Size = new Size(114, 48);
      this.button3.TabIndex = 2;
      this.button3.Text = "Silindir Hacim Hesaplayıcıyı Aç";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.Location = new Point(235, 125);
      this.button4.Name = "button4";
      this.button4.Size = new Size(116, 48);
      this.button4.TabIndex = 3;
      this.button4.Text = "Dikdörtgenler Prizması Hacim Hesaplayıcıyı Aç";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button5.Location = new Point(172, 12);
      this.button5.Name = "button5";
      this.button5.Size = new Size(75, 23);
      this.button5.TabIndex = 10;
      this.button5.Text = "Çıkış";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Cyan;
      this.ClientSize = new Size(437, 356);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Name = nameof (Form6);
      this.Text = "Prizma Hacim Hesaplayıcı";
      this.ResumeLayout(false);
    }
  }
}
