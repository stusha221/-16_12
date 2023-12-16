using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ЗАНЯТИЕ_16_12
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            string selectedOption = selectedItem.Content.ToString();
            MessageBox.Show("Выбранный вариант: " + selectedOption);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = new Button();
            button.Content = "Наведите курсор для просмотра подсказки";
            ToolTip tooltip = new ToolTip();
            tooltip.Content = "Ваша подсказка здесь";
            button.ToolTip = tooltip;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lb.Items.Add(element.Text);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string ch1 = chislo1.Text;
            int x = Convert.ToInt32(ch1);

            string ch2 = chislo2.Text;
            int y = Convert.ToInt32(ch2);

            int z = x + y;
            otvet.Content = "Сумма введеных чисел: " + z.ToString();
        }
    }
    
}
