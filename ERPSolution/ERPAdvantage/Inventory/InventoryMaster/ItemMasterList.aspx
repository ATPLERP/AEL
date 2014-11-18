<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemMasterList.aspx.cs" Inherits="ERPAdvantage.Inventory.InventoryMaster.ItemMasterList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 110px;
        }
        .auto-style3 {
            height: 202px;
        }
        .auto-style7 {
            width: 110px;
            height: 35px;
        }
        .auto-style8 {
            height: 35px;
        }
        .auto-style9 {
            width: 110px;
            height: 34px;
        }
        .auto-style10 {
            height: 34px;
        }
        .auto-style11 {
            height: 35px;
            width: 143px;
        }
        .auto-style12 {
            height: 34px;
            width: 143px;
        }
        .auto-style13 {
            width: 143px;
        }
        .auto-style14 {
            width: 105px;
            height: 35px;
        }
        .auto-style15 {
            width: 105px;
            height: 34px;
        }
        .auto-style16 {
            width: 105px;
        }
        .auto-style17 {
            height: 35px;
            width: 155px;
        }
        .auto-style18 {
            height: 34px;
            width: 155px;
        }
        .auto-style19 {
            width: 155px;
        }
        .auto-style20 {
            height: 35px;
            width: 325px;
        }
        .auto-style21 {
            height: 34px;
            width: 325px;
        }
        .auto-style22 {
            width: 325px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style7">
    <asp:Button ID="btnView0" runat="server" OnClick="btnView_Click" Text="New" Width="85px" PostBackUrl="~/Inventory/InventoryMaster/ItemMasterMst.aspx" />
            </td>
            <td class="auto-style11">
    <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="View" Width="85px" />
            </td>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">Stock Code&nbsp;&nbsp;&nbsp;</td>
            <td class="auto-style11">
    <asp:TextBox ID="txtStockCode" runat="server" Height="22px"></asp:TextBox>
            </td>
            <td class="auto-style14">Item Description</td>
            <td class="auto-style17">
    <asp:TextBox ID="txtItemDescription" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style8">Part No</td>
            <td class="auto-style20">
    <asp:TextBox ID="txtPartNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Major Group&nbsp;</td>
            <td class="auto-style12">
    <asp:TextBox ID="txtMajorGroup" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style15">Model No&nbsp;</td>
            <td class="auto-style18">
    <asp:TextBox ID="txtModelNo" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="6">
    <asp:GridView ID="gvItemMaster" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="198px" Width="416px" AllowPaging="True" AllowSorting="True" EnableSortingAndPagingCallbacks="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:ButtonField Text="Edit" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
    </table>
&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;<br />
    <br />
    <br />
</asp:Content>
