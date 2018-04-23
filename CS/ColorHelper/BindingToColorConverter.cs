// Developer Express Code Central Example:
// A general approach to highlighting specific grid cells
// 
// To change a specific grid cell color, use the solution from the Styles and
// Templates Overview (http://documentation.devexpress.com/#WPF/CustomDocument6762)
// article.
// 
// In case of a simple scenario, when you need to highlight a cell
// based on its value or some other property that is available in the current row
// object, just specify a correct binding. For example:
// </para><para><Style
// x:Key="customCellStyle"</para><para>            BasedOn="{StaticResource
// {dxgt:GridRowThemeKey ResourceKey=CellStyle}}"</para><para>
// TargetType="dxg:CellContentPresenter"></para><para>          <Setter
// Property="Background"</para><para>              Value="{Binding
// Path=RowData.Row.SomeFieldName, Converter={local:YourConverter}}"/></para><para>
// </Style></para><para>
// However, if your cells should be colored based on
// complex logic, then a simple binding won't help you. In this case, it is better
// to create an attached property and bind to this property. Then, update this
// property when it is necessary. For example, if a specific row color depends on
// other rows, handle data changes in your datasource and update your attached
// property based on these changes. This example demonstrates the main idea of how
// to implement this functionality.
// See
// also:
// 
// http://www.devexpress.com/scid=E1297
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4181

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

namespace WpfApplication {
    public class BindingToColorConverter : DependencyObject, IMultiValueConverter {
        object IMultiValueConverter.Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            ObservableCollection<HighlightedGridCell> cellsToHighlight = values[0] as ObservableCollection<HighlightedGridCell>;
            object row = values[1];
            object column = values[2];
            return GetColorToHighlight(row, column, cellsToHighlight);
        }
        object[] IMultiValueConverter.ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
        private object GetColorToHighlight(object row, object column, ObservableCollection<HighlightedGridCell> cellsToHighlight) {
            if (row == null || column == null || cellsToHighlight == null)
                return null;
            foreach (HighlightedGridCell cell in cellsToHighlight) {
                if (cell.Column == column && cell.Row == row)
                    return new SolidColorBrush(cell.Color);
            }
            return null;
        }
    }
}