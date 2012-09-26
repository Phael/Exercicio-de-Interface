namespace Exercicio
{
    partial class Form_Principal
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Ficção Ciêntifica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_Data = new System.Windows.Forms.DateTimePicker();
            this.groupBox_Genero = new System.Windows.Forms.GroupBox();
            this.comboBox_Genero = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Nome = new System.Windows.Forms.GroupBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.button_Editar = new System.Windows.Forms.Button();
            this.groupBox_Local = new System.Windows.Forms.GroupBox();
            this.textBox_Local = new System.Windows.Forms.TextBox();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_roll = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.groupBox_Genero.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Nome.SuspendLayout();
            this.groupBox_Local.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_Data);
            this.tabPage1.Controls.Add(this.groupBox_Genero);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox_Nome);
            this.tabPage1.Controls.Add(this.button_Adicionar);
            this.tabPage1.Controls.Add(this.button_Editar);
            this.tabPage1.Controls.Add(this.groupBox_Local);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Data.Controls.Add(this.dateTimePicker_Data);
            this.groupBox_Data.Location = new System.Drawing.Point(535, 27);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Size = new System.Drawing.Size(248, 46);
            this.groupBox_Data.TabIndex = 49;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "Data";
            // 
            // dateTimePicker_Data
            // 
            this.dateTimePicker_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Data.Location = new System.Drawing.Point(8, 17);
            this.dateTimePicker_Data.Name = "dateTimePicker_Data";
            this.dateTimePicker_Data.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker_Data.TabIndex = 18;
            // 
            // groupBox_Genero
            // 
            this.groupBox_Genero.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Genero.Controls.Add(this.comboBox_Genero);
            this.groupBox_Genero.Location = new System.Drawing.Point(25, 79);
            this.groupBox_Genero.Name = "groupBox_Genero";
            this.groupBox_Genero.Size = new System.Drawing.Size(177, 52);
            this.groupBox_Genero.TabIndex = 48;
            this.groupBox_Genero.TabStop = false;
            this.groupBox_Genero.Text = "Genero";
            // 
            // comboBox_Genero
            // 
            this.comboBox_Genero.FormattingEnabled = true;
            this.comboBox_Genero.Location = new System.Drawing.Point(8, 18);
            this.comboBox_Genero.Name = "comboBox_Genero";
            this.comboBox_Genero.Size = new System.Drawing.Size(155, 21);
            this.comboBox_Genero.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_roll);
            this.groupBox1.Location = new System.Drawing.Point(27, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 267);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roll de Filmes";
            // 
            // groupBox_Nome
            // 
            this.groupBox_Nome.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Nome.Controls.Add(this.textBox_Nome);
            this.groupBox_Nome.Location = new System.Drawing.Point(24, 27);
            this.groupBox_Nome.Name = "groupBox_Nome";
            this.groupBox_Nome.Size = new System.Drawing.Size(436, 46);
            this.groupBox_Nome.TabIndex = 47;
            this.groupBox_Nome.TabStop = false;
            this.groupBox_Nome.Text = "Nome";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(8, 16);
            this.textBox_Nome.Multiline = true;
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(416, 20);
            this.textBox_Nome.TabIndex = 7;
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(26, 200);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_Adicionar.TabIndex = 46;
            this.button_Adicionar.Text = "ADICIONAR";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // button_Editar
            // 
            this.button_Editar.Location = new System.Drawing.Point(107, 200);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(75, 23);
            this.button_Editar.TabIndex = 45;
            this.button_Editar.Text = "EDITAR";
            this.button_Editar.UseVisualStyleBackColor = true;
            // 
            // groupBox_Local
            // 
            this.groupBox_Local.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Local.Controls.Add(this.textBox_Local);
            this.groupBox_Local.Location = new System.Drawing.Point(25, 138);
            this.groupBox_Local.Name = "groupBox_Local";
            this.groupBox_Local.Size = new System.Drawing.Size(407, 46);
            this.groupBox_Local.TabIndex = 50;
            this.groupBox_Local.TabStop = false;
            this.groupBox_Local.Text = "groupBox_Local";
            // 
            // textBox_Local
            // 
            this.textBox_Local.Location = new System.Drawing.Point(9, 17);
            this.textBox_Local.Multiline = true;
            this.textBox_Local.Name = "textBox_Local";
            this.textBox_Local.Size = new System.Drawing.Size(387, 20);
            this.textBox_Local.TabIndex = 20;
            // 
            // Nome
            // 
            this.Nome.Text = "NOME DO FILME";
            this.Nome.Width = 233;
            // 
            // Genero
            // 
            this.Genero.Text = "GENERO";
            this.Genero.Width = 170;
            // 
            // Local
            // 
            this.Local.Text = "LOCAL";
            this.Local.Width = 166;
            // 
            // Data
            // 
            this.Data.Text = "DATA";
            this.Data.Width = 155;
            // 
            // listView_roll
            // 
            this.listView_roll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Genero,
            this.Local,
            this.Data});
            listViewGroup1.Header = "Ação";
            listViewGroup1.Name = "Ação";
            listViewGroup2.Header = "Romance";
            listViewGroup2.Name = "Romance";
            listViewGroup3.Header = "Aventura";
            listViewGroup3.Name = "Aventura";
            listViewGroup4.Header = "Infantil";
            listViewGroup4.Name = "Infantil";
            listViewGroup5.Header = "Ficção Ciêntifica";
            listViewGroup5.Name = "Ficção Ciêntifica";
            listViewGroup6.Header = "Documentário";
            listViewGroup6.Name = "Documentário";
            listViewGroup7.Header = "Suspense";
            listViewGroup7.Name = "Suspense";
            listViewGroup8.Header = "Terror";
            listViewGroup8.Name = "Terror";
            listViewGroup9.Header = "Comédia";
            listViewGroup9.Name = "Comédia";
            this.listView_roll.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9});
            this.listView_roll.Location = new System.Drawing.Point(12, 25);
            this.listView_roll.Name = "listView_roll";
            this.listView_roll.Size = new System.Drawing.Size(730, 226);
            this.listView_roll.TabIndex = 27;
            this.listView_roll.UseCompatibleStateImageBehavior = false;
            this.listView_roll.View = System.Windows.Forms.View.Details;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(808, 557);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Controle de Filmes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Genero.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Nome.ResumeLayout(false);
            this.groupBox_Nome.PerformLayout();
            this.groupBox_Local.ResumeLayout(false);
            this.groupBox_Local.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox_Data;
        public System.Windows.Forms.DateTimePicker dateTimePicker_Data;
        private System.Windows.Forms.GroupBox groupBox_Genero;
        public System.Windows.Forms.ComboBox comboBox_Genero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_Nome;
        public System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button button_Adicionar;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.GroupBox groupBox_Local;
        public System.Windows.Forms.TextBox textBox_Local;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ListView listView_roll;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Genero;
        private System.Windows.Forms.ColumnHeader Local;
        private System.Windows.Forms.ColumnHeader Data;



    }
}

