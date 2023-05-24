using System.Windows;

namespace TestErrorValidation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int cardinalNumber;

        public int CardinalNumber
        {
            get { return cardinalNumber; }
            set { cardinalNumber = value; }
        }


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            //默认值
            CardinalNumber = 100;

            
        }
    }
}
