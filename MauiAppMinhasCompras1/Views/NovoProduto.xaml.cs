using MauiAppMinhasCompras1.Models;

namespace MauiAppMinhasCompras1.Views;

public partial class NovoProduto : ContentPage
{
    public NovoProduto()
    {
        InitializeComponent();
    }

    //Botão de adicionar produto
    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        try
        {
            Produto p = new Produto
            {
                Descricao = txt_descricao.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
                Preco = Convert.ToDouble(txt_preco.Text)
            };

            await App.Db.Insert(p);
            await DisplayAlert("Sucesso", "Produto inserido", "OK");
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}