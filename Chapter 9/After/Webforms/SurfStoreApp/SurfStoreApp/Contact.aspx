<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SurfStoreApp.Contact" %>

 <%@ OutputCache Duration="86400" VaryByParam="none"  %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="span9">
        <div class="row-fluid">
            <h2>
                Contact us
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
</asp:Content>
