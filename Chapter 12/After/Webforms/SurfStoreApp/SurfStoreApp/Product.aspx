<%@ Page Title="Product" EnableSessionState="False" EnableViewState="False"  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="SurfStoreApp.Product" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

        <div class="span9">
            <div class="row-fluid">
                <asp:PlaceHolder ID="phProductImages" runat="server"></asp:PlaceHolder>
            </div>
        </div>
        <!--/span-->

</asp:Content>