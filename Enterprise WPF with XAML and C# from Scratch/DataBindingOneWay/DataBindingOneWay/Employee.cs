using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace DataBindingOneWay {
  public class Employee : INotifyPropertyChanged {
    private string name;
    public string Name {
      get {
        return Name;

        }
      set {
        name = value; 
        OnPropertyChanged();
      }
    }

    public string Title { get; set; }

    public static Employee GetEmployee() {
      var emp = new Employee() {
        Name = "Tom",
        Title = "Developer"
      };
      return emp;
    }
  public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string caller = "") {
      if (PropertyChanged != null) {
        PropertyChanged(this, new PropertyChangedEventArgs(caller));
      }
    }
  }
}
