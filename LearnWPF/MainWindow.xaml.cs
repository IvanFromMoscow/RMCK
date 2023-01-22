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

namespace LearnWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //    Button myButton = new Button();
            //    myButton.Content = "Кнопка";
            //    myButton.Width = 120;
            //    myButton.Height = 40;
            //    myButton.HorizontalAlignment = HorizontalAlignment.Center;
            //    //myButton.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
            //    // обращение через конвертер для кисти
            ////    myButton.Background = (Brush)System.ComponentModel.TypeDescriptor
            ////.GetConverter(typeof(Brush)).ConvertFromInvariantString("Red");
            //    layoutGrid.Children.Add(myButton);
            //button1.Background = new SolidColorBrush(Colors.Red);
            //button1.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            StackPanel stackPanel = new StackPanel();
            //stackPanel.Children.Add(new TextBlock { Text = "Набор кнопок" });
            //stackPanel.Children.Add(new Button { Content = "Red", Height = 20, Background = new SolidColorBrush(Colors.Red) });
            //stackPanel.Children.Add(new Button { Content = "Yellow", Height = 20, Background = new SolidColorBrush(Colors.Yellow) });
            //stackPanel.Children.Add(new Button { Content = "Green", Height = 20, Background = new SolidColorBrush(Colors.Green) });
            //button1.Content = stackPanel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string text = txtbx1.Text;
            //if (text != "")
            //{
            //    MessageBox.Show(text);
            //}

        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Действие выполнено");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox.Content.ToString() + " отмечен");
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox.Content.ToString() + " не отмечен");
        }

        private void checkBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(checkBox.Content.ToString() + " в неопределенном состоянии");
        }
        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            MessageBox.Show("Узел " + tvItem.Header.ToString() + " раскрыт");
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            MessageBox.Show("Выбран узел: " + tvItem.Header.ToString());
        }
    }
}
