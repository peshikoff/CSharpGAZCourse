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

namespace WpfApp1
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            //Дефолтный метод

            double numberDouble;//+переменная
            //Берем число из текстбокса, если взялось и реально double - дальше
            if (!double.TryParse(inputTextBox.Text, out numberDouble))
            {
                MessageBox.Show("Please enter a double");
                return;
            }

            //Проверка на то, что ==положительное число
            if(numberDouble <=0)
            {
                MessageBox.Show("Please enter a positive number");
                return;
            }

            //Используем SQRT метод класса Math
            double squareRoot = Math.Sqrt(numberDouble);

            //Делаем результат в String и выводим его в текст-надпись(лэйбл)
            frameworkLabel.Content 
                = string.Format("{0} (Using .NET Framework)", 
                squareRoot);


            //Метод Ньютона 

            decimal numberDecimal;//+переменная
            //Проверка на сходимость к decimal
            if(!decimal.TryParse(inputTextBox.Text, out numberDecimal))
            {
                MessageBox.Show("Please enter a decimal");
                return;
            }

            /*
             устанавливаем переменной delta минимальный диапазон,
            поддерживаемый decimal типом. Как только разница будет меньше 
            этого значения - останавливаемся.
             */
            decimal delta = Convert.ToDecimal(Math.Pow(10, -28));

            //Делим на 2, чтобы сделать "предположение" ответа
            decimal guess = numberDecimal / 2;

            //Результат первой итерации
            decimal result = ((numberDecimal / guess) + guess / 2);

            /* 
             Пока разница между значениями для каждой текущей итерации 
             не меньше дельты, выполняется еще одну итерациия, чтобы
             уточнить ответ.
            */
            while (Math.Abs(result - guess) > delta)
            {
                //Конец прошлой - начало новой итерации
                guess = result;
                //По новой
                result = ((numberDecimal / guess) + guess )/2;
            }

            //Выводим результат на форму(окно)
            newtonLabel.Content = string.Format("{0} (Using Newton)", result);

        }

    }
}
