<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogMeIn.aspx.cs" MasterPageFile="~/Site.master" Inherits="ERPAdvantage.Login.LogMeIn" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        ERP
        LogIn</h2>
    <p>
        Please enter your username and password.
        <asp:HyperLink ID="RegisterHyperLink" runat="server" EnableViewState="false">Register</asp:HyperLink> if you don't have an account.
    </p>

   
    
      <asp:UpdatePanel ID="UpdatePanel1" runat="server">
          <ContentTemplate>
              <asp:ScriptManager runat="server" />         

     <asp:Panel runat="server" ID="LoginPanel" Height="350px">

                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style7">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lblcompanyName" runat="server" AssociatedControlID="txtcompany">Company:</asp:Label>
                        </td>
                        <td class="auto-style7">
                            <asp:TextBox ID="txtcompany" runat="server" CssClass="textEntry" Height="18px" Width="285px" Font-Bold="True" Font-Names="Verdana">Abans Electricals PLC</asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="lblBranch" runat="server" AssociatedControlID="ddlBranch">Branch:</asp:Label>
                        </td>
                        <td class="auto-style5">
                            <asp:DropDownList ID="ddlBranch" runat="server" AutoPostBack="True" Height="16px" onselectedindexchanged="ddlBranch_SelectedIndexChanged" Width="285px">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style6">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="lblBranch0" runat="server" AssociatedControlID="ddlBranch">Branch Name:</asp:Label>
                        </td>
                        <td class="auto-style5">
                            <asp:TextBox ID="txtBranchName" runat="server" CssClass="textEntry" Font-Bold="True" Font-Names="Verdana" Width="285px"></asp:TextBox>
                        </td>
                        <td class="auto-style6">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Username:</asp:Label>
                        </td>
                        <td class="auto-style7">
                            <asp:TextBox ID="UserName" runat="server" CssClass="textEntry" Width="285px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" CssClass="failureNotification" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                        </td>
                        <td class="auto-style5">
                            <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password" Width="285px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                        </td>
                        <td class="auto-style6"></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="RememberMeLabel0" runat="server" AssociatedControlID="RememberMe" CssClass="inline">Keep me logged in</asp:Label>
                        </td>
                        <td class="auto-style7">
                            <asp:CheckBox ID="RememberMe" runat="server" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style7">
                            &nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style7">
                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" Height="26px" onclick="LoginButton_Click" Text="Login" ValidationGroup="LoginUserValidationGroup" Width="100px" Font-Bold="True" Font-Names="Verdana" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
              

                <br />
                <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
                <br />
                <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification" ValidationGroup="LoginUserValidationGroup" />
                <br />
                </span>
              

            </asp:Panel>
              </ContentTemplate>
       </asp:UpdatePanel>
              


    <%--<asp:Login ID="LoginUser" runat="server" EnableViewState="true" RenderOuterTable="false" >
        <LayoutTemplate>
            <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
            <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification" 
                 ValidationGroup="LoginUserValidationGroup"/>
            <div class="accountInfo">
                <fieldset class="login">
                    <legend>Account Information</legend>
                    <p>
                     <asp:Label ID="lblcompanyName" runat="server" AssociatedControlID="txtcompany">Company:</asp:Label>
                       <asp:TextBox ID="txtcompany" runat="server" CssClass="textEntry">Abans Electricals PLC</asp:TextBox>
                    </p>
                    
                    <p>
                     <asp:Label ID="lblBranch" runat="server" AssociatedControlID="ddlBranch">Branch:</asp:Label>
                        <asp:DropDownList ID="ddlBranch" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="ddlBranch_SelectedIndexChanged"> 
                                              
                        </asp:DropDownList>
                     </p>

                    <p>
                     <asp:Label ID="lblbranchname" runat="server" AssociatedControlID="txtBranchName">Branch Name:</asp:Label>
                     <asp:TextBox ID="txtBranchName" runat="server" CssClass="textEntry"></asp:TextBox>
                    </p>
                    <p>
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Username:</asp:Label>
                        <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                             CssClass="failureNotification" ErrorMessage="User Name is required." ToolTip="User Name is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                        <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                             CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Password is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                       <tr>
                       <td>
                        <asp:CheckBox ID="RememberMe" runat="server"/>
                        <asp:Label ID="RememberMeLabel" runat="server" AssociatedControlID="RememberMe" CssClass="inline">Keep me logged in</asp:Label>
                        </td>
                        <td>
                        
                            <asp:HyperLink ID="hlChapass" runat="server" ForeColor="#3333FF" 
                                NavigateUrl="~/Account/ChangePassword.aspx">Change Password</asp:HyperLink>
                        </td>
                        </tr>
                    </p>
                   
                </fieldset>
                <p class="submitButton">
                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" 
                        ValidationGroup="LoginUserValidationGroup" Height="26px" 
                        onclick="LoginButton_Click"/>
                </p>
            </div>
        </LayoutTemplate>
    </asp:Login>--%>
</asp:Content>

