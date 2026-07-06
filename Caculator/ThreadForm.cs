using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class ThreadForm : Form
    {
        private int _countThread = 0;
        private bool _onThread = false;

        private int _countAW = 0;
        private bool _onAW = false;

        private int _countTask = 0;
        private bool _onTask = false;
        public ThreadForm()
        {

            InitializeComponent();

        }

        private void StartThread()
        {

            while (_onThread)
            {
                if (prThread.IsDisposed || prThread.Disposing)
                {
                    break;
                }
                prThread.Invoke(new Action(() =>
                    {
                        prThread.Value = _countThread;
                    }));
                _countThread += 10;

                if (_countThread > 100)
                {
                    _countThread = 0;
                }
                Thread.Sleep(1000);

            }


        }


        private void StartTask()
        {
            while (_onTask)
            {
                if (prTask.IsDisposed || prTask.Disposing)
                {
                    break;
                }
                prTask.Invoke(new Action(() =>
                {
                    prTask.Value = _countTask;
                }));
                _countTask += 10;

                if (_countTask > 100)
                {
                    _countTask = 0;
                }
                Thread.Sleep(1000);

            }

        }

        private async Task StartAW()
        {

            while (_onAW)
            {
                if (prAW.IsDisposed || prAW.Disposing)
                {
                    break;
                }
                prAW.Invoke(new Action(() =>
                {
                    prAW.Value = _countAW;
                }));
                _countAW += 10;

                if (_countAW > 100)
                {
                    _countAW = 0;
                }
                await Task.Delay(1000);

            }

        }
        //=================================================== Event click =====================

        private void StartThread_Click(object sender, EventArgs e)
        {
            _onThread = true;
            Thread start = new Thread(StartThread);
            start.Start();
        }

        private void StopThread_Click(object sender, EventArgs e)
        {
            _onThread = false;
        }
        private async void StartAW_Click(object sender, EventArgs e)
        {
            _onAW = true;
            await StartAW();
        }
        private void StopAW_Click(object sender, EventArgs e)
        {
            _onAW = false;
        }
        private void StartTask_Click(object sender, EventArgs e)
        {
            _onTask = true;
            Task.Run(() => StartTask());
        }
        private void StopTask_Click(object sender, EventArgs e)
        {
            _onTask = false;
        }

    }
}
