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
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Ficção Ciêntifica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup17 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup18 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_Genero = new System.Windows.Forms.ComboBox();
            this.textBox_Local = new System.Windows.Forms.TextBox();
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.groupBox_Nome = new System.Windows.Forms.GroupBox();
            this.groupBox_Genero = new System.Windows.Forms.GroupBox();
            this.groupBox_Local = new System.Windows.Forms.GroupBox();
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_Data = new System.Windows.Forms.DateTimePicker();
            this.button_Filtrar = new System.Windows.Forms.Button();
            this.listView_roll = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_apresenta = new System.Windows.Forms.TextBox();
            this.groupBox_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "APAGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Genero
            // 
            this.comboBox_Genero.FormattingEnabled = true;
            this.comboBox_Genero.Location = new System.Drawing.Point(14, 130);
            this.comboBox_Genero.Name = "comboBox_Genero";
            this.comboBox_Genero.Size = new System.Drawing.Size(153, 21);
            this.comboBox_Genero.TabIndex = 2;
            this.comboBox_Genero.SelectedIndexChanged += new System.EventHandler(this.comboBox_Genero_SelectedIndexChanged);
            // 
            // textBox_Local
            // 
            this.textBox_Local.Location = new System.Drawing.Point(13, 188);
            this.textBox_Local.Multiline = true;
            this.textBox_Local.Name = "textBox_Local";
            this.textBox_Local.Size = new System.Drawing.Size(397, 20);
            this.textBox_Local.TabIndex = 3;
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(11, 232);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_Adicionar.TabIndex = 5;
            this.button_Adicionar.Text = "ADICIONAR";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(15, 79);
            this.textBox_Nome.Multiline = true;
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(395, 20);
            this.textBox_Nome.TabIndex = 7;
            // 
            // groupBox_Nome
            // 
            this.groupBox_Nome.Location = new System.Drawing.Point(6, 61);
            this.groupBox_Nome.Name = "groupBox_Nome";
            this.groupBox_Nome.Size = new System.Drawing.Size(410, 46);
            this.groupBox_Nome.TabIndex = 12;
            this.groupBox_Nome.TabStop = false;
            this.groupBox_Nome.Text = "Nome";
            // 
            // groupBox_Genero
            // 
            this.groupBox_Genero.Location = new System.Drawing.Point(6, 113);
            this.groupBox_Genero.Name = "groupBox_Genero";
            this.groupBox_Genero.Size = new System.Drawing.Size(169, 46);
            this.groupBox_Genero.TabIndex = 13;
            this.groupBox_Genero.TabStop = false;
            this.groupBox_Genero.Text = "Genero";
            // 
            // groupBox_Local
            // 
            this.groupBox_Local.Location = new System.Drawing.Point(6, 171);
            this.groupBox_Local.Name = "groupBox_Local";
            this.groupBox_Local.Size = new System.Drawing.Size(410, 46);
            this.groupBox_Local.TabIndex = 14;
            this.groupBox_Local.TabStop = false;
            this.groupBox_Local.Text = "Local";
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.dateTimePicker_Data);
            this.groupBox_Data.Location = new System.Drawing.Point(440, 59);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Size = new System.Drawing.Size(259, 48);
            this.groupBox_Data.TabIndex = 13;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "Data";
            // 
            // dateTimePicker_Data
            // 
            this.dateTimePicker_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Data.Location = new System.Drawing.Point(16, 17);
            this.dateTimePicker_Data.Name = "dateTimePicker_Data";
            this.dateTimePicker_Data.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker_Data.TabIndex = 18;
            // 
            // button_Filtrar
            // 
            this.button_Filtrar.Location = new System.Drawing.Point(173, 232);
            this.button_Filtrar.Name = "button_Filtrar";
            this.button_Filtrar.Size = new System.Drawing.Size(75, 23);
            this.button_Filtrar.TabIndex = 15;
            this.button_Filtrar.Text = "FILTRAR";
            this.button_Filtrar.UseVisualStyleBackColor = true;
            // 
            // listView_roll
            // 
            this.listView_roll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Genero,
            this.Local,
            this.Data});
            listViewGroup10.Header = "Ação";
            listViewGroup10.Name = "Ação";
            listViewGroup11.Header = "Romance";
            listViewGroup11.Name = "Romance";
            listViewGroup12.Header = "Aventura";
            listViewGroup12.Name = "Aventura";
            listViewGroup13.Header = "Infantil";
            listViewGroup13.Name = "Infantil";
            listViewGroup14.Header = "Ficção Ciêntifica";
            listViewGroup14.Name = "Ficção Ciêntifica";
            listViewGroup15.Header = "Documentário";
            listViewGroup15.Name = "Documentário";
            listViewGroup16.Header = "Suspense";
            listViewGroup16.Name = "Suspense";
            listViewGroup17.Header = "Terror";
            listViewGroup17.Name = "Terror";
            listViewGroup18.Header = "Comédia";
            listViewGroup18.Name = "Comédia";
            this.listView_roll.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup10,
            listViewGroup11,
            listViewGroup12,
            listViewGroup13,
            listViewGroup14,
            listViewGroup15,
            listViewGroup16,
            listViewGroup17,
            listViewGroup18});
            this.listView_roll.Location = new System.Drawing.Point(6, 274);
            this.listView_roll.Name = "listView_roll";
            this.listView_roll.Size = new System.Drawing.Size(730, 197);
            this.listView_roll.TabIndex = 16;
            this.listView_roll.UseCompatibleStateImageBehavior = false;
            this.listView_roll.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome Do Filme";
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
            this.Data.Width = 119;
            // 
            // textBox_apresenta
            // 
            this.textBox_apresenta.Location = new System.Drawing.Point(341, 489);
            this.textBox_apresenta.Multiline = true;
            this.textBox_apresenta.Name = "textBox_apresenta";
            this.textBox_apresenta.Size = new System.Drawing.Size(395, 139);
            this.textBox_apresenta.TabIndex = 17;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(761, 680);
            this.Controls.Add(this.textBox_apresenta);
            this.Controls.Add(this.listView_roll);
            this.Controls.Add(this.button_Filtrar);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.button_Adicionar);
            this.Controls.Add(this.textBox_Local);
            this.Controls.Add(this.comboBox_Genero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_Nome);
            this.Controls.Add(this.groupBox_Genero);
            this.Controls.Add(this.groupBox_Local);
            this.Controls.Add(this.groupBox_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Controle de Filmes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Data.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox_Genero;
        private System.Windows.Forms.Button button_Adicionar;
        private System.Windows.Forms.GroupBox groupBox_Nome;
        private System.Windows.Forms.GroupBox groupBox_Genero;
        private System.Windows.Forms.GroupBox groupBox_Local;
        private System.Windows.Forms.GroupBox groupBox_Data;
        private System.Windows.Forms.Button button_Filtrar;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Genero;
        private System.Windows.Forms.ColumnHeader Local;
        private System.Windows.Forms.ColumnHeader Data;
        public System.Windows.Forms.TextBox textBox_Local;
        public System.Windows.Forms.TextBox textBox_Nome;
        public System.Windows.Forms.ListView listView_roll;
        public System.Windows.Forms.TextBox textBox_apresenta;
        public System.Windows.Forms.DateTimePicker dateTimePicker_Data;
    }
}

