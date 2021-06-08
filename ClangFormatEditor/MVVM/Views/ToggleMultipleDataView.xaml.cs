using ClangFormatEditor.MVVM.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace ClangFormatEditor.MVVM.Views
{
  /// <summary>
  /// Interaction logic for InputFormatStylesView.xaml
  /// </summary>
  public partial class ToggleMultipleDataView : Window
  {
    public ToggleMultipleDataView(List<ToggleModel> input, Window owner)
    {
      InitializeComponent();
      PreviewKeyDown += (s, e) => { if (e.Key == Key.Escape) Close(); };
      DataContext = new ToggleMultipleDataViewModel(input);
      Owner = owner;
    }
  }
}
