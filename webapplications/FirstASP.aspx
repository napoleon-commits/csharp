<%@ Page Language="C#"%>

<HTML>
    <HEAD>
        <SCRIPT>
            protected void btnMyButtonClick(object Source, EventArgs e)
            {
                lblMyLabel.Text = "The button was <b>clicked</b>!";
            }
        </SCRIPT>
    </HEAD>
    <BODY>
        <H3>Simple Web Form Example</H3>

        <FORM runat=server>
            <asp:Button id=btnMyButton runat="server" Text="My Button" onclick="btnMyButtonClick" />
            <br />
            <br />
            <asp:Label id=lblMyLabel runat=server />
        </FORM>
    </BODY>
</HTML>