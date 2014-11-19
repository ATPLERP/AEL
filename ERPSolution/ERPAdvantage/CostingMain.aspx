<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CostingMain.aspx.cs" Inherits="ERPAdvantage.CostingMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.9em" PathSeparator=" : ">
        <CurrentNodeStyle ForeColor="#333333" />
        <NodeStyle Font-Bold="True" ForeColor="#990000" />
        <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
        <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
    </asp:SiteMapPath>
    <br />
    <asp:Menu ID="Menu2" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.9em" ForeColor="#284E98" StaticSubMenuIndent="10px">
        <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
        <DynamicMenuItemStyle HorizontalPadding="6px" VerticalPadding="3px" />
        <DynamicMenuStyle BackColor="#B5C7DE" />
        <DynamicSelectedStyle BackColor="#507CD1" />
        <Items>
            <asp:MenuItem Text="Master" Value="Master">
                <asp:MenuItem NavigateUrl="~/Costing/CostingMaster/ChargeMaster.aspx" Text="Charge Master" Value="Charge Master"></asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="Transaction" Value="Transaction">
                <asp:MenuItem NavigateUrl="~/Service/ServiceTransaction/Quotation.aspx" Text="Commercial Invoice" Value="CommercialInvoice"></asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="Report" Value="Report"></asp:MenuItem>
        </Items>
        <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <StaticSelectedStyle BackColor="#507CD1" />
    </asp:Menu>
    <br />
</asp:Content>
