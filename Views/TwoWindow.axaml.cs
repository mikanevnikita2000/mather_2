using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace mather_2.Views
{
    public partial class TwoWindow : Window
    {
        public TwoWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}