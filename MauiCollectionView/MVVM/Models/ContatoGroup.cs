namespace MauiCollectionView.MVVM.Models;

public class ContatoGroup : List<Contato>
{
    public string Nome { get; private set; }
    public ContatoGroup(string nome, List<Contato> contatos)
        : base(contatos)
    {
        Nome = nome;
    }
}
