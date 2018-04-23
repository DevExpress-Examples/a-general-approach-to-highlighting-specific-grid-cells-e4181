using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Markup;
using System.Collections.ObjectModel;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<HighlightedGridCell> cellsToHiglight = new ObservableCollection<HighlightedGridCell>();
            cellsToHiglight.Add(new HighlightedGridCell(gridControl1.GetRow(0), gridControl1.Columns["ID"], Colors.Red));
            CellsHightlightHelper.SetCellsToHighlight(gridControl1, cellsToHiglight);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<HighlightedGridCell> cellsToHiglight = new ObservableCollection<HighlightedGridCell>();
            cellsToHiglight.Add(new HighlightedGridCell(gridControl1.GetRow(1), gridControl1.Columns["Name"], Colors.Yellow));
            cellsToHiglight.Add(new HighlightedGridCell(gridControl1.GetRow(1), gridControl1.Columns["Date"], Colors.Orange));
            CellsHightlightHelper.SetCellsToHighlight(gridControl1, cellsToHiglight);
        }

    
        
    }
}