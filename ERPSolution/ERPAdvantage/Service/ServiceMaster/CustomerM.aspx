<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerM.aspx.cs" Inherits="ERPAdvantage.MST.CustomerM" MasterPageFile="~/Site.master" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" TagPrefix="cc1" %>
 <asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
  <style type="text/css">
        .modalBackground
        {
            background-color:Black;
            filter:alpha(opacity = 80);
            opacity:0.8;
            z-index:1000;
        }
         #txtSerAddress
            {
                height: 49px;
            }
            #txtInAddress
            {
                height: 48px;
            }
            .style1
            {
                width: 12px;
            }
            .style2
            {
                width: 23px;
            }
            .style3
            {
                width: 21px;
            }
  </style>
 
 </asp:Content>
 <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

   <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" CombineScripts="false">
   </cc1:ToolkitScriptManager>
      
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
     <ContentTemplate>

    <cc1:ModalPopupExtender ID="btnPopup_ModalPopupExtender" runat="server" 
            
            DynamicServicePath="" Enabled="True" TargetControlID="btnPopup" 
            BackgroundCssClass="modalBackground" PopupControlID="PanelModal">
        </cc1:ModalPopupExtender>

      <asp:Button ID="btnPopup" runat="server" Height="30px" Text="New" 
                Width="151px" onclick="btnPopup_Click"/>
      <asp:Table runat="server">
      
      <asp:TableRow>
     <%-- <asp:TableCell><asp:Image ID="imgAdd" runat="server"  ImageUrl= /> </asp:TableCell>--%>
      
      </asp:TableRow>
      
      </asp:Table> 

           
     </ContentTemplate>
    </asp:UpdatePanel>

 </asp:Content>
 
