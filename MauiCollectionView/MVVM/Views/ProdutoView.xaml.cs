using MauiCollectionView.MVVM.ViewModels;

namespace MauiCollectionView.MVVM.Views;

public partial class ProdutoView : ContentPage
{
	public ProdutoView()
	{
		InitializeComponent();
		BindingContext = new ProdutoViewModel();
	}
}