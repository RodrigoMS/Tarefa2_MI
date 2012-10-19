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
        }

        public List<Filme> ListaFilmes = new List<Filme>();

        private void ADICIONAR_Click(object sender, EventArgs e)
        {
            if (Tgenero.Text == String.Empty || Tnome.Text == String.Empty)
            {
                if (Tnome.Text == String.Empty)
                    SetaNome.Visible = true;
                if (Tgenero.Text == String.Empty)
                    SetaGenero.Visible = true;
                LFRASE.Visible = true;
                LFRASE.Text = "É necessário que os campos nome e gênero estejam preenchidos.";
            }
            else
            {
                //Cria um objeto com referencia a class Filme
                Filme novoFilme = new Filme();
                //Atribui os valores digitados ao objeto da classe filme
                novoFilme.nome = Tnome.Text;
                novoFilme.genero = Tgenero.Text;
                novoFilme.data = Tdata.Value;
                novoFilme.local = Tlocal.Text;

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



                // Criar a lista para usar como fonte personalizado para o TextBox - Tnome.  
                var Complete = new AutoCompleteStringCollection();
                Complete.AddRange(new string[]
                        {
                            Tnome.Text
                        });

                // Criar e inicializar a caixa de texto.

                Tnome.AutoCompleteCustomSource = Complete;
                Tnome.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                Tnome.AutoCompleteSource = AutoCompleteSource.CustomSource;

                //Criar a lista para usar como fonte persomalizada para o TextBox - Tlocal.
                Complete = new AutoCompleteStringCollection();
                Complete.AddRange(new string[]
                        {
                            Tlocal.Text
                        });

                // Criar e inicializar a caixa de texto.

                Tlocal.AutoCompleteCustomSource = Complete;
                Tlocal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                Tlocal.AutoCompleteSource = AutoCompleteSource.CustomSource;

                // Método Limpar
                LFRASE.Visible = true;
                LFRASE.Text = "Para atualizar ou excluir dados, de clique duplo em cima do item desejado.";
                LIMPAR();
            }
        }

        private Filme filmeSobAlteracao;

        private void LISTA_FILMES_DoubleClick(object sender, EventArgs e)
        {
            // O item selecionado é enviodo para os Text Box
            Adicionar.Enabled = false;
            Exclusao.Enabled = true;
            Alterar.Enabled = true;
            LFRASE.Text = "Insira ou atualize dados e clique em Alterar. Para excluir basta clicar em Excluir.";
            foreach (ListViewItem item in LISTA_FILMES.SelectedItems)
            {
                filmeSobAlteracao = new Filme();
                filmeSobAlteracao.Selecionado = item.Index;
                Tnome.Text = item.Text;
                Tgenero.Text = item.SubItems[1].Text;
                Tdata.Text = item.SubItems[2].Text;
                Tlocal.Text = item.SubItems[3].Text;
                filmeSobAlteracao.genero = Tgenero.Text;

                //Adiciona ao objeto o filme que terá alteração
                filmeSobAlteracao.nome = Tnome.Text;
                filmeSobAlteracao.genero = Tgenero.Text;
                filmeSobAlteracao.data = Tdata.Value;
                filmeSobAlteracao.local = Tlocal.Text;

            }
        }

        private void ALTERAR_Click(object sender, EventArgs e)
        {
            LFRASE.Visible = false;
            string generoAntigo = String.Empty;
            Filme trocaFilmeGenero = new Filme();
            bool GeneroTrocado = false; 

            foreach (KeyValuePair<string, List<Filme>> Procurar in Dicionario)
            {
                if (Procurar.Key == filmeSobAlteracao.genero)
                {
                    foreach (Filme Encontrar in Procurar.Value)
                    {
                        //Verifica e faz a alteração se caso o item for diferente
                        if (Encontrar.nome == filmeSobAlteracao.nome)
                        {
                            Encontrar.nome = Tnome.Text;
                            Encontrar.genero = Tgenero.Text;
                            Encontrar.data = Tdata.Value;
                            Encontrar.local = Tlocal.Text;
                        }
                        if (Encontrar.genero != filmeSobAlteracao.genero)
                        {
                            generoAntigo = Encontrar.genero;
                            //Encontrar.genero = Tgenero.Text;
                            trocaFilmeGenero.nome = Encontrar.nome;
                            trocaFilmeGenero.genero = Tgenero.Text;
                            trocaFilmeGenero.data = Encontrar.data;
                            trocaFilmeGenero.local = Encontrar.local;
                            GeneroTrocado = true;   
                        }
                    }
                }
            }

            // Se o genero foi alterado ele entrará nesta condição
            if (GeneroTrocado == true)
            {
                if (Dicionario.ContainsKey(trocaFilmeGenero.genero))
                {
                    ListaFilmes.Add(trocaFilmeGenero);
                    Dicionario[trocaFilmeGenero.genero] = ListaFilmes;
                }
                else
                {
                    ListaFilmes = new List<Filme>();
                    ListaFilmes.Add(trocaFilmeGenero);
                    Dicionario.Add(trocaFilmeGenero.genero,ListaFilmes);
                }

                //exclusão do Item selecionado
                List<Filme> listaSemOFilme = new List<Filme>();
                foreach (KeyValuePair<string, List<Filme>> Excluir in Dicionario)
                {
                    if (Excluir.Key == generoAntigo)
                    {
                        foreach (Filme ExcluirFilme in Excluir.Value)
                        {
                            if (ExcluirFilme.genero != trocaFilmeGenero.genero)
                            {
                                listaSemOFilme.Add(ExcluirFilme);
                            }
                        }
                    }
                }
                Dicionario.Remove(generoAntigo);
                Dicionario.Add(generoAntigo, listaSemOFilme);
            }

            foreach (ListViewItem item in LISTA_FILMES.SelectedItems)
            {
                item.Text = Tnome.Text;
                item.SubItems[1].Text = Tgenero.Text;
                item.SubItems[2].Text = Tdata.Text;
                item.SubItems[3].Text = Tlocal.Text;

                item.Group = LISTA_FILMES.Groups[Tgenero.Text];
            }
            Adicionar.Enabled = true;
            Alterar.Enabled = false;
            LFRASE.Visible = true;
            Exclusao.Enabled = false;
            LFRASE.Text = "Para cadastrar insira os dados e clique em Adicionar";
            LIMPAR();
        }

        private void EXCLUIR_Click(object sender, EventArgs e)
        {
            ListaFilmes = new List<Filme>();
            foreach (KeyValuePair<string, List<Filme>> Excluir in Dicionario)
            {
                if (Excluir.Key == Tgenero.Text)
                {
                    foreach (Filme ExcluirFilme in Excluir.Value)
                    {
                        if (ExcluirFilme.nome != Tnome.Text)
                        {
                            ListaFilmes.Add(ExcluirFilme);
                        }
                    }
                }
            }
            Dicionario.Remove(Tgenero.Text);
            Dicionario.Add(Tgenero.Text,ListaFilmes);
            foreach (ListViewItem item in LISTA_FILMES.SelectedItems)
            {
                if (item.Text == Tnome.Text)
                {
                    item.Remove();
                }
            }
            Adicionar.Enabled = true;
            Alterar.Enabled = false;
            Exclusao.Enabled = false;
            LFRASE.Text = "Para cadastrar insira os dados e clique em Adicionar.";
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
                if(pesq.Key == Tgenero.Text || Tgenero.Text == "Todos os gêneros")
                {
                    foreach (Filme Pesquisado in pesq.Value)
                    {
                        if ((Pesquisado.nome == Tnome.Text || Tnome.Text == "")
                            && (Pesquisado.genero == Tgenero.Text || Tgenero.Text == "Todos os gêneros")
                            && (AbilitarData.Checked == false || (Pesquisado.data >= Tdata.Value && Pesquisado.data <= Tdata_Ate.Value))
                            && (Pesquisado.local == Tlocal.Text || Tlocal.Text == ""))
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
            Alterar.Visible = false;
            Adicionar.Visible = false;
            Exclusao.Visible = false;
            PERQUISA.Visible = false;
            Pesquisa.Visible = true;
            FecharPesquisa.Visible = true;
            Tdata_Ate.Visible = true;
            ATE.Visible = true;
            AbilitarData.Visible = true;
            DesabilitarData.Visible = true;
            Tgenero.Items.Add("Todos os gêneros");
            AbilitarData.Checked = true;
        }

        private void FECHAR_PESQUISA_Click(object sender, EventArgs e)
        {
            //Abilita e desabilita botões dentro do form
            LFRASE.Text = "Para cadastrar insira os dados e clique em Adicionar";
            Alterar.Visible = true;
            Adicionar.Visible = true;
            Exclusao.Visible = true;
            PERQUISA.Visible = true;
            Pesquisa.Visible = false;
            FecharPesquisa.Visible = false;
            Tdata_Ate.Visible = false;
            ATE.Visible = false;
            AbilitarData.Visible = false;
            DesabilitarData.Visible = false;
            Tgenero.Items.Remove("Todos os gêneros");
            LFRASE.Visible = true;
            Tdata.Enabled = true;
        }

        public void LIMPAR()
        {
            //Limpa todos os TextBox e posiciona o cursor no TexBox nome
            Tnome.Clear();
            Tgenero.Text = "";
            Tlocal.Clear();
            Tnome.Focus();
        }

        private void TGENERO_MouseClick(object sender, MouseEventArgs e)
        {
            SetaGenero.Visible = false;
        }

        private void TNOME_MouseClick(object sender, MouseEventArgs e)
        {
            SetaNome.Visible = false;
        }

        private void DesabilitarData_CheckedChanged(object sender, EventArgs e)
        {
            Tdata_Ate.Enabled = false;
            Tdata.Enabled = false;
        }

        private void AbilitarData_CheckedChanged(object sender, EventArgs e)
        {
            Tdata_Ate.Enabled = true;
            Tdata.Enabled = true;
        }
    }
}