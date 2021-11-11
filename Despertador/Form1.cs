
using System.Media;

namespace Despertador
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer Timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            textoStatus.Text = "Alarma puesta";
            Timer.Start();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            textoStatus.Text = "Alarma detenida";
            Timer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer = new System.Timers.Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime horaAlarma = selectorHora.Value;
            DateTime horaActual = DateTime.Now;
            if(horaAlarma.Hour == horaActual.Hour && horaAlarma.Minute == horaActual.Minute && horaAlarma.Second == horaActual.Second)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"C:\Windows\Media\Alarm05.wav";
                player.PlayLooping();
                DialogResult resultado = MessageBox.Show("Despierta!!!", "Selecciona una opción", MessageBoxButtons.OKCancel);
                if(resultado == DialogResult.OK)
                {
                    Timer.Stop();
                    player.Stop();
                    Bienvenida bienvenida = new Bienvenida();
                    bienvenida.Show();
                    //this.Hide();
                }
                /*else if(resultado == DialogResult.Cancel)
                {
                    updateHour(DateTime.Now);
                    player.Stop();
                }*/
            }
        }

        private void updateHour(DateTime hora)
        {
            selectorHora.Value = hora.AddMinutes(1);
        }
    }
}