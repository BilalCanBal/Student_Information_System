<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="MvcProje.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <thead>
            <tr>
                <th>Örenci Id</th>
                <th>Örenci Ad</th>
                <th>Örenci Soyad</th>
                <th>Örenci Numara</th>
                <th>Örenci Şifre</th>
                <th>Örenci Fotoğraf</th>
                <th>Bakiye</th>
                <th>İşlemler</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <!-- Eval deger ceker -->
                        <td><%#Eval("ID")%></td>
                        <td><%#Eval("AD")%></td>
                        <td><%#Eval("SOYAD")%></td>
                        <td><%#Eval("NUMARA")%></td>
                        <td><%#Eval("SIFRE")%></td>
                        <td><%#Eval("FOTOGRAF")%></td>
                        <td><%#Eval("BAKIYE")%></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/OgrenciSil.aspx?OGRID="+Eval("ID") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "~/OgrenciGUncelle.aspx?OGRID="+Eval("ID") %>' CssClass="btn btn-warning" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater> 
        </tbody>
    </table>
</asp:Content>
