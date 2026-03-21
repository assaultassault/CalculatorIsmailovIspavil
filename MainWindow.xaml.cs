using CalculatorIsmaiov.Lib;
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


namespace CalculatorIsmailov;
    public partial class MainWindow : Window
{
    private string currentOperator = "";
    private double firstNumber = 0;
    private bool isNewInput = true;

    private Class1 calc = new Class1();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Number_Click(object sender, RoutedEventArgs e)
    {
        string value = (sender as Button).Content.ToString();

        if (isNewInput)
        {
            Display.Text = value;
            isNewInput = false;
        }
        else
        {
            Display.Text += value;
        }
    }

    private void Operator_Click(object sender, RoutedEventArgs e)
    {
        firstNumber = double.Parse(Display.Text);
        currentOperator = (sender as Button).Content.ToString();
        isNewInput = true;
    }

    private void Equals_Click(object sender, RoutedEventArgs e)
    {
        double secondNumber = double.Parse(Display.Text);
        double result = 0;

        switch (currentOperator)
        {
            case "+": result = calc.Add(firstNumber, secondNumber); break;
            case "-": result = calc.Subtract(firstNumber, secondNumber); break;
            case "*": result = calc.Multiply(firstNumber, secondNumber); break;
            case "/": result = calc.Divide(firstNumber, secondNumber); break;
            case "^": result = calc.Power(firstNumber, secondNumber); break;
        }

        Display.Text = result.ToString();
        isNewInput = true;
    }

    private void Clear_Click(object sender, RoutedEventArgs e)
    {
        Display.Text = "0";
        firstNumber = 0;
        currentOperator = "";
        isNewInput = true;
    }
}
