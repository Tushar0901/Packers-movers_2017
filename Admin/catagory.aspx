<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="catagory.aspx.cs" Inherits="Admin_catagory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            font-family: "Arial Rounded MT Bold";
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <p>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Catagory" CssClass="submit2"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Update Catagories" 
            CssClass="style1"></asp:Label>
        <span class="style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; :-&nbsp;&nbsp;</span>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" CssClass="css-input2"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="submit" BackColor="#666666" CssClass="css-input1" 
            ForeColor="Silver" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="cancel" BackColor="#666666" 
            CssClass="css-input1" ForeColor="Silver" ValidationGroup="b" 
            onclick="Button2_Click" />
    </p>
    <p>
        &nbsp;</p>
<div id="right1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;  
        <asp:GridView ID="grvCategory" runat="server" AutoGenerateColumns="False" 
                         onrowcancelingedit="grvCategory_RowCancelingEdit" 
                         onrowediting="grvCategory_RowEditing" 
                         onrowupdating="grvCategory_RowUpdating" CellPadding="4" 
            CellSpacing="2" ForeColor="Black" 
                         GridLines="None" Width="434px" Font-Size="Small" 
            Height="200px" BackColor="LightGoldenrodYellow" BorderColor="Tan" 
            BorderWidth="1px" CssClass="css-input2">
                        
                         <AlternatingRowStyle BackColor="PaleGoldenrod" />
                         <Columns>
                             <asp:TemplateField HeaderText="Id">
                                 <ItemTemplate>
                                     <center><asp:Label ID="lblcid" runat="server" Text='<%# Bind("cat_id") %>'></asp:Label></center>
                                 </ItemTemplate>
                             </asp:TemplateField>
                             <asp:TemplateField HeaderText="Name">
                                 <EditItemTemplate>
                                    <center> <asp:TextBox ID="txtcname" runat="server" Text='<%# Bind("catagory") %>'></asp:TextBox></center>
                                 </EditItemTemplate>
                              <ItemTemplate>
                                     <center><asp:Label ID="lblcnm" runat="server" Text='<%# Bind("catagory") %>'></asp:Label></center>
                                 </ItemTemplate>
                             </asp:TemplateField>
                             <asp:TemplateField>
                              <ItemTemplate>
                                 <center> <asp:LinkButton ID="lbkRemove" runat="server" CommandArgument='<%# Bind("cat_id") %>' OnClick="DeleteCat">Delete</asp:LinkButton></center>
                                 </ItemTemplate>
                             </asp:TemplateField>
                             <asp:CommandField ShowEditButton="true" />
                         </Columns>
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
                 <br />
        </div>
    </asp:Content>

