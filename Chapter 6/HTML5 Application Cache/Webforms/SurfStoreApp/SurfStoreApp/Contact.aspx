<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SurfStoreApp.Contact" %>

<!DOCTYPE html>
<html lang="en" manifest="AppCache.aspx">
<head>
        <meta charset="utf-8">
        <title>Surf Store Application</title>
        <link rel="shortcut icon" href="Images/favicon.ico" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta name="description" content="">
        <meta name="author" content="">
        <link href="Styles/bootstrap.css" rel="stylesheet" />
        <link href="Styles/bootstrap-responsive.css" rel="stylesheet" />
        <script src="Scripts/jquery-1.7.2.js"></script>
        <style type="text/css">
            body
            {
                padding-top: 60px;
                padding-bottom: 40px;
            }

            .sidebar-nav
            {
                padding: 9px 0;
            }
        </style>
</head>
<body>
    <div class="navbar navbar-fixed-top">
        <div class="navbar-inner">
            <div class="container-fluid">
                <a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse"><span
                    class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span>
                </a><a class="brand" href="Default.aspx">Surf Store Application</a>
                <div class="btn-group pull-right">
                    <a class="btn dropdown-toggle" data-toggle="dropdown" href="#"><i class="icon-user"></i>Logon <span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="#">Profile</a></li>
                        <li class="divider"></li>
                        <li><a href="#">Sign Out</a></li>
                    </ul>
                </div>
                <div class="nav-collapse">
                    <ul class="nav">
                        <li class="active"><a href="Default.aspx">Home</a></li>
                        <li><a href="About.aspx">About</a></li>
                        <li><a href="Contact.aspx">Contact</a></li>
                    </ul>
                </div>
                <!--/.nav-collapse -->
            </div>
        </div>
    </div>
    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span3">
                <div class="well sidebar-nav">
                    <ul class="nav nav-list">
                        <li class="nav-header">All Items</li>
                        <li><a href="Product.aspx?category=surfboard">Surfboards</a></li>
                        <li><a href="Product.aspx?category=mens">Mens</a></li>
                        <li><a href="Product.aspx?category=ladies">Ladies</a></li>
                        <li><a href="Product.aspx?category=fins">Fins</a></li>
                    </ul>
                </div>
                <div class="well form-search">
                    <h3>Browse the Store</h3>
                    <input type="text" class="input-medium search-query" value="Search.....">
                    <button type="submit" class="btn">
                        Search</button>
                </div>
                <!--/.well -->
            </div>
            <div class="span9">
                <div class="row-fluid">
                    <h2>CONTACT US
                    </h2>
                    <form>
                        <fieldset>
                            <div class="control-group">
                                <label class="control-label" for="focusedInput">
                                    Name</label>
                                <div class="controls">
                                    <input class="input-xlarge focused" id="focusedInput" type="text" value="Enter your name">
                                </div>
                            </div>
                            <div class="control-group">
                                <label class="control-label" for="focusedInput">
                                    Subject</label>
                                <div class="controls">
                                    <input class="input-xlarge focused" id="Text1" type="text" value="Enter your email subject">
                                </div>
                            </div>
                            <div class="control-group">
                                <label class="control-label" for="focusedInput">
                                    Email Address</label>
                                <div class="input-prepend">
                                    <input class="span2" id="Text3" size="16" type="text"><span class="add-on">@</span><input
                                        class="span2" id="prependedInput" size="16" type="text">
                                </div>
                            </div>
                            <div class="control-group">
                                <label class="control-label" for="focusedInput">
                                    Message</label>
                                <div class="controls">
                                    <textarea class="input-xlarge" id="textarea" rows="3"></textarea>
                                </div>
                            </div>
                            <div class="form-actions">
                                <button type="submit" class="btn btn-primary">
                                    Submit</button>
                            </div>
                        </fieldset>
                    </form>
                </div>
            </div>
        </div>
        <hr>
        <footer class="footer">
            <p class="pull-right"><a href="Default.aspx">Back to top</a></p>
            <p>Surf Store 2012</p>
        </footer>
    </div>
    <!--/.fluid-container-->
</body>
</html>
