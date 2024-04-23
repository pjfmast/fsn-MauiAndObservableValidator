using MauiAndObservableValidator.ViewModels;

namespace MauiAndObservableValidator;

public partial class AddRatingPage : ContentPage
{
    public AddRatingPage(AddRatingViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}