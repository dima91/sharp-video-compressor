namespace SharpVideoCompressor.ViewModels;

using ReactiveUI;
using Splat;
using SharpVideoCompressor.Services;
using SharpVideoCompressor.ViewModels.Cards;

public class MainWindowViewModel : ViewModelBase
{
    
    private CurrentConversionCardViewModel _CurrentConversionCardVM;
    public CurrentConversionCardViewModel CurrentConversionCardVM { get => _CurrentConversionCardVM; }

    private GlobalSettingsCardViewModel _GlobalSettingsCardVM;
    public GlobalSettingsCardViewModel GlobalSettingsCardVM {get => _GlobalSettingsCardVM; }

    private JobListCardViewModel _JobListCardVM;
    public JobListCardViewModel JobListCardVM {get => _JobListCardVM; }


    public MainWindowViewModel ()
    {
        Locator.CurrentMutable.RegisterConstant(new VideoConverterService(), typeof(VideoConverterService));
        Locator.CurrentMutable.RegisterConstant(new AppDataService(), typeof(AppDataService));

        _CurrentConversionCardVM = new CurrentConversionCardViewModel();
        _GlobalSettingsCardVM = new GlobalSettingsCardViewModel();
        _JobListCardVM = new JobListCardViewModel();
    }
}
