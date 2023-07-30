using MauiCollectionView.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionView.Selectors
{
    internal class ProdutoDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var produto = item as Produto;
            if (!produto.EmOferta)
            {
                Application.Current.Resources.TryGetValue("ProdutosStyle", out var produtoStyle);
                return produtoStyle as DataTemplate;
            }
            else
            {
                Application.Current.Resources.TryGetValue("EmOfertaStyle", out var emOfertaStyle);
                return emOfertaStyle as DataTemplate;
            }
        }
    }
}
