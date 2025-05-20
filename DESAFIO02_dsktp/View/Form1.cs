using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DESAFIO02_dsktp.Model;
using DESAFIO02_dsktp.Controller;
using System.Text.Json;
using System.Net.Http;

namespace DESAFIO02_dsktp
{
    public partial class Form1 : Form
    {
        private List<Produto> produto = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_buscar_Click(object sender, EventArgs e)
        {
            string url = "https://fakestoreapi.com/products";

            using (HttpClient product = new HttpClient())
            {
                try
                {
                    string json = await product.GetStringAsync(url);

                    produto = JsonSerializer.Deserialize<List<Produto>>(json);

                    dgv_produtos.DataSource = produto;
                    AtualizarFiltros();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar API: " + ex.Message);
                }
            }
           
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            if (produto == null || produto.Count == 0)
            {
                MessageBox.Show("Nenhum produto carregado.");
                return;
            }
            string categoria = cb_categoria.SelectedItem?.ToString();
            decimal.TryParse(txt_Min.Text, out var min);
            decimal.TryParse(txt_Max.Text, out var max);
            var filtrados = produto
                .Where(p =>
                    (categoria == "Todas" || p.category == categoria) &&
                    p.price >= min &&
                    p.price <= max)
                .ToList();
            dgv_produtos.DataSource = null; 
            dgv_produtos.DataSource = filtrados;
            if (filtrados.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado com os critérios fornecidos.");
            }
        }

        private void AtualizarFiltros()
        {
            if (produto == null || produto.Count == 0)
                return;
            var categorias = produto
                .Select(p => p.category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();
            categorias.Insert(0, "Todas");
            cb_categoria.DataSource = null;
            cb_categoria.DataSource = categorias;
            cb_categoria.SelectedIndex = 0;  
        }

        private void btn_favoritar_Click(object sender, EventArgs e)
        {
            if (dgv_produtos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto para favoritar.");
                return;
            }

            Produto selecionado = dgv_produtos.CurrentRow.DataBoundItem as Produto;

            if (selecionado != null)
            {
                try
                {
                    FavoritoController.AdicionarFavorito(selecionado);
                    MessageBox.Show("Produto adicionado aos favoritos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao favoritar produto: " + ex.Message);
                }
            }

        }

        private void btn_mostrarFavoritos_Click(object sender, EventArgs e)
        {
            try
            {
                var favoritos = FavoritoController.ListarFavoritos();
                dgv_produtos.DataSource = null;
                dgv_produtos.DataSource = favoritos;

                if (favoritos.Count == 0)
                {
                    MessageBox.Show("Nenhum favorito encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar favoritos: " + ex.Message);
            }
        }
    }
}
