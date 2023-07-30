using MauiCollectionView.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionView.MVVM.ViewModels
{
    public class ProdutoViewModel
    {
        public ObservableCollection<Produto> Produtos { get; set; }

        public ProdutoViewModel()
        {
            CriarProdutos();
        }

        private void CriarProdutos()
        {
            Produtos = new ObservableCollection<Produto>
            {
                 new Produto
                 {
                    Nome = "Dragon Ball",
                    Preco = 13.90m,
                    Imagem = "dragonball1.jpg",
                    EmOferta = false,
                    Estoque = 10
                 },
                 new Produto
                 {
                    Nome = "Reborn",
                    Preco = 15.90m,
                    Imagem = "rebon1.jpg",
                    EmOferta = false,
                    Estoque = 5
                 },
                 new Produto
                 {
                    Nome = "Gravitation",
                    Preco = 23.50m,
                    Imagem = "gravitation1.jpg",
                    EmOferta = true,
                    Estoque = 3
                 },
                 new Produto
                 {
                    Nome = "The Spirit",
                    Preco = 30.25m,
                    Imagem = "spirit1.jpg",
                    EmOferta = false,
                    Estoque = 10
                 },
                 new Produto
                 {
                    Nome = "Sakura",
                    Preco = 10.45m,
                    Imagem = "sakura1.jpg",
                    EmOferta = false,
                    Estoque = 4
                 },
                 new Produto
                 {
                    Nome = "Naruto",
                    Preco = 21.50m,
                    Imagem = "naruto1.jpg",
                    EmOferta = true,
                    Estoque = 5
                 },
                 new Produto
                 {
                    Nome = "Orquídea Negra",
                    Preco = 30.40m,
                    Imagem = "orquideanegra1.jpg",
                    EmOferta = false,
                    Estoque = 7
                 },
                 new Produto
                 {
                    Nome = "Lovehina",
                    Preco = 10.99m,
                    Imagem = "lovehina1.jpg",
                    EmOferta = true,
                    Estoque = 2
                 },
                 new Produto
                 {
                    Nome = "Inu Yasha",
                    Preco = 12.60m,
                    Imagem = "inuyasha1.jpg",
                    EmOferta = false,
                    Estoque = 2
                 },
                 new Produto
                 {
                    Nome = "Negima",
                    Preco = 15.90m,
                    Imagem = "negina1.jpg",
                    EmOferta = false,
                    Estoque = 6
                 },
                 new Produto
                 {
                    Nome = "SuperOne",
                    Preco = 9.70m,
                    Imagem = "superone1.jpg",
                    EmOferta = true,
                    Estoque = 5
                 }
            };
        }
    }
}
