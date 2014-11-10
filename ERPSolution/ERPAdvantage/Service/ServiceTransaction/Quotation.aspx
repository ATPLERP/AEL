<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Quotation.aspx.cs" Inherits="ERPAdvantage.Service.ServiceTransaction.Quotation" %>
<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" TagPrefix="cc1" %>--%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
   
      
    <style type="text/css">
        .auto-style1
        {
            width: 38%;
            height: 236px;
        }
        .auto-style2
        {
            height: 21px;
            width: 226px;
        }
        .auto-style3
        {
            width: 146px;
        }
        .auto-style4
        {
            height: 21px;
            width: 146px;
        }
        .auto-style5
        {
            width: 146px;
            height: 33px;
        }
        .auto-style6
        {
            height: 33px;
            width: 226px;
        }
        .auto-style7
        {
            width: 100%;
        }
        .auto-style8
        {
            width: 287px;
        }
        .auto-style11
        {
            width: 460px;
        }
        .auto-style12
        {
            height: 21px;
            width: 460px;
        }
        .auto-style13
        {
            width: 226px;
        }
        .auto-style14
        {
            width: 69px;
        }
        .auto-style15
        {
            height: 21px;
            width: 69px;
        }
        .auto-style16
        {
            width: 69px;
            height: 8px;
        }
        .auto-style17
        {
            width: 460px;
            height: 8px;
        }
        .auto-style18
        {
            width: 187px;
        }
        .auto-style19
        {
            width: 81px;
        }
    </style>

     <style>
          .modalBackground
          {
           position: absolute;
           top: 0px;
           left: 0px;
           filter: alpha(opacity=60);
           -moz-opacity: 0.6;
            opacity: 0.6;
         }
        .popup
        {
           background-color: #ddd;
           margin: 0px auto;
           width: auto;
           position: relative;
           border: Gray 2px inset;
       }
    </style>

   <%--<script type="text/javascript" language="javascript">
      

       function showDate(sender,args)
       {
           if(sender._textbox.get_element().value == "")
           {
               var todayDate = new Date();
               sender._selectedDate = todayDate;
           }
       }
       </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

    <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.9em" PathSeparator=" : ">
              <CurrentNodeStyle ForeColor="#333333" />
              <NodeStyle Font-Bold="True" ForeColor="#990000" />
              <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
              <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
          </asp:SiteMapPath>

    <br />
    <br />
    <table class="auto-style7">
        <tr>
            <td class="auto-style8">
    <table class="auto-style1" >
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label1" runat="server" Text="Quotation Details Entry"></asp:Label>
            </td>
            <td class="auto-style2"></td>
        </tr>
         
        <tr>
           <td class="auto-style5">
                <asp:Label ID="Label2" runat="server" Text="Quotation Number"></asp:Label>
                <asp:Label ID="Label3" runat="server" ForeColor="#CC0000" Text="*"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtQuotNo" CssClass="textbox" runat="server"></asp:TextBox>
                <asp:Button ID="btnQuotNoSearch" CssClass="textbox" runat="server" Text="....." Height="20px" />
                <div>
                <asp:Panel ID="pnModelPopup" runat="server" CssClass="popup">

            <table>

                <tr>

                    <td class="auto-style19">

                        <asp:Label ID="lblQuatationmodal" runat="server" Text="Quotation Number"></asp:Label>

                    </td>

                    <td>
                        <asp:TextBox ID="txtQuotationNumber" CssClass="textbox" runat="server"></asp:TextBox>
                    </td>
                    <td>
                          <asp:Label ID="lblFromDate" runat="server" Text="From Date"></asp:Label>

                     </td>
                    <td>
                     <asp:CalendarExtender ID="calFromDate" CssClass="textbox" runat="Server" BehaviorID="calFromDate"  TargetControlID="txtFromDate"  /> 
                     <asp:TextBox ID="txtFromDate" runat="server" ></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblTodate" runat="server" Text="To Date"></asp:Label>
                    </td>
                    <td>
                     <asp:CalendarExtender ID="calToDate" CssClass="textbox" runat="Server" BehaviorID="calToDate"  TargetControlID ="txtToDate"  /> 
                     <asp:TextBox ID="txtToDate" runat="server" ></asp:TextBox>
                  
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style19"> 
                        <asp:Label ID="lblCustName" runat="server" Text="Customer Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCustName" CssClass="textbox" runat="server" Height="16px" Width="128px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" CssClass="textbox" Text="Search" />
                    </td>
                     <td>
                        <asp:Button ID="btnCancel" runat="server" CssClass="textbox" Text="Cancel" />
                    </td>
        </tr>

                <tr>
                    <td class="auto-style19">
                        <asp:GridView ID="grvQuotationDetails" CssClass="textbox" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="93px" Visible="true"  Width="266px">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField HeaderText="Quotation No" />
                                <asp:BoundField HeaderText="Customer Name" />
                                <asp:BoundField HeaderText="Date" />
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

        </asp:Panel>
                    
                <asp:ModalPopupExtender ID="btnQuotNoSearch_ModalPopupExtender" runat="server" DropShadow="true" TargetControlID="btnQuotNoSearch"  Drag="true"  
                  PopupControlID="pnModelPopup" OkControlID="btnSearch" CancelControlID="btnCancel" BackgroundCssClass="modalBackground">
                                
                </asp:ModalPopupExtender>
                </div>
               
            </td>
        </tr>
         <asp:RequiredFieldValidator runat="server" id="reqQuotNoSearch" 
                        controltovalidate="txtQuotNo" errormessage="Please enter Quotation No!"  
                        ForeColor="Red" Enabled="true"/>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label4" runat="server" Text="Jobcategory"></asp:Label>
                <asp:Label ID="Label7" runat="server" ForeColor="#CC0000" Text="*"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="ddlJobcategory" CssClass="textbox" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" Text="Customer Order No"></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:TextBox ID="txtCustOrNo" CssClass="textbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label6" runat="server" Text="Quotation Remarks"></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:TextBox ID="txtQuotRemarks" runat="server" Height="64px" TextMode="MultiLine" Width="183px"></asp:TextBox>
            </td>
           
        </tr>
       
    </table>
            </td>
            <td>
                <table class="auto-style7">
                    <tr>
                        <td class="auto-style16">
                            <asp:Label ID="Label8" runat="server" Text="Customer Details"></asp:Label>
                        </td>
                        <td class="auto-style17">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="Label9" runat="server" Text="Name"></asp:Label>
                        </td>
                        <td class="auto-style12">
                            <asp:TextBox ID="txtCustNo" runat="server" CssClass="textbox" Width="30px"></asp:TextBox>
                            <asp:DropDownList ID="ddlPrefix" CssClass="textbox"  runat="server" Height="16px" Width="54px">
                            </asp:DropDownList>
                            <asp:TextBox ID="txtCustNmae" CssClass="textbox"  runat="server" Width="165px"></asp:TextBox>
                            <asp:Button ID="btnGetCustomer" CssClass="textbox"  runat="server" Text="...." Height="19px" />
                            <asp:Button ID="btnCreate"  CssClass="textbox" runat="server" Text="Create" Height="19px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label10" runat="server" Text="Invoice Address"></asp:Label>
                        </td>
                        <td class="auto-style11">
                            <asp:TextBox ID="txtInvAddres"  CssClass="textbox" runat="server" Height="45px" TextMode="MultiLine" Width="235px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="Label11" runat="server" Text="Service Address"></asp:Label>
                        </td>
                        <td class="auto-style12">
                            <asp:TextBox ID="txtSerAddress"  CssClass="textbox" runat="server" Height="42px" Width="231px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label12" runat="server" Text="Area"></asp:Label>
                        </td>
                        <td class="auto-style11">
                            <asp:DropDownList ID="ddlAreaName"  CssClass="textbox" runat="server">
                            </asp:DropDownList>
                            <asp:Label ID="Label16" runat="server" Text="VAT no"></asp:Label>
                            <asp:TextBox ID="txtVatNo"   CssClass="textbox" runat="server" Width="104px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label13" runat="server" Text="Phone"></asp:Label>
                        </td>
                        <td class="auto-style11">
                            <asp:TextBox ID="txtTelPhone" runat="server"  CssClass="textbox"  MaxLength="10" Width="106px"></asp:TextBox>
                            <asp:Label ID="Label17" runat="server" Text="Fax"></asp:Label>
                            <asp:TextBox ID="txtFax" runat="server"  CssClass="textbox" MaxLength="10" Width="104px"></asp:TextBox>
                            <asp:Label ID="Label18" runat="server" Text="Cellular"></asp:Label>
                            <asp:TextBox ID="txtCell" runat="server"  CssClass="textbox" MaxLength="10" Width="86px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label14" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td class="auto-style11">
                            <asp:TextBox ID="txtEmail"  CssClass="textbox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label15" runat="server" Text="Contact Person Inv"></asp:Label>
                        </td>
                        <td class="auto-style11">
                            <asp:TextBox ID="txtContPerInv"  CssClass="textbox"  runat="server" MaxLength="10"></asp:TextBox>
                            <asp:Label ID="Label19" runat="server" Text="Cont Per Service"></asp:Label>
                            <asp:TextBox ID="txtContPerSer"  CssClass="textbox" runat="server" Height="21px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

    <br />
   </ContentTemplate>
          </asp:UpdatePanel>
</asp:Content>
