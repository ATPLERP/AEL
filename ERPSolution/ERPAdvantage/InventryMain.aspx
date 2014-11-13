<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InventryMain.aspx.cs" Inherits="ERPAdvantage.InventryMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.9em" PathSeparator=" : ">
        <CurrentNodeStyle ForeColor="#333333" />
        <NodeStyle Font-Bold="True" ForeColor="#990000" />
        <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
        <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
    </asp:SiteMapPath>
&nbsp;<br />
    <br />
<asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
    <Items>
        <asp:MenuItem Text="Maser" Value="Maser">
            <asp:MenuItem NavigateUrl="~/Inventory/InventoryMaster/SupplierMaster.aspx" Text="Supplier" Value="New Item"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Inventory/InventoryMaster/TC_ORG_MST.aspx" Text="Organization" Value="Organization"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Inventory/InventoryMaster/TI_STORE_MST.aspx" Text="Store" Value="Store"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Inventory/InventoryMaster/ItemMaster.aspx" Text="Item Master" Value="Item Master"></asp:MenuItem>
        </asp:MenuItem>
    </Items>
</asp:Menu>
    <br />
    <asp:Panel ID="Panel1" runat="server" Height="238px" Width="131px">
    </asp:Panel>
    <br />
</asp:Content>
