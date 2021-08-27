<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128577063/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1805)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/E1805/Default.aspx) (VB: [Default.aspx](./VB/E1805/Default.aspx))
* [Default.aspx.cs](./CS/E1805/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/E1805/Default.aspx.vb))
<!-- default file list end -->
# Create Header or Field Value Templates and replicate existing look-and-feel
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1805/)**
<!-- run online end -->


<p>This example demonstrates how to customize the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument3588">Field Header</a> and <a href="https://documentation.devexpress.com/#AspNet/CustomDocument3597">Field Value</a> templates, and keep automatic appearance and functionality. It is not possible to simply replace the default Header or Value element with a custom label, because these elements have a really complex layout. Ordinarily, it consists of a table including a few cells with nested items, and attached styles and scripts. These elements are generated dynamically based on the current pivot grid layout. <br />This example demonstrates how to customize the templates at runtime. Using this approach, it is possible to call the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxPivotGridPivotGridFieldValueTemplateContainer_CreateFieldValuetopic">CreateFieldValue</a> and <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxPivotGridPivotGridHeaderTemplateContainer_CreateHeadertopic">CreateHeader</a> methods to generate the default template content. Then it is possible to replace some of default items with custom ones to introduce a required functionality. </p>
<p><br /><b>See Also:</b> <br /><a href="https://www.devexpress.com/Support/Center/p/E3278">E3278: How to get an object ID corresponding to a specific  Field Value within a custom FieldValueTemplate</a><br /><a href="https://www.devexpress.com/Support/Center/p/E3279">E3279: How to get a list of higher level field values corresponding to the specific Field Value or Cell  and use them in  custom templates</a><br /><a href="https://www.devexpress.com/Support/Center/p/E4669">E4669: How to replace the default Filter Popup with a custom one made with ASPxGridView control</a><br /><a href="https://www.devexpress.com/Support/Center/p/S32439">S32439: Provide the capability to replicate the original look-and-feel and functionality when a header template is set</a></p>

<br/>


