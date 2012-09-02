<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppCache.aspx.cs" Inherits="SurfStoreApp.AppCache" %>
<%@ Import Namespace="SurfStoreApp.Utils" %>
<% HttpContext.Current.Response.ContentType = "text/cache-manifest"; %>CACHE MANIFEST

NETWORK:
*

CACHE:
# JS files
<%= FileVersionUtils.BuildVersionedFileName("Scripts/jquery-1.7.2.js") %>

# CSS files
<%= FileVersionUtils.BuildVersionedFileName("Styles/bootstrap.css") %>
<%= FileVersionUtils.BuildVersionedFileName("Styles/bootstrap-responsive.css") %>

FALLBACK:
