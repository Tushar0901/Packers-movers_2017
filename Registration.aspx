<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <div id="cont_razd">
    <style type="text/css">
        .style1
    {
        width: %;
        height: 496px;
    }
    .style3
    {
        width: 100px;
        height: 31px;
            visibility: visible;
        }
    .style4
    {
        height: 31px;
            width: 452px;
        }
    .style5
    {
        width: 100px;
        height: 40px;
    }
    .style6
    {
        height: 40px;
            width: 452px;
        }
        .style7
        {
            width: 100px;
            visibility: visible;
        }
        .style8
        {
            width: 100px;
        }
        .style9
        {
        width: 452px;
    }
    </style>
      </div>
    <style type="text/css">
        .style1
        {
            width: 150px;
        }
        .style2
        {
            width: 138px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div id="right1">
    <table class="style1">
        <caption>
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" CssClass="submit2" Text="Registration"></asp:Label>
        </caption>
    <tr>
        <td class="style2" 
            
            
            
            
            style="font-size: medium; font-family: 'Arial Rounded MT Bold'; font-variant: normal; color: #666666">
            &nbsp;</td>
        <td class="style9">
            &nbsp;</td>
        <td class="style9">
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="style2" 
            
            
            
            
            style="font-size: medium; font-family: 'Arial Rounded MT Bold'; font-variant: normal; color: #666666">
            &nbsp;</td>
        <td class="style9">
            &nbsp;</td>
        <td class="style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2" 
            
            
            
            
            style="font-size: medium; font-family: 'Arial Rounded MT Bold'; font-variant: normal; color: #666666">
            First Name&nbsp;&nbsp;&nbsp; </td>
        <td class="style9">
            :-&nbsp;
        </td>
        <td class="style9">
            <asp:TextBox ID="TextBox1" runat="server" CssClass="css-input2" Width="220px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="Plz Enter First name." SetFocusOnError="True" 
                ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style2" 
            
            
            
            
            style="font-size: medium; font-family: 'Arial Rounded MT Bold'; font-variant: normal; color: #666666">
            Last Name&nbsp;&nbsp;&nbsp; </td>
        <td class="style9">
            :-</td>
        <td class="style9">
            <asp:TextBox ID="TextBox2" runat="server" CssClass="css-input2" Width="220px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Plz Enter Last Name." SetFocusOnError="True" 
                ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style2" 
            
            
            
            
            style="font-size: medium; font-family: 'Arial Rounded MT Bold'; font-variant: normal; color: #666666">
            Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td class="style9">
            :-</td>
        <td class="style9">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
                CssClass="css-input2">
                <asp:ListItem Selected="True">Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ErrorMessage="Plz select gender." SetFocusOnError="True" 
                ControlToValidate="RadioButtonList1" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style2" 
            
            
            
            
            style="font-size: medium; font-family: 'Arial Rounded MT Bold'; font-variant: normal; color: #666666">
            Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td class="style9">
            :-</td>
        <td class="style9">
            <asp:TextBox ID="TextBox3" runat="server" CssClass="css-input2" 
                TextMode="MultiLine" Width="220px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ErrorMessage="Plz enter address." SetFocusOnError="True" 
                ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style2" 
            
            
            
            
            style="font-size: medium; font-family: 'Arial Rounded MT Bold'; font-variant: normal; color: #666666">
            City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td class="style9">
            :-</td>
        <td class="style9">
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                CssClass="css-input2" Width="150px" DataSourceID="SqlDataSource1" 
                DataTextField="city_name" DataValueField="city_name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT [city_name] FROM [city]"></asp:SqlDataSource>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ErrorMessage="Plz select your city." SetFocusOnError="True" 
                ControlToValidate="DropDownList1" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style2" 
            
            
            
            
            style="font-size: medium; font-family: 'Arial Rounded MT Bold'; font-variant: normal; color: #666666">
            State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td class="style9">
            :-</td>
        <td class="style9">
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                CssClass="css-input2" Width="150px" DataSourceID="SqlDataSource2" 
                DataTextField="state_name" DataValueField="state_name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT [state_name] FROM [state]"></asp:SqlDataSource>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                ErrorMessage="Plz select your state." SetFocusOnError="True" 
                ControlToValidate="DropDownList2" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style2" 
            
            
            
            
            
            
            style="font-size: medium; font-family: 'Arial Rounded MT Bold'; font-variant: normal; color: #666666">
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td class="style9">
            :-</td>
        <td class="style9">
            <asp:TextBox ID="TextBox4" runat="server" CssClass="css-input2" Width="220px"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                ControlToValidate="TextBox4" ErrorMessage="Plz Enter email." ForeColor="Red" 
                SetFocusOnError="True"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ErrorMessage="Plz enter only email." SetFocusOnError="True" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                ControlToValidate="TextBox4" ForeColor="Red" Height="17px"></asp:RegularExpressionValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td class="style2" 
            
            
            
            
            style="font-size: medium; font-family: 'Arial Rounded MT Bold'; font-variant: normal; color: #666666">
            Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td class="style4">
            :-</td>
        <td class="style4">
            <asp:TextBox ID="TextBox5" runat="server" CssClass="css-input2" Width="220px" 
                TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                ControlToValidate="TextBox5" ErrorMessage="Plz Enter password." 
                ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style2" 
            
            style="font-family: 'Arial Rounded MT Bold'; font-size: medium; color: #666666">
            Confirm Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td class="style9">
            :-</td>
        <td class="style9">
            <asp:TextBox ID="TextBox6" runat="server" CssClass="css-input2" Width="220px" 
                TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator2" runat="server" 
                ControlToCompare="TextBox5" ControlToValidate="TextBox6" 
                ErrorMessage="Plz enter confirm Password." SetFocusOnError="True" 
                ForeColor="Red"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="style2" 
            
            style="font-family: 'Arial Rounded MT Bold'; font-size: medium; color: #666666">
            Contact No&nbsp;&nbsp; </td>
        <td class="style9">
            :-</td>
        <td class="style9">
            <asp:TextBox ID="TextBox7" runat="server" CssClass="css-input2" Width="220px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                ErrorMessage="Plz enter phone no.." SetFocusOnError="True" 
                ControlToValidate="TextBox7" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td class="style9">
            &nbsp;</td>
        <td class="style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td class="style9">
            &nbsp;</td>
        <td class="style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Button ID="Button1" runat="server" CssClass="css-input1" 
                ForeColor="Silver" Height="35px" Text="Submit" Width="80px" 
                BackColor="#666666" onclick="Button1_Click" />
        </td>
        <td class="style6">
            &nbsp;</td>
        <td class="style6">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" CssClass="css-input1" 
                ForeColor="Silver" Height="35px" Text="Cancel" Width="80px" 
                BackColor="#666666" onclick="Button2_Click" ValidationGroup="b" />
        </td>
    </tr>
</table>
</div>

</asp:Content>

