<!-- default file list -->
*Files to look at*:

* [DataHelper.cs](./CS/dxSample_IAnyControl/Grid%20Data/DataHelper.cs) (VB: [DataHelper.vb](./VB/dxSample_IAnyControl/Grid%20Data/DataHelper.vb))
* [EmployeeSellingByCategoryChartData.cs](./CS/dxSample_IAnyControl/Grid%20Data/EmployeeSellingByCategoryChartData.cs) (VB: [EmployeeSellingByCategoryChartData.vb](./VB/dxSample_IAnyControl/Grid%20Data/EmployeeSellingByCategoryChartData.vb))
* **[EmbeddedChartControl.cs](./CS/dxSample_IAnyControl/IAny%20Files/EmbeddedChartControl.cs) (VB: [EmbeddedChartControl.vb](./VB/dxSample_IAnyControl/IAny%20Files/EmbeddedChartControl.vb))**
* [MainForm.cs](./CS/dxSample_IAnyControl/MainForm.cs) (VB: [MainForm.vb](./VB/dxSample_IAnyControl/MainForm.vb))
* [Program.cs](./CS/dxSample_IAnyControl/Program.cs) (VB: [Program.vb](./VB/dxSample_IAnyControl/Program.vb))
* [UserControl_GridWIthChart.cs](./CS/dxSample_IAnyControl/UserControl_GridWIthChart.cs) (VB: [UserControl_GridWIthChart.vb](./VB/dxSample_IAnyControl/UserControl_GridWIthChart.vb))
<!-- default file list end -->
# How to implement an embedded Chart Control 

<p><strong>Important note.</strong></p>

Starting from version 17.2, the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument8117">Chart Control</a> can be directly embedded in a container control's cells using a RepositoryItemAnyControl object.

## ***If the built-in functionality does not suit you, we will be happy to find the most appropriate solution for you if you describe your real-life scenario. Just click <a href="https://www.devexpress.com/Support/Center/Question/Create">here</a> to submit a ticket to our Support Center.***

To embed a chart into a container control in **previous** versions, you need to manually create a custom chart control that implements the IAnyControlEdit interface. See the example below for more details.<br><br>See also:<br><a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsCustomEditorRepositoryItemAnyControltopic">RepositoryItemAnyControl Class</a>

<br/>
