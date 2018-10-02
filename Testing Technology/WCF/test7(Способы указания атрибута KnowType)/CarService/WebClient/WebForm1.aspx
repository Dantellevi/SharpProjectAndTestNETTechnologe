<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Vendor"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Model"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Year"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="Label4" runat="server" Text="Тип"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="DDCarType" runat="server" OnSelectedIndexChanged="DropDownListType_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem Text="Truck car">

                        </asp:ListItem>
                        
                        <asp:ListItem Text="Passeger car">

                        </asp:ListItem>


                    </asp:DropDownList></td>
            </tr>

            <tr id="trCapasity" runat="server" visible="False">
                 <td>
                    <asp:Label ID="Caplab" runat="server" Text="Грузоподъемность"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="CapasityField" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr id="trPasseger" runat="server" visible="False">
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Кол-во пассажиров"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="PassegerField" runat="server"></asp:TextBox>
                </td>
            </tr>
           
                   
               
        </table>
         <asp:Button ID="ButtonSet" runat="server" Text="SetCar" OnClick="ButtonSet_Click" /><asp:Button ID="ButtonGet" runat="server" Text="GetCar" OnClick="ButtonGet_Click" />
        
        
    </div>
    </form>
</body>
</html>
