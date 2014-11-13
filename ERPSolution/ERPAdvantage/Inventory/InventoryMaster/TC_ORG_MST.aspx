<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TC_ORG_MST.aspx.cs" Inherits="ERPAdvantage.Inventory.InventoryMaster.TC_ORG_MST" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .auto-style1 {
            height: 15.0pt;
            width: 106pt;
        }
        .auto-style2 {
            height: 15.0pt;
            width: 131pt;
        }
        .auto-style3 {
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div>
        <table border="0" cellpadding="0" cellspacing="0" style="border-collapse:
 collapse;width:350pt">
            <colgroup>
                <col style="mso-width-source: userset; mso-width-alt: 4132;" />
            </colgroup>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">&nbsp;</td>
                <td class="auto-style3" height="20">&nbsp;</td>
                <td height="20" width="113">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">&nbsp;</td>
                <td class="auto-style3" height="20">ORGANIZATION MASTER</td>
                <td height="20" width="113">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">&nbsp;</td>
                <td class="auto-style3" height="20">&nbsp;</td>
                <td height="20" width="113">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">ORGANIZATIOIN CD</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_CD" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="__" />
                </td>
                <td height="20" width="113">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">BRANCH FLAG</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_BRANCH_FLAG" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">MAIN CODE</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_MAIN_CODE" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">NAME</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_NAME" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">VAT NO</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_VAT_NO" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">CONT PER</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_CONT_PER" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">ADD</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_ADD" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">CITY</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_CITY" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">PROV</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_PROV" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">CTRY</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_CTRY" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">PIN</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_PIN" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">PH1</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_PH1" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">PH2</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_PH2" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">FAX1</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_FAX1" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">FAX2</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_FAX2" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">E-MAIL</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_EMAIL" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">WEB</td>
                <td class="auto-style3" height="20">
                    <asp:TextBox ID="txtCOM_ORG_WEB" runat="server"></asp:TextBox>
                </td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">&nbsp;</td>
                <td class="auto-style3" height="20">&nbsp;</td>
                <td height="20">&nbsp;</td>
            </tr>
            <tr height="20" style="height:15.0pt">
                <td class="auto-style3" height="20">&nbsp;</td>
                <td class="auto-style3" height="20">
                    <asp:Button ID="cmdSave" runat="server" OnClick="cmdSave_Click" Text="SAVE" Width="101px" />
                </td>
                <td height="20">
                    <asp:Button ID="cmdUpdate" runat="server" Text="UPDATE" Width="101px" />
                </td>
            </tr>
        </table>
    </div>
    <br />
    <br />
</asp:Content>
