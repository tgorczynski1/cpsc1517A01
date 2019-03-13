<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContestEntry.aspx.cs" Inherits="WebApp.SamplePages.ContestEntry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h1>Contest Entry</h1>
    </div>

    <div class="row col-md-12">
        <div class="alert alert-info">
            <blockquote style="font-style: italic">
                This illustrates some simple controls to fill out an entry form for a contest. 
                This form will use basic bootstrap formatting and illustrate Validation.
            </blockquote>
            <p>
                Please fill out the following form to enter the contest. This contest is only available to residents in Western Canada.
            </p>

        </div>
    </div>

    <%--    place all the validation controls in one group one may have multiple validation controls per field, 
        fields can only support a single instance of a particular validation control
        Required Validation--%>
    <asp:RequiredFieldValidator ID="RequiredFieldFirstName" runat="server" ErrorMessage="First Name is required." Display="None"
        SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="FirstName"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldLastName" runat="server" ErrorMessage="Last Name is required." Display="None"
        ForeColor="Firebrick" ControlToValidate="LastName"> </asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldStreetAdress1" runat="server" ErrorMessage="Steet Address 1 is required." Display="None"
        ForeColor="Firebrick" ControlToValidate="StreetAddress1"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldCity" runat="server" ErrorMessage="City is required." Display="None"
        ForeColor="Firebrick" ControlToValidate="City"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldPostalCode" runat="server" ErrorMessage="Postal Code is required." Display="None"
        ForeColor="Firebrick" ControlToValidate="PostalCode"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldEmailAddress" runat="server" ErrorMessage="Email is required." Display="None"
        ForeColor="Firebrick" ControlToValidate="EmailAddress"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldCheckAnswer" runat="server" ErrorMessage="Skill question is required." Display="None"
        ForeColor="Firebrick" ControlToValidate="CheckAnswer"></asp:RequiredFieldValidator>

    <%--we do not have a sample control to do range validation
    for this demonstration, StreetAdress2 will be used to demonstrate a Range Validation--%>
    <asp:RangeValidator ID="RangeStreetAddress2" runat="server" ErrorMessage="Enter a value between 1 (strongly disagree) and 10 (strongly agree)" Display="None"
        SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="StreetAddress2" MaximumValue="10" MinimumValue="1" Type="Integer"></asp:RangeValidator>

    <%-- RegularExpression Validation (Regex)
        you can create your own pattern or since most general patterns have already been well developed,
        search the net for the acceptable pattern--%>
    <asp:RegularExpressionValidator ID="RegularExpressionPostalCode" runat="server" ErrorMessage="Invalid postal code format eg [T1Y7E8]"
         SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="PostalCode" ValidationExpression="[a-zA-Z][0-9][a-zA-Z][0-9][a-zA-Z][0-9]"></asp:RegularExpressionValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionEmailAddress" runat="server" ErrorMessage="Invalid email address format eg [string]@[email]"
         SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="EmailAddress" 
        ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"></asp:RegularExpressionValidator>

    <%-- Compare --%>
    <%-- Compare Datatype --%>
    <%--<asp:CompareValidator ID="CompareStreetAddress2" runat="server" ErrorMessage="Survery value needs to be a number" Display="None" SetFocusOnError="true" 
        ForeColor="Firebrick" ControlToValidate="StreetAddress2" Type="Integer" ></asp:CompareValidator>--%>
    <asp:CompareValidator ID="CompareCheckAnswer" runat="server" ErrorMessage="Incorrect skill testing answer" Display="None" SetFocusOnError="true" 
        ForeColor="Firebrick" ControlToValidate="StreetAddress2" Type="Integer" Operator="Equal" ValueToCompare="15" ></asp:CompareValidator>
    
    <%-- Compare to another control
        for this example assume there is a confirmed email field--%>
    <%--<asp:CompareValidator ID="CompareConfirmEmailAddress" runat="server" ErrorMessage="Email address not confirmed, retry." Display="None" SetFocusOnError="true" 
        ForeColor="Firebrick" ControlToValidate="StreetAddress2" Type="String" Operator="Equal" ControlToCompare="EmailAddress" ></asp:CompareValidator>--%>

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Correct the following concerns and resubmit" CssClass="alert alert-danger"/>

    <div class="row">
        <div class="col-md-6">
            <fieldset class="form-horizontal">
                <legend>Application Form</legend>

                <asp:Label ID="Label1" runat="server" Text="First Name"
                    AssociatedControlID="FirstName"></asp:Label>
                <asp:TextBox ID="FirstName" runat="server"
                    ToolTip="Enter your first name." MaxLength="25"></asp:TextBox>

                <asp:Label ID="Label6" runat="server" Text="Last Name"
                    AssociatedControlID="LastName"></asp:Label>
                <asp:TextBox ID="LastName" runat="server"
                    ToolTip="Enter your last name." MaxLength="25"></asp:TextBox>

                <asp:Label ID="Label3" runat="server" Text="Street Address 1"
                    AssociatedControlID="StreetAddress1"></asp:Label>
                <asp:TextBox ID="StreetAddress1" runat="server"
                    ToolTip="Enter your street address." MaxLength="75"></asp:TextBox>

                <asp:Label ID="Label7" runat="server" Text="Street Address 2"
                    AssociatedControlID="StreetAddress2"></asp:Label>
                <asp:TextBox ID="StreetAddress2" runat="server"
                    ToolTip="Enter your additional street address." MaxLength="75"></asp:TextBox>
                <br />
                <asp:Label ID="Label8" runat="server" Text="City"
                    AssociatedControlID="City"></asp:Label>
                <asp:TextBox ID="City" runat="server"
                    ToolTip="Enter your City name" MaxLength="50"></asp:TextBox>

                <asp:Label ID="Label9" runat="server" Text="Province"
                    AssociatedControlID="Province"></asp:Label>
                <asp:DropDownList ID="Province" runat="server" Width="75px">
                    <asp:ListItem Value="AB" Text="AB"></asp:ListItem>
                    <asp:ListItem Value="BC" Text="BC"></asp:ListItem>
                    <asp:ListItem Value="MN" Text="MN"></asp:ListItem>
                    <asp:ListItem Value="SK" Text="SK"></asp:ListItem>
                </asp:DropDownList>

                <asp:Label ID="Label10" runat="server" Text="Postal Code"
                    AssociatedControlID="PostalCode"></asp:Label>
                <asp:TextBox ID="PostalCode" runat="server"
                    ToolTip="Enter your postal code" MaxLength="6"></asp:TextBox>

                <asp:Label ID="Label2" runat="server" Text="Email"
                    AssociatedControlID="EmailAddress"></asp:Label>
                <asp:TextBox ID="EmailAddress" runat="server"
                    ToolTip="Enter your email address"
                    TextMode="Email"></asp:TextBox>

            </fieldset>
            <p>
                Note: You must agree to the contest terms in order to be entered.
               <br />
                <asp:CheckBox ID="Terms" runat="server" Text="I agree to the terms of the contest" />
            </p>

            <p>
                Enter your answer to the following calculation instructions:<br />
                Multiply 15 times 6<br />
                Add 240<br />
                Divide by 11<br />
                Subtract 15<br />
                <asp:TextBox ID="CheckAnswer" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="col-md-6">
            <div class="col-md-offset-2">
                <p>
                    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />&nbsp;&nbsp;
                    <asp:Button ID="Clear" runat="server" Text="Clear" CausesValidation="true" OnClick="Clear_Click" />
                </p>
                <asp:Label ID="Message" runat="server"></asp:Label><br />
                <hr style="width: 5px" />
                <asp:GridView ID="ContestEntryList" runat="server"></asp:GridView>

            </div>
        </div>
    </div>
    <script src="../Scripts/bootwrap-freecode.js"></script>
</asp:Content>
