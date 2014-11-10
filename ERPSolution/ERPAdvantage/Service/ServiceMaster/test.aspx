<%@ Page Language="C#" AutoEventWireup="true" Inherits="MST_CustomerMaster" Codebehind="CustomerMaster.aspx.cs" MasterPageFile="~/Site.master" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" TagPrefix="cc1" %>

   <asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
  
     <style type="text/css">
           #txtInAddress
           {
               height: 42px;
               width: 180px;
               margin-top: 0px;
               vertical-align: top;
           }
           .style1
           {
               height: 50px;
               vertical-align: top;
           }
           .style2
           {
               height: 41px;
               vertical-align: top;
           }
           .style3
           {
               height: 74px;
               vertical-align: top;
             width: 209px;
         }
           .style4
           {
             height: 0px;
             vertical-align: top;
             width: 194px;
         }
                                 
           .style27
           {
               height: 41px;
               vertical-align: top;
             width: 194px;
         }
                                 
           .txttop
           {
            height: 0px;
            vertical-align: top;
           }
           
           .style36
           {
               height: 41px;
               width: 123px;
               vertical-align: top;
           }
           .style37
           {
               vertical-align: top;
               width: 124px;
               vertical-align: top;
               }
                                 
         .stylerow
         {
              height:1px;
               vertical-align: top; 
         }
                      
         .style43
         {
             width: 108px;
         }
                                        
         .style49
         {
             height: 2px;
             vertical-align: top;
         }
                      
         .style50
         {
             vertical-align: top;
             width: 108px;
             vertical-align: top;
         }
         .style51
         {
             height: 41px;
             width: 108px;
             vertical-align: top;
         }
         .style53
         {
             vertical-align: top;
             width: 123px;
             vertical-align: top;
         }
         .style54
         {
             vertical-align: top;
         }
                      
         .style55
         {
             width: 194%;
         }
         .style56
         {
         }
         .style8
         {
             height: 639px;
             width: 922px;
         }
                      
         .style57
         {
             height: 2px;
             vertical-align: top;
             width: 194px;
         }
         .style58
         {
             vertical-align: top;
             width: 194px;
         }
                      
       </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

  <div style="height:600px; width: 528px;" CssClass="textbox">
   <div id="Div1" class="title_heading">New Customer Registration</div>
        <table class="style8">
            <tr class="stylerow">
                <td class="style49">
                    First name</td>
              
                <td class="style57">
                
                <asp:UpdatePanel ID="uplplddlPre" runat="server">
                 <ContentTemplate>
                    <asp:DropDownList ID="ddlPrefix" runat="server" CssClass="textbox"  SelectionMode="Multiple" AutoPostBack="true" >
                    </asp:DropDownList>
                  </ContentTemplate>
                </asp:UpdatePanel>
                     <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                         <ContentTemplate>
                             <asp:TextBox ID="txtFname" runat="server" CssClass="textbox" Width="123px"></asp:TextBox>
                         </ContentTemplate>
                    </asp:UpdatePanel>
                     <asp:RequiredFieldValidator runat="server" id="reqName" 
                        controltovalidate="txtFname" errormessage="Please enter your name!"  
                        ForeColor="Red" Enabled="False"/>
   
                </td>
             
                <td class="style50" CssClass="textbox">
                    Telephone No1</td>
                <td class="style53">
                    <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txttelNo1" CssClass="textbox" 
                         runat="server" MaxLength="10"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                      <asp:RequiredFieldValidator runat="server" id="ReqtxttelNo1" 
                        controltovalidate="txttelNo1" errormessage="Please enter telephone no1!"  
                        ForeColor="Red" Enabled="False"/>
                    
                </td>
                <td class="style3" rowspan="08">
       <DIV id="top_title" class="title_heading">Customer Search
       </DIV>

           <table class="style55">
               <tr>
                   <td class="style56">
                       customer Name&nbsp;&nbsp;</td>
                   <td>
&nbsp;Phone Number</td>
               </tr>
               <tr>
                   <td class="style56">
                       <asp:UpdatePanel ID="UpdatePanel3" runat="server" 
                        UpdateMode="Conditional">
                           <ContentTemplate>
                               <asp:TextBox ID="txtCustomerName" runat="server" CssClass="textbox" 
                                Width="123px">%</asp:TextBox>
                           </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                   <td>
                       <asp:UpdatePanel ID="UpdatePanel20" runat="server">
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
                   <td class="style56" colspan="2" align="left">
                  
                       
                         <asp:GridView ID="gvCustomerDetails" runat="server" AllowPaging="True" 
                              AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CUST_NO" 
                              ForeColor="#333333" GridLines="None" Height="43px" HorizontalAlign="Right" 
                              onpageindexchanging="gvCustomerDetails_PageIndexChanging" 
                              onrowdeleting="gvCustomerDetails_RowDeleting" 
                              onselectedindexchanged="gvCustomerDetails_SelectedIndexChanged" PageSize="5" 
                              style="margin-right: 0px" Width="400px" EmptyDataText="No data available" 
                              onpageindexchanged="gvCustomerDetails_PageIndexChanged">
                            
                              <AlternatingRowStyle BackColor="White" />
                              <Columns>
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
                  
                   </td>
               </tr>
           </table>
                              
             </td>
          
            </tr>
            <tr  class="stylerow">
                <td class="style2" CssClass="textbox">
                    Invoice Address</td>
                <td class="style27">
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtInAddress" runat="server" Height="51px" CssClass="textbox" Width="215px"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
               
               </td>
               
                <td class="style51">
                    Telephone No2</td>
                <td class="style36">
                   
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
            <tr  class="stylerow">
                <td class="style49">
                    Service Address</td>
                <td class="style57">
                    <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtSerAddress" runat="server" Height="50px" CssClass="textbox" Width="212px"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:RequiredFieldValidator runat="server" id="reqSerAddress" 
                        controltovalidate="txtSerAddress" errormessage="Please enter Ser Address!"  
                        ForeColor="Red" Enabled="False"/>
                   </td>
                    
                     <td class="style50">
                    Fax No</td>
                <td class="style53">
                    
                    <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtFaxno" runat="server" CssClass="textbox" MaxLength="10"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                ControlToValidate="txtFaxno" ErrorMessage="Invalid phone no" ForeColor="Red" 
                                ValidationExpression="/([0-9\s\-]{7,})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$/"></asp:RegularExpressionValidator>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    
                </td>
            </tr>
            <tr class="stylerow">
                <td class="style49">
                    Area Name</td>
                <td class="style57">
                <asp:UpdatePanel ID="updplddlArea" runat="server">
                 <ContentTemplate>
                    <asp:DropDownList ID="ddlAreaName" CssClass="textbox" runat="server"  AutoPostBack="True">
                   <%-- <asp:ListItem>--Select--</asp:ListItem>--%>
                      
                    </asp:DropDownList>
                 <%--   <asp:RequiredFieldValidator ID="reqAreaName" runat="server" ErrorMessage="Please select area" ControlToValidate="ddlAreaName" ValidationGroup="btnAdd" InitialValue="--Select--" ForeColor ="Red" ></asp:RequiredFieldValidator>
                    --%>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td class="style50">
                    Mobile no</td>
                <td class="style53">
                  
               
                    <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtMobNo" CssClass="textbox" 
    runat="server" MaxLength="10"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                ControlToValidate="txtMobNo" ErrorMessage="Invalid phone no" ForeColor="Red" 
                                ValidationExpression="/([0-9\s\-]{7,})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$/"></asp:RegularExpressionValidator>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                  
               
                </td>
            </tr>
            <tr class="stylerow">
                <td class="style7" CssClass="textbox">
                    Category</td>
                <td class="style57">
                      <asp:UpdatePanel ID="udplddlCatogory" runat="server">
                 <ContentTemplate>
                    <asp:DropDownList ID="ddlCatogory" runat="server" CssClass="textbox" AutoPostBack="True">
                      

                    </asp:DropDownList>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td class="style43">
                    Email Address</td>
                <td class="style53">
                    <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtEmailAddress" runat="server" CssClass="textbox"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr class="stylerow">
                <td class="style37">
                    Spl.Customer</td>
                <td class="style57">
                 <asp:UpdatePanel ID="uppddlSplcust" runat="server">
                 <ContentTemplate>
               <%--     <asp:TextBox ID="txtSplcust" runat="server" Width="24px"></asp:TextBox>
              --%>      <asp:DropDownList ID="ddlSplcust" runat="server" CssClass="textbox" Height="18px" Width="76px">
                        <asp:ListItem>---Select---</asp:ListItem>
                        <asp:ListItem>Y</asp:ListItem>
                        <asp:ListItem>N</asp:ListItem>
                    </asp:DropDownList>
                </ContentTemplate>
                </asp:UpdatePanel>
                </td>
                <td class="style50">
                    Contact Person Service</td>
                <td class="style53">
                    <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtContPerSer" runat="server" CssClass="textbox"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <%--  <Triggers>
                              <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
                          </Triggers>--%>
            </tr>
            <tr class="stylerow">
                <td class="style6">
                    Credit Limit</td>
                <td class="style4">
                    <%-- <asp:ListItem>--Select--</asp:ListItem>--%>
                    <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtCreLimit" runat="server" CssClass="textbox"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                                ControlToValidate="txtCreLimit" ErrorMessage="Value should be more than zero.." 
                                ForeColor="Red" ValidationExpression="^\d+(\.\d\d)?$"></asp:RegularExpressionValidator>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                 </td>
                <td class="style43">
                    Telephone No</td>
                <td class="style53">
                  
          
                    <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtTelnoSer"  CssClass="textbox" 
     runat="server" MaxLength="10"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                                ControlToValidate="txtTelnoSer" ErrorMessage="Invalid phone no" ForeColor="Red" 
                                ValidationExpression="/([0-9\s\-]{7,})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$/"></asp:RegularExpressionValidator>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                  
          
                </td>
            </tr>
            <tr class="stylerow">
                <td class="style54">
                    Credit Given<br />
                    <br />
                </td>
                <td class="style58">
                    <%--   <asp:RequiredFieldValidator ID="reqAreaName" runat="server" ErrorMessage="Please select area" ControlToValidate="ddlAreaName" ValidationGroup="btnAdd" InitialValue="--Select--" ForeColor ="Red" ></asp:RequiredFieldValidator>
                    --%>
                    <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtCreGiven" runat="server" CssClass="textbox"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                         <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
                        ControlToValidate="txtCreGiven" ErrorMessage="Value should be more than zero.."  ForeColor="Red" 
                        ValidationExpression="^\d+(\.\d\d)?$"></asp:RegularExpressionValidator>
                    <br/>
                </td>
                <td class="style50">
                    Contact Person Invoice</td>
                <td class="style53">
                    <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtConPerinv" runat="server" CssClass="textbox"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr class="stylerow">
                <td class="style1">
                    Vat Number</td>
                <td class="style4">
                    <br />
                    <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtVatNo" runat="server" CssClass="textbox"></asp:TextBox>
                            <asp:CheckBox ID="cheVatnumber" runat="server" CssClass="textbox" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td class="style43">
                    Telephone No</td>
                <td class="style53">
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                        ControlToValidate="txtTelnoInv" ErrorMessage="Invalid phone no"  ForeColor="Red" 
                        ValidationExpression="/([0-9\s\-]{7,})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$/"></asp:RegularExpressionValidator>
            
                    <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtTelnoInv" runat="server" CssClass="textbox" MaxLength="10"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
            
                </td>
            </tr>
            <tr class="stylerow">
                <td class="style6">
                    SVAT Number</td>
                <td class="style4">
                    <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtSvatNo" runat="server" CssClass="textbox"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    
                </td>
                <td class="style43">
                    <asp:Button ID="btnSave" runat="server"  CssClass="button_lg1" onclick="btnSave_Click" Text="Save" 
                        Width="69px" />
                </td>
                <td class="style53">
                    <asp:Button ID="btnReset" runat="server"  CssClass="button_lg1" Text="Reset" 
                        Width="69px" onclick="btnReset_Click" />
                &nbsp;</td>
            </tr>
            <tr class="stylerow">
                <td>
                    SVAT Category</td>
                <td class="style4">
                <asp:UpdatePanel ID="udplddlSvatcatogary" runat="server">
                 <ContentTemplate>
                    <asp:DropDownList ID="ddlSvatcatogary" runat="server"   CssClass="textbox" AutoPostBack="True">
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
                <td class="style43">
                    &nbsp;</td>
                <td class="style53">
                    <asp:Label ID="lblStates" CssClass="textbox" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
   
<%--     <asp:TextBox ID="txtSplcust" runat="server" Width="24px"></asp:TextBox>
              --%>
          
    
    
    </asp:Content>
 
