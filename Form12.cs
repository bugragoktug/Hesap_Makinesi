// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp2.Form12
// Assembly: WindowsFormsApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D7D2246A-9B6F-4433-9685-422A7D5D940A
// Assembly location: C:\Users\Administrator\Downloads\Hesap_Makinesi.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public class Form12 : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private Button button1;
    private Button button2;

    public Form12() => this.InitializeComponent();

    private void button2_Click(object sender, EventArgs e) => this.Close();

    private void button1_Click(object sender, EventArgs e) => this.label5.Text = Convert.ToString(5.0 * (Convert.ToDouble(this.textBox1.Text) * Convert.ToDouble(this.textBox2.Text) / 2.0) * Convert.ToDouble(this.textBox3.Text));

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
      this.label5 = new Label();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.textBox3 = new TextBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 72);
      this.label1.Name = "label1";
      this.label1.Size = new Size(202, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Düzgün beşgenin bir kenarının uzunluğu :";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(52, 114);
      this.label2.Name = "label2";
      this.label2.Size = new Size(95, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Yarıçap uzunluğu :";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(74, 157);
      this.label3.Name = "label3";
      this.label3.Size = new Size(59, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Yükseklik :";
      this.label4.AutoSize = true;
      this.label4.ForeColor = Color.Red;
      this.label4.Location = new Point(86, 212);
      this.label4.Name = "label4";
      this.label4.Size = new Size(47, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Sonuç =";
      this.label5.AutoSize = true;
      this.label5.ForeColor = Color.Red;
      this.label5.Location = new Point(233, 212);
      this.label5.Name = "label5";
      this.label5.Size = new Size(0, 13);
      this.label5.TabIndex = 4;
      this.textBox1.Location = new Point(220, 69);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 20);
      this.textBox1.TabIndex = 5;
      this.textBox2.Location = new Point(220, 107);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(100, 20);
      this.textBox2.TabIndex = 6;
      this.textBox3.Location = new Point(220, 154);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(100, 20);
      this.textBox3.TabIndex = 7;
      this.button1.Location = new Point(119, 251);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 8;
      this.button1.Text = "Hesapla";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(12, 12);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 9;
      this.button2.Text = "Çıkış";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.DarkGray;
      this.ClientSize = new Size(345, 329);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox3);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (Form12);
      this.Text = "Beşgen prizma alan";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
