using System.Windows;
using System.Windows.Controls;

namespace Laba1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SmallButtonClick(object sender, RoutedEventArgs e)
        {
            // Создание новой вкладки
            TabItem NTI = new TabItem();
            NTI.Header = "Тестовая вкладка";


            Grid newTabContent = new Grid();
            NTI.Content = newTabContent;

            //Добавление новой вкладки и переход в нее
            myTabControl.Items.Add(NTI);


            myTabControl.SelectedItem = NTI;


        }
    }
}