<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test 1.aspx.cs" Inherits="WebDev2015_03_11.test_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Test 2</title>

    <script type="text/javascript" src="JavaScript1.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>This is a heading</h2>
            <p>This is a paragraph.</p>
            <p>This is another paragraph.</p>
            <button>Click me</button>
        </div>
    </form>

    <script type="text/javascript">
        $(document).ready(function () {
            $("button").click(function () {
                $("p").hide();
            });
        });
    </script>
</body>
</html>
