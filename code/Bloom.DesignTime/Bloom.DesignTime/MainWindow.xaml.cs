using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bloom.DesignTime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new Hammer // 初始化运行时数据
            {
                Name = "My Hammer",
                Size = 15,
                Nails = new ObservableCollection<Nail>
                {
                    new Nail { Material = "Steel", Length = 5 },
                    new Nail { Material = "Aluminum", Length = 10 }
                }
            };

        }
    }
}