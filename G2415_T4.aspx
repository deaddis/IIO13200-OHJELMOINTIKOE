<%@ Page Title="" Language="C#" MasterPageFile="~/G2415_T4M.master" AutoEventWireup="true" CodeFile="G2415_T4.aspx.cs" Inherits="G2415_T4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4>
        Opintojakso ilmoittautumisia löytyi: <asp:Label ID="ojIlmo" runat="server" ></asp:Label><br />
        Oppilaita löytyi: <asp:Label ID="oppilasCount" runat="server" ></asp:Label><br />
    </h4> 
    <h3><asp:Label ID="lblError" runat="server" Visible="false"></asp:Label></h3> <br />
    <h4>
        <asp:DropDownList id="ddlJaksot" runat="server" DataSourceID="SqlDataSource4" AutoPostBack="true" DataTextField="course" Visible="false" OnSelectedIndexChanged="ddlJaksot_SelectedIndexChanged"></asp:DropDownList>  <br />
                <asp:DropDownList id="ddlOppilaat" runat="server" DataSourceID="SqlDataSource5" AutoPostBack="true" DataTextField="lastname" Visible="false" OnSelectedIndexChanged="ddlOpiskelija_SelectedIndexChanged"></asp:DropDownList>   <br />
        <asp:Button ID="Oppilaat" OnClick="getStudents" runat="server" Text="Hae Oppilaat"/>
        <asp:Button ID="LasnaOlot" OnClick="getLasnat" runat="server" Text="Hae Ilmot"/>
        <asp:Button ID="Opintojakson" OnClick="getOpinnot" runat="server" Text="Hae Opintojaksot"/><br />
        
        <asp:GridView id="gvOppilaat" runat="server" AutoGenerateColumns="true" >
        </asp:GridView><br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Ilmot %>" SelectCommand="SELECT DISTINCT [lastname], [firstname], [asioid] FROM [lasnaolot]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Ilmot %>" SelectCommand="SELECT [lastname], [firstname], [asioid], [course], [dateAdded] FROM [lasnaolot] ORDER BY [lastname]"></asp:SqlDataSource>
        
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:Ilmot %>" SelectCommand="SELECT DISTINCT [course] FROM [lasnaolot]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Ilmot %>" SelectCommand="SELECT [lastname], [firstname], [asioid], [course], [dateAdded] FROM [lasnaolot] WHERE [course] = @Course ORDER BY [lastname]">
                <SelectParameters>
               <asp:ControlParameter Name="Course" ControlID="ddlJaksot" 
                    PropertyName="SelectedValue" />
            </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:Ilmot %>" SelectCommand="SELECT DISTINCT [lastname], [firstname] FROM [lasnaolot]"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:Ilmot %>" SelectCommand="SELECT [lastname], [firstname], [course], [dateAdded] FROM [lasnaolot] WHERE [lastname] = @Lastname">
                    <SelectParameters>
                        <asp:ControlParameter Name="Lastname" ControlID="ddlOppilaat" 
                            PropertyName="SelectedValue" />
                    </SelectParameters>
                    </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:Ilmot %>" SelectCommand="SELECT [lastname], [firstname], [asioid], [course], [added] FROM [lasnaolot]"></asp:SqlDataSource>
       
    </h4>
</asp:Content>

