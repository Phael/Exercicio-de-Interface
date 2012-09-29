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
        Dictionary<int, List<Filmes>> DICIONARIO = new Dictionary<int, List<Filmes>>();
        
        public Form_Principal()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            textBox_Nome.ResetText();
            comboBox_Genero.ResetText();
            textBox_Local.ResetText();
            dateTimePicker_Data.ResetText();

        }

        public void Limpar_Filtro()
        {
            textBox_Filtrar_Nome.ResetText();
            comboBox_Filtrar_Genero.ResetText();
            textBox_Local.ResetText();
            dateTimePicker_Filtrar_datainicial.ResetText();
            dateTimePicker_Filtrar_datafilnal.ResetText();
            checkBox_Data.Checked = false;
            checkBox_Nome.Checked = false;
            checkBox_Genero.Checked = false;
            checkBox_Local.Checked = false;
            

        }

        public void Adicionar()
        {
            Filmes Filme = new Filmes();
            ListViewItem LIST_VIEW = new ListViewItem();

            if ((textBox_Nome.Text != string.Empty) && (comboBox_Genero.Text != string.Empty) && (textBox_Local.Text != string.Empty))
            {
                                               
                //Adiciona o FIlme a Lista filmes e ao Dicionario
                Filme.NOME_FILME = textBox_Nome.Text;
                Filme.GENERO = comboBox_Genero.Text;
                Filme.LOCAL = textBox_Local.Text;
                Filme.DATA = dateTimePicker_Data.Value;

                
                //Verifica se existe a chave no dicionario, se houver ele mantem a chave e insere valores na mesma, 
                //se nao houver ele cria uma nova lista e insere no dicionario
                if(DICIONARIO.ContainsKey(comboBox_Genero.SelectedIndex))
                {
                    List<Filmes> LISTAREF = DICIONARIO[comboBox_Genero.SelectedIndex];
                    LISTAREF.Add(Filme);
                }
                else
                {
                    List<Filmes> LISTA = new List<Filmes>();
                    LISTA.Add(Filme);
                    DICIONARIO.Add(comboBox_Genero.SelectedIndex, LISTA);
                }
                
                //Adiciona valores no lisView_roll
                LIST_VIEW.Text = Filme.NOME_FILME;
                LIST_VIEW.SubItems.Add(Filme.GENERO);
                LIST_VIEW.SubItems.Add(Filme.LOCAL);
                LIST_VIEW.SubItems.Add(Filme.DATA.ToShortDateString());
                LIST_VIEW.Group = listView_roll.Groups[comboBox_Genero.Text];
                listView_roll.Items.Add(LIST_VIEW);
                
                //Verificar Valores do Dicionario
                Dictionary<int, List<Filmes>> DIC = DICIONARIO;

                //Limpar();
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos", "Campos Nao Preenchidos", MessageBoxButtons.OK);
            }

        }
        public void comboBox_Genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Genero.DataSource = listView_roll.Groups;
            comboBox_Filtrar_Genero.DataSource = listView_Filtrar.Groups;
   
        }
        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            Adicionar();
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            //List<Filmes> LIST = new List<Filmes>();

            string NOME_FILME = listView_roll.SelectedItems[0].Text;
            string GENERO_FILME = listView_roll.SelectedItems[0].SubItems[1].Text;
            string LOCAL_FILME = listView_roll.SelectedItems[0].SubItems[2].Text;            
            string DATA_FILME = listView_roll.SelectedItems[0].SubItems[3].Text;

            //foreach (KeyValuePair<int, List<Filmes>> DIC in DICIONARIO)
            //{
            //    foreach (Filmes VALORES in DIC.Value)
            //    {
            //        LIST.Add(VALORES);
            //    }
            //}

            //for(int I=0; I < DICIONARIO.Count;++I)
            //{
            //    for(int J=0; J < DICIONARIO.Values.Count;++J)
            //    {
            //        if(VALOR.NOME_FILME == NOME_FILME)
            //        {
            //        }
            //    }
                    
            //}
            //foreach(KeyValuePair<int, List<Filmes>>  ALTERARDICIONARIO in DICIONARIO ) 
            //{
            //    foreach(Filmes ALTERARFILME in ALTERARDICIONARIO.Value)
            //    {
            //        if (NOME_FILME == ALTERARFILME.NOME_FILME && GENERO_FILME == ALTERARFILME.GENERO && LOCAL_FILME == ALTERARFILME.LOCAL && DATA_FILME == ALTERARFILME.DATA.ToShortDateString())
            //        {
            //            ALTERARFILME.NOME_FILME = textBox_Nome.Text;
            //            ALTERARFILME.LOCAL = textBox_Local.Text;
            //            ALTERARFILME.GENERO = comboBox_Genero.Text;
            //            ALTERARFILME.LOCAL = textBox_Local.Text;
            //            if (DICIONARIO.ContainsKey(comboBox_Genero.SelectedIndex))
            //            {
            //                List<Filmes> LISTAREF = DICIONARIO[comboBox_Genero.SelectedIndex];
            //                LISTAREF.Add(ALTERARFILME);

            //            }
            //            else
            //            {
            //                List<Filmes> LISTA = new List<Filmes>();
            //                LISTA.Add(ALTERARFILME);
            //                DICIONARIO.Add(comboBox_Genero.SelectedIndex, LISTA);
            //            }

            //        }
            //    }
                
            // }

            //listView_roll.SelectedItems[0].Remove();

            //ListViewItem NOVA = new ListViewItem();
            //NOVA.Text = textBox_Nome.Text;
            //NOVA.SubItems.Add(comboBox_Genero.Text);
            //NOVA.SubItems.Add(textBox_Local.Text);
            //NOVA.SubItems.Add(dateTimePicker_Data.Value.ToShortDateString());
            //NOVA.Group = listView_roll.Groups[comboBox_Genero.Text];
            //listView_roll.Items.Add(NOVA);

            //verificação de inserção de valores
            //Dictionary<int, List<Filmes>> DIC = DICIONARIO;            

            //button_Editar.Enabled = false;
            //button_Adicionar.Enabled = true;

            //Limpar();



        }

        private void listView_roll_DoubleClick(object sender, EventArgs e)
        {
            //Carrega os textos do list_view_roll para os seus determinados texbox para alteração
            textBox_Nome.Text = listView_roll.SelectedItems[0].Text;
            comboBox_Genero.Text = listView_roll.SelectedItems[0].SubItems[1].Text;
            textBox_Local.Text = listView_roll.SelectedItems[0].SubItems[2].Text;
            dateTimePicker_Data.Text = listView_roll.SelectedItems[0].SubItems[3].Text;
            

            button_Adicionar.Enabled = false;
            button_Editar.Enabled = true;
        }
        private void button_Filtrar_Click(object sender, EventArgs e)
        {
            List<Filmes> LIST = new List<Filmes>();

            //Adiciona os Valores Da Lista do Dicionario nos valores de uma nova lista chamada LIST
            foreach (KeyValuePair<int, List<Filmes>> DIC in DICIONARIO)
            {
                foreach (Filmes VALORES in DIC.Value)
                {
                    LIST.Add(VALORES);
                }
            }

            //Verifica se o LIST nao esta vazio
            if (LIST.Count != 0)
            {
                foreach (KeyValuePair<int, List<Filmes>> PESQUISA in DICIONARIO)
                {
                    foreach (Filmes FILME in PESQUISA.Value)
                    {
                        
                        //Sequencia de Condiçoes para verificar as pesquisas selecionadas
                        if (FILME.NOME_FILME != textBox_Filtrar_Nome.Text && checkBox_Nome.Checked == true)
                        {
                            //Toda condição verdadeira remove os itens desnecessarios do LIST, ate ser encontrado apenas 
                            //os valores selecionados pelo usuario
                            LIST.Remove(FILME);
                        }
                        if (FILME.GENERO != comboBox_Filtrar_Genero.Text && checkBox_Genero.Checked == true)
                        {
                            LIST.Remove(FILME);
                        }
                        if (FILME.LOCAL != textBox_Filtrar_Local.Text && checkBox_Local.Checked == true)
                        {
                            if ((FILME.DATA < dateTimePicker_Filtrar_datafilnal.MaxDate) && (FILME.DATA > dateTimePicker_Filtrar_datainicial))
                            {
                                LIST.Remove(FILME);
                            }
                            else
                            {
                                MessageBox.Show("Atencao", "Data Incorreta", MessageBoxButtons.OK);
                            }
                        }
                        if (FILME.DATA != dateTimePicker_Filtrar_datafilnal.Value && checkBox_Data.Checked == true)
                        {
                            LIST.Remove(FILME);
                        }

                    }

                }

                //Apresenta os Valores no ListView_Filtrar
                foreach (Filmes ADD in LIST)
                {
                    ListViewItem LIST_VIEW_FILTRAR = new ListViewItem();

                    LIST_VIEW_FILTRAR.Text = ADD.NOME_FILME;
                    LIST_VIEW_FILTRAR.SubItems.Add(ADD.LOCAL);
                    LIST_VIEW_FILTRAR.SubItems.Add(ADD.DATA.ToShortDateString());
                    LIST_VIEW_FILTRAR.Group = listView_Filtrar.Groups[ADD.GENERO];
                    listView_Filtrar.Items.Add(LIST_VIEW_FILTRAR);
                }
            }

            button_Filtrar.Enabled = false;
            button_Limpar.Enabled = true;
        }

        private void checkBox_Data_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Data.Checked == true)
                groupBox_data_filnal.Visible = true;
            else
                groupBox_data_filnal.Visible = false;
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            Limpar_Filtro();
            button_Filtrar.Enabled = true;
            button_Limpar.Enabled = false;
        }

    }
}


