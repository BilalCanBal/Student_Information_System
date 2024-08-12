<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="MvcProje.OgrenciGuncelle" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
            <asp:Label for="TextId" runat="server" Text="Label" style="font-weight: bold">Öğrenci ID:</asp:Label>
            <asp:TextBox ID="TextId1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
            <asp:Label for="TextAd" runat="server" Text="Label" style="font-weight: bold">Öğrenci Adı:</asp:Label>
            <asp:TextBox ID="TextAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />


             <div>
            <asp:Label for="TextSoyad" runat="server" Text="Label" style="font-weight: bold">Öğrenci Soyadı:</asp:Label>
            <asp:TextBox ID="TextSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

             <div>
            <asp:Label for="TextNumara" runat="server" Text="Label" style="font-weight: bold">Öğrenci Numara:</asp:Label>
            <asp:TextBox ID="TextNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

             <div>
            <asp:Label for="TextSifre" runat="server" Text="Label" style="font-weight: bold">Öğrenci Şifre:</asp:Label>
            <asp:TextBox ID="TextSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

             <div>
            <asp:Label for="TextFoto" runat="server" Text="Label" style="font-weight: bold">Öğrenci Fotoğraf:</asp:Label>
            <asp:TextBox ID="TextFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
        </div>

    <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="Button2_Click" />
        


    </form>
</asp:Content>


 
