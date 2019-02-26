using System.Windows;
using System.Windows.Controls;

namespace WpfTestAutomation
{
    public partial class ButtonExamples : UserControl
    {
        public ButtonExamples()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "clicked";
        }
    }
}
