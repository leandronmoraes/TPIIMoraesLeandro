using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class TemporizadorHoraFecha
{
    private Timer horaFechaTimer;
    private Label lblHora;
    private Label lblFecha;

    public TemporizadorHoraFecha(Label horaLabel, Label fechaLabel)
    {
        lblHora = horaLabel;
        lblFecha = fechaLabel;

        horaFechaTimer = new Timer();
        horaFechaTimer.Interval = 1000; // Intervalo en milisegundos (1 segundo)
        horaFechaTimer.Tick += new EventHandler(horaFecha_Tick);
        horaFechaTimer.Start();
    }

    private void horaFecha_Tick(object sender, EventArgs e)
    {
        lblHora.Text = DateTime.Now.ToLongTimeString();
        lblFecha.Text = DateTime.Now.ToLongDateString();
    }
}
