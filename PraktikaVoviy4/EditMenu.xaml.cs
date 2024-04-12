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
using System.Windows.Shapes;

namespace PraktikaVoviy4
{
    public partial class EditMenu : Window
    {
        Voviy4Entities _base = Voviy4Entities.GetContext();
        Agent _agent = new Agent();

        public EditMenu()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _agent = _base.Agents.Find(Data.Id);

            Name.Text = _agent.Title;
            AgentId.Text = _agent.AgentTypeID.ToString();
            INN.Text = _agent.INN.ToString();
            Phone.Text = _agent.Phone.ToString();
            Priority.Text = _agent.Priority.ToString();
            Artikul.Text = _agent.ID.ToString();
        }

        private void ButtonClickAdd(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (Name.Text.Length == 0)
                errors.AppendLine("Введите название продукта");
            if (AgentId.Text.Length == 0)
                errors.AppendLine("Введите AgentId");
            if (INN.Text.Length == 0)
                errors.AppendLine("Введите ИНН");
            if (Phone.Text.Length == 0)
                errors.AppendLine("Введите Номер Телефона");
            if (Priority.Text.Length == 0)
                errors.AppendLine("Введите приоритетность");
            if (Artikul.Text.Length == 0)
                errors.AppendLine("Введите артикул");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                _agent.Title = Name.Text;
                _agent.AgentTypeID = int.Parse(AgentId.Text);
                _agent.INN = INN.Text;
                _agent.Phone = Phone.Text;
                _agent.Priority = int.Parse(Priority.Text);

                _base.SaveChanges();
                MessageBox.Show("Запись обновлена");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
