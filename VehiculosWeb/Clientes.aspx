<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="VehiculosWeb.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content condensed">
        <div class="jumbotron">
            <h2>Administración de Clientes</h2>           
        </div>

        <div class="well">
            <form id="formNuevoCliente" class="form-horizontal">
                <fieldset>
                    <legend>Crear Cliente</legend>
                    <div class="form-group">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="rfvNombre"
                            ControlToValidate="txtNombre"
                            Display="Static"
                            ErrorMessage="*"
                            Text="Este campo es obligatorio!"
                            runat="server"
                            ForeColor="Red"
                            Font-Bold="true" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblApellido" runat="server" Text="Apellido" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="rfvApellido"
                            ControlToValidate="txtApellido"
                            Display="Static"
                            ErrorMessage="*"
                            Text="Este campo es obligatorio!"
                            runat="server"
                            ForeColor="Red"
                            Font-Bold="true" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblDNI" runat="server" Text="DNI" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" MaxLength="8"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="rfvDNI"
                            ControlToValidate="txtDNI"
                            Display="Static"
                            ErrorMessage="*"
                            Text="Este campo es obligatorio!"
                            runat="server"
                            ForeColor="Red"
                            Font-Bold="true" />
                    </div>
                    <div class="form-group">
                        <div class="col-lg-10 col-lg-offset-2">
                            <button type="reset" class="btn btn-default" id="btnCancelar">Cancelar</button>
                            <asp:Button Text="Grabar" runat="server" CssClass="btn btn-primary" ID="btnGrabar" OnClick="btnGrabar_Click" />
                        </div>
                    </div>
                </fieldset>
            </form>
        </div>
        <div class="well">

            <asp:GridView ID="gvClientes" runat="server" AllowPaging="True" AllowSorting="True" OnRowCommand="gvClientes_RowCommand">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>
