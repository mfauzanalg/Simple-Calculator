using CalculatorOOP;
using System.Windows;
using System.Windows.Forms;

namespace CButton
{
    public abstract partial class CalcButton : System.Windows.Forms.Button
    {
        public Button B;
        public abstract void OnClick(object sender, RoutedEventArgs e);
    }
    public class MyButton : Button
    {
        public MyButton() : base()
        {
            // set whatever styling properties needed here
            this.ForeColor = System.Drawing.Color.Red; ;
        }
    }
}