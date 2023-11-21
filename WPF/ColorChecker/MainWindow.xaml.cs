using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<MyColor> myColors = new List<MyColor> { };
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private MyColor[] GetColorList()
        {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color color = Color.FromRgb((byte)(int)rSlider.Value, (byte)(int)gSlider.Value, (byte)(int)bSlider.Value);
            SolidColorBrush brush = new SolidColorBrush(color);
            colorArea.Background = brush;
            
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            var col = Color.FromRgb((byte)(int)rSlider.Value, (byte)(int)gSlider.Value, (byte)(int)bSlider.Value);
            var clist = GetColorList();
            var a = clist.FirstOrDefault(x => x.Color == col)?.Name ??  "R:" + col.R + " G:" + col.G + " B:" + col.B;
            var color = new MyColor { Color = col, Name = a};
            myColors.Add(new MyColor { Color = col, Name = a });
            colorstock.Items.Add(color.Name);
            
        }

        private void colorstock_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            var selected = colorstock.SelectedItem;
            var color = myColors.Find(x => x.Name == selected.ToString());
            setcolor(color);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selected = (MyColor)((ComboBox)sender).SelectedItem;
            setcolor(selected);
        }
        public void setcolor(MyColor color) {
            rValue.Text = color.Color.R.ToString();
            gValue.Text = color.Color.G.ToString();
            bValue.Text = color.Color.B.ToString();
        }
        
    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }

    
}
