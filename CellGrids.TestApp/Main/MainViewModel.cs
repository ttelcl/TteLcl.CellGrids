using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CellGrids.TestApp.Main;

public class MainViewModel: ObservableObject
{
  public MainViewModel()
  {
    ExitCommand = new RelayCommand(() => {
      var w = Application.Current.MainWindow;
      w?.Close();
    });
  }

  public ICommand ExitCommand { get; }

  public string StatusMessage {
    get => _statusMessage;
    set {
      if(SetProperty(ref _statusMessage, value))
      {
      }
    }
  }
  private string _statusMessage = "";

}
