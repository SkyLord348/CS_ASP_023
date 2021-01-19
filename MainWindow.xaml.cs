using System.Windows;

namespace CS_ASP_024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double[,] priceGrid;


        public MainWindow()
        {
            InitializeComponent();

            priceGrid = new double[3, 3];

            priceGrid[0, 1] = 350.00;
            priceGrid[0, 2] = 700.00;
            priceGrid[1, 0] = 400.00;
            priceGrid[1, 2] = 550.00;
            priceGrid[2, 0] = 375.00;
            priceGrid[2, 1] = 500.00;

            //label3.Content = priceGrid[1, 2].ToString();



        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            int fromCity;

            if (checkBoxFromChicago.IsChecked == true) fromCity = 0;
            else if (checkBoxFromNewYork.IsChecked == true) fromCity = 1;
            else fromCity = 2;

            int toCity;

            if (checkBoxToChicago.IsChecked == true) toCity = 0;
            else if (checkBoxToNewYork.IsChecked == true) toCity = 1;
            else toCity = 2;

            if (fromCity == toCity)
            {

                label3.Content = "";

            }
            else label3.Content = priceGrid[fromCity, toCity].ToString();


        }
    }
}
