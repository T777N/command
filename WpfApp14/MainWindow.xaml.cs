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
using WpfApp14.Command;

namespace WpfApp14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MessageCommand MessageCommand;
        public string Text { get; set; } = "Salam";
        public MainWindow()
        {
            this.DataContext = this;
            MessageCommand = new MessageCommand(Display);
            InitializeComponent();
        }
        public void Display()
        {
            MessageBox.Show("Hatuna Matata");
        }
        public void Send()
        {
            MessageBox.Show("Message was send successfully");
        }
    }
}
