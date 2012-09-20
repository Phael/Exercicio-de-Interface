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

        public void Adicionar(string TIPO_GENERO)
        {
            Filmes Filme = new Filmes();
            Dictionary<string, List<Filmes>> DICIONARIO = new Dictionary<string, List<Filmes>>();
            List<Filmes> LISTA_FILMES = new List<Filmes>();
            ListViewItem LISTA_VIEW = new ListViewItem();

            if ((textBox_Nome.Text != string.Empty) && (comboBox_Genero.Text != string.Empty) && (textBox_Local.Text != string.Empty))
            {
                //Adiciona o FIlme a Lista e ao Dicionario
                Filme.NOME_FILME = textBox_Nome.Text;
                Filme.GENERO = comboBox_Genero.Text;
                Filme.LOCAL = textBox_Local.Text;
                Filme.DATA = dateTimePicker_Data.Value.ToString();
                LISTA_FILMES.Add(Filme);
                DICIONARIO.Add("Rafael", LISTA_FILMES);

                //Adiciona valores no lisView_roll
                LISTA_VIEW.Text = Filme.NOME_FILME;
                LISTA_VIEW.SubItems.Add(Filme.GENERO);
                LISTA_VIEW.SubItems.Add(Filme.LOCAL);
                LISTA_VIEW.SubItems.Add(Filme.DATA);
                LISTA_VIEW.Group = listView_roll.Groups[TIPO_GENERO];
                listView_roll.Items.Add(LISTA_VIEW);

                //Limpar();
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos", "Campos Nao Preenchidos", MessageBoxButtons.OK);
            }
        }

        public void INSERIR()
        {
            string TIPO_GENERO = comboBox_Genero.Text;

            if (TIPO_GENERO == comboBox_Genero.Text)
            {
                Adicionar(TIPO_GENERO);
            }
            else
                MessageBox.Show("Insira um Genero Valido", "Erro", MessageBoxButtons.OK);

        }

           
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
            INSERIR();
            
            
            //Filmes Filme = new Filmes();
            //Dictionary<string, List<Filmes>> DICIONARIO = new Dictionary<string, List<Filmes>>();
            //List<Filmes> LISTA_FILMES = new List<Filmes>();
            //ListViewItem LISTA_VIEW = new ListViewItem();

            //if ((textBox_Nome.Text != string.Empty) && (comboBox_Genero.Text != string.Empty) && (textBox_Local.Text != string.Empty))
            //{
            //    //Adiciona o FIlme a Lista e ao Dicionario
            //    Filme.NOME_FILME = textBox_Nome.Text;
            //    Filme.GENERO = comboBox_Genero.Text;
            //    Filme.LOCAL = textBox_Local.Text;
            //    Filme.DATA = dateTimePicker_Data.Value.ToString();
            //    LISTA_FILMES.Add(Filme);
            //    DICIONARIO.Add("Rafael", LISTA_FILMES);

            //    //Adiciona valores no lisView_roll
            //    LISTA_VIEW.Text = Filme.NOME_FILME;
            //    LISTA_VIEW.SubItems.Add(Filme.GENERO);
            //    LISTA_VIEW.SubItems.Add(Filme.LOCAL);
            //    LISTA_VIEW.SubItems.Add(Filme.DATA);
            //    listView_roll.Items.Add(LISTA_VIEW);

            //    Limpar();
            //}
            //else
            //{
            //    MessageBox.Show("Preencha todos os Campos", "Campos Nao Preenchidos", MessageBoxButtons.OK);
            //}

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

