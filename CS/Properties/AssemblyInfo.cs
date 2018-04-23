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

using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("WpfApplication")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("WpfApplication")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

//In order to begin building localizable applications, set 
//<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
//inside a <PropertyGroup>.  For example, if you are using US english
//in your source files, set the <UICulture> to en-US.  Then uncomment
//the NeutralResourceLanguage attribute below.  Update the "en-US" in
//the line below to match the UICulture setting in the project file.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
    //(used if a resource is not found in the page, 
    // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
    //(used if a resource is not found in the page, 
    // app, or any theme specific resource dictionaries)
)]


// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
