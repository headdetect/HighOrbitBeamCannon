using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighOrbitBeamCannon
{
    public partial class MainForm : Form
    {
        private bool _running;
        public bool Running
        {
            get { return _running; }
            set
            {
                _running = value;
                RunOnUi(() =>
                {
                    btnFire.Text = value ? "Stop" : "Fire!";
                    foreach (Control child in Controls)
                        child.Enabled = !Running || child == btnFire;
                });
            }
        }

        public Thread[] Threads { get; set; }
        public Socket[] Sockets { get; set; }

        public Queue<Action> UiTasks { get; } = new Queue<Action>();

        public IPEndPoint EndPoint { get; set; }
        
        public decimal ShotsFired { get; set; }
        public decimal SwingAndAMiss { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private static readonly object FormLock = new object();

        public void RunOnUi(Action e)
        {
            if (InvokeRequired) Invoke(e);
            else lock (FormLock) { e(); }
        }

        public void QueueUiWork(Action e)
        {
            if (InvokeRequired) Invoke(e);
            else lock (FormLock) { e(); }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            Running = !Running;
            
            if (Running || EndPoint == null)
                ChargeZeCannon();

            if (Running)
                timerUiWork.Start();
            else timerUiWork.Stop();
        }

        private void ChargeZeCannon()
        {
            ShotsFired = 0;
            SwingAndAMiss = 0;

            try
            {
                // Allocate thread resources //
                Threads = new Thread[(int) numThreads.Value];
                Sockets = new Socket[(int) numThreads.Value];

                for (var i = 0; i < (int) numThreads.Value; i++)
                {
                    var socket = Sockets[i] = radUdp.Checked
                        ? new UdpClient(txtAddress.Text, (int) numPort.Value).Client
                        : new TcpClient(txtAddress.Text, (int) numPort.Value).Client;

                    var starter = new ThreadStart(() => FireZeCannon(socket));
                    Threads[i] = new Thread(starter);
                    Threads[i].Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error allocating resources. Did you type in the address correctly?\n{e.Message}");
                Running = false;
            }
        }

        private static readonly object CannonLock = new object();
        public void FireZeCannon(Socket socket)
        {
            var buffer = GetMessageBytes();
            while (_running)
            {
                try
                {
                    int result = socket.Send(buffer);

                    if (result != -1)
                        lock(CannonLock) ShotsFired++;
                    else lock (CannonLock) SwingAndAMiss++;
                }
                catch
                {
                    // Ignore //
                }

                Thread.Sleep(1);
            }
            
        }

        private byte[] GetMessageBytes()
        {
            return Encoding.UTF8.GetBytes(txtMessage.Text);
        }

        private void timerUiWork_Tick(object sender, EventArgs e)
        {
            var busy = Threads.Sum(t => (t.IsAlive ? 1 : 0));
            lblBusy.Text = busy.ToString();
            lblWaiting.Text = (Threads.Length - busy).ToString();
            lblRequests.Text = ShotsFired.ToString(CultureInfo.CurrentCulture);

            RunOnUi(() =>
            {
                while (UiTasks.Count > 0)
                    UiTasks.Dequeue()();
            });
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Running = false;
        }
    }

}
