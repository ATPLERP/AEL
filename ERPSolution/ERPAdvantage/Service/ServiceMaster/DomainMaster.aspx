<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DomainMaster.aspx.cs" Inherits="ERPAdvantage.Service.ServiceMaster.DomainMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style3
        {
            width: 405px;
        }
        .auto-style4
        {
            width: 137px;
        }
        .auto-style7
        {
            width: 80px;
        }
        .auto-style8
        {
            width: 80px;
            height: 30px;
        }
        .auto-style9
        {
            width: 405px;
            height: 30px;
        }
        .auto-style10
        {
            height: 30px;
        }
        .auto-style11
        {
            width: 407px;
        }
        .auto-style13
        {
            width: 88px;
        }
        .auto-style14
        {
            width: 137px;
            height: 38px;
        }
        .auto-style15
        {
            width: 407px;
            height: 38px;
        }
        .auto-style16
        {
            width: 88px;
            height: 38px;
        }
        .auto-style17
        {
            height: 38px;
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


    <asp:UpdatePanel runat ="server">
        <ContentTemplate>
            <asp:ScriptManager runat="server" />

            <asp:Label runat ="server" ID="lblstatus" />
            <br />
            <br />

            <table class="auto-style1">
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="lbldomtype" runat="server" Text="Domain Type"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtdomaintype" runat="server" Height="16px" Width="387px"></asp:TextBox>
            </td>
            <td class="auto-style10">
                <asp:Button ID="btngetdomainlist" runat="server" Text="...." OnClick="btngetdomainlist_Click" />
            </td>
        </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style9">
                        <asp:Button ID="btnaddnewdomaintype" runat="server" OnClick="btnaddnewdomaintype_Click" Text="Add New Type" Width="100px" />
                    </td>
                    <td class="auto-style10">&nbsp;</td>
                </tr>
    </table>

    <asp:Panel  runat="server" ID="Domainlist" ScrollBars="Both" Height="200px" Width="400" Visible="false">
                         <asp:Label ID="Popup" runat="server" Text="Select Domain"></asp:Label>
                                          
                      <br />
                      <asp:Label ID="Label5" runat="server" Text="Domain Name"  BackColor="Wheat" ForeColor="Blue" />
                         &nbsp;<asp:TextBox runat="server" ID="txtsearchbydomname"  Text="%" Height="18px" Width="180px" />
                <asp:Button runat="server" ID ="cmdsearch" Text="Search.." OnClick="cmdsearch_Click" Height="23px" Width="52px" />
                      <br/>                      
                      <asp:GridView ID="GridVdomlist" runat="server" AutoGenerateSelectButton="true"  ShowHeader="true" Width="329px" style="overflow:auto" OnSelectedIndexChanged="GridVdomlist_SelectedIndexChanged"  />                                            
                      

            </asp:Panel>


    <br />
           

            
             <br />
             <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style14">
                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="Label6" runat="server" Text="Domain Code"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:Label ID="Label7" runat="server" Text="Domain Description"></asp:Label>
            </td>
            <td class="auto-style16">
                <asp:Label ID="Label8" runat="server" Text="Prefix"></asp:Label>
            </td>
            <td class="auto-style17"></td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:TextBox ID="txtdomcode" runat="server" Height="18px"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="txtdomaindesc" runat="server" Height="18px" Width="400px"></asp:TextBox>
            </td>
            <td class="auto-style13">
                <asp:TextBox ID="txtdomprefix" runat="server" Height="18px" Width="74px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnadd" runat="server" Text="+" OnClick="btnadd_Click" />
            </td>
        </tr>
    </table>
    <br />

    <asp:Panel  runat="server" ID="tempdom" ScrollBars="Both" Height="150" Width="700" Visible="false">
                       
       
         <asp:GridView ID="gvtemp" runat="server"   ShowHeader="true" Width="650px" style="overflow:auto" AutoGenerateDeleteButton="True" Height="100" OnRowDeleting="gvtemp_RowDeleting" />                                            
                 
         </asp:Panel>
            <br />
            <br />
    <asp:Panel  runat="server" ID="addeddom" ScrollBars="Both" Height="200" Width="700" Visible="false">
        
         <asp:Label ID="Label1" runat="server" Text ="Search Area:" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Code" />
        &nbsp;<asp:TextBox runat="server" ID="txtsearchcode" >%</asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Name" />
        <asp:TextBox runat="server" ID="txtsearchname" Width="200" >%</asp:TextBox>
        <asp:Button runat="server" ID="cmdsearchdomain" Text="...." OnClick="cmdsearchdomain_Click" />
        <br />
        <br />
         <asp:GridView ID="gvaddeddomain" runat="server"  ShowHeader="true" Width="650px" style="overflow:auto" Height="148px" OnRowDeleting="gvaddeddomain_RowDeleting" AutoGenerateDeleteButton="True" />                                                             
         <br />
                 
         </asp:Panel>
        
            <br />
            <br />

            <asp:Button runat="server" ID="cmdsave" Text="Save" Height="20" Width="80" OnClick="cmdsave_Click" />
            &nbsp;&nbsp;
            <asp:Button runat="server" ID="cmdreset" Text="Reset" Height="20" Width="80" OnClick="cmdreset_Click" />
        
    <br />
    <br />

        </ContentTemplate>

    </asp:UpdatePanel>

    
    
    
</asp:Content>
