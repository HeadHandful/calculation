using DoctorsScheduleWPF.Model;
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

namespace DoctorsScheduleWPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskTableDoctors.xaml
    /// </summary>
    public partial class TaskTableDoctors : Page
    {
        
        public TaskTableDoctors()
        {
            Core db= new Core();
            
            InitializeComponent();
        }

        

        private void MainDataGridSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
