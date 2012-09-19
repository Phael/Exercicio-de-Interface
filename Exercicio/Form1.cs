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
        public void Adicionar_Roll()
        {
            ListViewItem LISTA = new ListViewItem();
            
            if ((textBox_Nome.Text != string.Empty) && (comboBox_Genero.Text != string.Empty) && (textBox_Local.Text != string.Empty))
            {
                //Adiciona valores no lisView_roll
                LISTA.Text = textBox_Nome.Text;
                LISTA.SubItems.Add(comboBox_Genero.Text);
                LISTA.SubItems.Add(textBox_Local.Text);
                LISTA.SubItems.Add(dateTimePicker_Data.Value.ToString());
                listView_roll.Items.Add(LISTA); 
                Limpar();
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos", "Campos Nao Preenchidos", MessageBoxButtons.OK);
            }
            
        
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
            Filme Filmes = new Filme();

            Dictionary<string, List<Filme>> DICIONARIO = new Dictionary<string, List<Filme>>();
  
            List<Filme> LISTA = new List<Filme>();

            Filmes.NOME_FILME = textBox_Nome.Text;
            Filmes.GENERO = comboBox_Genero.Text;
            Filmes.LOCAL = textBox_Local.Text;
            Filmes.DATA = dateTimePicker_Data.Value.ToString();

            LISTA.Add(Filmes);
            DICIONARIO.Add("Rafael", LISTA);

            foreach (KeyValuePair<string, List<Filme>> J in DICIONARIO)
            {
                foreach (Filme JJ in J.Value)
                {
                    MessageBox.Show("" + Filmes.NOME_FILME + Filmes.LOCAL + Filmes.DATA + Filmes.GENERO, "" + J.Key, MessageBoxButtons.OK);
                }
            }
           
            Adicionar_Roll();
        
        }

    }

}

