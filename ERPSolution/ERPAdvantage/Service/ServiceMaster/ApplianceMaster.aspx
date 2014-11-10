<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ApplianceMaster.aspx.cs" Inherits="ERPAdvantage.Service.ServiceMaster.ApplianceMaster" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1
        {
            width: 66%;
        }
        .auto-style2
        {
            width: 144px;
        }
        .auto-style3
        {
            width: 144px;
            height: 21px;
        }
        .auto-style5
        {
            width: 341px;
        }
        .auto-style6
        {
            height: 21px;
            width: 341px;
        }
        .auto-style7
        {
            width: 144px;
            height: 26px;
        }
        .auto-style8
        {
            width: 341px;
            height: 26px;
        }
        .popupcontrol
        {
            
            height:50px;
            width:50px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

    <asp:Panel runat="server" ID ="Appliancepanel">
            <asp:Label ID="lblstatus" runat="server" BackColor="Transparent"></asp:Label>
            <br />
            <br />
            <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.9em" PathSeparator=" : ">
                <CurrentNodeStyle ForeColor="#333333" />
                <NodeStyle Font-Bold="True" ForeColor="#990000" />
                <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
                <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
            </asp:SiteMapPath>               

        <table class="auto-style1">
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label runat="server" Text ="Appliance Code" />
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtappliancecode" runat="server" Width="284px" OnTextChanged="txtappliancecode_TextChanged" AutoPostBack="True"></asp:TextBox>
                    <asp:Button ID="cmdgetlist" runat="server" Height="23px" Text="...." Width="26px" OnClick="cmdgetlist_Click" />

                            
                 </td>                                                 
                </tr>  
                </table>
            
            <asp:Panel  runat="server" ID="Applist" ScrollBars="Both" Height="200px" Width="603px" Visible="false">
                         <asp:Label ID="Popup" runat="server" Text="Select Appliance"></asp:Label>
                      <br/>
                      <asp:Label ID="Label3" runat="server" Text="Appliance Code" BackColor="Wheat" ForeColor="Blue"/>
                         &nbsp;<asp:TextBox runat="server" ID="txtsearchbyappcode"  Text="%" OnTextChanged="txtsearchbyappcode_TextChanged" Width="187px" />
                      <br />
                      <asp:Label ID="Label5" runat="server" Text="Appliance Name"  BackColor="Wheat" ForeColor="Blue" />
                      <asp:TextBox runat="server" ID="txtsearchbyappname"  Text="%" Height="16px" Width="187px" />
                <asp:Button runat="server" ID ="cmdsearch" Text="Search.." OnClick="cmdsearch_Click" Height="23px" Width="52px" />
                      <br/>                      
                      <asp:GridView ID="GridVapplist" runat="server" AutoGenerateSelectButton="true"  ShowHeader="true" Width="481px" style="overflow:auto"  OnSelectedIndexChanged="GridVapplist_SelectedIndexChanged" />                                            
                      

            </asp:Panel>

             <table class="auto-style1">        
                                
            <tr>
                <td class="auto-style7">
                 
                </td>
                <td class="auto-style8">
                    
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label runat="server" Text="Description" />
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtappliancedesc" runat="server" Width="284px"></asp:TextBox>
            
                </td>
             
                     
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Storage Cost"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtstoragecost" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Estimation Cost"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtestimationcost" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <br />
                </td>
                <td class="auto-style5">
                   <asp:UpdatePanel ID="uplplddlPre" runat="server">
                 <ContentTemplate>
                    <asp:DropDownList ID="ddlappcategory" runat="server" AutoPostBack="true" Height="18px" Width="290px">
                    </asp:DropDownList>
                 <asp:RequiredFieldValidator ID="rfvapptype" runat="server" ErrorMessage="Invalid Appliance Type" ForeColor="Red" ControlToValidate="ddlappcategory">
            </asp:RequiredFieldValidator>
                     </ContentTemplate>
                       </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="cmdsave" runat="server" Height="26px" Text="Save" Width="101px" OnClick="cmdsave_Click" />
                    &nbsp;&nbsp;
                    <asp:Button ID="cmdresetform" runat="server" Height="26px" OnClick="cmdresetform_Click" Text="Reset" Width="101px" />
                </td>
            </tr>
        </table>
        <br />
            

        </asp:Panel>
            </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
