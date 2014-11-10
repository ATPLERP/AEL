<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ERPAdvantage._Default"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" TagPrefix="asp" %>
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
</style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" CombineScripts="false">
        </cc1:ToolkitScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
        <br />
        <br />
            <asp:Button ID="btnPopup" runat="server" Height="34px" Text="Popup" 
                Width="231px" onclick="btnPopup_Click"/>
            
            <%--<asp:ModalPopupExtender ID="btnPopup_ModalPopupExtender" runat="server" 
                DynamicServicePath="" Enabled="True" TargetControlID="btnPopup" 
                BackgroundCssClass="modalBackground" PopupControlID="PanelModal">
           </asp:ModalPopupExtender>--%>
            
            
            <cc1:ModalPopupExtender ID="btnPopup_ModalPopupExtender" runat="server" 
            
                DynamicServicePath="" Enabled="True" TargetControlID="btnPopup" 
                BackgroundCssClass="modalBackground" PopupControlID="PanelModal">
            </cc1:ModalPopupExtender>
           
            <asp:Panel ID="PanelModal" runat="server" style="display:none;background:white;width:80% ;height:auto">
            <div class="modal hide fade">
                <div class="modal-header">
                  <button type="button" class="close" data-dismiss="modal" runat="server" aria-hidden="true">x</button>
                  <h3>Modal header</h3>
                  </div>
                 <div class="modal-body">
                     <asp:Label ID="Label1" runat="server" Text="My First Modal Popup"></asp:Label>
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                <div class="modal-footer">
                <a class="btn" data-dismiss="modal" runat="server" aria-hidden="true">Close</a>
                <a class="btn btn-primary">Save changes</a>
                </div>
           </div>
           </asp:Panel>
    <br />
     </ContentTemplate>
 </asp:UpdatePanel>
</asp:Content>
