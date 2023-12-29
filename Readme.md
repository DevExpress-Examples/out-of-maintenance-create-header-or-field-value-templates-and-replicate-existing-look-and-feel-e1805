

# Pivot Grid for Web Forms - Create Header or Field Value Templates and Replicate Existing Look-and-Feel

This example demonstrates how to customize the [Field Header](https://docs.devexpress.com/AspNet/3588/components/pivot-grid/ui-elements/column-header-area) and [Field Value](https://docs.devexpress.com/AspNet/3597/components/pivot-grid/ui-elements/field-value) templates, and keep automatic appearance and functionality. It is not possible to simply replace the default Header or Value element with a custom label, because these elements have a really complex layout. Ordinarily, it consists of a table including a few cells with nested items, and attached styles and scripts. These elements are generated dynamically based on the current pivot grid layout.   

This example demonstrates how to customize the templates at runtime. Using this approach, it is possible to call the [CreateFieldValue](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.PivotGridFieldValueTemplateContainer.CreateFieldValue) and [CreateHeader](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.PivotGridHeaderTemplateContainer.CreateHeader) methods to generate the default template content. Then it is possible to replace some of default items with custom ones to introduce a required functionality. 

## Files to Look At

* [Default.aspx](./CS/E1805/Default.aspx) (VB: [Default.aspx](./VB/E1805/Default.aspx))
* [Default.aspx.cs](./CS/E1805/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/E1805/Default.aspx.vb))


## Documentation

- [Save and Restore Layout](https://docs.devexpress.com/AspNet/7266/components/pivot-grid/layout/save-and-restore-layout)

## More Examples
- [How to get an object ID corresponding to a specific Field Value within a custom FieldValueTemplate](https://github.com/DevExpress-Examples/field-value-template-how-to-get-id-value-from-a-hidden-data-source-field-e3278)  
- [How to get a list of higher level field values corresponding to the specific Field Value or Cell and use them in custom templates](https://github.com/DevExpress-Examples/templates-how-to-get-field-values-corresponding-to-the-specific-field-value-or-cell-e3279)  
- [How to replace the default Filter Popup with a custom one made with ASPxGridView control](https://github.com/DevExpress-Examples/how-to-replace-the-default-filter-popup-with-a-custom-one-made-with-aspxgridview-control-e4669)
