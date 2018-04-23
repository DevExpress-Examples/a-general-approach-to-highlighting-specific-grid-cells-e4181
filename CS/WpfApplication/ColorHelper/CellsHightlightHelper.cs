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
using DevExpress.Xpf.Grid;

namespace WpfApplication
{
    public static class CellsHightlightHelper
    {
        
        public static readonly DependencyProperty CellsToHighlightProperty = DependencyProperty.RegisterAttached("CellsToHighlight", typeof(ObservableCollection<HighlightedGridCell>), typeof(CellsHightlightHelper), null);

  

        public static ObservableCollection<HighlightedGridCell> GetCellsToHighlight(DependencyObject target)
        {
            return (ObservableCollection<HighlightedGridCell>)target.GetValue(CellsToHighlightProperty);
        }
        public static void SetCellsToHighlight(GridControl target, ObservableCollection<HighlightedGridCell> value)
        {
            target.SetValue(CellsToHighlightProperty, value);
        }

        
       
    }
}