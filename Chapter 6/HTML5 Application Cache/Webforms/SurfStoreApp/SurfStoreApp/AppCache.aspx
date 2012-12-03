<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppCache.aspx.cs" Inherits="SurfStoreApp.AppCache" %>
<%@ Import Namespace="SurfStoreApp.Utils" %>
<% HttpContext.Current.Response.ContentType = "text/cache-manifest"; %>CACHE MANIFEST

NETWORK:
*

CACHE:
# JS files
<%= "Scripts/jquery-1.7.2.js".AppendHash(Request) %>

# CSS files
<%= "Styles/bootstrap.css".AppendHash(Request) %>
<%= "Styles/bootstrap-responsive.css".AppendHash(Request) %>

FALLBACK:
