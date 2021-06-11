
namespace Deneme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeger = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pdil :";
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Location = new System.Drawing.Point(70, 127);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(58, 13);
            this.lblDeger.TabIndex = 1;
            this.lblDeger.Text = ".................";
            this.lblDeger.Click += new System.EventHandler(this.lblDeger_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Java",
            "Python",
            "Dart"});
            this.comboBox1.Location = new System.Drawing.Point(73, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(73, 68);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(121, 23);
            this.btnGoster.TabIndex = 3;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 213);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGoster;
    }
}

