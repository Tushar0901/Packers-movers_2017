<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Admin_Feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" 
        BorderColor="Tan" BorderWidth="1px" CellPadding="4" ForeColor="Black" 
        GridLines="None" Width="936px" CellSpacing="2" CssClass="css-input2">
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




    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConflictDetection="CompareAllValues" 
        ConnectionString="Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True" 
        DeleteCommand="DELETE FROM [Feedback] WHERE [feedback_id] = @original_feedback_id AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL)) AND (([subject] = @original_subject) OR ([subject] IS NULL AND @original_subject IS NULL)) AND (([massage] = @original_massage) OR ([massage] IS NULL AND @original_massage IS NULL))" 
        InsertCommand="INSERT INTO [Feedback] ([name], [email], [subject], [massage]) VALUES (@name, @email, @subject, @massage)" 
        OldValuesParameterFormatString="original_{0}" 
        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Feedback]" 
        UpdateCommand="UPDATE [Feedback] SET [name] = @name, [email] = @email, [subject] = @subject, [massage] = @massage WHERE [feedback_id] = @original_feedback_id AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL)) AND (([subject] = @original_subject) OR ([subject] IS NULL AND @original_subject IS NULL)) AND (([massage] = @original_massage) OR ([massage] IS NULL AND @original_massage IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_feedback_id" Type="Int32" />
            <asp:Parameter Name="original_name" Type="String" />
            <asp:Parameter Name="original_email" Type="String" />
            <asp:Parameter Name="original_subject" Type="String" />
            <asp:Parameter Name="original_massage" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="subject" Type="String" />
            <asp:Parameter Name="massage" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="subject" Type="String" />
            <asp:Parameter Name="massage" Type="String" />
            <asp:Parameter Name="original_feedback_id" Type="Int32" />
            <asp:Parameter Name="original_name" Type="String" />
            <asp:Parameter Name="original_email" Type="String" />
            <asp:Parameter Name="original_subject" Type="String" />
            <asp:Parameter Name="original_massage" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>




</asp:Content>

