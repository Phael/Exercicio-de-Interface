using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

 


namespace Exercicio
{    

    public partial class Form_Principal : Form
    {
        Dictionary<string, List<Filmes>> DICIONARIO = new Dictionary<string, List<Filmes>>();
        List<Filmes> LISTA_FILMES = new List<Filmes>();
        Filmes Filme = new Filmes();
        Filmes REFFILME;

        public Form_Principal()
        {
            InitializeComponent();
        }



        public void Limpar()
        {
            textBox_Nome.Text = string.Empty;
            comboBox_Genero.Text = string.Empty;
            textBox_Local.Text = string.Empty;

        }

        public void Adicionar()
        {
            List<Filmes> LISTA = new List<Filmes>();
            ListViewItem LISTA_VIEW = new ListViewItem();

            if ((textBox_Nome.Text != string.Empty) && (comboBox_Genero.Text != string.Empty) && (textBox_Local.Text != string.Empty))
            {
                   
                //Adiciona o FIlme a Lista e ao Dicionario
                Filme.NOME_FILME = textBox_Nome.Text;
                Filme.GENERO = comboBox_Genero.Text;
                Filme.LOCAL = textBox_Local.Text;
                Filme.DATA = dateTimePicker_Data.Value.ToShortDateString();
                LISTA_FILMES.Add(Filme);

                //Verifica se existe a chave, e adiciona os valores no dicionario
                if(DICIONARIO.ContainsKey(dateTimePicker_Data.Value.ToShortDateString()))
                {
                     List<Filmes> FILMESREF = DICIONARIO[dateTimePicker_Data.Value.ToShortDateString()];
                     LISTA.Add(Filme);

                 }
                 else
                 {
                     DICIONARIO.Add(dateTimePicker_Data.Value.ToShortDateString(), LISTA_FILMES);
                 }
                 
                    //Adiciona valores no lisView_roll
                    LISTA_VIEW.Text = Filme.NOME_FILME;
                    LISTA_VIEW.SubItems.Add(Filme.GENERO);
                    LISTA_VIEW.SubItems.Add(Filme.LOCAL);
                    LISTA_VIEW.SubItems.Add(Filme.DATA);
                    LISTA_VIEW.Group = listView_roll.Groups[comboBox_Genero.Text];
                    listView_roll.Items.Add(LISTA_VIEW);

                    Limpar();
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos", "Campos Nao Preenchidos", MessageBoxButtons.OK);
            }

            

            //foreach (KeyValuePair<string, List<Filmes>> J in DICIONARIO)
            //{
            //    foreach (Filmes JJ in J.Value)
            //    {
            //        MessageBox.Show("" + Filme.NOME_FILME + Filme.LOCAL + Filme.DATA + Filme.GENERO, "" + J.Key, MessageBoxButtons.OK);
            //    }
            //}
        }
        public void comboBox_Genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Genero.DataSource = listView_roll.Groups;
            comboBox_Genero.Text = string.Empty;
        }
        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            Adicionar();
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            Filme.NOME_FILME = textBox_Nome.Text;

            listView_roll.SelectedItems[0].Text = textBox_Nome.Text;
            listView_roll.SelectedItems[0].SubItems[1].Text = comboBox_Genero.Text;
            listView_roll.SelectedItems[0].SubItems[2].Text = textBox_Local.Text;
            listView_roll.SelectedItems[0].SubItems[3].Text = dateTimePicker_Data.Value.ToShortDateString();

            button_Editar.Enabled = false;
            button_Adicionar.Enabled = true;

        }

        private void listView_roll_DoubleClick(object sender, EventArgs e)
        {
            button_Adicionar.Enabled = false;
            button_Editar.Enabled = true;
        }

        private void checkBox__CheckedChanged(object sender, EventArgs e)
        {

        }

    }

}

