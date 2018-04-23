using System.Collections.ObjectModel;
using System.Windows;
using DevExpress.Xpf.Grid;

namespace WpfApplication {
    public static class CellsHightlightHelper {
        public static readonly DependencyProperty CellsToHighlightProperty = DependencyProperty.RegisterAttached("CellsToHighlight", typeof(ObservableCollection<HighlightedGridCell>), typeof(CellsHightlightHelper), null);

        public static ObservableCollection<HighlightedGridCell> GetCellsToHighlight(DependencyObject target) {
            return (ObservableCollection<HighlightedGridCell>)target.GetValue(CellsToHighlightProperty);
        }
        public static void SetCellsToHighlight(GridControl target, ObservableCollection<HighlightedGridCell> value) {
            target.SetValue(CellsToHighlightProperty, value);
        }
    }
}