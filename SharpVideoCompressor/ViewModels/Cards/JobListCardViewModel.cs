using SharpVideoCompressor.Services;

namespace SharpVideoCompressor.ViewModels.Cards;

public class JobListCardViewModel : ViewModelBase
{
    private readonly AppDataStorage _appDataStorage;


    public JobListCardViewModel(AppDataStorage appDataStorage)
    {
        _appDataStorage = appDataStorage;
    }
}
