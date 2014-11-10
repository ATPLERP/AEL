<%@ Page Title="Area Master" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AreaMaster.aspx.cs" Inherits="ERPAdvantage.Service.ServiceMaster.AreaMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style2
        {
            width: 375px;
        }
        .auto-style4
        {
            width: 195px;
        }
        .auto-style5
        {
            width: 185px;
        }
        .auto-style6
        {
            width: 201px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.9em" PathSeparator=" : ">
        <CurrentNodeStyle ForeColor="#333333" />
        <NodeStyle Font-Bold="True" ForeColor="#990000" />
        <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
        <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
    </asp:SiteMapPath>
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label1" runat="server" Text="Cutomer Service Center"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:DropDownList ID="ddlCutomerServiceCenter" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:Label ID="Label2" runat="server" Text="Area"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlArea" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
                <asp:GridView ID="gvCustomerServiceCenter" runat="server">
                </asp:GridView>
            </td>
            <td colspan="2">
                <asp:GridView ID="gvArea" runat="server">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
