<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.master" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="User_Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
    {
            width: 5px;
            font-family: "Arial Rounded MT Bold";
            font-size: medium;
        }
        .style5
        {
            width: 15px;
            font-family: "Arial Rounded MT Bold";
            font-size: medium;
        }
        .style6
        {
            width: 15px;
        }
    .style7
    {
        font-family: "Arial Rounded MT Bold";
        font-size: medium;
    }
        .style8
        {
            width: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span 
            class="style7"><strong>Welcome :</strong></span>&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Order" CssClass="submit2"></asp:Label>
    &nbsp;</p>
<p>
        &nbsp;</p>
      <div id="right1">
    <table class="style1">
        <tr>
            <td class="style3">
                Name</td>
            <td class="style5">
                :-</td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server" CssClass="css-input2"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Contact no</td>
            <td class="style5">
                :-</td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server" CssClass="css-input2"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Catagory&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style5">
                :-</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    CssClass="css-input2" DataSourceID="SqlDataSource1" 
                    DataTextField="catagory" DataValueField="cat_id">
                    <asp:ListItem>-- Select Category --</asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True" 
                    ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [catagory]">
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Shift From&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style5">
                :-</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="css-input2" 
                    TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style5">
                :-</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="css-input2" 
                    AutoPostBack="True" onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                    <asp:ListItem>--Select City--</asp:ListItem>
                    <asp:ListItem>Ahmedabad</asp:ListItem>
                    <asp:ListItem>Mehsana</asp:ListItem>
                    <asp:ListItem>Rajkot</asp:ListItem>
                    <asp:ListItem>Bhavnagar</asp:ListItem>
                    <asp:ListItem>Himmatnagar</asp:ListItem>
                    <asp:ListItem>Mumbai</asp:ListItem>
                    <asp:ListItem>Pune</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style3">
                State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style5">
                :-</td>
            <td>
                <asp:DropDownList ID="DropDownList6" runat="server" CssClass="css-input2" 
                    Width="129px">
                    <asp:ListItem>--select State--</asp:ListItem>
                    <asp:ListItem>Gujarat</asp:ListItem>
                    <asp:ListItem>Maharastra</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Shift To&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style5">
                :-</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="css-input2" 
                    TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style5">
                :-</td>
            <td>
                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="css-input2" 
                    AutoPostBack="True" onselectedindexchanged="DropDownList4_SelectedIndexChanged">
                    <asp:ListItem>-- Select City --</asp:ListItem>
                    <asp:ListItem>Ahmedabad</asp:ListItem>
                    <asp:ListItem>Mehsana</asp:ListItem>
                    <asp:ListItem>Rajkot</asp:ListItem>
                    <asp:ListItem>Bhavnagar</asp:ListItem>
                    <asp:ListItem>Himmatnagar</asp:ListItem>
                    <asp:ListItem>Mumbai</asp:ListItem>
                    <asp:ListItem>Pune</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style3">
                State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style5">
                :-</td>
            <td>
                <asp:DropDownList ID="DropDownList5" runat="server" CssClass="css-input2" 
                    Width="138px">
                    <asp:ListItem>--Select State--</asp:ListItem>
                    <asp:ListItem>Gujarat</asp:ListItem>
                    <asp:ListItem>Maharastra</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <br />
                <asp:Label ID="Label2" runat="server" CssClass="submit2" Text="Estimate"></asp:Label>
                </td>
            <td class="style5">
                &nbsp;</td>
            <td>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" CssClass="submit2" Text="/"></asp:Label>
                <asp:Label ID="Label3" runat="server" CssClass="submit2" Text="Payment Details"></asp:Label>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Transportation Charge</td>
            <td class="style5">
                :-</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="css-input2" ReadOnly="True" 
                    Width="80px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td class="style3">
                Packing Cost</td>
            <td class="style5">
                :-</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" CssClass="css-input2" ReadOnly="True" 
                    Width="80px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Services Charges</td>
            <td class="style5">
                :-</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" CssClass="css-input2" ReadOnly="True" 
                    Width="80px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Unpacking Charges</td>
            <td class="style5">
                :-</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" CssClass="css-input2" Width="80px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Service Tax</td>
            <td class="style5">
                :-</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" CssClass="css-input2" Width="80px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Total Cost</td>
            <td class="style5">
                :-</td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" CssClass="css-input2" Width="80px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                <asp:Button ID="Button1" runat="server" BackColor="#666666" 
                    CssClass="css-input1" ForeColor="Silver" Text="Order now" 
                    onclick="Button1_Click" />
            </td>
            <td class="style6">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" BackColor="#666666" 
                    CssClass="css-input1" ForeColor="Silver" Text="Cancel" 
                    ValidationGroup="b" onclick="Button2_Click" />
            </td>
        </tr>
    </table>
    </div>
</asp:Content>

