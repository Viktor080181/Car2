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

namespace CarApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
     public class Car
    {
        public double Mileage { get; set; }
        public string Color { get; set; }
        private string brand; // Марка автомобиля
        private string model; // Модель автомобиля
        private int year;     // Год выпуска

        // Конструктор
        public Car(string brand, string model, int year, double mileage, string color)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.Mileage = mileage;
            this.Color = color;
        }
        // Методы для получения значений полей
        public string GetBrand() => brand;
        public string GetModel() => model;
        public int GetYear() => year;

        // Переопределение метода ToString для отображения информации о машине
        public override string ToString()
        {
            return $"{GetBrand()} {GetModel()} ({GetYear()}), Пробег: {Mileage} км, Цвет: {Color}";
        }

    }/// </summary>

    namespace WpfApp1
    {
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                
                LoadCars();
            }

         
            private void LoadCars()
            {
                List<Car> cars = new List<Car>
            {
                new Car("Toyota", "Camry", 2020, 15000, "Синий"),
                new Car("Honda", "Civic", 2019, 22000, "Красный"),
                new Car("Ford", "Focus", 2021, 8000, "Черный"),
                new Car("BMW", "X5", 2022, 5000, "Белый")
            };

                foreach (var car in cars)
                {
                    CarListBox.Items.Add(car);
                }
            }

            
        }
        public class AddCarWindow
        {
            public string ShowDialog { get; set; }

            private void AddCarButton_Click(object sender, RoutedEventArgs e)
            {
                AddCarWindow addCarWindow = new AddCarWindow();
                if (addCarWindow.ShowDialog() == true)
                {
                    Car newCar = addCarWindow.NewCar;
                    CarListBox.Items.Add(newCar);
                }
            }
        }
    }


}