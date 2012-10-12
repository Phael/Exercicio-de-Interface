using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;  

 
namespace Exercicio
{    

    public partial class Form_Principal : Form
    {
        //Dicionario global para armazenamento das listas que conterao os objetos
        Dictionary<int, List<Filmes>> DICIONARIO = new Dictionary<int, List<Filmes>>();
        
        public Form_Principal()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            //Rotina para limpar os texbox , combobox, datetimepicker
            textBox_Nome.ResetText();
            comboBox_Genero.ResetText();
            textBox_Local.ResetText();
            dateTimePicker_Data.ResetText();

        }
        public bool VerificaCampos()
        {
            if (textBox_Nome.Text != string.Empty && comboBox_Genero.Text != string.Empty)
            {
                label_obrigatorio1.Visible = false;
                label_Obrigatorio2.Visible = false;
                return true;
            }
            else if (textBox_Nome.Text == string.Empty && comboBox_Genero.Text == string.Empty)
            {
                label_obrigatorio1.Visible = true;
                label_Obrigatorio2.Visible = true;
                return false;
            }
            else if (comboBox_Genero.Text == string.Empty)
            {
                label_Obrigatorio2.Visible = true;
                label_obrigatorio1.Visible = false;
                return false;
            }
            else if (textBox_Nome.Text == string.Empty)
            {
                label_Obrigatorio2.Visible = false;
                label_obrigatorio1.Visible = true;
                return false;
            }
            else
                return false;

        }

        public void Adicionar()
        {
            //Instacia da Classe Filme
            Filmes Filme = new Filmes();

            if (VerificaCampos())
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
                    //se a chave ja existir ele pega a referencia ja existente e adiciona a lista nesta posição
                    List<Filmes> LISTAREF = DICIONARIO[comboBox_Genero.SelectedIndex];
                    LISTAREF.Add(Filme);
                }
                else
                {
                    //se a chave nao existir ele cria uma nova lista armazena os valores e insere a nova chave       
                    List<Filmes> LISTA = new List<Filmes>();
                    LISTA.Add(Filme);
                    DICIONARIO.Add(comboBox_Genero.SelectedIndex, LISTA);
                }

                //cria o listview itens para o listview_Roll
                ListViewItem LIST_VIEW = new ListViewItem();
                //Adiciona valores no lisView_roll
                LIST_VIEW.Text = Filme.NOME_FILME;
                LIST_VIEW.SubItems.Add(Filme.GENERO);
                LIST_VIEW.SubItems.Add(Filme.LOCAL);
                LIST_VIEW.SubItems.Add(Filme.DATA.ToShortDateString());
                LIST_VIEW.Group = listView_roll.Groups[comboBox_Genero.Text];
                listView_roll.Items.Add(LIST_VIEW);
                Limpar();


            }
        }
        public void comboBox_Genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //Insere os valores do grupo do listview no Combobox_Genero
            comboBox_Genero.DataSource = listView_roll.Groups;
            comboBox_Filtrar_Genero.DataSource = listView_Filtrar.Groups;
   
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            Adicionar();
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            //Atribui os Valores da posição selecionada as variaveis criadas
            string NOME_FILME = listView_roll.SelectedItems[0].Text;
            string GENERO_FILME = listView_roll.SelectedItems[0].SubItems[1].Text;
            string LOCAL_FILME = listView_roll.SelectedItems[0].SubItems[2].Text;            
            string DATA_FILME = listView_roll.SelectedItems[0].SubItems[3].Text;


            if (VerificaCampos())
            {
                foreach (KeyValuePair<int, List<Filmes>> ALTERARDICIONARIO in DICIONARIO)
                {
                    foreach (Filmes ALTERARFILME in ALTERARDICIONARIO.Value)
                    {
                        if (NOME_FILME == ALTERARFILME.NOME_FILME && GENERO_FILME == ALTERARFILME.GENERO && LOCAL_FILME == ALTERARFILME.LOCAL && DATA_FILME == ALTERARFILME.DATA.ToShortDateString())
                        {
                            ALTERARFILME.NOME_FILME = textBox_Nome.Text;
                            ALTERARFILME.LOCAL = textBox_Local.Text;
                            ALTERARFILME.GENERO = comboBox_Genero.Text;
                            ALTERARFILME.LOCAL = textBox_Local.Text;
                        }
                    }

                }

                listView_roll.SelectedItems[0].Remove();

                //Cria um novo listaView para inserçao dos valores
                ListViewItem NOVA = new ListViewItem();
                //Insere os novos Valores
                NOVA.Text = textBox_Nome.Text;
                NOVA.SubItems.Add(comboBox_Genero.Text);
                NOVA.SubItems.Add(textBox_Local.Text);
                NOVA.SubItems.Add(dateTimePicker_Data.Value.ToShortDateString());
                NOVA.Group = listView_roll.Groups[comboBox_Genero.Text];
                listView_roll.Items.Add(NOVA);

                button_Editar.Enabled = false;
                button_Adicionar.Enabled = true;
            }            
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
            if((checkBox_Data.Checked == true || checkBox_Genero.Checked == true || checkBox_Nome.Checked == true || checkBox_Local.Checked == true) && (textBox_Filtrar_Local.Text != string.Empty || textBox_Filtrar_Nome.Text != string.Empty || comboBox_Filtrar_Genero.Text != string.Empty))
            {
               
                    //Lista Para armazenar os valores contidos na lista do dicionario
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
                                    //Toda condição verdadeira remove os itens desnecessarios do LIST, ate ser encontrado apenas os valores selecionados pelo usuario
                                    LIST.Remove(FILME);
                                }
                                if (FILME.GENERO != comboBox_Filtrar_Genero.Text && checkBox_Genero.Checked == true)
                                {
                                    LIST.Remove(FILME);
                                }
                                if (FILME.LOCAL != textBox_Filtrar_Local.Text && checkBox_Local.Checked == true)
                                {
                                    LIST.Remove(FILME);
                                }
                                if (checkBox_Data.Checked == true)
                                {
                                    if ((FILME.DATA.Date < dateTimePicker_Filtrar_datafilnal.Value) && (FILME.DATA.Date > dateTimePicker_Filtrar_datainicial.Value))
                                    {
                                        LIST.Remove(FILME);
                                    }
                                }
                        }
                            listView_Filtrar.Items.Clear();

                        //Apresenta a lista filtrada no ListView_Filtrar
                        foreach (Filmes ADD in LIST)
                        {
                            ListViewItem LIST_VIEW_FILTRAR = new ListViewItem();

                            LIST_VIEW_FILTRAR.Text = ADD.NOME_FILME;
                            LIST_VIEW_FILTRAR.SubItems.Add(ADD.LOCAL);
                            LIST_VIEW_FILTRAR.SubItems.Add(ADD.DATA.ToShortDateString());
                            LIST_VIEW_FILTRAR.Group = listView_Filtrar.Groups[ADD.GENERO];
                            listView_Filtrar.Items.Add(LIST_VIEW_FILTRAR);

                            button_Filtrar.Enabled = true;

                        }
                    }
                }
            }
             else
                MessageBox.Show("Selecione uma opção de Pesquisa e insira um valor a ser Pesquisado", "Atenção", MessageBoxButtons.OK,MessageBoxIcon.Exclamation); 
                
        }

        private void checkBox_Data_CheckedChanged(object sender, EventArgs e)
        {
            //ativa o calendario para filtrar a Data Final
            if (checkBox_Data.Checked == true)
                groupBox_data_filnal.Visible = true;
            else
                groupBox_data_filnal.Visible = false;
        }
        private void listView_Filtrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Adicionar_MouseHover(object sender, EventArgs e)
        {
            label_Info.Text = "Adiciona os Valores inseridos, no Historico de Filmes";
        }

        private void button_Adicionar_MouseLeave(object sender, EventArgs e)
        {
            label_Info.Text = "Para Editar Clique Duas vezes sobre o item Desejado";
        }

        private void button_Editar_MouseHover(object sender, EventArgs e)
        {
            label_Info.Text = "Clique em Editar para salvar as alterações";
        }

    }
}


