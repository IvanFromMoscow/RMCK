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

namespace UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmbx_countPeriods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Sp_OptionPeriods.Children.RemoveRange(1, Sp_OptionPeriods.Children.Count);
            ComboBox comboBox = (ComboBox)sender;
            var selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            if (selectedItem.Content != null)
            {
                var selectedValue = selectedItem.Content.ToString();
                if (int.TryParse(selectedValue, out int selectedPeriod))
                {
                    CreateStackPanel(selectedPeriod);
                }
            }
            else
            {
                CreateStackPanel(1);
            }
        }
        private void CreateStackPanel(int count)
        {
            for (int i = 0; i < count; i++)
            {
                StackPanel sp = new StackPanel
                {
                    Name = "myPanel" + i,
                    Orientation = Orientation.Horizontal
                };
                Sp_OptionPeriods.Children.Add(sp);
                var exp = new Expander();
                for (var j = 0; j < 2; j++) // The 10 here could be any number
                {
                    exp.Name = "exp_period" + j;
                    exp.Header = "Этап - " + (i + 1);
                    exp.Content = new CheckBox { Content = "Новый флажок", MinHeight = 20, IsChecked = true };
                }
                sp.Children.Add(exp);
            }
        }
    }
}
