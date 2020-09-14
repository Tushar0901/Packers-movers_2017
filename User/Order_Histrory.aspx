<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.master" AutoEventWireup="true" CodeFile="Order_Histrory.aspx.cs" Inherits="User_Order_track" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" CssClass="submit2" Text="Order History"></asp:Label>
    </p>
    <p>
        
             <asp:GridView ID="GridView1" runat="server" 
                 BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="2px" 
                 CellPadding="7" ForeColor="Black" GridLines="None" Width="236px" 
                 CellSpacing="2" CssClass="css-input1">
             <AlternatingRowStyle BackColor="PaleGoldenrod" />
             <FooterStyle BackColor="Tan" />
             <HeaderStyle BackColor="Tan" Font-Bold="True" />
             <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                 HorizontalAlign="Center" />
             <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
             <SortedAscendingCellStyle BackColor="#FAFAE7" />
             <SortedAscendingHeaderStyle BackColor="#DAC09E" />
             <SortedDescendingCellStyle BackColor="#E1DB9C" />
             <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
             &nbsp;<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
     
    &nbsp;
     
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
      
</asp:Content>

