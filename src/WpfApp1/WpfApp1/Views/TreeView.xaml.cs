using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpaApp1.Domain.Entities;

namespace WpfApp1.UI.Views
{
    /// <summary>
    /// TreeView.xaml の相互作用ロジック
    /// </summary>
    public partial class TreeView : Window
    {
        private ObservableCollection<Dto> _dtos = new();


        public TreeView()
        {
            InitializeComponent();

            var dto1 = new Dto("Name1");
            dto1.Dtos.Add(new Dto("Name1-1"));
            dto1.Dtos.Add(new Dto("Name1-2"));
            _dtos.Add(dto1);

            CTreeView.ItemsSource = _dtos;
        }
    }
}
