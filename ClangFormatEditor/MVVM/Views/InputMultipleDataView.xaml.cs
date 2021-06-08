using System.Windows;
using System.Windows.Input;

namespace ClangFormatEditor.MVVM.Views
{
  /// <summary>
  /// Interaction logic for InputFormatStylesView.xaml
  /// </summary>
  public partial class InputMultipleDataView : Window
  {
    public InputMultipleDataView(string input, Window owner)
    {
      InitializeComponent();
      PreviewKeyDown += (s, e) => { if (e.Key == Key.Escape) Close(); };
      DataContext = new InputMultipleDataViewModel(input);
      Owner = owner;
    }
  }
}
