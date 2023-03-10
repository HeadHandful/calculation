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
using SF2022UserLibrary;
using System.Windows.Shapes;
using DoctorsScheduleWPF.View.Windows;

namespace DoctorsScheduleWPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для SchedulePage.xaml
    /// </summary>
    public partial class SchedulePage : Page
    {
        public SchedulePage()
        {
            InitializeComponent();
            
            DateTime newdate = DateTime.Now;
            Calculations obj = new Calculations();
            for (int i = 0; i <15 ; i++)
            {
              
                Button but = new Button();
                but.Name = $"ScheduleButton{i+1}";
                but.Click += ScheduleButtonClick;
                but.Content = $"{newdate.ToString(@"dd.MM.yy")}";
                ScheduleStackPanel.Children.Add(but);
                newdate = newdate.AddDays(1);
            }
        }
        private void ScheduleButtonClick(object sender, EventArgs e)
        {
            TableWindow tableWindow = new TableWindow();
            tableWindow.ShowDialog();
        }

    }
}
