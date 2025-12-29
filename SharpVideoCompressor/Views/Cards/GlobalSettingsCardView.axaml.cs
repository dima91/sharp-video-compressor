using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SharpVideoCompressor.Views.Cards;

public partial class GlobalSettingsCardView : UserControl
{
    public GlobalSettingsCardView()
    {
        AvaloniaXamlLoader.Load(this);
    }
}