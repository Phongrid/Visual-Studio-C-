<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="MVC_APP.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
Hello World
    <table class="table">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">Product img</th>
      <th scope="col">Last</th>
      <th scope="col">Price</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row">1</th>
      <td>
          <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="https://images.unsplash.com/photo-1523895665936-7bfe172b757d?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;w=1000&amp;q=80" Width="300px" />
        </td>
      <td>Otto</td>
      <td>300 THB</td>
    </tr>
    <tr>
      <th scope="row">2</th>
      <td>
          <asp:Image ID="Image2" runat="server" Height="150px" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSTUSj5gCwQE6gOnlSxiVWPum-_eTk3iqffPTfcofh6r5aY5H_G" Width="300px" />
        </td>
      <td>Thornton</td>
      <td>300 THB</td>
    </tr>
    <tr>
      <th scope="row">3</th>
      <td>
          <asp:Image ID="Image3" runat="server" Height="150px" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQ4ZlFZoCQLalua9J4c4hmJdHPqVmYmggd1OrlYei3r2jyFTTRt" Width="300px" />
        </td>
      <td>the Bird</td>
      <td>300 THB</td>
    </tr>
  </tbody>
</table>
</asp:Content>
