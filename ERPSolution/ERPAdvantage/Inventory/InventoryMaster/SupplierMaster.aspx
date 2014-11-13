<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SupplierMaster.aspx.cs" Inherits="ERPAdvantage.Inventory.InventoryMaster.SupplierMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .auto-style33 {
            height: 30px;
            width: 77px;
        }
        .auto-style34 {
            height: 30px;
            width: 297px;
        }
        .auto-style35 {
            height: 30px;
            width: 531px;
        }
        .auto-style36 {
            height: 30px;
            width: 448px;
        }
        .auto-style37 {
            height: 30px;
        }
        .auto-style38 {
            height: 9px;
            width: 77px;
        }
        .auto-style39 {
            height: 9px;
            width: 297px;
        }
        .auto-style40 {
            height: 9px;
            width: 531px;
        }
        .auto-style41 {
            height: 9px;
            width: 448px;
        }
        .auto-style42 {
            height: 9px;
        }
        .auto-style30 {
            height: 20px;
            width: 77px;
        }
        .auto-style26 {
            height: 20px;
            width: 297px;
        }
        .auto-style15 {
            height: 20px;
            width: 531px;
        }
        .auto-style18 {
            height: 20px;
            width: 448px;
        }
        .auto-style3 {
            height: 20px;
        }
        .auto-style31 {
            width: 77px;
        }
        .auto-style27 {
            width: 297px;
        }
        .auto-style14 {
            width: 531px;
        }
        .auto-style17 {
            width: 448px;
        }
        .auto-style32 {
            height: 29px;
            width: 77px;
        }
        .auto-style28 {
            height: 29px;
            width: 297px;
        }
        .auto-style16 {
            height: 29px;
            width: 531px;
        }
        .auto-style19 {
            height: 29px;
            width: 448px;
        }
        .auto-style4 {
            height: 29px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table border="0" cellpadding="0" cellspacing="0" style="border-collapse: collapse; width: 566pt">
        <colgroup>
            <col style="mso-width-source: userset; mso-width-alt: 5266;" />
            <col span="1" />
            <col span="1" />
            <col span="2" style="width:48pt" width="64" />
        </colgroup>
        <tr>
            <td class="auto-style33"></td>
            <td class="auto-style34">SUPPLIER MASTER</td>
            <td class="auto-style35"></td>
            <td class="auto-style36"></td>
            <td class="auto-style37" width="64"></td>
        </tr>
        <tr>
            <td class="auto-style38">
                &nbsp;</td>
            <td class="auto-style39"></td>
            <td class="auto-style40"></td>
            <td class="auto-style41"></td>
            <td class="auto-style42" width="64"></td>
        </tr>
        <tr>
            <td class="auto-style30">SupplierCode</td>
            <td class="auto-style26">
                <asp:TextBox ID="txtSupplierCode" runat="server" Height="16px" Width="119px"></asp:TextBox>
                <asp:Button ID="supplierListCmd" runat="server" Text="...." />
            </td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style18"></td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">Prefix</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtPrefix" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">SupplierName</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">Address</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style30">Country</td>
            <td class="auto-style26">
                <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style15"></td>
            <td class="auto-style18"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">ContactPerson</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtContactPerson" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">MobileNo</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">PhoneNo1</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtPhoneNo1" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">PhoneNo2</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtPhoneNo2" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">Fax</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style30">Email</td>
            <td class="auto-style26">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style15"></td>
            <td class="auto-style18"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style32">VATNo</td>
            <td class="auto-style28">
                <asp:TextBox ID="txtVATNo" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style16"></td>
            <td class="auto-style19"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">TypeOfSupplier</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtTypeOfSupplier" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">PurchaseType</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtPurchaseType" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">LeadTime</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtLeadTime" runat="server">0</asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">CreditLimit</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtCreditLimit" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">CreditLimitTime</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtCreditLimitTime" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">LastPurchaseDate</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtLastPurchaseDate" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">CurrentCreditAmount</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtCurrentCreditAmount" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">VATApplicable</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtVATApplicable" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">Category</td>
            <td class="auto-style27">
                <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">&nbsp;</td>
            <td class="auto-style27">
                <asp:Button ID="btnSave" runat="server" OnClick="SaveButton_Click" Text="Save" Width="122px" />
            </td>
            <td class="auto-style17">
                <asp:Button ID="SaveButton0" runat="server" OnClick="SaveButton_Click" style="margin-bottom: 0px" Text="Reset" Width="122px" />
            </td>
            <td></td>
        </tr>
        <tr height="20">
            <td class="auto-style31" height="20">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style14"></td>
            <td class="auto-style17"></td>
            <td></td>
        </tr>
    </table>
</asp:Content>
