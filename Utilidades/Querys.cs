using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using JuVa.Models;

namespace JuVa.Utilerias
{
    internal class Querys
    {
        private static string sCn = "Data Source=LAPTOP-GJ3KKJ3E\\SQLEXPRESS; Initial Catalog=JuVa;" +
            "Persist Security Info=True;User ID=sa;Password=ornitorrinco";
        private static BindingSource bindi = new BindingSource();
        private static SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private static DataTable tablon = new DataTable();
        //private ArrayList usuarios = new ArrayList();
        private static readonly int[,] permisos = new int[5, 22]
        {
            {-1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 0,0,0,0,0,0,0,0,0,1,1,1,0,1,1,1,0,0,0,0,0,0 },
            { 1,0,1,0,0,1,1,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1 },
            { 2,1,1,1,1,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 3,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 }
        };

        private static readonly string[] querys = new string[60]
        {   "EXEC sp_Login '{0}','{1}';",                               //0
            "EXEC sp_Logout2 '{0}';",                                   //1
            "EXEC sp_InsertarUsuario '{0}','{1}','{2}',{3},'{4}';",     //2
            "SELECT ID,Nombre FROM Departamentos",                      //3
            "SELECT Clave,Nombre FROM",                        //4
            "SELECT noTarjeta,Nombre FROM ",                  //5
            "SELECT Usuario,Nombre FROM Usuarios",                      //6
            "EXEC sp_BorrarUsuario '{0}','{1}';",                       //7
            "SELECT Estado FROM Usuarios WHERE Usuario = '{0}' AND Borrado=0;",  //8
            "EXEC sp_CambiarEstado {0},'{1}','{2}'",                    //9
            "EXEC sp_extraeDatosUsuario '{0}'",                         //10
            "EXEC sp_ActualizarUsuario '{0}','{1}','{2}',{3},'{4}','{5}';",//11
            "EXEC sp_InsertarProveedor {0},'{1}','{2}','{3}',{4},'{5}';",//12
            "EXEC sp_InsertarCupon '{0}','{1}','{2}',{3},{4},'{5}';",    //13
            "EXEC sp_SubirForm '{0}','{1}',{2},'{3}';" ,                  //14
            "SELECT ID_Articulo,Nombre FROM Almacen" ,                     //15
            "sp_AgregarArticulo {0},'{1}',{2},'{3}';",                     //16
            "sp_ModArticulo {0},{1},'{2}';",                              //17
            "SELECT * FROM Almacen",                                      //18
            "SELECT Usuario,Nombre FROM Usuarios",                        //19
            "sp_NuevaSolicitud {0},{1},{2},'{3}','{4}';",                 //20
            "SELECT ID_Solicitud,Articulo,Cantidad,Estado,Fecha  from SolicitudCompra WHERE Estado=",//21
            "SELECT ID_Solicitud from SolicitudCompra WHERE Estado='Pendiente' AND ID_Proveedor=",//22
            "EXEC sp_EstadoSolicitud {0},'{1}','{2}';",                                    //23
            "SELECT ID_Solicitud,Articulo,Cantidad,Estado  from SolicitudCompra WHERE Estado!='En curso' AND Estado!='Pagada';",//24
            "SELECT ID_Solicitud,Articulo,Cantidad,Estado,precio,Guia,Fecha from SolicitudCompra WHERE Estado='En curso' OR Estado='Pagada'",//25
            "SELECT ID_Solicitud,Articulo,Cantidad,Estado,precio,Fecha  from SolicitudCompra WHERE Estado=",//26
            "EXEC sp_PrecioSolicitud {0},{1},'{2}';",                                                 //27
            "SELECT ID_Solicitud from SolicitudCompra WHERE Estado='Aceptada' AND ID_Proveedor=",     //28
            "SELECT ID_Solicitud from SolicitudCompra WHERE Estado='En curso';",      //29
            "EXEC sp_GuiaSolicitud {0},{1},'{2}';",                                      //30
            "SELECT ID_Solicitud from SolicitudCompra WHERE Estado='Pagada' AND ID_Proveedor=",//31
            "EXEC sp_SolicitudCliente '{0}','{1}','{2}','{3}';",                           //32
            "Select * from solicitud where Estado='Pendiente';",                           //33
            "EXEC sp_EstadoSolicitudCliente {0},'{1}','{2}';",                                //34
            "Select ID_Solicitud from solicitud where Estado='Pendiente';",                   //35
            "Select * from solicitud where ID_cliente=",                                      //36
            "EXEC sp_NuevaDireccion  '{0}',{1},'{2}',{3},'{4}','{5}',{6},'{7}','{8}','{9}','{10}';",//37 que bonito, o que estresante, en serio debían durar 2 semanas las vacaciones?
            "EXEC sp_extraeDireccion '{0}',{1}",                                             //38
            "SELECT DIRECCION_ID FROM DIRECCION WHERE ID_CLIENTE=",                          //39
            "SELECT * FROM PRODUCTO;",                                                       //40
            "SELECT PRODUCTO_ID,Nombre FROM PRODUCTO",                                       //41
            "SELECT Clave FROM Cupones where Nivel<=",                                       //42
            "EXEC sp_extraeProducto {0};",                                                    //43
            "EXEC sp_extraeCuponazo '{0}';",                                                  //44
            "EXEC sp_insertaPedido '{0}',{1},{2},{3},{4},{5},'{6}';",                         //45
            "Select * from pedido where ID_cliente=",                                         //46
            "SELECT Clave,Titulo,Descripción from Cupones where nivel<=",                     //47
            "SELECT * from Formulario",                                                       //48
            "SELECT Usuario,Nombre FROM Usuarios",                                            //49
            "SELECT ID_Pedido from pedido where Estado='Pendiente';",                         //50
            "EXEC sp_insertaRepartidor {0},'{1}','{2}';",                                     //51
            "SELECT ID_Pedido,ID_cliente,Producto,Cantidad,Estado from pedido where Estado='Pendiente';",//52
            "SELECT * from Bitacora;",                                                         //53
            "SELECT ID_Pedido,ID_Cliente,Direccion from pedido where Repartidor=",             //54
            "SELECT ID_Pedido from pedido where Repartidor=",                                  //55
            "EXEC sp_estadoEnvio {0},'{1}','{2}';",                                            //56
            "EXEc sp_AumentaNivel '{0}';",                                                      //57
            "SELECT Usuario, Nombre, Tipo, Estado, IPS, Borrado FROM Usuarios;",                //58
            ""
        };

        private static readonly string[] filtros = new string[50]
        {
            "","","","",
            "IDDepto = {0}",           //4
            "Clave = '{0}'" ,    //5
            "Tipo > 0",                 //6
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "Tipo = 2",
             "",
            "",
            "",
            "",
            "",
             "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
             "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "Tipo = 5"
        };

        public static void AgregaPedido(string usr, string calle, string num, string col, string ciu, string est, string cp)
        {
            string[] param = new string[7] { usr, calle, num, col, ciu, est, cp };
            ejecutaNonQuery(creaQuery(param, 45));
        }

        public static void AumentaNivel(string usr)
        {
            string[] param = new string[1] { usr };
            ejecutaNonQuery(creaQuery(param, 57));
        }

        public static void AgregaDireccion(string usr, string calle, string num, string col, string ciu, string est, string cp, string Ecalle, string Ref, string Indi, string usra)
        {
            string[] param = new string[11] { usr, calle, num, col, ciu, est, cp, Ecalle, Ref, Indi, usra };
            ejecutaNonQuery(creaQuery(param, 37));
        }

        public static void ActualizarUsuario(string usrn, string nom, string clv, string tipo, string usro, string usra)
        {
            string[] param = new string[6] { usrn, nom, clv, tipo, usro, usra };
            ejecutaNonQuery(creaQuery(param, 11));
        }
        public static void solicitudCompra(string usrn, string nom, string clv, string tipo, string usra)
        {
            string[] param = new string[5] { usrn, nom, clv, tipo, usra };
            ejecutaNonQuery(creaQuery(param, 20));
        }

        public static void solicitudCliente(string usrn, string nom, string clv, string tipo)
        {
            string[] param = new string[4] { usrn, nom, clv, tipo };
            ejecutaNonQuery(creaQuery(param, 32));
        }

        public static void SubirForm(string usrn, string nom, string clv, string usra)
        {
            string[] param = new string[4] { usrn, nom, clv, usra };
            ejecutaNonQuery(creaQuery(param, 14));
        }

        public static void AgregaArticulo(string usrn, string nom, string clv, string usra)
        {
            string[] param = new string[4] { usrn, nom, clv, usra };
            ejecutaNonQuery(creaQuery(param, 16));
        }

        public static void modArticulo(string nom, string clv, string usra)
        {
            string[] param = new string[3] { nom, clv, usra };
            ejecutaNonQuery(creaQuery(param, 17));
        }

        public static void insertaRepa(string nom, string clv, string usra)
        {
            string[] param = new string[3] { nom, clv, usra };
            ejecutaNonQuery(creaQuery(param, 51));
        }

        public static void modEstadoEnvio(string nom, string clv, string usra)
        {
            string[] param = new string[3] { nom, clv, usra };
            ejecutaNonQuery(creaQuery(param, 56));
        }

        public static void modEstadoSol(string nom, string clv, string usra)
        {
            string[] param = new string[3] { nom, clv, usra };
            ejecutaNonQuery(creaQuery(param, 23));
        }

        public static void modEstadoSolC(string nom, string clv, string usra)
        {
            string[] param = new string[3] { nom, clv, usra };
            ejecutaNonQuery(creaQuery(param, 34));
        }

        public static void modPrecio(string nom, string clv, string usra)
        {
            string[] param = new string[3] { nom, clv, usra };
            ejecutaNonQuery(creaQuery(param, 27));
        }

        public static void modGuia(string nom, string clv, string usra)
        {
            string[] param = new string[3] { nom, clv, usra };
            ejecutaNonQuery(creaQuery(param, 30));
        }

        public static DireccionModel extraeDirec(string clv, string usra)
        {

            return extraeDirecQ(clv, usra);
        }

        public static UsuariosModel2 extraerUsuario(string usr)
        {
            return extraerUsuarioQ(usr);
        }

        public static ProductoModel extraeProducto(string id)
        {
            return extraeProductoQ(id);
        }

        public static CuponModel extraeCupon(string id)
        {
            return extraeCuponQ(id);
        }

        private static CuponModel extraeCuponQ(string usr)
        {
            CuponModel datos = new CuponModel();
            SqlConnection con = new SqlConnection(sCn);
            SqlCommand command = new SqlCommand(creaQuery(new string[1] { usr }, 44), con);
            con.Open();
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                datos.Clave = r.GetString(0);
                datos.Titulo = r.GetString(1);
                datos.Descripción = r.GetString(2);
                datos.Nivel = r.GetInt32(3);
                datos.Descuento = (float)r.GetDouble(4);

            }
            con.Close();
            return datos;
        }

        private static ProductoModel extraeProductoQ(string usr)
        {
            ProductoModel datos = new ProductoModel();
            SqlConnection con = new SqlConnection(sCn);
            SqlCommand command = new SqlCommand(creaQuery(new string[1] { usr }, 43), con);
            con.Open();
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                datos.PRODUCTO_ID = r.GetInt32(0);
                datos.Nombre = r.GetString(1);
                datos.Volumen = r.GetString(2);
                datos.COSTO = (float)r.GetDouble(3);
                
            }
            con.Close();
            return datos;
        }

        private static DireccionModel extraeDirecQ(string usr, string id)
        {
            DireccionModel datos = new DireccionModel();
            SqlConnection con = new SqlConnection(sCn);
            string[] param = new string[2] { usr, id };
            SqlCommand command = new SqlCommand(creaQuery(param, 38), con);
            con.Open();
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                datos.NUMERO = r.GetInt32(0);
                datos.CALLE = r.GetString(1);
                datos.COLONIA = r.GetString(2);
                datos.CIUDAD = r.GetString(3);
                datos.ESTADO = r.GetString(4);
                datos.CP = r.GetInt32(5);
                datos.ENTRECALLE = r.GetString(6);
                datos.REFERENCIA = r.GetString(7);
                datos.INDICACIONES = r.GetString(8);
            }
            con.Close();
            return datos;
        }

        private static UsuariosModel2 extraerUsuarioQ(string usr)
        {
            UsuariosModel2 datos = new UsuariosModel2();
            SqlConnection con = new SqlConnection(sCn);
            SqlCommand command = new SqlCommand(creaQuery(new string[1] { usr }, 10), con);
            con.Open();
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                datos.Usuario = r.GetString(0);
                datos.Nombre = r.GetString(1);
                datos.Clave = r.GetString(2);
                datos.Tipo = r.GetInt32(3);
                datos.Nivel = r.GetInt32(4);
            }
            con.Close();
            return datos;
        }
        public static void llenarDatagrid(DataGridView panel, int nQ)
        {
            try
            {
                panel.DataSource = bindi;
                GetData(nQ);
                panel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                panel.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void llenarDatagrid(DataGridView panel, int nQ, string estado, string modelito)
        {
            try
            {
                panel.DataSource = bindi;
                GetData(nQ,estado,modelito);
                panel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                panel.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void GetData(int nQ, string estado, string modelito)
        {
            string q="";
            if (nQ != 25)
            {
                q = querys[nQ] + "'" + estado + "' AND ID_Proveedor=" + "'" + modelito + "';";
                if (nQ == 36||nQ==46||nQ==54)
                {
                 
                    q = querys[nQ] + "'" + modelito + "';";
                }
            }
            
            if (nQ == 25)
            {
                q=querys[nQ]+ " AND ID_Proveedor=" + "'" + modelito + "'";
                
            }
            if (nQ == 47)
            {
                q = querys[nQ] + modelito+";";
            }
            dataAdapter = new SqlDataAdapter(q, sCn);
            SqlCommandBuilder command = new SqlCommandBuilder(dataAdapter);
            tablon = new DataTable();
            tablon.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(tablon);
            bindi.DataSource = tablon;
        }




        private static void GetData(int nQ)
        {
            string q = querys[nQ];
            dataAdapter = new SqlDataAdapter(q, sCn);
            SqlCommandBuilder command = new SqlCommandBuilder(dataAdapter);
            tablon = new DataTable();
            tablon.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(tablon);
            bindi.DataSource = tablon;
        }


        private static readonly string noBorrado = "Borrado = 0";

        public static void BorrarUsuario(int nQ, string usr, string usra)
        {
            string[] param = new string[2] { usr, usra };
            ejecutaNonQuery(creaQuery(param, 7));
        }

        public static bool estadoUsuario(string usr)
        {
            return querysEstadoUsuario(usr);
        }

        public static void cambiarEstadoUsuario(bool estado, string usr, string usra)
        {
            string est = "0";
            if (estado)
            {
                est = "1";
            }
            ejecutaNonQuery(creaQuery(new string[3] { est, usr, usra }, 9));
        }

        private static bool querysEstadoUsuario(string usr)
        {
            bool estado = false;
            SqlConnection con = new SqlConnection(sCn);
            SqlCommand command = new SqlCommand(creaQuery(new string[1] { usr }, 8), con);
            con.Open();
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                estado = r.GetBoolean(0);
            }
            con.Close();
            return estado;
        }

        public static void llenarCombo(ComboBox cmb, Button btn, int nQ, ArrayList param)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            LimpiarKlombo(cmb, btn);
            datos = leerRegistros(nQ, param);
            cmb.DataSource = new BindingSource(datos, null);
            cmb.DisplayMember = "Value";
            cmb.ValueMember = "Key";
            cmb.SelectedIndex = 0;
            if (cmb.SelectedValue.ToString() == "-1")
            {
                EstadoCombo(cmb, btn, false);
            }
            else
            {
                EstadoCombo(cmb, btn, true);
            }

        }

        public static void llenarComboUr(ComboBox cmb, Button btn, int nQ, ArrayList param,string modelito)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            LimpiarKlombo(cmb, btn);
            datos = leerRegistrosUr(nQ, param,modelito);
            cmb.DataSource = new BindingSource(datos, null);
            cmb.DisplayMember = "Value";
            cmb.ValueMember = "Key";
            cmb.SelectedIndex = 0;
            if (cmb.SelectedValue.ToString() == "-1")
            {
                EstadoCombo(cmb, btn, false);
            }
            else
            {
                EstadoCombo(cmb, btn, true);
            }
        }
            public static void llenarCombo(ComboBox cmb, Button btn, int nQ, ArrayList param, bool incluirBorrados)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();

            LimpiarKlombo(cmb, btn);
            datos = leerRegistros(nQ, param, incluirBorrados);
            cmb.DataSource = new BindingSource(datos, null);
            cmb.DisplayMember = "Value";
            cmb.ValueMember = "Key";
            cmb.SelectedIndex = 0;
            if (cmb.SelectedValue.ToString() == "-1")
            {
                EstadoCombo(cmb, btn, false);
            }
            else
            {
                EstadoCombo(cmb, btn, true);
            }

        }

        private static Dictionary<string, string> leerRegistros(int nQ, ArrayList param, bool incluirBorrados)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            string q = querys[nQ] + " WHERE ";
            if (nQ == 6)
                q = q + filtros[nQ] + " AND ";
            if (!incluirBorrados)
                q = q + noBorrado;
            if (param.Count > 0)
            {//Tengo parametros
                q = q + "WHERE ";
                for (int x = 0; x < param.Count; x++)
                {
                    q = q + filtros[nQ] + " ";
                    #pragma warning disable CS8602   // Desreferencia de una referencia posiblemente NULL
                    q = q.Replace("{0}", param[x].ToString());
                    #pragma warning restore CS8602    // Desreferencia de una referencia posiblemente NULL
                    if (x < param.Count - 1)
                    {
                        q = q + "OR ";
                    }
                }
            }
            SqlConnection con = new SqlConnection(sCn);
            SqlCommand cm = new SqlCommand(q, con);
            con.Open();
            SqlDataReader r = cm.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    if (r[0].GetType().ToString() == "System.Int32")
                    {
                        datos.Add(r.GetInt32(0).ToString(), r.GetString(1));
                    }
                    else
                    {
                        datos.Add(r.GetString(0), r.GetString(1));
                    }
                }
            }
            else
            {
                datos.Add("-1", "No hay datos");
            }
            con.Close();
            return datos;
        }

        private static Dictionary<string, string> leerRegistros(int nQ, ArrayList param)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            string q = querys[nQ] + " ";
            if (nQ == 19||nQ==49)
            {
                q = q + "WHERE " + filtros[nQ] + " ";
            }
            if (param.Count > 0)
            {//Tengo parametros
                q = q + "WHERE ";
                for (int x = 0; x < param.Count; x++)
                {
                    q = q + filtros[nQ] + " ";
                    #pragma warning disable CS8602   // Desreferencia de una referencia posiblemente NULL
                    q = q.Replace("{0}", param[x].ToString());
                    #pragma warning restore CS8602    // Desreferencia de una referencia posiblemente NULL
                    if (x < param.Count - 1)
                    {
                        q = q + "OR ";
                    }
                }
            }

            SqlConnection con = new SqlConnection(sCn);
            SqlCommand cm = new SqlCommand(q, con);
            con.Open();
            SqlDataReader r = cm.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    if (r[0].GetType().ToString() == "System.Int32")
                    {
                        datos.Add(r.GetInt32(0).ToString(), r.GetString(1));
                    }
                    else
                    {
                        datos.Add(r.GetString(0), r.GetString(1));
                    }
                }
            }
            else
            {
                datos.Add("-1", "No hay datos");
            }
            con.Close();
            return datos;
        }

        private static Dictionary<string, string> leerRegistrosUr(int nQ, ArrayList param, string modelito)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            string q = querys[nQ] + ""+modelito+";";
            if (nQ == 41)
            {
                q = "";
                q = querys[nQ];
            }
            SqlConnection con = new SqlConnection(sCn);
            SqlCommand cm = new SqlCommand(q, con);
            con.Open();
            SqlDataReader r = cm.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    if (r[0].GetType().ToString() == "System.Int32")
                    {
                        datos.Add(r.GetInt32(0).ToString(), r.GetString(1));
                    }
                    else
                    {
                        datos.Add(r.GetString(0), r.GetString(1));
                    }
                }
            }
            else
            {
                datos.Add("-1", "No hay datos");
            }
            con.Close();
            return datos;
        }

        public static void llenarComboFiltros(ComboBox combo, int nQ, string modelito)
        {
            combo.DataSource = null;
            combo.Items.Clear();
            using (SqlConnection cn = new SqlConnection(sCn))
            {
                string sqlConsulta = querys[nQ]+"'"+modelito+"';";
                if (nQ == 29||nQ==35||nQ==41)
                {
                    sqlConsulta = querys[nQ];
                    //MessageBox.Show(sqlConsulta);
                }
                if (nQ == 42)
                {
                    sqlConsulta = querys[nQ] + modelito;
                    //MessageBox.Show(sqlConsulta);
                }
                if (nQ == 50)
                {
                    sqlConsulta = querys[nQ];
                }

                using (SqlCommand cmd = new SqlCommand(sqlConsulta, cn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    combo.ValueMember = "ID_Solicitud";
                    combo.DisplayMember = "ID_Solicitud";
                    if (nQ == 39)
                    {
                        combo.ValueMember = "DIRECCION_ID";
                        combo.DisplayMember = "DIRECCION_ID";
                    }
                    if (nQ == 41)
                    {
                        combo.ValueMember = "PRODUCTO_ID";
                        combo.DisplayMember = "Nombre";
                    }
                    if (nQ == 42)
                    {
                        combo.ValueMember = "Clave";
                        combo.DisplayMember = "Clave";
                    }
                    if (nQ == 50||nQ==55)
                    {
                        combo.ValueMember = "ID_Pedido";
                        combo.DisplayMember = "ID_Pedido";
                    }
                    combo.DataSource = dt;
                }
            }
        }

        public static void LimpiarListBox(ListBox lst,Button btn)
        {
            lst.DataSource = null;
            lst.Items.Clear();
            EstadoList(lst, btn, false);
        }

        public static void EstadoList(ListBox lst, Button btn, bool estado)
        {
            lst.Enabled = estado;
            btn.Enabled = estado;
        }

        public static void LimpiarKlombo(ComboBox cmb, Button btn)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
            EstadoCombo(cmb, btn, false);
        }

        public static void EstadoCombo(ComboBox cmb, Button btn, bool estado)
        {
            cmb.Enabled = estado;
            btn.Enabled = estado;
        }
           
        public static void LlenarLstBox(ListBox lst, Button btn, int nQ, ArrayList param)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            LimpiarListBox(lst, btn);
            datos = leerRegistros(nQ, param);
            lst.DataSource = new BindingSource(datos, null);
            lst.DisplayMember = "Value";
            lst.ValueMember = "Key";
            lst.SelectedIndex = 0;
            if (((KeyValuePair < string, string>)lst.Items[0]).Value.ToString() == "-1"){
                EstadoList(lst, btn, false);
            }
            else
            {
                EstadoList(lst, btn, true);
            }
        }


        public static UsuariosModel buscarUsuarios(string usuario, string clave)
        {
            UsuariosModel aux = null;
            string[] param = { usuario, clave };
            SqlConnection con = new SqlConnection(sCn);
            SqlCommand command = new SqlCommand(creaQuery(param,0), con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                aux = new UsuariosModel(reader.GetString(1), reader.GetString(0), reader.GetInt32(2));
            }
            con.Close();
            return aux;
        }

        public static void cerrarApp(string usuario)
        {
            string[] param = { usuario };
            ejecutaNonQuery(creaQuery(param, 1));
            System.Windows.Forms.Application.Exit();
        }

        
        public static bool tienePermiso(int Tipo, int Formulario)
        {
            bool tiene = false;
            for (int x=0; x < 5; x++)
            {
                if (permisos[x, 0] == Tipo)
                {
                    if (permisos[x, Formulario] == 1)
                    {
                        tiene = true;
                    }
                }
                    
            }
            return tiene;
        }

        /*EXEC sp_InsertarUsuario 'admingen','Administrador general','admingen',-1,'system';*/
        public static void agregarUsuario(string usuario, string nombre, string clv, string tipo, string usra)
        {
            string[] param = { usuario, nombre, clv, tipo, usra };
            ejecutaNonQuery(creaQuery(param, 2));
            
        }

        public static void agregarCupon(string clave, string titulo, string descripcion, string nivel,string des, string usra)
        {
            string[] param = { clave, titulo, descripcion, nivel, des, usra };
            ejecutaNonQuery(creaQuery(param, 13));

        }

        public static void agregarProveedor(string id, string nombre, string paterno, string materno, string tel, string usra)
        {
            string[] param = { id, nombre, paterno, materno, tel, usra };
            ejecutaNonQuery(creaQuery(param, 12));

        }

        private static string creaQuery(string[] parametros, int numero)
        {
            string q = querys[numero];
            for(int i = 0; i < parametros.Length; i++)
            {
                q=q.Replace("{" + i + "}", parametros[i]);
            }
            return q;
        }

        private static void ejecutaNonQuery(string q)
        {
            SqlConnection con = new SqlConnection(sCn);
            SqlCommand command = new SqlCommand(q, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        public static void llenarDesc(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
            Dictionary<string, string> niveles = new Dictionary<string, string>()
            {
                {"0.98","2%" },{"0.95","5%"},{"0.9","10%"},{"0.85","15%"},
                {"0.80","20%"}, {"0.75", "25%" },{"0.70","30%" } };
            cmb.DataSource = new BindingSource(niveles, null);
            cmb.DisplayMember = "Value";
            cmb.ValueMember = "key";
            cmb.SelectedIndex = 0;
        }

        public static void llenarNivel(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
            Dictionary<string, string> niveles = new Dictionary<string, string>()
            {
                {"0","Nivel 0" },{"1","Nivel 1"},{"2","Nivel 2"},{"3","Nivel 3"},
                {"4","Nivel 4"}, {"5", "Nivel 5" },{"6","Nivel 6" } };
            cmb.DataSource = new BindingSource(niveles, null);
            cmb.DisplayMember = "Value";
            cmb.ValueMember = "key";
            cmb.SelectedIndex = 0;
        }

        public static void llenarSolicitud(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
            Dictionary<string, string> solicitudes = new Dictionary<string, string>()
            {
             {"Desactivar cuenta","Desactivar cuenta" },{"Borrar cuenta","Borrar cuenta"},{"Modificar cuenta","Modificar cuenta"} };
            cmb.DataSource = new BindingSource(solicitudes, null);
            cmb.DisplayMember = "Value";
            cmb.ValueMember = "key";
            cmb.SelectedIndex = 0;
        }



        public static void llenarTipo(ComboBox cmb)
        {
            cmb.DataSource = null;
            cmb.Items.Clear();
            /*EXEC sp_InsertarUsuario 'logistica','Gerente de Logistica','logistica',4,'system';
              EXEC sp_InsertarUsuario 'repartidor','Repartidor tito','repartidor',5,'system';
              EXEC sp_InsertarUsuario 'marketing','Te tengo que pagar por esto?','marketing',6,'system';*/
            Dictionary<string, string> tipos = new Dictionary<string, string>()
            {
                {"0","Administrador" },{"1","Administrador de BD"},{"2","Proveedor"},{"3","Cliente"},
                {"4","Analista"}, {"5", "Repartidor" },{"6","Marketing" } };
            
            cmb.DataSource = new BindingSource(tipos, null);
            cmb.DisplayMember = "Value";
            cmb.ValueMember = "key";
            cmb.SelectedIndex = 0;
        }
        
    }
}
