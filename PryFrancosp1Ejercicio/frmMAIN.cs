using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFrancosp1Ejercicio
{
    public partial class frmMAIN : Form
    {
        public frmMAIN()
        {
            InitializeComponent();
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstModulo.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        int intentos = 2;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
           

            //1
            if (txtUser.Text == "Adm" && txtContra.Text == "@1a")
            {
                if(lstModulo.Text == "ADM" || lstModulo.Text == "COM" || lstModulo.Text == "VTA")
                {
                    MessageBox.Show("Bienvenido");

                }
                              
                //Nuevo formulario
                if (lstModulo.Text == "ADM")
                {
                    var myfrmADM = new frmADM();
                    myfrmADM.Show();
                    this.Hide();

                }
                if (lstModulo.Text == "COM")
                {
                    var myfrmCOM = new frmCOM();
                    myfrmCOM.Show();
                    this.Hide();

                }
                if (lstModulo.Text == "VTA")
                {
                    var myfrmVTA = new frmVTA();
                    myfrmVTA.Show();
                    this.Hide();

                }
                
            }
            else
            {   //2
                if (txtUser.Text == "John" && txtContra.Text == "*2b")
                {
                    if (lstModulo.Text == "SIST")
                    {
                        MessageBox.Show("Bienvenido");
                    }
                    //Nuevo formulario
                    if (lstModulo.Text == "SIST")
                    {
                        var myfrmSIST = new frmSIST();
                        myfrmSIST.Show();
                        this.Hide();
                    }

                }
                else
                {   //3
                    if (txtUser.Text == "Ceci" && txtContra.Text == "*@3c")
                    {
                        if (lstModulo.Text == "ADM" || lstModulo.Text == "VTA")
                        {
                            MessageBox.Show("Bienvenido");

                        }
                        //Nuevo formulario
                        if (lstModulo.Text == "ADM")
                        {
                            var myfrmADM = new frmADM();
                            myfrmADM.Show();
                            this.Hide();

                        }
                        if (lstModulo.Text == "VTA")
                        {
                            var myfrmVTA = new frmVTA();
                            myfrmVTA.Show();
                            this.Hide();

                        }

                    }
                    else
                    {   //4
                        if (txtUser.Text == "God" && txtContra.Text == "*@#4d")
                        {
                            if (lstModulo.Text == "ADM" || lstModulo.Text == "COM" || lstModulo.Text == "VTA" || lstModulo.Text == "SIST")
                            {
                                MessageBox.Show("Bienvenido");

                            }

                            //Nuevo formulario
                            if (lstModulo.Text == "ADM")
                            {
                                var myfrmADM = new frmADM();
                                myfrmADM.Show();
                                this.Hide();

                            }
                            if (lstModulo.Text == "COM")
                            {
                                var myfrmCOM = new frmCOM();
                                myfrmCOM.Show();
                                this.Hide();

                            }
                            if (lstModulo.Text == "VTA")
                            {
                                var myfrmVTA = new frmVTA();
                                myfrmVTA.Show();
                                this.Hide();

                            }
                            if (lstModulo.Text == "SIST")
                            {
                                var myfrmSIST = new frmSIST();
                                myfrmSIST.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            intentos = intentos - 1;
                            MessageBox.Show("Usuario y/o contraseña incorrecta" + " " + "\n\ncantidad de intentos" + " " + intentos);
                            if (intentos == 0)
                            {
                                this.Close();
                            }

                        }
                        
                    }
                }
            }
            
           
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtContra.Text != "")
            {
                lstModulo.Enabled = true;
            }
            else
            {
                lstModulo.Enabled = false;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
