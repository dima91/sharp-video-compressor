namespace SharpVideoCompressor.ViewModels;

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
        _CurrentConversionCardVM = new CurrentConversionCardViewModel();
        _GlobalSettingsCardVM = new GlobalSettingsCardViewModel();
        _JobListCardVM = new JobListCardViewModel();
    }
}
