using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionView.MVVM.Models;

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string Imagem { get; set; }
    public int Estoque { get; set; }
    public bool EmOferta { get; set; }
}
