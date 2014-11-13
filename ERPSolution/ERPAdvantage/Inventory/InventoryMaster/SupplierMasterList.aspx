<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SupplierMasterList.aspx.cs" Inherits="ERPAdvantage.Inventory.InventoryMaster.SupplierMasterList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .auto-style2 {
            text-align: center;
        }
        .auto-style1 {
            width: 913px;
            height: 234px;
        }
        .auto-style6 {
            width: 542px;
        }
        .auto-style7 {
            width: 543px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="auto-style2">
        Supplier Master</div>
    <table class="auto-style1">
        <tr>
            <td></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">Supplier ID&nbsp;
                <asp:TextBox ID="SupplierCodeTextBox" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style7">Supplier Type&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">
                <asp:Button ID="cmdButton" runat="server" OnClick="cmdButton_Click" Text="View" Width="79px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="2">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="403px">
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
    <p>
    </p>
    <br />
</asp:Content>
