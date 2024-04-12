using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace PraktikaVoviy4
{
    public partial class MainWindow : Window
    {
        private Voviy4Entities _base = Voviy4Entities.GetContext();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _base.Agents.Load();
            listViewAgent.ItemsSource = _base.Agents.Local.ToBindingList();
        }

        private void DeliteButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Удвлить запись?", "Удаление записи",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Agent row = (Agent)listViewAgent.SelectedValue;
                    _base.Agents.Remove(row);
                    _base.SaveChanges();
                }

                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберете запись!!!");
                }
            }
        }

        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            int indexRow = listViewAgent.SelectedIndex;
            if (indexRow != -1)
            {
                var row = (Agent)listViewAgent.Items[indexRow];
                Data.Id = row.ID;
                var editMenu = new EditMenu();
                editMenu.ShowDialog();
                listViewAgent.Items.Refresh();
                listViewAgent.Focus();
            }
        }

        private void CreateButtonClick(object sender, RoutedEventArgs e)
        {
            var createMenu = new CreateMenu();
            createMenu.ShowDialog();
            listViewAgent.Focus();
        }
    }
}
