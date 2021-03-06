﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Quotation.aspx.cs" Inherits="ERPAdvantage.Service.ServiceTransaction.Quotation" %>
<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" TagPrefix="cc1" %>--%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  
    <style type="text/css">
        .auto-style1
        {
            width: 38%;
            height: 236px;
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
            width: 122px;
        }
        .auto-style7
        {
            width: 91%;
            height: 96px;
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
           width: 401px;
           position: relative;
           border: Gray 2px inset;
             top: 0px;
             left: 0px;
             height: 54px;
         }
         .auto-style20
         {
             height: 22px;
         }
         .auto-style22
         {
             height: 21px;
             width: 122px;
         }
         .auto-style23
         {
             width: 122px;
         }
         .auto-style25
         {
             height: 22px;
         }
         .auto-style29
         {
             height: 37px;
             }
         .auto-style30
         {
             width: 609px;
             height: 186px;
         }
         .auto-style37
         {
             height: 22px;
             width: 56px;
         }
         .auto-style39
         {
             height: 37px;
             width: 56px;
         }
         .auto-style41
         {
             height: 37px;
             width: 4px;
         }
         .auto-style42
         {
             height: 22px;
             width: 4px;
         }
         .auto-style43
         {
             width: 85px;
             height: 37px;
         }
         .auto-style46
         {
             width: 67px;
             height: 37px;
         }
         .auto-style47
         {
             height: 37px;
             width: 58px;
         }
         .auto-style48
         {
             height: 22px;
             width: 58px;
         }
         .auto-style49
         {
             width: 134%;
             height: 3px;
         }
         .auto-style61
         {
             height: 9px;
             width: 42px;
         }
         #div2
         {
             height: 170px;
             width: 972px;
             margin-bottom: 0px;
         }
         .auto-style62
         {
             height: 168px;
             width: 1065px;
         }
         .auto-style64
         {
             width: 51px;
         }
         .auto-style65
         {
             height: 9px;
             width: 51px;
         }
         .auto-style67
         {
             width: 44px;
         }
         .auto-style68
         {
             height: 9px;
             width: 44px;
         }
         .auto-style79
         {
             height: 9px;
             width: 67px;
         }
         .auto-style81
         {
             width: 67px;
         }
         .auto-style82
         {
             width: 36px;
         }
         .textbox
         {
             margin-bottom: 0px;
         }
         .auto-style86
         {
             width: 12px;
         }
         .auto-style92
         {
             width: 30px;
         }
         .auto-style93
         {
             height: 22px;
             width: 30px;
         }
         .auto-style94
         {
             width: 28px;
         }
         .auto-style95
         {
             height: 22px;
             width: 12px;
         }
         .auto-style99
         {
             height: 9px;
             width: 30px;
         }
         .auto-style102
         {
             width: 83px;
         }
         .auto-style103
         {
             height: 9px;
             width: 83px;
         }
         .auto-style106
         {
             width: 57px;
         }
         .auto-style107
         {
             height: 9px;
             width: 57px;
         }
         .auto-style108
         {
         }
         .auto-style109
         {
             width: 75px;
             height: 9px;
         }
         .auto-style110
         {
             width: 36px;
             height: 9px;
         }
         .auto-style111
         {
             height: 9px;
         }
         </style>

 <%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" TagPrefix="cc1" %>--%>
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
        <asp:Label ID="lblStates" runat="server" CssClass="textbox"></asp:Label>
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
            <td class="auto-style22"></td>
        </tr>
         
        <tr>
           <td class="auto-style5">
                <asp:Label ID="Label2" runat="server" Text="Quotation Number"></asp:Label>
                <asp:Label ID="Label3" runat="server" ForeColor="#CC0000" Text="*"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtQuotNo" CssClass="textbox" runat="server" AutoPostBack="true"></asp:TextBox>
<<<<<<< HEAD
                <asp:Button ID="btnQuotNoSearch" CssClass="textbox" runat="server" Text="....." Height="20px" OnClick="btnQuotNoSearch_Click"/>
                <asp:Label ID="lblStates" runat="server" CssClass="textbox"></asp:Label>
=======
                <asp:Button ID="btnQuotNoSearch" CssClass="textbox" runat="server" Text="....." Height="20px"/>
                <%--<asp:Label ID="lblStates" runat="server" CssClass="textbox"></asp:Label>--%>
>>>>>>> f4d26e9aa5b1326548e7612421016d59e416394d
                <div>
             <asp:Panel ID="pnModelPopup" runat="server" BorderStyle="Solid" Height="200px" Width="600px" CssClass="popup">
             <table class="auto-style30">
                <tr>
                    <td class="auto-style19">
                        <asp:Label ID="lblQuatationmodal" runat="server" Text="Quotation Number"></asp:Label>
                    </td>
                    <td class="auto-style43">
                       <asp:UpdatePanel runat="server" ID="updtxtQuotation">
                        <ContentTemplate>
                        <asp:TextBox ID="txtQuotationNumber" runat="server" CssClass="textbox" AutoPostBack="true"   Height="18px" Width="174px"></asp:TextBox>
                       </ContentTemplate>
                        </asp:UpdatePanel>
                             </td> 
                    <td class="auto-style46">
                          <asp:Label ID="lblFromDate" runat="server" Text="From Date"></asp:Label>

                     </td>
                    <td class="auto-style41">
                          <asp:TextBox ID="txtFromDate" runat="server" Height="16px" Width="74px"></asp:TextBox>

                     </td>
                    <td class="auto-style47">
                        <asp:Label ID="lblTodate" runat="server" Text="To Date"></asp:Label>
                    </td>
                    <td class="auto-style39">
                     <asp:CalendarExtender ID="calFromDate" CssClass="textbox" runat="Server"  EnabledOnClient="true"   Animated="true" PopupPosition="TopRight" BehaviorID="calFromDate" TargetControlID="txtFromDate"/> 
                        <asp:TextBox ID="txtToDate" runat="server" Height="16px" Width="77px"></asp:TextBox>
                    </td>
                    <td class="auto-style29">
                        <asp:CalendarExtender ID="calToDate" runat="Server" BehaviorID="calToDate" CssClass="textbox" TargetControlID="txtToDate" />
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style19"> 
                        <asp:Label ID="lblCustName" runat="server" Text="Customer Name"></asp:Label>
                    </td>
                    <td class="auto-style25" colspan="2">
                        <asp:TextBox ID="txtCustName" runat="server" CssClass="textbox" Height="16px" Width="240px"></asp:TextBox>
                    </td>
                    <td class="auto-style42">
                        &nbsp;</td>
                     <td class="auto-style48">
                         <asp:UpdatePanel ID="upSearch" runat="server">
                             <ContentTemplate>
                                 <asp:Button ID="btnSearch" runat="server" CssClass="textbox" OnClick="btnSearch_Click" Text="Search" />
                             </ContentTemplate>
                         </asp:UpdatePanel>
                    </td>
                     <td class="auto-style37">
                        <asp:Button ID="btnCancel" runat="server" CssClass="textbox" Text="Cancel" />
                    </td>
         </tr>

                 <tr>
                     <td class="auto-style20" colspan="6">
                         <div id="divGv" runat="server">
                         <asp:Panel ID="Panel1" ScrollBars="Both" Height="112px" Width="575px" runat="server">
                              <asp:UpdatePanel ID="updpnlGV" runat="server" UpdateMode="Conditional">
                              <ContentTemplate>
                         <asp:GridView ID="gvQuotationDetails" EmptyDataText="No data available"  runat="server"  AutoGenerateSelectButton="true" AutoGenerateColumns="False" CellPadding="4" CssClass="textbox" ForeColor="#333333" GridLines="None" Height="22px" OnPageIndexChanging="gvQuotationDetails_PageIndexChanging" PageSize="5"  AllowPaging="True" Width="559px" DataKeyNames="QuoationNo" OnSelectedIndexChanged="gvQuotationDetails_SelectedIndexChanged">
                             <AlternatingRowStyle BackColor="White"/>
                             <Columns>
                                 <asp:BoundField DataField="QuoationNo" HeaderText="Quoation No" />
                                 <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                                 <asp:BoundField DataField="QuoationDate" HeaderText="Date" />
                             </Columns>
                             <EditRowStyle BackColor="#2461BF" />
                             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                             <PagerSettings FirstPageText="First" LastPageText="Last" PageButtonCount="4" />
                             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                             <RowStyle BackColor="#EFF3FB" />
                             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                             <SortedAscendingCellStyle BackColor="#F5F7FB" />
                             <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                             <SortedDescendingCellStyle BackColor="#E9EBEF" />
                             <SortedDescendingHeaderStyle BackColor="#4870BE" />
                         </asp:GridView>
                         </ContentTemplate>
                        </asp:UpdatePanel>
                        </asp:Panel>
                        </div>
                     </td>
                 </tr>

            </table>

        </asp:Panel>
                    
                <asp:ModalPopupExtender ID="btnQuotNoSearch_ModalPopupExtender" runat="server" DropShadow="true" TargetControlID="btnQuotNoSearch"  Drag="true"  
                  PopupControlID="pnModelPopup" OnOkScript="btnSearch" CancelControlID="btnCancel"  PopupDragHandleControlID="pnModelPopup"  RepositionMode="RepositionOnWindowResizeAndScroll" BackgroundCssClass="modalBackground">
                </asp:ModalPopupExtender>
                </div>
               
            </td>
        </tr>
         <asp:RequiredFieldValidator runat="server" id="reqQuotNoSearch" 
                        controltovalidate="txtQuotNo" errormessage="Please enter Quotation No!"  
                        ForeColor="Red" Enabled="false"/>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label4" runat="server" Text="Jobcategory"></asp:Label>
                <asp:Label ID="Label7" runat="server" ForeColor="#CC0000" Text="*"></asp:Label>
            </td>
            <td class="auto-style22">
                <asp:DropDownList ID="ddlJobcategory" CssClass="textbox" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" Text="Customer Order No"></asp:Label>
            </td>
            <td class="auto-style23">
                <asp:TextBox ID="txtCustOrNo" CssClass="textbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label6" runat="server" Text="Quotation Remarks"></asp:Label>
            </td>
            <td class="auto-style23">
                <asp:TextBox ID="txtQuotRemarks" runat="server" Height="48px" TextMode="MultiLine" Width="183px"></asp:TextBox>
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
                            <asp:TextBox ID="txtCustCode" runat="server" CssClass="textbox" Width="30px"></asp:TextBox>
                            <asp:DropDownList ID="ddlPrefix" CssClass="textbox"  runat="server" Height="16px" Width="54px">
                            </asp:DropDownList>
                            <asp:TextBox ID="txtCustNmae" CssClass="textbox"  runat="server" Width="165px"></asp:TextBox>
                            <asp:Button ID="btnGetCustomer" CssClass="textbox"  runat="server" Text="...." Height="19px" />
                            <asp:Button ID="btnCreate"  CssClass="textbox" runat="server" Text="Create" Height="19px" OnClick="btnCreate_Click" />
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
                            <asp:TextBox ID="txtSerAddress"  CssClass="textbox" runat="server" Height="39px" Width="231px" TextMode="MultiLine"></asp:TextBox>
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
                            <asp:TextBox ID="txtFax" runat="server"  CssClass="textbox" MaxLength="10" Width="104px" Height="22px"></asp:TextBox>
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
            
        <table class="auto-style49">
            <table>
            <tr>
                <td class="auto-style82">
                    <asp:Label ID="Label20" runat="server" Text="Appliance Code"></asp:Label>
                </td>
                <td class="auto-style82">
                    </td>
                <td>
                    <asp:Label ID="Label21" runat="server" Text="Description"></asp:Label>
                </td>
                <td class="auto-style64">
                    <asp:Label ID="Label22" runat="server" Text="Item Modal"></asp:Label>
                </td>
                <td class="auto-style67">
                    <asp:Label ID="Label23" runat="server" Text="Item Serial No"></asp:Label>
                </td>
                <td class="auto-style81">
                    <asp:Label ID="Label24" runat="server" Text="Item Capacity"></asp:Label>
                </td>
                <td class="auto-style106">
                    <asp:Label ID="Label25" runat="server" Text="Type"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label27" runat="server" Text="Quantity"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label28" runat="server" Text="Price"></asp:Label>
                </td>
                <td class="auto-style108" colspan="2">
                    <asp:Label ID="Label29" runat="server" Text="Discount"></asp:Label>
                </td>
                <td class="auto-style92">
                    <asp:Label ID="Label30" runat="server" Text="NBT"></asp:Label>
                </td>
                <td class="auto-style102">
                    <asp:Label ID="Label31" runat="server" Text="VAT"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label32" runat="server" Text="Total"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style110">
                    <asp:TextBox ID="txtAppliaenceCode" runat="server" CssClass="textbox" Height="16px" Width="75px"></asp:TextBox>
                </td>
               <td class="auto-style110">
                <div>
                 <asp:Panel ID="pnModelPopupitem" runat="server" BorderStyle="Solid" CssClass="popup" Height="200px" Width="600px">
                     <table class="auto-style30">
                 <tr>
                     <td class="auto-style19">
                        <asp:Label ID="lblItemCode" runat="server" Text="ItemCode"></asp:Label>
                    </td>
                    <td class="auto-style92">
                       <asp:UpdatePanel runat="server" ID="UpdatePanel2">
                        <ContentTemplate>
                        <asp:TextBox ID="txtItemCode" runat="server" CssClass="textbox" AutoPostBack="true"   Height="18px" Width="174px"></asp:TextBox>
                       </ContentTemplate>
                        </asp:UpdatePanel>
                    </td> 

                     <td class="auto-style94">
                          <asp:Label ID="lblMajorGroup" runat="server" Text="Major Group"></asp:Label>

                     </td>
                    <td class="auto-style86">
                       
                        <asp:DropDownList ID="ddlMajorGroup"  CssClass="textbox" runat="server"></asp:DropDownList>
                     </td>
                                    
                </tr>
                <tr>
                    <td class="auto-style19"> 
                        <asp:Label ID="lblItemName" runat="server" Text="Item Name" EnableViewState="False"></asp:Label>
                    </td>
                    <td class="auto-style93">
                        <asp:TextBox ID="txttItemname" runat="server" CssClass="textbox" Height="16px" Width="174px"></asp:TextBox>
                    </td>
                    <td class="auto-style94"> 
                        <asp:Label ID="lblApplianceCode" runat="server" Text="Appliance" EnableViewState="False"></asp:Label>
                    </td>
                    <td class="auto-style95" colspan="2">
                        <asp:DropDownList ID="ddlApplianceCode"  CssClass="textbox" runat="server"></asp:DropDownList>
                    </td>
                     <tr>
                   <td class="auto-style48">
                         <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                             <ContentTemplate>
                                 <asp:Button ID="btnItemSearch" runat="server" CssClass="textbox" OnClick="btnItemSearch_Click" Text="Search" />
                             </ContentTemplate>
                         </asp:UpdatePanel>
                    </td>
                     <td class="auto-style93">
                        <asp:Button ID="btnItemCancel" runat="server" CssClass="textbox" Text="Cancel" />
                    </td>
                          <caption>
                              <tr>
                                  <td class="auto-style20" colspan="6">
                                      <div id="div1" runat="server">
                                          <asp:Panel ID="Panel3" runat="server" Height="121px" ScrollBars="Both" Width="590px">
                                              <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                                                  <ContentTemplate>
                                                      <asp:GridView ID="gvOrgItemList" runat="server" AllowPaging="True" AutoGenerateColumns="False" AutoGenerateSelectButton="true" AutoPostBack="True" CellPadding="4" CssClass="textbox" DataKeyNames="StockCode" EmptyDataText="No data available" ForeColor="#333333" GridLines="None" Height="35px" OnPageIndexChanging="gvOrgItemList_PageIndexChanging" OnSelectedIndexChanged="gvOrgItemList_SelectedIndexChanged" PageSize="5" Width="562px" OnPageIndexChanged="gvOrgItemList_PageIndexChanged">
                                                          <AlternatingRowStyle BackColor="White" />
                                                          <Columns>
                                                              <asp:BoundField DataField="ItemCode" HeaderText="Item ID"/>
                                                              <asp:BoundField DataField="StockCode" HeaderText="Stock code"/>
                                                              <asp:BoundField DataField="ItemDescription" HeaderText="Item Name"/>
                                                              <asp:BoundField DataField="MajorGroup" HeaderText="Major Group"/>
                                                              <asp:BoundField DataField="Appliance" HeaderText="Appliance"/>
                                                              <asp:BoundField DataField="Brand" HeaderText="Brand"/>
                                                              <asp:BoundField DataField="ModelNo" HeaderText="Model No"/>
                                                          </Columns>
                                                          <EditRowStyle BackColor="#2461BF" />
                                                          <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                          <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                          <PagerSettings FirstPageText="First" LastPageText="Last" PageButtonCount="4" />
                                                          <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                                          <RowStyle BackColor="#EFF3FB" />
                                                          <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                                          <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                                          <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                                          <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                                          <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                                      </asp:GridView>
                                                  </ContentTemplate>
                                              </asp:UpdatePanel>
                                          </asp:Panel>
                                      </div>
                                  </td>
                              </tr>
                          </caption>
                    </table>
                 </asp:Panel>
                <asp:ModalPopupExtender ID="btnApplianceList_ModalPopupExtender" Enabled="True" Drag="true" runat="server" DropShadow="true"  OnOkScript="btnItemSearch" CancelControlID="btnItemCancel" PopupControlID="pnModelPopupitem"  PopupDragHandleControlID="pnModelPopupitem"  RepositionMode="RepositionOnWindowResizeAndScroll" BackgroundCssClass="modalBackground" TargetControlID="btnApplianceList">
               </asp:ModalPopupExtender>  
               </div>
               <asp:Button ID="btnApplianceList" CssClass="textbox" runat="server" Height="21px" Text="..." Width="24px" OnClick="btnApplianceList_Click" />
             </td>

                <td class="auto-style111">
                    <asp:TextBox ID="txtDescription" runat="server" CssClass="textbox" Width="107px" Height="16px"></asp:TextBox>
                </td>
                <td class="auto-style65">
                    <asp:TextBox ID="txtItemModal" runat="server" CssClass="textbox" Height="16px" Width="58px"></asp:TextBox>
                </td>
                <td class="auto-style68">
                    <asp:TextBox ID="txtItemSerial" runat="server" CssClass="textbox" Height="16px" Width="46px"></asp:TextBox>
                </td>
                <td class="auto-style79">
                    <asp:TextBox ID="txtItemCapacity" runat="server" CssClass="textbox" Width="38px" Height="16px"></asp:TextBox>
                </td>
                <td class="auto-style107">
                    <asp:DropDownList ID="ddlType" runat="server" CssClass="textbox" Width="57px">
                        <asp:ListItem>OG</asp:ListItem>
                        <asp:ListItem>UG</asp:ListItem>
                        <asp:ListItem>NA</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style111">
                    <asp:TextBox ID="txtQuontaty" runat="server" CssClass="textbox" Width="45px" Height="16px">0</asp:TextBox>
                </td>
                <td class="auto-style111">
                  <asp:UpdatePanel ID="updpnlPrice" runat="server">
                  <ContentTemplate>
                    <asp:TextBox ID="txtPrice" runat="server" CssClass="textbox" Height="16px" Width="78px"></asp:TextBox>
                 <%--   <asp:RequiredFieldValidator ID="requPrice" runat="server" ControlToValidate="txtPrice"  ForeColor="Red" ErrorMessage="Please enter a valid Phone no"></asp:RequiredFieldValidator>--%>
                        
                  </ContentTemplate>
                  </asp:UpdatePanel>
                 </td>
                <td class="auto-style109">
                    <asp:TextBox ID="txtDiscounnt" runat="server" CssClass="textbox" Height="16px" Width="43px"></asp:TextBox>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtDiscountPer" runat="server" CssClass="textbox" Height="16px" Width="24px"></asp:TextBox>
                </td>
                <td class="auto-style99">
                    <asp:TextBox ID="txtNBT" runat="server" CssClass="textbox" Height="16px" Width="52px"></asp:TextBox>
                </td>
                <td class="auto-style103">
                    <asp:TextBox ID="txtVAT" runat="server" CssClass="textbox" Height="16px" Width="49px"></asp:TextBox>
                </td>
                <td class="auto-style111">
                    <asp:TextBox ID="txtTotal" runat="server" CssClass="textbox" Height="16px" Width="58px"></asp:TextBox>
                </td>

                <td class="auto-style55">
                    &nbsp;<td class="auto-style111">
                    <%--<asp:Label ID="lblPricecheck" runat="server" CssClass="textbox"></asp:Label>--%>
                    <asp:Button ID="btnAddList" runat="server" CssClass="textbox" Height="21px" OnClick="btnAddList_Click" Text="Add" Width="33px" />

                </td>
            </tr>
           </table>
            <table>
            <tr>
                <td class="auto-style62">
                    <div id="div2" runat="server">
                         <asp:Panel ID="Panel2" ScrollBars="Both" Height="168px" Width="927px" runat="server">
                    <asp:UpdatePanel ID="UpplgvItemDescr" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                      <%--<asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>--%>
                     </ContentTemplate>
                      </asp:UpdatePanel>
                             <asp:GridView ID="gvItemDescription" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="254px" Width="750px" RowHeaderColumn="DiscountAmt">
                                 <Columns>
                                     <asp:TemplateField HeaderText="#">   
                                <ItemTemplate>
                                 <%# Container.DataItemIndex + 1 %>   
                                </ItemTemplate>
                                </asp:TemplateField>
                                     <asp:BoundField DataField="ItemCode" HeaderText="Item Code" />
                                     <asp:BoundField DataField="StockCode" HeaderText="Stock Code" />
                                     <asp:BoundField DataField="ItemDescription" HeaderText="Description" />
                                     <asp:BoundField DataField="ItemModal" HeaderText="Model No" />
                                     <asp:BoundField DataField="ItemSerialNo" HeaderText="Serial no" />
                                     <asp:BoundField DataField="ItemCapacity" HeaderText="Item Capacity" />
                                     <asp:BoundField HeaderText="Category" />
                                     <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                                     <asp:BoundField DataField="Price" HeaderText="Price" />
                                     <asp:BoundField HeaderText="Discount[%]" />
                                     <asp:BoundField DataField="DiscountAmt" HeaderText="Discount" />
                                     <asp:BoundField DataField="VATPer" HeaderText="VAT[%]" />
                                     <asp:BoundField HeaderText="VAT" />
                                     <asp:BoundField HeaderText="Amount" />
                                     <asp:BoundField HeaderText="S" />
                                     <asp:BoundField HeaderText="X" />
                                     <asp:BoundField HeaderText="Stock" />
                                     <asp:BoundField DataField="NBTPer" HeaderText="NBT Per" />
                                     <asp:BoundField DataField="NBTAmt" HeaderText="NBT Amount" />
                                     <asp:BoundField DataField="QuoationNo" HeaderText="Quoation No" />
                                     
                                 </Columns>
                                 <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                 <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                                 <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                                 <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                                 <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                                 <SortedAscendingCellStyle BackColor="#FFF1D4" />
                                 <SortedAscendingHeaderStyle BackColor="#B95C30" />
                                 <SortedDescendingCellStyle BackColor="#F1E5CE" />
                                 <SortedDescendingHeaderStyle BackColor="#93451F" />
                             </asp:GridView>
                      </asp:Panel>
                        </div>
              </td>
            </tr>
          </table>
           </table>
              <table>
               <tr>
                <td><asp:Label ID="Label26" runat="server" Text="VAT Amount"></asp:Label></td>
                <td><asp:TextBox ID="txtVATTotal" runat="server" Height="16px" Width="90px"></asp:TextBox></td>
                 <td><asp:Label ID="Label33" CssClass="textbox" runat="server" Text="Discount"></asp:Label></td>
                <td><asp:TextBox ID="txtDiscountTotal" CssClass="textbox" runat="server" Height="16px" Width="90px"></asp:TextBox></td>
                <td><asp:Label ID="Label34" CssClass="textbox" runat="server" Text="Grand Total"></asp:Label></td>
                <td><asp:TextBox ID="txtGrandTotal" CssClass="textbox" runat="server" Height="16px" Width="90px"></asp:TextBox></td>
                <td><asp:Label ID="Label35" CssClass="textbox" runat="server" Text="Net Amount"></asp:Label></td>
                <td><asp:TextBox ID="txtNetAmount" CssClass="textbox" runat="server" Height="19px" Width="90px"></asp:TextBox></td>
                <td><asp:Label ID="Label36" CssClass="textbox" runat="server" Text="NBT Amount"></asp:Label></td>
                <td><asp:TextBox ID="txtNBTAmt" CssClass="textbox" runat="server" Height="16px" Width="90px"></asp:TextBox></td>
                <td><asp:Button ID="btnSave" runat="server" CssClass="textbox" Text="Save" OnClick="btnSave_Click" /></td>
               </tr>
             </table>

   </ContentTemplate>
          </asp:UpdatePanel>
</asp:Content>
