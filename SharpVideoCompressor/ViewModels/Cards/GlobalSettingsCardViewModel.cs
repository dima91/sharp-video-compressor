using SharpVideoCompressor.Services;

namespace SharpVideoCompressor.ViewModels.Cards;

public class GlobalSettingsCardViewModel : ViewModelBase
{
    private readonly AppDataStorage _appDataStorage;


    public GlobalSettingsCardViewModel(AppDataStorage appDataStorage)
    {
        _appDataStorage = appDataStorage;
    }
}
