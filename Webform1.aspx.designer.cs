
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="safety.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
    <form id="form1" runat="server" >
    <div >
    
      
       <center>

       <asp:Label ID="Label1" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" 
              ForeColor="Black" Text="Welcome to Safety Dashboard Data Maintenance" 
              runat="server" Font-Names="Times New Roman"></asp:Label><br />
              <br />
              <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Label ID="Label16" runat="server" ForeColor="Black" Text="Choose Year:" 
               Font-Bold="True" Font-Names="Arial" Font-Size="Medium"></asp:Label>
           <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" 
               DataTextField="Year" DataValueField="Year" AutoPostBack="True" 
               Font-Bold="True" Font-Size="Medium" ForeColor="#003399">
        
        </asp:DropDownList>
           <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" 
               Font-Size="Large" ForeColor="#003399" OnClick="next_click">Insert Year</asp:LinkButton>
               <br />
               <br />

        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
               AutoGenerateColumns="False" CellPadding="4" 
            DataKeyNames="location_id,year,month" DataSourceID="SqlDataSource1" 
          BackColor="White" 
               BorderColor="#3366CC" BorderStyle="Solid" BorderWidth="1px" PageSize="9" 
               >
            <Columns>
                
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="Button3" runat="server" CausesValidation="True" 
                            CommandName="Update" Text="Update" ></asp:LinkButton>
                        <asp:LinkButton ID="Button4" runat="server" CausesValidation="False" 
                            CommandName="Cancel" Text="Cancel" ></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="Button3" runat="server" CausesValidation="False" 
                            CommandName="Edit" Text="Edit" ></asp:LinkButton>
                       <asp:LinkButton ID="Button4" runat="server" CausesValidation="False" 
                            CommandName="Delete" Text="Delete" OnClientClick=" return confirm('Are you sure you want to delete this data?'); "  ></asp:LinkButton>
                    </ItemTemplate>
                    <FooterTemplate>
                    <asp:LinkButton ID="Button1" runat="server" Text="Insert" 
            onclick="New_Click"  ></asp:LinkButton>
            <asp:LinkButton ID="Button6" runat="server" CausesValidation="False" 
                            CommandName="Cancel" Text="Cancel" OnClick="Undo_Click" ></asp:LinkButton>
                    </FooterTemplate>
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Location ID" >
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("location_id") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("location_id") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                     <asp:RequiredFieldValidator ID="RfvlocID" runat="server" ErrorMessage="Location ID is required" Text="*" ControlToValidate="Tlocid" ></asp:RequiredFieldValidator>
                        <asp:TextBox ID="Tlocid" runat="server" Width="150" Height="15"></asp:TextBox>
                        
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Location">
                    <EditItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Location") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Location") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Year" >
                    <EditItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("year") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("year") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:RequiredFieldValidator ID="Rfvyear" runat="server" ErrorMessage="Year is required" Text="*" ControlToValidate="Tyear"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="Tyear" runat="server" Width="150" Height="15"></asp:TextBox>
                            
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Month">
                    <EditItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("month") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("month") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:RequiredFieldValidator ID="Rfvmonth" runat="server" ControlToValidate="Tmonth" ErrorMessage="Month is required" Text="*"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="Tmonth" runat="server" Width="150" Height="15"></asp:TextBox>
                  
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Shop Strength" >
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Shop_Strength") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Shop_Strength") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="Tshopstr" runat="server" Width="150" Height="15"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Office Strength" 
                    >
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Office_Strength") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("Office_Strength") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="Toffstr" runat="server" Width="150" Height="15"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Total Strength" >
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("strength") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("strength") %>'></asp:Label>
                    </ItemTemplate>
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Accidents" >
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("accidents") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Bind("accidents") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="Tacc" runat="server" Width="150" Height="15"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fatal" >
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox10" runat="server" Text='<%# Bind("fatal") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label14" runat="server" Text='<%# Bind("fatal") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="Tfatal" runat="server" Width="150" Height="15"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mandays Lost" >
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("mandayslost") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%# Bind("mandayslost") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="Tml" runat="server" Width="150" Height="15"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Frequency Rate">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("frequency") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label9" runat="server" Text='<%# Bind("frequency") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="Tfreq" runat="server" Width="150" Height="15"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Severity Rate" >
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("severityrate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label12" runat="server" Text='<%# Bind("severityrate") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="Tsevrate" runat="server" Width="150" Height="15"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="HE-FR" >
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("hefr") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label13" runat="server" Text='<%# Bind("hefr") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="Thefr" runat="server" Width="150" Height="15"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="HE-SR" >
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("hesr") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label11" runat="server" Text='<%# Bind("hesr") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="Thesr" runat="server" Width="150" Height="15"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" 
                HorizontalAlign="Center" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle ForeColor="#003399" HorizontalAlign="Center" BackColor="White" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:testConnectionString2 %>" 
            DeleteCommand="DELETE FROM [tblSafetyStatistics_test] WHERE [location_id] = @location_id AND [year] = @year AND [month] = @month" 
            InsertCommand="INSERT INTO tblSafetyStatistics_test(location_id, year, month, [Shop Strength], [Office Strength] ,strength, accidents ,fatal,  mandayslost,frequency,severityrate,hefr,hesr ) VALUES (@location_id, @year, @month, @Shop_Strength, @Office_Strength , @Shop_Strength+@Office_Strength, @accidents, @fatal, @mandayslost,@frequency, @severityrate,@hefr,@hesr)" 
            SelectCommand="SELECT location_id, (CASE WHEN [location_id] = 225 THEN 'Sohar' WHEN [location_id] = 450 THEN 'Powai' WHEN [location_id] = 460 THEN 'Talegaon'  WHEN [location_id] = 470 THEN 'Bangalore' WHEN [location_id] = 480 THEN 'Coimbatore' WHEN [location_id] = 500 THEN 'Hazira' WHEN [location_id] = 510 THEN 'Ranoli' WHEN [location_id] = 540 THEN 'Vizag' WHEN [location_id] = 999 THEN 'Sites' END) AS Location, year, month, [Shop Strength] AS Shop_Strength, [Office Strength] AS Office_Strength,  [Shop Strength]+[Office Strength] as strength, accidents, fatal, mandayslost, frequency, severityrate,(case when month=1 then (select top 1  hefr from tblSafetyStatistics_test where month=1 and year=(SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year))) when month=2 then (select top 1 hefr from tblSafetyStatistics_test where month=2 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year))) when month=3 then (select top 1 hefr from tblSafetyStatistics_test where month=3 and year =(SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year))) when month=4 then (select top 1 hefr from tblSafetyStatistics_test where month=4 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year))) when month=5 then (select top 1 hefr from tblSafetyStatistics_test where month=5 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year))) when month=6 then (select top 1 hefr from tblSafetyStatistics_test where month=6 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year))) when month=7 then (select top 1 hefr from tblSafetyStatistics_test where month=7 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))when month=8 then (select top 1  hefr from tblSafetyStatistics_test where month=8 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))when month=9 then (select top 1 hefr from tblSafetyStatistics_test where month=9 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year))) when month=10 then (select top 1 hefr from tblSafetyStatistics_test where month=10 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year))) when month=11 then (select top 1  hefr from tblSafetyStatistics_test where month=11  and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year))) when month=12 then (select top 1 hefr from tblSafetyStatistics_test where month=12 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year))) end)[hefr],(case when month =1 then (select top 1 hesr from tblSafetyStatistics_test where month=1 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))  when month =2 then (select top 1 hesr from tblSafetyStatistics_test where month=2 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))  when month =3 then (select top 1 hesr from tblSafetyStatistics_test where month=3 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))  when month =4 then (select top 1 hesr from tblSafetyStatistics_test where month=4 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))  when month =5 then (select top 1 hesr from tblSafetyStatistics_test where month=5 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))  when month =6 then (select top 1 hesr from tblSafetyStatistics_test where month=6 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))  when month =7 then (select top 1 hesr from tblSafetyStatistics_test where month=7 and year= (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))  when month =8 then (select top 1 hesr from tblSafetyStatistics_test where month=8 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))  when month =9 then (select top 1 hesr from tblSafetyStatistics_test where month=9 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))  when month =10 then (select top 1 hesr from tblSafetyStatistics_test where month=10 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))  when month =11 then (select top 1 hesr from tblSafetyStatistics_test where month=11 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year)))  when month =12 then (select top 1 hesr from tblSafetyStatistics_test where month=12 and year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year))) end)[hesr] FROM tblSafetyStatistics_test WHERE (year = (SELECT DISTINCT Year FROM tblsafetyyear WHERE (Year = @Year))) ORDER BY month" 
            UpdateCommand="UPDATE tblSafetyStatistics_test SET  [Shop Strength] = @Shop_Strength, [Office Strength] = @Office_Strength, accidents = @accidents,fatal = @fatal, mandayslost = @mandayslost,frequency = @frequency,severityrate = @severityrate,hefr = @hefr,hesr = @hesr WHERE (location_id = @location_id) AND (year = @year) AND (month = @month)">
            <DeleteParameters>
                <asp:Parameter Name="location_id" Type="Int32" />
                <asp:Parameter Name="year" Type="Int32" />
                <asp:Parameter Name="month" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="location_id" Type="Int32" />
                <asp:Parameter Name="year" Type="Int32" />
                <asp:Parameter Name="month" Type="Int32" />
                <asp:Parameter Name="Shop_Strength" Type="Int32" />
                <asp:Parameter Name="Office_Strength" Type="Int32" />
                <asp:Parameter Name="accidents" Type="Int32" />
                <asp:Parameter Name="fatal" Type="Int32" />
                <asp:Parameter Name="mandayslost" Type="Int32" />
                <asp:Parameter Name="frequency" Type="Double"/>
                <asp:Parameter Name="severityrate" Type="Double" />
                <asp:Parameter Name="hefr" Type="Double" />
                <asp:Parameter Name="hesr" Type="Double" />
            
               
             
               
                
            </InsertParameters>
            <UpdateParameters>
               <asp:Parameter Name="Shop_Strength" Type="Int32" />
                <asp:Parameter Name="Office_Strength" Type="Int32" />
                <asp:Parameter Name="accidents" Type="Int32" />
                <asp:Parameter Name="fatal" Type="Int32" />
                <asp:Parameter Name="mandayslost" Type="Int32" />
                <asp:Parameter Name="frequency" Type="Double" />
                <asp:Parameter Name="severityrate" Type="Double" />
                  <asp:Parameter Name="hefr" Type="Double" />
                <asp:Parameter Name="hesr" Type="Double" />
              <asp:Parameter Name="location_id" Type="Int32" />
                <asp:Parameter Name="year" Type="Int32" />
                <asp:Parameter Name="month" Type="Int32" />
            </UpdateParameters>
            <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="year" 
                PropertyName="SelectedValue" Type="Int32" DefaultValue="" />
        </SelectParameters>
        </asp:SqlDataSource>
       
       <br />
       <br />
       
       </center>
           <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            ForeColor="#003399" Font-Bold="True" />


<center>
           <asp:Button ID="Button2" runat="server" Text="ADD DATA" onclick="insert_click" 
               BackColor="#003399" Font-Bold="True" Font-Names="Arial" ForeColor="#CCCCFF" 
               Height="50px" Width="112px" BorderStyle="Solid" BorderColor="Black" 
               style="margin-left: 98px" />
            
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
               ConnectionString="<%$ ConnectionStrings:testConnectionString2 %>" 
               
               
               
               
               
               
               SelectCommand="SELECT DISTINCT * FROM [tblsafetyyear] ORDER BY [Year] DESC">
           </asp:SqlDataSource>
           <br />
        
             
                </center>
    </div>
    </form>
</body>
</html>


