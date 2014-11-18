<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SupplierMasterList.aspx.cs" Inherits="ERPAdvantage.Inventory.InventoryMaster.SupplierMasterList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .auto-style2 {
            text-align: center;
        }
        .auto-style11 {
            width: 100%;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="auto-style2">
        Supplier List</div>
    <br />
    <table class="auto-style11">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnNew" runat="server" OnClick="btnNew_Click" Text="New" Width="93px" />
            </td>
            <td>
                <asp:Button ID="btnView0" runat="server" Text="View" Width="86px" OnClick="btnView_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Supplier Code</td>
            <td>
                <asp:TextBox ID="txtSupplierCode" runat="server"></asp:TextBox>
            </td>
            <td>Supplier Name</td>
            <td><asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Type Of Supplier&nbsp;&nbsp;</td>
            <td>
                <asp:TextBox ID="txtTypeOfSuppler" runat="server"></asp:TextBox>
            </td>
            <td>Country&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td>
                <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:GridView ID="gvSupplierList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="403px" style="margin-bottom: 0px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
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
    </table>
    <br />
</asp:Content>
