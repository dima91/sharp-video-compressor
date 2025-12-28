using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SharpVideoCompressor.Views.Cards;

public partial class JobListCardView : UserControl
{
    public JobListCardView()
    {
        AvaloniaXamlLoader.Load(this);
    }
}