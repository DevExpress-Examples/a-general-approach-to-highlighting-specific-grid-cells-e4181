<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128647368/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4181)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [BindingToColorConverter.cs](./CS/ColorHelper/BindingToColorConverter.cs) (VB: [BindingToColorConverter.vb](./VB/ColorHelper/BindingToColorConverter.vb))
* [CellsHightlightHelper.cs](./CS/ColorHelper/CellsHightlightHelper.cs) (VB: [CellsHightlightHelper.vb](./VB/ColorHelper/CellsHightlightHelper.vb))
* [HighlightedGridCell.cs](./CS/ColorHelper/HighlightedGridCell.cs) (VB: [HighlightedGridCell.vb](./VB/ColorHelper/HighlightedGridCell.vb))
* **[MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [DataHelper.cs](./CS/Model/DataHelper.cs) (VB: [DataHelper.vb](./VB/Model/DataHelper.vb))
* [ViewModel.cs](./CS/ViewModel/ViewModel.cs) (VB: [ViewModel.vb](./VB/ViewModel/ViewModel.vb))
<!-- default file list end -->
# A general approach to highlighting specific grid cells


<p>To change a specific grid cell color, use the solution from the <a href="http://documentation.devexpress.com/#WPF/CustomDocument6762">Styles and Templates Overview</a> article.</p>
<br />
<p>In case of a simple scenario, when you need to highlight a cell based on its value or some other property that is available in the current row object, just specify a correct binding. For example:</p>


```xaml
<Style x:Key="customCellStyle" BasedOn="{StaticResource {dxgt:GridRowThemeKey ResourceKey=CellStyle}}" TargetType="dxg:CellContentPresenter">
    <Setter Property="Background" Value="{Binding Path=RowData.Row.SomeFieldName, Converter={local:YourConverter}}"/>
</Style>

Optimized mode
<Style x:Key="customCellStyle" BasedOn="{StaticResource {dxgt:GridRowThemeKey ResourceKey=LightweightCellStyle}}" TargetType="dxg:LightweightCellEditor">
    <Setter Property="Background" Value="{Binding Path=RowData.Row.SomeFieldName, Converter={local:YourConverter}}"/>
</Style>
```


<p>However, if your cells should be colored based on complex logic, then a simple binding won't help you. In this case, it is better to create an attached property and bind to this property. Then, update this property when it is necessary.</p>
<p>For example, if a specific row color depends on other rows, handle data changes in your datasource and update your attached property based on these changes.</p>
<p>This example demonstrates the main idea of how to implement this functionality.</p>
<p><strong>S</strong><strong>ee al</strong><strong>so</strong><strong>:<br /> </strong><br /> <a href="https://www.devexpress.com/Support/Center/p/E1297">How to change background color for modified cells</a></p>

<br/>


