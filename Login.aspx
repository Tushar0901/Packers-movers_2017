<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 99%;
        height: 308px;
    }
        .style2
        {
        width: 76px;
        visibility: visible;
    }
        .style3
        {
        width: 339px;
    }
    .style4
    {
        width: 76px;
    }
    .style5
    {
        width: 76px;
        height: 31px;
    }
    .style6
    {
        width: 339px;
        height: 31px;
    }
        .style7
        {
            width: 76px;
            visibility: visible;
            height: 35px;
        }
        .style8
        {
            width: 339px;
            height: 35px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="right1">
    <table class="style1">
        <tr>
            <td class="style2" 
                
                
                
                style="font-family: 'Arial Rounded MT Bold'; font-size: medium; font-variant: normal; color: #666666; ">
                &nbsp;</td>
            <td class="style3">
                <asp:Label ID="Label1" runat="server" CssClass="submit2" Text="Login"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2" 
                
                
                
                style="font-family: 'Arial Rounded MT Bold'; font-size: medium; font-variant: normal; color: #666666; ">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" 
                
                
                
                style="font-family: 'Arial Rounded MT Bold'; font-size: medium; font-variant: normal; color: #666666; ">
                Email:</td>
            <td class="style3">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="css-input2" Width="220px" 
                    ValidationGroup="a"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Plz enter email." ForeColor="Red" 
                    ValidationGroup="a"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Plz only email." ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="a"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style7" 
                
                
                
                
                style="font-family: 'Arial Rounded MT Bold'; font-size: medium; font-variant: normal; color: #666666; ">
                Password:</td>
            <td class="style8">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="css-input2" Width="220px" 
                    TextMode="Password" ValidationGroup="a"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="Plz insert password." 
                    ForeColor="Red" ValidationGroup="a"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style6">
                <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click" 
                    Width="136px" Height="31px">Forgot Password ?</asp:LinkButton>
                </td>
        </tr>
        <tr>
            <td class="style4">
                <asp:Button ID="Button1" runat="server" CssClass="css-input1" Height="35px" 
                    Text="Login" Width="100px" ForeColor="Silver" BackColor="#666666" 
                    onclick="Button1_Click" ValidationGroup="a" />
            </td>
            <td class="style3">
                <asp:Button ID="Button2" runat="server" CssClass="css-input1" Height="35px" 
                    Text="Cancel" Width="100px" ForeColor="Silver" BackColor="#666666" 
                    ValidationGroup="b" onclick="Button2_Click" />
            </td>
        </tr>
    </table>
    </div>
</asp:Content>

