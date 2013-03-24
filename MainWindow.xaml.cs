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
using System.Runtime.InteropServices;
using ClassLibrary1;                    //PROJECT-> Add reference -> point to the .NET DLL assembly 
using Substract;                        //then use the namespace from the assembly as the name in using in this file


namespace WpfApplicationDLL
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int a, b;
            float fA, fB;

            a = int.Parse(textBoxA.Text);
            b = int.Parse(textBoxB.Text);
            fA = float.Parse(textBoxfA.Text);
            fB = float.Parse(textBoxfB.Text);

            try
            {
                ClassLibrary1.Class1 externalDLL = new ClassLibrary1.Class1();
                Substract.Sub substractDLL = new Substract.Sub();

                textBoxCalc.Text = externalDLL.sum(a, b).ToString();
                textBoxCalcSubstract.Text = substractDLL.substract(fA, fB).ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}
