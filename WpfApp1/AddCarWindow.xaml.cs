using System;
using System.Windows;

namespace CarApp
{
    public partial class AddCarWindow : Window
    {
        public Car NewCar { get; private set; }

        public AddCarWindow()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string brand = BrandTextBox.Text;
                string model = ModelTextBox.Text;
                int year = int.Parse(YearTextBox.Text);
                double mileage = double.Parse(MileageTextBox.Text);
                string color = ColorTextBox.Text;

                NewCar = new Car(brand, model, year, mileage, color);
                DialogResult = true; // Установить результат диалога как "Ок"
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; // Установить результат диалога как "Отмена"
            Close();
        }
    }
}
