<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="safety.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <asp:Label ID="Label1" runat="server" Text="Insert Year" ForeColor="Black" Font-Bold="True" Font-Size="Large"></asp:Label>
        <BR />
        
        &nbsp;&nbsp;&nbsp;
        
        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="new_click" 
            BackColor="#507CD1" ForeColor="White" Font-Bold="True" BorderColor="Black" 
            BorderStyle="Solid" />
           
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnback" runat="server" Text="Back" Onclick="bck_click" 
            BackColor="#507CD1" ForeColor="White" Font-Bold="True" BorderColor="Black" 
            BorderStyle="Solid"/>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Year" DataSourceID="SqlDataSource1" CellPadding="4" 
            ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                            CommandName="Delete" Text="Delete" OnClientClick=" return confirm('Are you sure you want to delete this data?');" Font-Bold="True"></asp:LinkButton>
                    </ItemTemplate>
                    <FooterTemplate>
                    <asp:LinkButton ID="lnkinsert" runat="server" Text="Insert" OnClick="add_Click" ForeColor="White"></asp:LinkButton>
                     <asp:LinkButton ID="lnkcancel" runat="server" CausesValidation="False" 
                            CommandName="Cancel" Text="Cancel" OnClick="cancel_click" ForeColor="White"></asp:LinkButton>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Year" SortExpression="Year">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Year") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Year") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="Textyear" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Year is required" ControlToValidate="Textyear" Text="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        </center>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:testConnectionString2 %>" 
        SelectCommand="SELECT * FROM [tblsafetyyear]" 
        DeleteCommand="DELETE FROM [tblsafetyyear] WHERE [Year] = @Year" 
        InsertCommand="INSERT INTO [tblsafetyyear] ([Year]) VALUES (@Year)">
        <DeleteParameters>
            <asp:Parameter Name="Year" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Year" Type="Int32" />
        </InsertParameters>
    </asp:SqlDataSource>
   
    </form>
</body>
</html>
