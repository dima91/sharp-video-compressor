using SharpVideoCompressor.Services;

namespace SharpVideoCompressor.ViewModels.Cards;

public class CurrentConversionCardViewModel : ViewModelBase
{
    private readonly AppDataStorage _appDataStorage;


    public CurrentConversionCardViewModel(AppDataStorage appDataStorage)
    {
        _appDataStorage = appDataStorage;
    }
}
