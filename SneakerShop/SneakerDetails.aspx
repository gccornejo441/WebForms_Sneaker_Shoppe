<%@ Page Title="Sneaker Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SneakerDetails.aspx.cs" Inherits="SneakerShop.SneakerDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="sneakerDetail" runat="server" ItemType="SneakerShop.Models.Sneaker" SelectMethod="GetSneaker" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.SneakerName %></h1
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Images/<%#:Item.ImagePath %>" style="border:solid; height:300px" alt="<%#:Item.SneakerName %>" />
                    </td>
                    <td>&nbsp</td>
                    <td style="vertical-align: top; text-align:left;">
                        <b>Description:</b><br /><%#: Item.Description %>
                        <br />
                        <span><b />Price:</span>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span><b>Sneaker Number:</b>&nbsp;<%#:Item.SneakerID %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
