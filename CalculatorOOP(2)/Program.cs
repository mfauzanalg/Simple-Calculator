using CalculatorOOP;

namespace CalculatorButton 
{
    public class CalcButton : System.Windows.Controls.Button
    {
        public new void OnClick() 
        {
            this.Click += CalcButton_Click;
        }

        private void CalcButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
