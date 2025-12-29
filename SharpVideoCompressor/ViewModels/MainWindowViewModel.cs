namespace SharpVideoCompressor.ViewModels;

using ReactiveUI;
using Splat;
using SharpVideoCompressor.Services;
using SharpVideoCompressor.ViewModels.Cards;

public class MainWindowViewModel : ViewModelBase
{
    private readonly AppDataStorage _appDataStorage;
    
    private CurrentConversionCardViewModel _CurrentConversionCardVM;
    public CurrentConversionCardViewModel CurrentConversionCardVM { get => _CurrentConversionCardVM; }

    private GlobalSettingsCardViewModel _GlobalSettingsCardVM;
    public GlobalSettingsCardViewModel GlobalSettingsCardVM {get => _GlobalSettingsCardVM; }

    private JobListCardViewModel _JobListCardVM;
    public JobListCardViewModel JobListCardVM {get => _JobListCardVM; }


    public MainWindowViewModel ()
    {
        _appDataStorage = new();
        Locator.CurrentMutable.RegisterConstant(new VideoConverterService(_appDataStorage), typeof(VideoConverterService));

        _CurrentConversionCardVM = new CurrentConversionCardViewModel(_appDataStorage);
        _GlobalSettingsCardVM = new GlobalSettingsCardViewModel(_appDataStorage);
        _JobListCardVM = new JobListCardViewModel(_appDataStorage);
    }
}
