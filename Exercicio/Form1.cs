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
        public Form_Principal()
        {
            Dictionary<string, List<string>> DICIONARIO = new Dictionary<string, List<string>>();
            InitializeComponent();
        }



        public void Limpar()
        {
            textBox_Nome.Text = string.Empty;
            comboBox_Genero.Text = string.Empty;
            textBox_Local.Text = string.Empty;

        }

        //Metodo para a criaçao do roll de filmes
        //public string Adicionar_Roll()
        //{
            
        
        //}        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        public void comboBox_Genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button_Adicionar_Click(object sender, EventArgs e)
        {
            Filmes Filme = new Filmes();
            Dictionary<string, List<Filmes>> DICIONARIO = new Dictionary<string, List<Filmes>>();
            List<Filmes> LISTA = new List<Filmes>();
            ListViewItem LIST = new ListViewItem();

            if ((textBox_Nome.Text != string.Empty) && (comboBox_Genero.Text != string.Empty) && (textBox_Local.Text != string.Empty))
            {
                //Adiciona o FIlme a Lista e ao Dicionario
                Filme.NOME_FILME = textBox_Nome.Text;
                Filme.GENERO = comboBox_Genero.Text;
                Filme.LOCAL = textBox_Local.Text;
                Filme.DATA = dateTimePicker_Data.Value.ToString();
                LISTA.Add(Filme);
                DICIONARIO.Add("Rafael", LISTA);

                //Adiciona valores no lisView_roll
                LIST.Text = Filme.NOME_FILME;
                LIST.SubItems.Add(Filme.GENERO);
                LIST.SubItems.Add(Filme.LOCAL);
                LIST.SubItems.Add(Filme.DATA);
                listView_roll.Items.Add(LIST);
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

    }

}

