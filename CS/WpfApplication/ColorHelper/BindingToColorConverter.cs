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
    public class BindingToColorConverter : DependencyObject, IMultiValueConverter
    {


        object IMultiValueConverter.Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            ObservableCollection<HighlightedGridCell> cellsToHighlight = values[0] as ObservableCollection<HighlightedGridCell>;
            object row = values[1];
            object column = values[2];
            return GetColorToHighlight(row, column, cellsToHighlight);
        }

        object[] IMultiValueConverter.ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        private object GetColorToHighlight(object row, object column, ObservableCollection<HighlightedGridCell> cellsToHighlight)
        {
            if (row == null || column == null)
                return null;
            foreach (HighlightedGridCell cell in cellsToHighlight)
            {
                if (cell.Column == column && cell.Row == row)
                    return new SolidColorBrush(cell.Color);
            }
            return null;
        }

     
    }
}