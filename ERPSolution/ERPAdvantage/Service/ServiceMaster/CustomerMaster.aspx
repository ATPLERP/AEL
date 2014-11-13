<%@ Page Language="C#" AutoEventWireup="true" Inherits="MST_CustomerMaster" Codebehind="CustomerMaster.aspx.cs" MasterPageFile="~/Site.master" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" TagPrefix="cc1" %>

 <asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
     <style type="text/css">
         .style1
         {
             width: 100%;
         }
         .style2
         {
             width: 134px;
         }
         .style3
         {
             width: 166px;
         }
         .style4
         {
             width: 203px;
             font-weight: 700;
         }
         .style5
         {
             width: 139px;
         }
     </style>
</asp:Content>
      <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

          <asp:ScriptManager ID="ScriptManager1" runat="server">
          </asp:ScriptManager>
          
          <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.9em" PathSeparator=" : ">
              <CurrentNodeStyle ForeColor="#333333" />
              <NodeStyle Font-Bold="True" ForeColor="#990000" />
              <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
              <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
          </asp:SiteMapPath>
          
          <table  id="tblMain" class="style1">
              <tr>
                  <td>
                      <table class="style1">
                          <tr>
                              <td class="style2">
                                  <asp:Label ID="lblFname" runat="server" Text="First name"></asp:Label>
                              </td>
                              <td class="style3">
                
                <asp:UpdatePanel ID="uplplddlPre" runat="server">
                 <ContentTemplate>
                    <asp:DropDownList ID="ddlPrefix" runat="server" CssClass="textbox" AutoPostBack="true" >
                    </asp:DropDownList>
                  </ContentTemplate>
                </asp:UpdatePanel>
                     <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                         <ContentTemplate>
                             <asp:TextBox ID="txtFname" runat="server"  CssClass="textbox" Width="123px" OnTextChanged="txtFname_TextChanged"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" id="reqName" 
                        controltovalidate="txtFname" errormessage="Please enter your name!"  
                        ForeColor="Red" Enabled="true"/>
                                 </td>
                          </ContentTemplate>
                        </asp:UpdatePanel>
                   
                              <td class="style5"> 
                                  <asp:Label ID="lblTelNo1" runat="server" Text="Telephone No1"></asp:Label>
                              </td>
                              <td class="style4">
                                  
                                  <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txttelNo1" runat="server" CssClass="textbox" MaxLength="10"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="ReqtxttelNo1" runat="server" 
                                      controltovalidate="txttelNo1" Enabled="true" 
                                      errormessage="Please enter telephone no1!" ForeColor="Red" />
                                  </ContentTemplate>
                                  </asp:UpdatePanel>
                                  
                                  
                              </td>
                          </tr>
                          <tr>
                              <td class="style2">
                                  <asp:Label ID="lblInvAdd" runat="server" Text="Invoice Address"></asp:Label>
                              </td>
                              <td class="style3">
                                  <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtInAddress" runat="server" CssClass="textbox" Height="51px" 
                                              Width="215px"></asp:TextBox>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                              <td class="style5">
                                  <asp:Label ID="lblTelNo2" runat="server" Text="Telephone No2"></asp:Label>
                              </td>
                              <td class="style4">
                                  <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtTelno2" runat="server" CssClass="textbox" MaxLength="10"></asp:TextBox>
                                          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                              ControlToValidate="txtTelno2" ErrorMessage="Invalid phone no" ForeColor="Red" 
                                              ValidationExpression="/([0-9\s\-]{7,})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$/"></asp:RegularExpressionValidator>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                          </tr>
                          <tr>
                              <td class="style2">
                                  <asp:Label ID="lblserAdd" runat="server" Text="Service Address"></asp:Label>
                              </td>
                              <td class="style3">
                                  <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtSerAddress" runat="server" CssClass="textbox" Height="50px" 
                                              Width="212px"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="reqSerAddress" runat="server" 
                                      controltovalidate="txtSerAddress" Enabled="true" 
                                      errormessage="Please enter Ser Address!" ForeColor="Red" />
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                                     
                               
                              </td>
                              <td class="style5">
                                  <asp:Label ID="Label1" runat="server" Text="Fax No"></asp:Label>
                              </td>
                              <td class="style4">
                                  <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtFaxno" runat="server" CssClass="textbox" MaxLength="10"></asp:TextBox>
                                          <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                              ControlToValidate="txtFaxno" ErrorMessage="Invalid Fax no" ForeColor="Red" 
                                              ValidationExpression="/([0-9\s\-]{7,})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$/"></asp:RegularExpressionValidator>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                          </tr>
                          <tr>
                              <td class="style2">
                                  <asp:Label ID="lblArName" runat="server" Text="Area Name"></asp:Label>
                              </td>
                              <td class="style3">
                                  <asp:UpdatePanel ID="updplddlArea" runat="server">
                                      <ContentTemplate>
                                          <asp:DropDownList ID="ddlAreaName" runat="server" AutoPostBack="True" 
                                              CssClass="textbox">
                   <%-- <asp:ListItem>--Select--</asp:ListItem>--%>
                      
                                          </asp:DropDownList>
                 <%--   <asp:RequiredFieldValidator ID="reqAreaName" runat="server" ErrorMessage="Please select area" ControlToValidate="ddlAreaName" ValidationGroup="btnAdd" InitialValue="--Select--" ForeColor ="Red" ></asp:RequiredFieldValidator>
                    --%>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                              <td class="style5">
                                  <asp:Label ID="lblMobNo" runat="server" Text="Mobile no"></asp:Label>
                              </td>
                              <td class="style4">
                                  <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtMobNo" runat="server" CssClass="textbox" MaxLength="10"></asp:TextBox>
                                          <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                              ControlToValidate="txtMobNo" ErrorMessage="Invalid phone no" ForeColor="Red" 
                                              ValidationExpression="/([0-9\s\-]{7,})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$/"></asp:RegularExpressionValidator>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                          </tr>
                          <tr>
                              <td class="style2">
                                  <asp:Label ID="lblcat" runat="server" Text="Category"></asp:Label>
                              </td>
                              <td class="style3">
                                  <asp:UpdatePanel ID="udplddlCatogory" runat="server">
                                      <ContentTemplate>
                                          <asp:DropDownList ID="ddlCatogory" runat="server" AutoPostBack="True" 
                                              CssClass="textbox">
                                          </asp:DropDownList>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                              <td class="style5">
                                  <asp:Label ID="lblEmailAdd" runat="server" Text="Email Address"></asp:Label>
                              </td>
                              <td class="style4">
                                  <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtEmailAddress" runat="server" CssClass="textbox"></asp:TextBox>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                          </tr>
                          <tr>
                              <td class="style2">
                                  <asp:Label ID="lblSplCust" runat="server" Text="Spl.Customer"></asp:Label>
                              </td>
                              <td class="style3">
                                  <asp:UpdatePanel ID="uppddlSplcust" runat="server">
                                      <ContentTemplate>
               <%--     <asp:TextBox ID="txtSplcust" runat="server" Width="24px"></asp:TextBox>
              --%>      
                                          <asp:DropDownList ID="ddlSplcust" runat="server" CssClass="textbox" 
                                              Height="18px" Width="76px">
                                              <asp:ListItem>---Select---</asp:ListItem>
                                              <asp:ListItem>Y</asp:ListItem>
                                              <asp:ListItem>N</asp:ListItem>
                                          </asp:DropDownList>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                              <td class="style5">
                                  <asp:Label ID="lblConPerSer" runat="server" Text="Contact Person Service"></asp:Label>
                              </td>
                              <td class="style4">
                                  <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtContPerSer" runat="server" CssClass="textbox"></asp:TextBox>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                          </tr>
                          <tr>
                              <td class="style2">
                                  <asp:Label ID="lblCrelimit" runat="server" Text="Credit Limit"></asp:Label>
                              </td>
                              <td class="style3">
                                  <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtCreLimit" runat="server" CssClass="textbox"></asp:TextBox>
                                          <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                                              ControlToValidate="txtCreLimit" ErrorMessage="Value should be more than zero.." 
                                              ForeColor="Red" ValidationExpression="^\d+(\.\d\d)?$"></asp:RegularExpressionValidator>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                              <td class="style5">
                                  <asp:Label ID="lblTelNo" runat="server" Text="Telephone No"></asp:Label>
                              </td>
                              <td class="style4">
                                  <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtTelnoSer" runat="server" CssClass="textbox" MaxLength="10"></asp:TextBox>
                                          <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                                              ControlToValidate="txtTelnoSer" ErrorMessage="Invalid phone no" ForeColor="Red" 
                                              ValidationExpression="/([0-9\s\-]{7,})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$/"></asp:RegularExpressionValidator>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                          </tr>
                          <tr>
                              <td class="style2">
                                  <asp:Label ID="lblCregiv" runat="server" Text="Credit Given"></asp:Label>
                              </td>
                              <td class="style3">
                                  <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtCreGiven" runat="server" CssClass="textbox"></asp:TextBox>
                                     <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
                                      ControlToValidate="txtCreGiven" ErrorMessage="Value should be more than zero.." 
                                      ForeColor="Red" ValidationExpression="^\d+(\.\d\d)?$"></asp:RegularExpressionValidator>
                                     
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                                  
                              </td>
                              <td class="style5">
                                  <asp:Label ID="lblContperInv" runat="server" Text="Contact Person Invoice"></asp:Label>
                              </td>
                              <td class="style4">
                                  <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtConPerinv" runat="server" CssClass="textbox"></asp:TextBox>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                          </tr>
                          <tr>
                              <td class="style2">
                                  <asp:Label ID="lblVat" runat="server" Text="Vat Numbe"></asp:Label>
                                  r</td>
                              <td class="style3">
                                  <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtVatNo" runat="server" CssClass="textbox"></asp:TextBox>
                                          <asp:CheckBox ID="cheVatnumber" runat="server" CssClass="textbox" />
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                              <td class="style5">
                                  <asp:Label ID="lblTelInv" runat="server" Text="Telephone No"></asp:Label>
                              </td>
                              <td class="style4">
                                  <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                                      ControlToValidate="txtTelnoInv" ErrorMessage="Invalid phone no" ForeColor="Red" 
                                      ValidationExpression="/([0-9\s\-]{7,})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$/"></asp:RegularExpressionValidator>
                                  <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtTelnoInv" runat="server" CssClass="textbox" MaxLength="10"></asp:TextBox>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                          </tr>
                          <tr>
                              <td class="style2">
                                  <asp:Label ID="lblSvatno" runat="server" Text="SVAT Number"></asp:Label>
                              </td>
                              <td class="style3">
                                  <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtSvatNo" runat="server" CssClass="textbox"></asp:TextBox>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                              <td class="style5">
                                  &nbsp;</td>
                              <td class="style4">
                                  &nbsp;</td>
                          </tr>
                          <tr>
                              <td class="style2">
                                  <asp:Label ID="lblSvatcat" runat="server" Text="SVAT Category"></asp:Label>
                              </td>
                              <td class="style3">
                                  <asp:UpdatePanel ID="udplddlSvatcatogary" runat="server">
                                      <ContentTemplate>
                                          <asp:DropDownList ID="ddlSvatcatogary" runat="server" AutoPostBack="True" 
                                              CssClass="textbox">
                                              <asp:ListItem>---Select---</asp:ListItem>
                                              <asp:ListItem Value="1">1 Exporters</asp:ListItem>
                                              <asp:ListItem Value="2">2 Specific Project</asp:ListItem>
                                              <asp:ListItem Value="3">3 Section 22(7)</asp:ListItem>
                                              <asp:ListItem Value="4">4 Manufacturer Supply to Expoters</asp:ListItem>
                                              <asp:ListItem Value="5">5 Value Added Supplier to Expoters</asp:ListItem>
                                          </asp:DropDownList>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                            <td class="style5">
                                <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                                    <ContentTemplate>
                                        <asp:Button ID="btnSave" runat="server" CssClass="button_lg1" 
                                    onclick="btnSave_Click" Text="Save" Width="69px" />
                                            </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                            <td class="style4">
                            
                                <asp:Button ID="btnReset" runat="server" CssClass="button_lg1" 
                                    onclick="btnReset_Click" Text="Reset" Width="69px" />
                            
                                <asp:Label ID="lblStates" runat="server" CssClass="textbox"></asp:Label>
                            
                            </td>
                          </tr>
                          <tr>
                              <td class="style2">
                                  &nbsp;</td>
                              <td class="style3">
                                  &nbsp;</td>
                              <td class="style5">
                                  &nbsp;</td>
                              <td class="style4">
                                  &nbsp;</td>
                          </tr>
                      </table>
                  </td>
                  <td valign="top">
                      <table class="">
                          <tr>
                              <td class="style56">
                                  customer Name&nbsp;&nbsp;</td>
                              <td>
                                  &nbsp;Phone Number</td>
                          </tr>
                          <tr>
                              <td class="style56">
                                  <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtCustomerName" runat="server" CssClass="textbox" 
                                              Width="123px">%</asp:TextBox>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                              <td>
                                  <asp:UpdatePanel ID="UpdatePanel24" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txttelNoSerch" runat="server" CssClass="textbox" 
                                              MaxLength="10"></asp:TextBox>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                          </tr>
                          <tr>
                              <td class="style56">
                                  Area Name&nbsp;&nbsp;</td>
                              <td>
                                  Address</td>
                          </tr>
                          <tr>
                              <td class="style56">
                                  <asp:UpdatePanel ID="UpdatePanel21" runat="server">
                                      <ContentTemplate>
                                          <asp:DropDownList ID="ddlAreaNameSearch" runat="server" AutoPostBack="True" 
                                              CssClass="textbox">
                   <%-- <asp:ListItem>--Select--</asp:ListItem>--%>
                                          </asp:DropDownList>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                              <td>
                                  <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                                      <ContentTemplate>
                                          <asp:TextBox ID="txtAddressSerch" runat="server" CssClass="textbox" 
                                              MaxLength="10"></asp:TextBox>
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                          </tr>
                          <tr>
                              <td class="style56">
                                  <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                                      <ContentTemplate>
                                          <asp:Button ID="btnSearch" runat="server" CssClass="button_lg1" 
                                              onclick="btnSearch_Click" Text="Search" />
                                      </ContentTemplate>
                                  </asp:UpdatePanel>
                              </td>
                              <td>
                                  &nbsp;</td>
                          </tr>
                          <tr>
                           
                              <td align="left" class="style56" colspan="2">
                              <asp:UpdatePanel ID="updpnlGV" runat="server">
                              <ContentTemplate>
                                  <asp:GridView ID="gvCustomerDetails" runat="server" AllowPaging="True" 
                                      AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CUST_NO" 
                                      EmptyDataText="No data available" ForeColor="#333333" GridLines="None" 
                                      Height="43px" HorizontalAlign="Right" 
                                      onpageindexchanged="gvCustomerDetails_PageIndexChanged" 
                                      onpageindexchanging="gvCustomerDetails_PageIndexChanging" 
                                      onrowdeleting="gvCustomerDetails_RowDeleting" 
                                      onselectedindexchanged="gvCustomerDetails_SelectedIndexChanged" PageSize="5" 
                                      style="margin-right: 0px" Width="400px">
                                      <AlternatingRowStyle BackColor="White" />
                                      <Columns>
                                          <asp:TemplateField HeaderText="#">   
                                          <ItemTemplate>
                                             <%# Container.DataItemIndex + 1 %>   
                                         </ItemTemplate>
                                         </asp:TemplateField>

                                          <asp:BoundField DataField="CUST_NO" HeaderText="Cust No" 
                                              SortExpression="CUST_NO" Visible="false" />
                                  <%--   <asp:BoundField DataField="OrgCode" HeaderText="OrgID" SortExpression="OrgCode" Visible="false" />
          --%>
                                          <asp:BoundField DataField="CUST_NO" HeaderText="Cust Code" />
                                          <asp:BoundField DataField="CustomerName" HeaderText="Name" />
                                          <asp:CommandField buttontype="Image" HeaderText="Deletion" 
                                              selectimageUrl="~\Images\delete.gif" ShowSelectButton="True" />
                                          <asp:CommandField buttontype="Image" HeaderText="Edit" 
                                              selectimageurl="~\Images\edit.gif" ShowSelectButton="True" />
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
                              </td>
                                     
                            
                          </tr>
                      </table>
                  </td>
              </tr>
          </table>
          
</asp:Content>

 