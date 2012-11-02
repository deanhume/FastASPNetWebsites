<%@ Page Language="C#" EnableSessionState="False" EnableViewState="False" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SurfStoreApp.Default" MasterPageFile="~/Site.master" %>
 <%@ OutputCache Duration="86400" VaryByParam="none"  %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="span9">
        <div style="background-image: url('Images/intro.jpg'); width: 100%; height: 400px;
            background-repeat: no-repeat;">
            <div style="color: white; padding: 40px;">
                <h2>
                    Welcome to the Surf Store Application</h2>
                <p>
                    This is the ultimate store to purchase your Extreme Sports gear from. 
                    <br/>
                    We have a
                    wide range of Surfboards, Snowboards, and Skateboards. We offer the best service
                    and our website speed is exceptional!! 
                    <br />Order Today!
                </p>
                <a class="btn btn-primary btn-large" href="About.aspx">Learn more &raquo;</a>
            </div>
        </div>
        <br />
        <div class="row-fluid">
            <a href="Product.aspx?category=surfboard">
                <div class="span4" style="padding: 5px">
                    <h2>
                        Surf</h2>
                    
                    <img src="<%= SurfStoreApp.Utils.CdnUtils.CdnUrl("Images/surfing-homepage.png") %>" width="297" height="197"   />
                </div>
            </a><a href="Product.aspx?category=mens">
                <div class="span4" style="padding: 5px">
                    <h2>
                        Skate</h2>
                    <img src="Images/skate-homepage.png" width="297" height="197"   />
                </div>
            </a><a href="Product.aspx?category=mens">
                <div class="span4" style="padding: 5px">
                    <h2>
                        Snow</h2>
                    <img src="Images/image.jpg" width="297" height="197" />
                </div>
            </a>
        </div>
        <br />
        <div class="row-fluid">
            <a href="Product.aspx?category=mens">
                <div class="span4" style="padding: 5px">
                    <h2>
                        Mens</h2>
                    <img src="Images/mens-homepage.png" width="297" height="197" />
                </div>
            </a><a href="Product.aspx?category=ladies">
                <div class="span4" style="padding: 5px">
                    <h2>
                        Ladies</h2>
                    <img src="Images/ladies-homepage.png" width="297" height="197" />
                </div>
            </a><a href="Product.aspx?category=surfboard">
                <div class="span4" style="padding: 5px">
                    <h2>
                        All Brands</h2>
                    <img src="Images/allbrands-homepage.png" width="297" height="197" />
                </div>
            </a>
        </div>
        <!--/row-->
    </div>
    <!--/span-->
</asp:Content>

