using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Arbol
{
    public partial class FrmRenombrar : Form
    {
        string rutaBase;
        string rutaOrigen;
        string rutaDestino;
        string archivoOriginal;
        string rutaAux;
        string subRutaDestino;
        string carpeta;

        public FrmRenombrar()
        {
            InitializeComponent();
        }
        private TreeNode CrearArbol(DirectoryInfo directoryInfo)
        {
            TreeNode TreeNode = new TreeNode(directoryInfo.Name);
            foreach (var item in directoryInfo.GetDirectories())
            {
                TreeNode.Nodes.Add(CrearArbol(item));
            }
            foreach (var item in directoryInfo.GetFiles())
            {
                TreeNode.Nodes.Add(new TreeNode(item.Name));
            }
            return TreeNode;
        }

        private void btnInterfases_Click(object sender, EventArgs e)
        {
            carpeta = "INTERFASES";
            tvFile.Nodes.Clear();
            rutaBase = @"C:\C123\000\DISTRIB\INTERFASES";
            tvFile.Nodes.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(rutaBase);
            tvFile.Nodes.Add(CrearArbol(directoryInfo));
        }

        private void btnMod_130_Click(object sender, EventArgs e)
        {
            carpeta = "RECEPCION";
            tvFile.Nodes.Clear();
            rutaBase = @"C:\C123\000\DISTRIB\RECEPCION\MOD_130";
            tvFile.Nodes.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(rutaBase);
            tvFile.Nodes.Add(CrearArbol(directoryInfo));
        }

        private void btnMod_Acci_Click(object sender, EventArgs e)
        {
            carpeta = "RECEPCION";
            tvFile.Nodes.Clear();
            rutaBase = @"C:\C123\000\DISTRIB\RECEPCION\MOD_ACCI";
            tvFile.Nodes.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(rutaBase);
            tvFile.Nodes.Add(CrearArbol(directoryInfo));
        }

        private void btn_mod_blackrock_Click(object sender, EventArgs e)
        {
            carpeta = "RECEPCION";
            tvFile.Nodes.Clear();
            rutaBase = @"C:\C123\000\DISTRIB\RECEPCION\MOD_BLACKROCK";
            tvFile.Nodes.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(rutaBase);
            tvFile.Nodes.Add(CrearArbol(directoryInfo));
        }

        private void btnMod_citidirect_Click(object sender, EventArgs e)
        {
            carpeta = "RECEPCION";
            tvFile.Nodes.Clear();
            rutaBase = @"C:\C123\000\DISTRIB\RECEPCION\MOD_CITIDIRECT";
            tvFile.Nodes.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(rutaBase);
            tvFile.Nodes.Add(CrearArbol(directoryInfo));
        }

        private void tvFile_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //********
                rutaAux = string.Empty;
                string[] fullPath = tvFile.SelectedNode.FullPath.Split('\\');
                for (int p = 0; p < fullPath.Length - 1; p++)
                {

                    rutaAux += fullPath[p] + @"\";

                }
                txtExtencion.Clear();

                subRutaDestino = string.Empty;
                archivoOriginal = tvFile.SelectedNode.Text;
                string[] arreglo = archivoOriginal.Split('.');

                if (arreglo.Length == 1)
                {
                    txtCambio.Text = archivoOriginal;
                }
                else
                {
                    txtExtencion.Text = tvFile.SelectedNode.Text.Split('.').Last();
                }

                for (int i = 0; i < arreglo.Length - 1; i++)
                {
                    subRutaDestino += arreglo[i];
                    for (int j = i; j == i && j < arreglo.Length - 2; j++)
                    {
                        subRutaDestino += ".";
                    }
                    txtCambio.Text = subRutaDestino;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnRenombrar_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(rutaBase);
            try
            {
                switch (MessageBox.Show("¿Seguro que desea renombrar este archivo?", "", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        if (carpeta.Equals("INTERFASES"))
                        {
                            //rutaOrigen = @"C:\C123\" + tvFile.SelectedNode.FullPath;
                            rutaOrigen = @"C:\C123\000\DISTRIB\" + tvFile.SelectedNode.FullPath;
                            //rutaDestino = @"C:\C123\" + rutaAux + txtCambio.Text + "." + txtExtencion.Text;
                            rutaDestino = @"C:\C123\000\DISTRIB\" + rutaAux + txtCambio.Text + "." + txtExtencion.Text;
                        }
                        else
                        {
                            //rutaOrigen = @"C:\C123\" + tvFile.SelectedNode.FullPath;
                            rutaOrigen = @"C:\C123\000\DISTRIB\RECEPCION\" + tvFile.SelectedNode.FullPath;
                            //rutaDestino = @"C:\C123\" + rutaAux + txtCambio.Text + "." + txtExtencion.Text;
                            rutaDestino = @"C:\C123\000\DISTRIB\RECEPCION\" + rutaAux + txtCambio.Text + "." + txtExtencion.Text;
                        }
                        File.Move(rutaOrigen, rutaDestino);
                        MessageBox.Show("Se ha renombrado el archivo");
                        LimpiarControles();

                        tvFile.Nodes.Add(CrearArbol(directoryInfo));
                        break;

                    case DialogResult.No:
                        // "No" processing
                        MessageBox.Show("Operacion Cancelada");
                        LimpiarControles();

                        tvFile.Nodes.Add(CrearArbol(directoryInfo));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede hacer la renombracion del archivo. " + "(" + ex.Message + ")");
                LimpiarControles();
            }
            //}
        }
        public void LimpiarControles()
        {
            tvFile.Nodes.Clear();
            txtCambio.Clear();
            txtExtencion.Clear();

        }

        private void FrmRenombrar_Load(object sender, EventArgs e)
        {
            txtCambio.Enabled = false;
        }

        private void Cootrasalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtExtencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int) Keys.Enter) 
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(rutaBase);
                try
                {
                    switch (MessageBox.Show("¿Seguro que desea renombrar este archivo?", "", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.Yes:
                            if (carpeta.Equals("INTERFASES"))
                            {
                                //rutaOrigen = @"C:\C123\" + tvFile.SelectedNode.FullPath;
                                rutaOrigen = @"C:\C123\000\DISTRIB\" + tvFile.SelectedNode.FullPath;
                                //rutaDestino = @"C:\C123\" + rutaAux + txtCambio.Text + "." + txtExtencion.Text;
                                rutaDestino = @"C:\C123\000\DISTRIB\" + rutaAux + txtCambio.Text + "." + txtExtencion.Text;
                            }
                            else
                            {
                                //rutaOrigen = @"C:\C123\" + tvFile.SelectedNode.FullPath;
                                rutaOrigen = @"C:\C123\000\DISTRIB\RECEPCION\" + tvFile.SelectedNode.FullPath;
                                //rutaDestino = @"C:\C123\" + rutaAux + txtCambio.Text + "." + txtExtencion.Text;
                                rutaDestino = @"C:\C123\000\DISTRIB\RECEPCION\" + rutaAux + txtCambio.Text + "." + txtExtencion.Text;
                            }
                            File.Move(rutaOrigen, rutaDestino);
                            MessageBox.Show("Se ha renombrado el archivo");
                            LimpiarControles();

                            tvFile.Nodes.Add(CrearArbol(directoryInfo));
                            break;

                        case DialogResult.No:
                            // "No" processing
                            MessageBox.Show("Operacion Cancelada");
                            LimpiarControles();

                            tvFile.Nodes.Add(CrearArbol(directoryInfo));
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede hacer la renombracion del archivo. " + "(" + ex.Message + ")");
                    LimpiarControles();
                }
            }
        }
    }
}