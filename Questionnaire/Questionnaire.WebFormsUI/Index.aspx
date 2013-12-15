<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Questionnaire.WebFormsUI.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="_tbxName" Text="Name"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="_tbxName" Height="28px" Width="400px"/>
        <br />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="_tbxName"
            CssClass="text-danger" ErrorMessage="The name field is required." />
        <br />
        <asp:Label runat="server" AssociatedControlID="_tbxSurname" Text="Surname"></asp:Label>
        <br />
        <asp:TextBox ID="_tbxSurname" runat="server" Height="39px" Width="397px"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="_tbxSurname" CssClass="text-danger" ErrorMessage="The surname field is required."></asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" AssociatedControlID="_tbxPatronymic" Text="Patronymic"></asp:Label>
        <br />
        <asp:TextBox ID="_tbxPatronymic" runat="server" Height="33px" Width="391px"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="_tbxPatronymic" ErrorMessage="The patronymic field is required." CssClass="text-danger"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="_lblQuestion" runat="server" Font-Size="Large" Text="Questions"></asp:Label>
        <br />
        <br />
        <asp:Label runat="server" AssociatedControlID="_tbxAge" Text="Age"></asp:Label>
        <asp:TextBox ID="_tbxAge" runat="server" CssClass="form-control" Height="16px" Width="140px" TextMode="Number"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="_tbxAge" CssClass="text-danger" ErrorMessage="Set age."></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label1" runat="server" AssociatedControlID="_tbxPetAnimals" Text="Do you like animals? Do you have one?"></asp:Label>
        <asp:TextBox ID="_tbxPetAnimals" runat="server" CssClass="form-control" Height="108px" TextMode="MultiLine" Width="416px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="_tbxPetAnimals" CssClass="text-danger" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" AssociatedControlID="_tbxSeasons" Text="What is your favorite seasons of the year?"></asp:Label>
        <asp:TextBox ID="_tbxSeasons" runat="server" CssClass="form-control" Height="108px" TextMode="MultiLine" Width="411px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="_tbxSeasons" CssClass="text-danger" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" AssociatedControlID="_tbxSubjects" Text="What is your favorite subjects?"></asp:Label>
        <asp:TextBox ID="_tbxSubjects" runat="server" CssClass="form-control" Height="105px" TextMode="MultiLine" Width="408px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="_tbxSubjects" CssClass="text-danger" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" AssociatedControlID="_tbxHobbies" Text="Hobbies"></asp:Label>
        <asp:TextBox ID="_tbxHobbies" runat="server" CssClass="form-control" Height="117px" TextMode="MultiLine" Width="407px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="_tbxHobbies" CssClass="text-danger" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" AssociatedControlID="_chbxLike" Text="Dou you like our questionnaire?"></asp:Label>
        <br />
        <asp:CheckBox ID="_chbxLike" runat="server" Text="Like" />
        <br />
        <asp:Button ID="_saveButton" runat="server" CssClass="form-control" OnClick="_saveButton_Click" Text="Save results" Width="198px" />
        <br />
    </div>
</asp:Content>
