<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" 
Inherits="SurfStoreApp.Product" MasterPageFile="~/Site.master" %>
<%@ OutputCache Duration="86400" VaryByParam="category"  %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

        <div class="span9">
            <div class="row-fluid">
                <asp:PlaceHolder ID="phProductImages" runat="server"></asp:PlaceHolder>
            </div>
        </div>
        <!--/span-->

</asp:Content>
