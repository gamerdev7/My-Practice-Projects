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
namespace TypeInfoDisplayer_Application
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

        private void discoverTypeInfo_Click(object sender, RoutedEventArgs e)
        {
            methodsList.Items.Clear();
            propertiesList.Items.Clear();
            constructorsList.Items.Clear();

            string typeName = typeNameBox.Text;
            Type T = Type.GetType(typeName);

            // Methods
            MethodInfo[] methods = T.GetMethods();
            foreach (var method in methods)
            {
                methodsList.Items.Add($"{method.ReturnType.Name} {method.Name}");
            }

            // Properties
            PropertyInfo[] properties = T.GetProperties();
            foreach (var property in properties)
            {
                propertiesList.Items.Add($"{property.PropertyType.Name} {property.Name}");
            }

            // Constructors
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (var constructor in constructors)
            {
                constructorsList.Items.Add(constructor.ToString());
            }

        }
    }
}
