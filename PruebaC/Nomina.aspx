<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nomina.aspx.cs" Inherits="PruebaC.Nomina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
     <style>
        .labelclas{
              font-weight: bold;
              font-size: medium;
              font-style: italic;
              color: #C0BA72;
        }

    </style>   

     <style>
       

        table {
            border-spacing: 0;
            border-collapse: collapse;
        
            align-content:center;
     
            
        }
        input[type="text"] {
            width: 90%;
            box-sizing: border-box;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
        }

       
       
    </style>
      <script>
          function acceptNum(evt) {
              // NOTE: Backspace = 8, Enter = 13, '0' = 48, '9' = 57	
              var key = nav4 ? evt.which : evt.keyCode;
              return (key <= 13 || (key >= 48 && key <= 57));
          }
          function ConsultaEmpleadoExistente() {
              document.getElementById("<%= btnBuscar.ClientID %>").click();

       }
     </script>
     

    <!DOCTYPE html>
     
<html lang="en">
      <section class="banner_main">
            
         <div id="banner1">
       
          	<form id="form1" runat="server"  method="post">

                        <div class="row" >
                      
                           <div class="col-md-12 ">
                                   
                                    <div  class="col-md-12" >
                                           <table style="margin: 0 auto;">
                                            <tr>
                                                <td> 
                                                     <h1> Consulta Entregas </h1>
                                                </td>
                                          </tr>
                                        </table>
                                        <table border="1"  style="margin: 0 auto;">
                                          <tr > 
                                                <td style="width:200px"  > 
                                                    <label class="labelclas" style="font-size:16px;">Nùmero empleado:</label>
                                                </td>
                                                <td style="width:300px" >
                                                    <asp:TextBox ID="txtNumero" z-index="0"   onblur="javascript:ConsultaEmpleadoExistente();" onkeydown="return (event.keyCode <= 13 || (event.keyCode >= 48 && event.keyCode <= 57))" MaxLength="3"  autocomplete="off" runat="server"  />
                                                </td>
                                          </tr>
                                          <tr> 
                                                <td class="td1"> 
                                                    <label class="labelclas" style="font-size:16px;">Numero de mes:</label>
                                                </td>
                                                <td>
                                                     
                                                  <asp:TextBox ID="txtDate" z-index="4" runat="server" placeholder="mm/dd/yyyy" Textmode="Month" ReadOnly = "false"></asp:TextBox>
                                                </td>
                                          </tr>
                                           <tr>
                                                <td> 
                                                    <asp:Button Text="Consultar" CssClass="btn btn-blue btn-lg" BackColor="DarkBlue" ForeColor="White" ID="btnConsultar" runat="server" OnClick="btnConsultar_Click"   />
                                                </td>
                                            
                                          </tr>
                                    
                                         
                                        </table>
                                        <table style="margin: 0 auto;">
                                            <tr>
                                                <td> 
                                                  <asp:GridView runat="server" ID="gvNomina" AutoGenerateColumns="false"     
                                                      CssClass="table table-hover table-nomargin table-bordered dataTable  dataTable-scroll-y "
                                                    DataKeyNames="IdEMpleado" AllowPaging="false" ShowHeader="true" ShowHeaderWhenEmpty="true" Visible="true"  data-checkall="all"
                                                    data-nopagination="true"   data-nosort="true"  >
                                                    <Columns>
                                                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                                                        <asp:BoundField HeaderText="Rol" DataField="DescripcionRol" />
                                                        <asp:BoundField HeaderText="Bono Rol" DataField="fTotalBono" />
                                                        <asp:BoundField HeaderText="Bono Entrega" DataField="fTotalEntregas" />
                                                        <asp:BoundField HeaderText="Salario Mes" DataField="fTotalSalario" />
                                                        <asp:BoundField HeaderText="Salario Bruto" DataField="fTotalGeneral" />
                                                        <asp:BoundField HeaderText="Salario Neto" DataField="fTotalGeneralConISR" />
                                                    
                                                    </Columns>
                            
                                                </asp:GridView>
                                                </td>
                                              
                                          </tr>
                                        </table>
                                    </div>
                             
                           </div>
                        </div>
                  <asp:Button Style="display: none"    ID="btnBuscar" runat="server" OnClick="btnBuscar_Click"   />
                 </div>
          </form>
      </section>
      <!-- end banner -->
      <!-- about section -->
     
      </footer>
      <!-- end footer -->
      <!-- Javascript files-->
      <script src="js/jquery.min.js"></script>
      <script src="js/popper.min.js"></script>
      <script src="js/bootstrap.bundle.min.js"></script>
      <script src="js/jquery-3.0.0.min.js"></script>
      <!-- sidebar -->
      <script src="js/jquery.mCustomScrollbar.concat.min.js"></script>
      <script src="js/custom.js"></script>
      <script>
          function openNav() {
              document.getElementById("mySidepanel").style.width = "250px";
          }

          function closeNav() {
              document.getElementById("mySidepanel").style.width = "0";
          }
      </script>
   </body>
</html>






</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
