<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemMaster.aspx.cs" Inherits="ERPAdvantage.Inventory.InventoryMaster.ItemMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .auto-style8 {
            color: black;
            font-size: 11.0pt;
            font-weight: 400;
            font-style: normal;
            text-decoration: none;
            font-family: Calibri, sans-serif;
            text-align: general;
            vertical-align: bottom;
            white-space: nowrap;
            border-style: none;
            border-color: inherit;
            border-width: medium;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style9 {
            color: black;
            font-size: 11.0pt;
            font-weight: 400;
            font-style: normal;
            text-decoration: none;
            font-family: Calibri, sans-serif;
            text-align: general;
            vertical-align: bottom;
            white-space: nowrap;
            border-style: none;
            border-color: inherit;
            border-width: medium;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
            height: 20px;
        }
        .auto-style10 {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table border="0" cellpadding="0" cellspacing="0" style="border-collapse: collapse; width: 382pt">
        <colgroup>
            <col style="mso-width-source:userset;mso-width-alt:2377;width:49pt" width="65" />
            <col style="mso-width-source:userset;mso-width-alt:3949;width:81pt" width="108" />
            <col span="1" />
            <col span="1" />
            <col span="1" style="width:48pt" width="64" />
        </colgroup>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20">&nbsp;</td>
            <td class="auto-style8" width="108">ITEM MASTER</td>
            <td width="64">&nbsp;</td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>StockCode</td>
            <td>
                <asp:TextBox ID="txtStockCode" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtStockCode" ErrorMessage="*" ForeColor="red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>ItemDescription</td>
            <td>
                <asp:TextBox ID="txtItemDescription" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="popStockCode" runat="server" Text="__" />
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtItemDescription" ErrorMessage="*" ForeColor="red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style10">MajorGroup</td>
            <td class="auto-style10">
                <asp:TextBox ID="txtMajorGroup" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style10"></td>
            <td class="auto-style9">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMajorGroup" ErrorMessage="*" ForeColor="red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>Appliance</td>
            <td>
                <asp:TextBox ID="txtAppliance" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAppliance" ErrorMessage="*" ForeColor="red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style8">Brand</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtBrand" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style8"></td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtBrand" ErrorMessage="*" ForeColor="red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>ModelNo</td>
            <td>
                <asp:TextBox ID="txtModelNo" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtModelNo" ErrorMessage="*" ForeColor="red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>Capacity</td>
            <td>
                <asp:TextBox ID="txtCapacity" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>PurchaseType</td>
            <td>
                <asp:DropDownList ID="txtPurchaseType" runat="server">
                    <asp:ListItem Value="I">Import</asp:ListItem>
                    <asp:ListItem Value="L">Local</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>FSN</td>
            <td>
                <asp:DropDownList ID="txtFSN" runat="server">
                    <asp:ListItem Value="N">Normal</asp:ListItem>
                    <asp:ListItem Value="F">Fixed Asset</asp:ListItem>
                    <asp:ListItem Value="S">Sandry</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>VATPercentage</td>
            <td>
                <asp:TextBox ID="txtVATPercentage" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>UoM</td>
            <td>
                <asp:TextBox ID="txtUoM" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>LifeTime</td>
            <td>
                <asp:TextBox ID="txtLifeTime" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>Obsolete</td>
            <td>
                <asp:DropDownList ID="txtObsolete" runat="server">
                    <asp:ListItem Value="Y">Yes</asp:ListItem>
                    <asp:ListItem Value="N">No</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>HSCode</td>
            <td>
                <asp:TextBox ID="txtHSCode" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>LastGRNNo</td>
            <td>
                <asp:TextBox ID="txtLastGRNNo" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>LastInCost</td>
            <td>
                <asp:TextBox ID="txtLastInCost" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>AverageCost</td>
            <td>
                <asp:TextBox ID="txtAverageCost" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>StockApplicable</td>
            <td>
                <asp:DropDownList ID="txtStockApplicable" runat="server">
                    <asp:ListItem Value="Y">Yes</asp:ListItem>
                    <asp:ListItem Value="N">No</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>LedgerCode</td>
            <td>
                <asp:TextBox ID="txtLedgerCode" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>CreatedBy</td>
            <td>
                <asp:TextBox ID="txtCreatedBy" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>CreateDate</td>
            <td>
                <asp:TextBox ID="txtCreateDate" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>InstllationAmt</td>
            <td>
                <asp:TextBox ID="txtInstllationAmt" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>PartNo</td>
            <td>
                <asp:TextBox ID="txtPartNo" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtPartNo" ErrorMessage="*" ForeColor="red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>ST</td>
            <td>
                <asp:TextBox ID="txtST" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>NormCode</td>
            <td>
                <asp:TextBox ID="txtNormCode" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>RateCategory</td>
            <td>
                <asp:TextBox ID="txtRateCategory" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>JobType</td>
            <td>
                <asp:TextBox ID="txtJobType" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>Duration</td>
            <td>
                <asp:TextBox ID="txtDuration" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>Meterial</td>
            <td>
                <asp:TextBox ID="txtMeterial" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>Labour</td>
            <td>
                <asp:TextBox ID="txtLabour" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style8">Points</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtPoints" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style8"></td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20"></td>
            <td>CommonJob</td>
            <td>
                <asp:DropDownList ID="txtCommonJob" runat="server">
                    <asp:ListItem Value="Y">Yes</asp:ListItem>
                    <asp:ListItem Value="N">No</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style8"></td>
        </tr>
        <tr height="20" style="height:15.0pt">
            <td class="auto-style8" height="20">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnSave" runat="server" OnClick="cmdSave_Click" Text="Save" Width="102px" />
            </td>
            <td>&nbsp;</td>
            <td class="auto-style8">
                <asp:Button ID="btnReset" runat="server" Text="Reset" Width="84px" />
            </td>
        </tr>
    </table>
</asp:Content>
