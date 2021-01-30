using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Win32;

namespace StaffApp
{

    public partial class TableWindow : Window
    {
        public TableWindow()
        {
            InitializeComponent();
        }

        private void Button_Load_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".xml";
            bool? resultFile = openFileDialog.ShowDialog();
            if (resultFile != true) return;
            string FilePath = openFileDialog.FileName;

            XDocument doc = XDocument.Load(FilePath);
            var result = doc.Descendants("Employee").Select(x => new
            {
                Id = x.Element("Id")?.Value,
                Name = x.Element("Name")?.Value,
                Age = x.Element("Age")?.Value,
                Experience = x.Element("Experience")?.Value,
                Position = x.Element("Position")?.Value,
                Bookmark = x.Element("Bookmark")?.Value,
            });

            dataGrid.ItemsSource = result;
        }

        private void Button_Delete_OnClick(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Remove(dataGrid.SelectedItem);
        }
    }
}

