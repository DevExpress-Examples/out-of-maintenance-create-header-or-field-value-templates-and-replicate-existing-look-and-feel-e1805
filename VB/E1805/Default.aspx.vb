Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxPivotGrid

Namespace E1805
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxPivotGrid1.HeaderTemplate = New HeaderTemplate()
			ASPxPivotGrid1.FieldValueTemplate = New FieldValueTemplate()
		End Sub
	End Class

	Public Class HeaderTemplate
		Implements ITemplate
		Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
			Dim c As PivotGridHeaderTemplateContainer = CType(container, PivotGridHeaderTemplateContainer)
			Dim table As PivotGridHeaderHtmlTable = c.CreateHeader()
			table.Content = New HeaderLink()
			c.Controls.Add(table)
		End Sub
	End Class

	Friend Class FieldValueTemplate
		Implements ITemplate
		Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
			Dim c As PivotGridFieldValueTemplateContainer = CType(container, PivotGridFieldValueTemplateContainer)
			Dim cell As PivotGridFieldValueHtmlCell = c.CreateFieldValue()
			cell.Controls.AddAt(cell.Controls.IndexOf(cell.TextControl), New HeaderLink())
			cell.Controls.Remove(cell.TextControl)
			c.Controls.Add(cell)
		End Sub
	End Class

	Public Class HeaderLink
		Inherits HyperLink
		Public Sub New()
			MyBase.New()
			Text = "Templated Text"
			NavigateUrl = "#"
			Attributes("onclick") = "alert('this is the test prompt')"
		End Sub
	End Class
End Namespace
