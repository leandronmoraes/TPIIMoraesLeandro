using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class configuracionesAdmin : Form
    {
        SqlConnection connectionString = new SqlConnection("Server=.;Database=ProyectoTPII_MoraesLeandro;Integrated Security=True;");
        public configuracionesAdmin()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string database = "ProyectoTPII_MoraesLeandro";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de respaldo de SQL Server (.bak)|.bak";
            saveFileDialog.Title = "Guardar Respaldo de la Base de Datos";
            saveFileDialog.FileName = database + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".bak";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + saveFileDialog.FileName + "'";

                connectionString.Open();
                SqlCommand command = new SqlCommand(cmd, connectionString);
                command.ExecuteNonQuery();
                MessageBox.Show("Base de datos respaldada con éxito", "Respaldo completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connectionString.Close();
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            bool restore = false;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Archivos de respaldo de SQL Server (.bak)|.bak";
            dlg.Title = "Restauración de base de datos";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtSubir.Text = dlg.FileName;
                restore = true;

            }
            else
            {
                restore = false;
            }

            if(restore)
            {
                string database = "ProyectoTPII_MoraesLeandro";
                connectionString.Open();
                try
                {
                    string str2 = "ALTER DATABASE [ProyectoTPII_MoraesLeandro] SET OFFLINE WITH ROLLBACK IMMEDIATE;RESTORE DATABASE [" + database + "] FROM DISK = '" + txtSubir.Text + "' WITH REPLACE; ALTER DATABASE[ProyectoTPII_MoraesLeandro] SET ONLINE";
                    SqlCommand cmd2 = new SqlCommand(str2, connectionString);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Base de datos restaurada con éxito", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la restauración de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connectionString.Close();
                }
            }
            
        }

        private void btnSubirBackup_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Archivos de respaldo de SQL Server (.bak)|.bak";
            dlg.Title = "Restauración de base de datos";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtSubir.Text = dlg.FileName;
                
            }
        }
    }
}

    

