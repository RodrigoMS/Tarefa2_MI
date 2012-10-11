using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarefa_CFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Dictionary<string, List<Filme>> Dicionario = new Dictionary<string, List<Filme>>();

        private void Form1_Load(object sender, EventArgs e)
        {
            LISTA_FILMES.Groups.Add("Grupo de filmes", "Lista de filmes");
            TNOME.Focus();
        }

        public List<Filme> ListaFilmes = new List<Filme>();

        private void ADICIONAR_Click(object sender, EventArgs e)
        {
            if (TGENERO.Text == String.Empty || TNOME.Text == String.Empty)
            {
                if (TNOME.Text == String.Empty)
                    SetaNome.Visible = true;
                if (TGENERO.Text == String.Empty)
                    SetaGenero.Visible = true;
                LMENSAGEM.Visible = true;
                LMENSAGEM.Text = "É necessário que os campos nome e gênero estejam preenchidos.";
            }
            else
            {
                //Cria um objeto com referencia a class Filme
                Filme novoFilme = new Filme();
                //Atribui os valores digitados ao objeto da classe filme
                novoFilme.nome = TNOME.Text;
                novoFilme.genero = TGENERO.Text;
                novoFilme.data = TDATA.Value;
                novoFilme.local = TLOCAL.Text;

                //Mostra o conteúdo da lista de informações para o listView
                ListViewItem FILME = new ListViewItem();
                FILME.Text = novoFilme.nome;
                FILME.SubItems.Add(novoFilme.genero);
                FILME.SubItems.Add(novoFilme.data.ToString());
                FILME.SubItems.Add(novoFilme.local);
                
                //Define o grupo que pertencerá ao listview LISTA_FILME
                FILME.Group = LISTA_FILMES.Groups[novoFilme.genero];

                // Insere o objeto FILME no ListView LISTA_FILME
                LISTA_FILMES.Items.Add(FILME);

                //Insere a ListaFilme no Dicionário
                if (Dicionario.ContainsKey(novoFilme.genero))
                {
                    ListaFilmes.Add(novoFilme);
                    Dicionario[novoFilme.genero] = ListaFilmes;
                }
                else
                {
                    ListaFilmes = new List<Filme>();
                    ListaFilmes.Add(novoFilme);
                    Dicionario.Add(novoFilme.genero,ListaFilmes);
                }

                

                //// Criar a lista para usar como fonte personalizado para o TextBox - TNOME.  
                //var COMPLETE = new AutoCompleteStringCollection();
                //COMPLETE.AddRange(new string[]
                //        {
          
                //        });

                //// Criar e inicializar a caixa de texto.

                //TNOME.AutoCompleteCustomSource = COMPLETE;
                //TNOME.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //TNOME.AutoCompleteSource = AutoCompleteSource.CustomSource;

                // Método Limpar
                LMENSAGEM.Visible = true;
                LMENSAGEM.Text = "Para atualizar ou excluir dados, de clique duplo em cima do item desejado.";
                LIMPAR();
            }
        }

        private Filme filmeSobAlteracao;

        private void LISTA_FILMES_DoubleClick(object sender, EventArgs e)
        {
            // O item selecionado é enviodo para os Text Box
            ADICIONAR.Enabled = false;
            EXCLUIR.Enabled = true;
            foreach (ListViewItem item in LISTA_FILMES.SelectedItems)
            {
                LFRASE.Text = "Insira ou atualize dados e clique em Alterar. Para excluir basta clicar em Excluir.";
                LMENSAGEM.Visible = false;
                ALTERAR.Enabled = true;
                filmeSobAlteracao = new Filme();
                filmeSobAlteracao.Selecionado = item.Index;
                TNOME.Text = item.Text;
                TGENERO.Text = item.SubItems[1].Text;
                TDATA.Text = item.SubItems[2].Text;
                TLOCAL.Text = item.SubItems[3].Text;
            }
        }

        private void ALTERAR_Click(object sender, EventArgs e)
        {
            string generoAntigo = String.Empty;
            string novoGenero = String.Empty;
            Filme TrocaFilmeGenero = new Filme();
            bool GeneroTrocado = false;
            foreach (KeyValuePair<string, List<Filme>> Procurar in Dicionario)
            {
                if (Procurar.Key != TGENERO.Text)
                {
                    GeneroTrocado = true;
                    foreach (Filme Encontrar in Procurar.Value)
                    {
                        if (Encontrar.genero == TGENERO.Text)
                        {
                            generoAntigo = Encontrar.genero;
                            TrocaFilmeGenero.nome = Encontrar.nome;
                            TrocaFilmeGenero.genero = TGENERO.Text;
                            TrocaFilmeGenero.data = Encontrar.data;
                            TrocaFilmeGenero.local = Encontrar.local;
                            Encontrar.genero = TGENERO.Text;
                        }
                    }
                }
                else
                {
                    foreach (Filme AlterarFilme in Procurar.Value)
                    {
                        if (AlterarFilme.nome == TNOME.Text)
                        {
                            AlterarFilme.nome = TNOME.Text;
                            AlterarFilme.genero = TGENERO.Text;
                            AlterarFilme.data = TDATA.Value;
                            AlterarFilme.local = TLOCAL.Text;
                        }
                    }
                }
            }

            if (GeneroTrocado == true)
            {
                if (Dicionario.ContainsKey(TGENERO.Text))
                {
                    ListaFilmes.Add(TrocaFilmeGenero);
                    Dicionario[TGENERO.Text] = ListaFilmes;
                }
                else
                {
                    ListaFilmes = new List<Filme>();
                    ListaFilmes.Add(TrocaFilmeGenero);
                    Dicionario.Add(TGENERO.Text,ListaFilmes);
                }

                //exclusão do Item selecionado
                ListaFilmes = new List<Filme>();
                foreach (KeyValuePair<string, List<Filme>> Excluir in Dicionario)
                {
                    if (Excluir.Key == generoAntigo)
                    {
                        foreach (Filme ExcluirFilme in Excluir.Value)
                        {
                            if (ExcluirFilme.genero != TrocaFilmeGenero.genero)
                            {
                                ListaFilmes.Add(ExcluirFilme);
                            }
                        }
                    }
                }
                Dicionario.Remove(generoAntigo);
                Dicionario.Add(generoAntigo,ListaFilmes);
            }

            foreach (ListViewItem item in LISTA_FILMES.SelectedItems)
            {
                item.Text = TNOME.Text;
                item.SubItems[1].Text = TGENERO.Text;
                item.SubItems[2].Text = TDATA.Text;
                item.SubItems[3].Text = TLOCAL.Text;

                item.Group = LISTA_FILMES.Groups[TGENERO.Text];
            }
            ADICIONAR.Enabled = true;
            ALTERAR.Enabled = false;
            LMENSAGEM.Visible = true;
            EXCLUIR.Enabled = false;
            LFRASE.Text = "Para cadastrar insira os dados e clique em Adicionar";
            LIMPAR();
        }

        private void EXCLUIR_Click(object sender, EventArgs e)
        {
            ListaFilmes = new List<Filme>();
            foreach (KeyValuePair<string, List<Filme>> Excluir in Dicionario)
            {
                if (Excluir.Key == TGENERO.Text)
                {
                    foreach (Filme ExcluirFilme in Excluir.Value)
                    {
                        if (ExcluirFilme.nome != TNOME.Text)
                        {
                            ListaFilmes.Add(ExcluirFilme);
                        }
                    }
                }
            }
            Dicionario.Remove(TGENERO.Text);
            Dicionario.Add(TGENERO.Text,ListaFilmes);
            foreach (ListViewItem item in LISTA_FILMES.SelectedItems)
            {
                if (item.Text == TNOME.Text)
                {
                    item.Remove();
                }
            }
            ADICIONAR.Enabled = true;
            ALTERAR.Enabled = false;
            EXCLUIR.Enabled = false;
            LMENSAGEM.Visible = true;
            LFRASE.Text = "Para cadastrar insira os dados e clique em Adicionar";
            LIMPAR();
        }

        private void PESQUISAR_Click(object sender, EventArgs e)
        {
            //Apaga os items do ListView 
            LISTA_FILMES.Items.Clear();
            //Retorna os filmes existentes
            List<Filme> Selecionados = new List<Filme>();
            bool NaoEncontrado = true;
            foreach(KeyValuePair<string,List<Filme>> pesq in Dicionario)
            {
                if(pesq.Key == TGENERO.Text || TGENERO.Text == "Todos os gêneros")
                {
                    foreach (Filme Pesquisado in pesq.Value)
                    {
                        if ((Pesquisado.nome == TNOME.Text || TNOME.Text == "")
                            && (Pesquisado.genero == TGENERO.Text || TGENERO.Text == "Todos os gêneros")
                            && (ABILITAR_DATA.Checked == false || (Pesquisado.data >= TDATA.Value && Pesquisado.data <= TDATA_ATE.Value))
                            && (Pesquisado.local == TLOCAL.Text || TLOCAL.Text == ""))
                        {
                            NaoEncontrado = false;
                            Selecionados.Add(Pesquisado);
                        }
                    }
                }     
            }
            if(NaoEncontrado == true)
            {
                ListViewItem f = new ListViewItem();
                f.Text = "Não a filmes cadastrados.";
                f.Group = LISTA_FILMES.Groups["Pesquisa"];
                LISTA_FILMES.Items.Add(f);
            }
            foreach (Filme Mostrar in Selecionados)
            {
                ListViewItem FILMEP = new ListViewItem();
                FILMEP.Text = Mostrar.nome;
                FILMEP.SubItems.Add(Mostrar.genero);
                FILMEP.SubItems.Add(Mostrar.data.ToString());
                FILMEP.SubItems.Add(Mostrar.local);

                FILMEP.Group = LISTA_FILMES.Groups[Mostrar.genero];
                LISTA_FILMES.Items.Add(FILMEP);
            }
        }

        private void PERQUISA_Click(object sender, EventArgs e)
        {
            //Abilita e desabilita botões dentro do form
            LFRASE.Text = "Defina os dados para a pesquisa e clique em Perquisar";
            ALTERAR.Visible = false;
            ADICIONAR.Visible = false;
            EXCLUIR.Visible = false;
            PERQUISA.Visible = false;
            PESQUISAR.Visible = true;
            FECHAR_PESQUISA.Visible = true;
            TDATA_ATE.Visible = true;
            ATE.Visible = true;
            ABILITAR_DATA.Visible = true;
            DESABILITAR_DATA.Visible = true;
            TGENERO.Items.Add("Todos os gêneros");
            LMENSAGEM.Visible = false;
        }

        private void FECHAR_PESQUISA_Click(object sender, EventArgs e)
        {
            //Abilita e desabilita botões dentro do form
            LFRASE.Text = "Para cadastrar insira os dados e clique em Adicionar";
            ALTERAR.Visible = true;
            ADICIONAR.Visible = true;
            EXCLUIR.Visible = true;
            PERQUISA.Visible = true;
            PESQUISAR.Visible = false;
            FECHAR_PESQUISA.Visible = false;
            TDATA_ATE.Visible = false;
            ATE.Visible = false;
            ABILITAR_DATA.Visible = false;
            DESABILITAR_DATA.Visible = false;
            TGENERO.Items.Remove("Todos os gêneros");
            LMENSAGEM.Visible = true;
        }

        public void LIMPAR()
        {
            //Limpa todos os TextBox e posiciona o cursor no TexBox nome
            TNOME.Clear();
            TGENERO.Text = "";
            TLOCAL.Clear();
            TNOME.Focus();
        }

        private void TGENERO_MouseClick(object sender, MouseEventArgs e)
        {
            SetaGenero.Visible = false;
            LMENSAGEM.Visible = false;
        }

        private void TNOME_MouseClick(object sender, MouseEventArgs e)
        {
            SetaNome.Visible = false;
            LMENSAGEM.Visible = false;
        }
    }
}