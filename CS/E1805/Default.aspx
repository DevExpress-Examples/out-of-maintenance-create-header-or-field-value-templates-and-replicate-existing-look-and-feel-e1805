<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E1805._Default" %>

<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v21.2, Version=21.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dxwpg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <dxwpg:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" 
            DataSourceID="AccessDataSource1" ClientIDMode="AutoID" IsMaterialDesign="False">
            <Fields>
                <dxwpg:PivotGridField ID="fieldSalesPerson" Area="RowArea" AreaIndex="0">
                    <DataBindingSerializable>
                        <dxwpg:DataSourceColumnBinding ColumnName="Sales_Person" />
                    </DataBindingSerializable>
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldExtendedPrice" Area="DataArea" AreaIndex="0">
                    <DataBindingSerializable>
                        <dxwpg:DataSourceColumnBinding ColumnName="Extended_Price" />
                    </DataBindingSerializable>
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldCategoryName" Area="ColumnArea" AreaIndex="0">
                    <DataBindingSerializable>
                        <dxwpg:DataSourceColumnBinding ColumnName="CategoryName" />
                    </DataBindingSerializable>
                </dxwpg:PivotGridField>
            </Fields>
            <OptionsData DataProcessingEngine="Optimized" />
        </dxwpg:ASPxPivotGrid>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/nwind.mdb" 
            SelectCommand="SELECT [Sales Person] AS Sales_Person, [Extended Price] AS Extended_Price, [CategoryName] FROM [SalesPerson]">
        </asp:AccessDataSource>
    
    </div>
    </form>
</body>
</html>
