namespace Exercicio
{
    partial class Filtrar
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_Genero = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Local = new System.Windows.Forms.Label();
            this.label_ = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_Genero
            // 
            this.label_Genero.AutoSize = true;
            this.label_Genero.Location = new System.Drawing.Point(91, 64);
            this.label_Genero.Name = "label_Genero";
            this.label_Genero.Size = new System.Drawing.Size(53, 13);
            this.label_Genero.TabIndex = 2;
            this.label_Genero.Text = "GENERO";
            this.label_Genero.Click += new System.EventHandler(this.label_Genero_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(237, 80);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(434, 80);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label_Local
            // 
            this.label_Local.AutoSize = true;
            this.label_Local.Location = new System.Drawing.Point(91, 110);
            this.label_Local.Name = "label_Local";
            this.label_Local.Size = new System.Drawing.Size(41, 13);
            this.label_Local.TabIndex = 8;
            this.label_Local.Text = "LOCAL";
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Location = new System.Drawing.Point(91, 171);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(41, 13);
            this.label_.TabIndex = 10;
            this.label_.Text = "LOCAL";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 9;
            // 
            // Filtrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 412);
            this.Controls.Add(this.label_);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_Local);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label_Genero);
            this.Controls.Add(this.comboBox1);
            this.Name = "Filtrar";
            this.Text = "Filtrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_Genero;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Local;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.TextBox textBox2;
    }
}