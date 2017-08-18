<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreamChoiceForm.aspx.cs" Inherits="FaceSkinBridge.Presentation.CreamChoiceForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1" OnNextButtonClick="Wizard1_NextButtonClick" Width="441px">
                <WizardSteps>
                    <asp:WizardStep runat="server" title="Types skin">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                            <asp:ListItem Value="SensitiveSkin">Sensitive</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" title="Colors skin">
                        <asp:RadioButtonList ID="RadioButtonList2" runat="server" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
                            <asp:ListItem Value="VanillaSkin">Vanilla</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" Title="Result">
                        <asp:Label ID="lblCreamName" runat="server" Text="Label"></asp:Label>
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </div>
    </form>
</body>
</html>
