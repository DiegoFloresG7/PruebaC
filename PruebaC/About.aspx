<%@ Page  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="PruebaC.About" %>


   <asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
       
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
                                                     <h1> Registro Empleados </h1>
                                                </td>
                                          </tr>
                                        </table>
                                        <table border="1" style="margin: 0 auto;">
                                          <tr> 
                                                <td> 
                                                    <label class="col-md-3" style="font-size:16px;">Nùmero</label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtNumero" CssClass="form-control" onblur="javascript:ConsultaEmpleadoExistente();"   autocomplete="off" runat="server" data-rule-number="true" data-rule-minlength="1" />
                                                </td>
                                          </tr>
                                          <tr>
                                                <td> 
                                                    <label class="col-md-3" style="font-size:16px;">Nombre</label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtNombre" z-index="0" CssClass="form-control" autofocus="true"  autocomplete="off" runat="server" data-rule-number="true" data-rule-minlength="1" />
                                                </td>
                                          </tr>
                                           <tr>
                                                <td> 
                                                    <label class="col-md-3" style="font-size:16px;">ROL</label>
                                                </td>
                                                <td>
                                                     <asp:DropDownList DataTextField="Descripcion" DataValueField="ID" ID="ddlRol" CssClass="form-control" runat="server"></asp:DropDownList>
                                                </td>
                                          </tr>
                                         
                                        </table>
                                        <table style="margin: 0 auto;">
                                            <tr>
                                                <td> 
                                                    <asp:Button Text="Agregar" CssClass="btn btn-blue btn-lg" ID="btnAgregar" runat="server" OnClick="btnAgregar_Click"   />
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