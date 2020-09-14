<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Change_Password.aspx.cs" Inherits="Admin_forgotepassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 228px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <caption>
            <asp:Label ID="Label1" runat="server" CssClass="submit2" Text="Change Password"></asp:Label>
        </caption>
        <tr>
            <td class="style2">
                Cuurent Password</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="css-input2"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                New Password</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="css-input2"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Confirm Password</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="css-input2"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Button ID="Button1" runat="server" BackColor="#666666" 
                    CssClass="css-input1" ForeColor="#999999" Text="Submit" 
                    onclick="Button1_Click" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" BackColor="#666666" 
                    CssClass="css-input1" ForeColor="#999999" Text="Cancel" 
                    onclick="Button2_Click" ValidationGroup="b" />
            </td>
        </tr>
    </table>
</asp:Content>

