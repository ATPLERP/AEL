<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChargeMaster.aspx.cs" Inherits="ERPAdvantage.Costing.CostingMaster.ChargeMaster" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 219px;
        }

        .auto-style2 {
            width: 124px;
        }

        table {
            width: auto;
            border: 1px solid black;
        }

        th {
            height: 50px;
        }
    </style>
    <style type="text/css">
        .modalBackground {
            background-color: black;
            filter: alpha(opacity=90);
            opacity: 0.8;
        }

        .modalPopup {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            padding-top: 10px;
            padding-left: 10px;
            width: 300px;
            height: 300px;
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
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    <h3 align="center">Common Charge Master
       
    </h3>

    <asp:Panel ID="Panel1" runat="server" Height="130px" BorderColor="Black">
        &nbsp;
        
       
        
         <table border="0" width="300" align="center" cellpadding="5px">
             <tr>
                 <td class="auto-style2">
                     <asp:Label ID="Label1" runat="server" Text="Charge Name"></asp:Label></td>
                 <td class="auto-style1">
                     <asp:TextBox ID="txtCommonCharge" runat="server"></asp:TextBox>
                     <asp:Button ID="btnGetCommonCharge" CssClass="textbox" runat="server" Text="...." Height="19px"  />
                     <br />
                     <asp:Panel ID="Panel2" runat="server" CssClass="modalPopup">
                         welcome to ASP Masters
                            <br />
                         <asp:Button ID="Ok" runat="server" Text="Ok..." />
                     </asp:Panel>

                     <asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server" BackgroundCssClass="modalBackground"
                         OkControlID="Ok" PopupControlID="Panel2" TargetControlID="btnGetCommonCharge">
                     </asp:ModalPopupExtender>
                 </td>
             </tr>

             <tr>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style1">
                     <asp:CheckBox ID="cheVatnumber" runat="server" CssClass="textbox" Text="Applicable For Duty Charges" />
                     <br />
                 </td>
             </tr>


             <tr>
                 <td class="auto-style2">&nbsp;</td>
                 <td class="auto-style1">

                     <asp:DropDownList ID="ddlPrefix" runat="server" CssClass="textbox" AutoPostBack="true" Width="100px">
                     </asp:DropDownList>
                 </td>
             </tr>


             <tr>
                 <td colspan="2" align="center">
                     <asp:Button runat="server" ID="cmdsave" Text="Save" Height="20" Width="80" OnClick="cmdsave_Click" />
                     <asp:Button ID="cmdreset" runat="server" Height="20" Text="Reset" Width="80" />

                 </td>
             </tr>


         </table>
    </asp:Panel>
    <p>
        <br />
    </p>

</asp:Content>
