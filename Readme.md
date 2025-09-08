<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128647368/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4181)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Grid - Highlight Specific Cells

This example highlights individual [`GridControl`](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridCell.GridControl) cells based on rules that may use data from the current row or other rows. You can target any cell and apply a color at runtime. Use this technique for validation, cross-row checks, or external rules without any column redesign or data model changes.

![Highlight Specific Cells in GridControl](./Images/grid-highlighted-cells.jpg)

## Implementation Details

### Target Cell and Color

The code example defines a record that points to a specific cell and its color:

```csharp
public sealed class HighlightedGridCell {
    public HighlightedGridCell(object row, GridColumn column, Color color) {
        Row = row; Column = column; Color = color;
    }
    public object Row { get; set; }
    public GridColumn Column { get; set; }
    public Color Color { get; set; }
}
```

### Highlighted Cell Collection

The `GridControl` stores the list of highlighted cells in the `CellsToHighlight` attached property. The property accepts the `ObservableCollection<HighlightedGridCell>` and does not require changes to the data model or column styles.

```csharp
public static class CellsHightlightHelper {
    public static readonly DependencyProperty CellsToHighlightProperty =
        DependencyProperty.RegisterAttached(
        "CellsToHighlight",
        typeof(ObservableCollection<HighlightedGridCell>),
        typeof(CellsHightlightHelper), null);

    public static void SetCellsToHighlight(GridControl target,
        ObservableCollection<HighlightedGridCell> value) =>
        target.SetValue(CellsToHighlightProperty, value);

    public static ObservableCollection<HighlightedGridCell> GetCellsToHighlight(DependencyObject target) =>
        (ObservableCollection<HighlightedGridCell>)target.GetValue(CellsToHighlightProperty);
}
```

### Color Converter

The following code example creates a color converter that receives the attached collection, current row, and current column. If a match exists, it returns a brush for the corresponding cell:

```csharp
public sealed class BindingToColorConverter : DependencyObject, IMultiValueConverter {
    public object Convert(object[] values, Type t, object p, CultureInfo c) {
        var list  = values[0] as ObservableCollection<HighlightedGridCell>;
        var row   = values[1];
        var column= values[2];
        if (row == null || column == null || list == null) return null;
        foreach (var cell in list)
        if (cell.Row == row && cell.Column == column)
            return new SolidColorBrush(cell.Color);
        return null;
    }
    public object[] ConvertBack(object v, Type[] ts, object p, CultureInfo c) =>
        throw new NotImplementedException();
}
```

### Cell Background

Bind the cell background to the converter. The binding passes three inputs: 

* The attached collection
* The row object
* The current column

```xaml
<Window.Resources>
  <local:BindingToColorConverter x:Key="CellColorConverter"/>
</Window.Resources>

<Style TargetType="dxg:CellContentPresenter"
       BasedOn="{StaticResource {dxgt:GridRowThemeKey ResourceKey=CellStyle}}">
    <Setter Property="Background">
        <Setter.Value>
        <MultiBinding Converter="{StaticResource CellColorConverter}">
            <!-- Attached collection on the parent GridControl -->
            <Binding RelativeSource="{RelativeSource AncestorType=dxg:GridControl}"
                    Path="(local:CellsHightlightHelper.CellsToHighlight)"/>
            <!-- Current row object -->
            <Binding Path="RowData.Row"/>
            <!-- Current column -->
            <Binding Path="Column"/>
        </MultiBinding>
        </Setter.Value>
    </Setter>
</Style>
```

### Runtime Updates

On page load, the grid highlights a specific cell. When the user clicks the **Button**, the `GridControl` assigns a new collection to the `CellsToHighlight` attached property and updates highlights.


```csharp
public partial class MainWindow : Window {
  public MainWindow() {
    InitializeComponent();
    var cells = new ObservableCollection<HighlightedGridCell> {
      new HighlightedGridCell(gridControl1.GetRow(0), gridControl1.Columns["ID"], Colors.Red)
    };
    CellsHightlightHelper.SetCellsToHighlight(gridControl1, cells);
  }

  void Button_Click(object sender, RoutedEventArgs e) {
    var cells = new ObservableCollection<HighlightedGridCell> {
      new HighlightedGridCell(gridControl1.GetRow(1), gridControl1.Columns["Name"], Colors.Yellow),
      new HighlightedGridCell(gridControl1.GetRow(1), gridControl1.Columns["Date"], Colors.Orange)
    };
    CellsHightlightHelper.SetCellsToHighlight(gridControl1, cells);
  }
}
```

## Files to Review

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [DataHelper.cs](./CS/Model/DataHelper.cs) (VB: [DataHelper.vb](./VB/Model/DataHelper.vb))
* [ViewModel.cs](./CS/ViewModel/ViewModel.cs) (VB: [ViewModel.vb](./VB/ViewModel/ViewModel.vb))
* [BindingToColorConverter.cs](./CS/ColorHelper/BindingToColorConverter.cs) (VB: [BindingToColorConverter.vb](./VB/ColorHelper/BindingToColorConverter.vb))
* [CellsHightlightHelper.cs](./CS/ColorHelper/CellsHightlightHelper.cs) (VB: [CellsHightlightHelper.vb](./VB/ColorHelper/CellsHightlightHelper.vb))
* [HighlightedGridCell.cs](./CS/ColorHelper/HighlightedGridCell.cs) (VB: [HighlightedGridCell.vb](./VB/ColorHelper/HighlightedGridCell.vb))

## Documentation

* [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridCell.GridControl)
* [TableView](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView)
* [Columns](https://docs.devexpress.com/WPF/6093/controls-and-libraries/data-grid/grid-view-data-layout/columns-and-card-fields)
* [CellStyle](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.CellStyle)

## More Examples

* [WPF Data Grid — Specify Custom Content for Column Chooser Headers](https://github.com/DevExpress-Examples/wpf-data-grid-custom-content-for-column-chooser-headers)
* [WPF Data Grid — Bind to Dynamic Data](https://github.com/DevExpress-Examples/wpf-bind-gridcontrol-to-dynamic-data)
* [Implement CRUD Operations in the WPF Data Grid](https://github.com/DevExpress-Examples/wpf-data-grid-implement-crud-operations)
* [WPF Grid — Resize Rows Using a Splitter](https://github.com/sergepilipchuk/wpf-grid-resize-rows-using-splitter)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-grid-highlight-specific-cells&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-grid-highlight-specific-cells&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
