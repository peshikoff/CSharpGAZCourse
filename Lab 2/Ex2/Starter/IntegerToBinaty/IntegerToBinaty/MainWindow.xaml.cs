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

namespace IntegerToBinaty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            //Получаем число от пользователя 
            int i;
            if(!int.TryParse(inputTextBox.Text, out i))
            {
                MessageBox.Show("TextBox does not contain an integer");
                return;
            }

            //Проверка на отрицательное число
            if(i<0)
            {
                MessageBox.Show("Please enter a positive number or zero");
                return ;
            }

            /*
             Остаток будет содержать остаток после деления i на 2
             после каждой итерации алгоритма
             */
            int remainder = 0;

            /*
             Двоичный файл будет использоваться для построения строки
             битов, которые представляют i в виде двоичного значения
             */
            StringBuilder binary = new StringBuilder();

            //Генерируем двоичное представление i
            do
            {
                remainder = i % 2;
                i = i / 2;
                binary.Insert(0, remainder);

            } while (i > 0);

            //Отображаем результат
            binaryLabel.Content = binary.ToString();
        }
    }
}
