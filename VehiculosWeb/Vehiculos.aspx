<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="VehiculosWeb.Vehiculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content condensed">
        <div class="jumbotron">
            <h2>Administración de Vehiculos</h2>
        </div>
        <table class="table table-striped table-hover ">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Column heading</th>
                    <th>Column heading</th>
                    <th>Column heading</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>Column content</td>
                    <td>Column content</td>
                    <td>Column content</td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>Column content</td>
                    <td>Column content</td>
                    <td>Column content</td>
                </tr>
                <tr class="info">
                    <td>3</td>
                    <td>Column content</td>
                    <td>Column content</td>
                    <td>Column content</td>
                </tr>
                <tr class="success">
                    <td>4</td>
                    <td>Column content</td>
                    <td>Column content</td>
                    <td>Column content</td>
                </tr>
                <tr class="danger">
                    <td>5</td>
                    <td>Column content</td>
                    <td>Column content</td>
                    <td>Column content</td>
                </tr>
                <tr class="warning">
                    <td>6</td>
                    <td>Column content</td>
                    <td>Column content</td>
                    <td>Column content</td>
                </tr>
                <tr class="active">
                    <td>7</td>
                    <td>Column content</td>
                    <td>Column content</td>
                    <td>Column content</td>
                </tr>
            </tbody>
        </table>

        <div class="row">
            <%--    <a href="#" class="btn btn-default" data-toggle="modal" data-target="#mdNuevoVehiculo">Agregar Vehiculo</a>--%>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <%-- 
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Dominio { get; set; }
        public DateTime AnioFabricacion { get; set; }
        public string NroMotor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public long ValuacionIngreso { get; set; }
        public DateTime FechaVenta { get; set; }
        public long PrecioVenta { get; set; }
        public int ClienteId { get; set; }
            --%>
        </div>
        <div class="well">
            <form id="formNuevoVehiculo" class="form-horizontal">
                <fieldset>
                    <legend>Agregar Vehiculo</legend>
                    <div class="form-group">
                        <asp:Label ID="lblMarca" runat="server" Text="Marca" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="rfvMarca"
                            ControlToValidate="txtMarca"
                            Display="Static"
                            ErrorMessage="*"
                            Text="Este campo es obligatorio!"
                            runat="server"
                            ForeColor="Red"
                            Font-Bold="true" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblModelo" runat="server" Text="Modelo" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="rfvModelo"
                            ControlToValidate="txtModelo"
                            Display="Static"
                            ErrorMessage="*"
                            Text="Este campo es obligatorio!"
                            runat="server"
                            ForeColor="Red"
                            Font-Bold="true" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblDominio" runat="server" Text="Dominio" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtDominio" runat="server" CssClass="form-control" MaxLength="8"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="rfvDominio"
                            ControlToValidate="txtDominio"
                            Display="Static"
                            ErrorMessage="*"
                            Text="Este campo es obligatorio!"
                            runat="server"
                            ForeColor="Red"
                            Font-Bold="true" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblAnioFab" runat="server" Text="Año Fabricación" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtAnioFabricacion" onkeypress="return this.value.length<=3"  runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="rfvAnioFabricacion"
                            ControlToValidate="txtAnioFabricacion"
                            Display="Dynamic"
                            ErrorMessage="*"
                            Text="Este campo es obligatorio!"
                            runat="server"
                            ForeColor="Red"
                            Font-Bold="true" />
                        <asp:RangeValidator
                            ID="rvAnioFab"
                            MaximumValue="2020"
                            MinimumValue="1910"
                            ControlToValidate="txtAnioFabricacion"
                            Display="Dynamic"
                            ErrorMessage="*"
                            Text="El Rango debe estar entre 1910 y 2020"
                            runat="server"
                            ForeColor="Red"
                            Font-Bold="true" />

                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblNroMotor" runat="server" Text="Nro de Motor" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtNroMotor" runat="server" CssClass="form-control" MaxLength="20" TextMode="DateTime"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator1"
                            ControlToValidate="txtAnioFabricacion"
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
                            <asp:Button Text="Grabar" runat="server" CssClass="btn btn-primary" ID="btnGrabar" />
                        </div>
                    </div>
                </fieldset>
            </form>
        </div>
        <div class="modal" id="mdNuevoVehiculo">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        <h4 class="modal-title">Nuevo Vehiculo</h4>
                    </div>
                    <div class="modal-body">
                        <p>One fine body…</p>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        <asp:Button Text="Grabar" runat="server" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
