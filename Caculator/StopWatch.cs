using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Caculator
{
    public partial class StopWatch : Form
    {
        private bool _onStopWatch;
        private int _hour = 0;
        private int _minute = 0;
        private int _second = 0;
        private int _centisecond = 0;
        private TimeSpan _elapsed = TimeSpan.Zero;
        private DateTime _startTime;
        private List<SaveTime> _listSaveTime;
        public StopWatch()
        {
            _onStopWatch = false;
            _listSaveTime = new List<SaveTime>();
            InitializeComponent();
            btnSave.Enabled = false;
            btnReset.Enabled = false;
            
            timer.Interval = 10;
            timer.Tick += timer_Tick;

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (_onStopWatch)
            {
                _elapsed = DateTime.Now - _startTime;

                txtTime.Text =
                    $"{_elapsed.Hours:D2}:" +
                    $"{_elapsed.Minutes:D2}:" +
                    $"{_elapsed.Seconds:D2}." +
                    $"{_elapsed.Milliseconds / 10:D2}";
            }
            //_centisecond++;
            //if (_centisecond == 100)
            //{
            //    _centisecond = 0;
            //    _second++;
            //}
            //if (_second == 60)
            //{
            //    _second = 0; 
            //    _minute++;
            //}
            //if(_minute == 60) 
            //{
            //    _minute = 0;
            //    _hour++;
            //}

            //txtTime.Text = $"{_hour:D2}:{_minute:D2}:{_second:D2}.{_centisecond:D2}";
            //if( txtTime.Text == "00:00:00:00")
            //{
            //    btnSave.Enabled = false;
            //    btnReset.Enabled = false;
            //}
        }
        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            //if(!_onStopWatch)
            //{
            //   _onStopWatch=true;
            //    btnOnOff.Text = "ON";
            //    btnOnOff.BackColor = Color.Green;
            //    btnSave.Enabled = true;
            //    btnReset.Enabled = true;
            //    timer.Start();
            //}  
            //else
            //{
            //    _onStopWatch = false;
            //    btnOnOff.Text = "OFF";
            //    btnOnOff.BackColor = Color.Red;
            //    if(txtTime.Text != "00:00:00.00")
            //    {
            //        btnReset.Enabled = true;
            //    } 
            //    else 
            //    { 
            //        btnReset.Enabled = false; 
            //    }
            //    btnSave.Enabled = false;
            //    timer.Stop();
            //}
            if (!_onStopWatch)
            {
                _startTime = DateTime.Now - _elapsed;

                _onStopWatch = true;
                btnOnOff.Text = "ON";
                btnOnOff.BackColor = Color.Green;
                btnSave.Enabled = true;
                btnReset.Enabled = true;
                timer.Start();
                timer.Start();
            }
            else 
            {
                _elapsed = DateTime.Now - _startTime;

                _onStopWatch = false;
            }

        }
        private TimeSpan ToTime(string time)
        {
            return TimeSpan.ParseExact(time,@"hh\:mm\:ss\.ff",null);
        }
        private void buttonSaveTime_Click(object sender, EventArgs e)
        {
            SaveTime Time = new SaveTime();
            Time.Lap = _listSaveTime.Count + 1;
            Time.Total = txtTime.Text;
           
            if(_listSaveTime.Count == 0)
            {
                Time.Time = txtTime.Text;
            }
            else
            {
                TimeSpan timeCurrent = ToTime(txtTime.Text);
                TimeSpan timePrevious = ToTime(_listSaveTime.Last().Total);
                Time.Time = (timeCurrent - timePrevious).ToString(@"hh\:mm\:ss\.ff");
            }
            _listSaveTime.Add(Time);
            dataTime.DataSource = null;
            dataTime.DataSource = _listSaveTime;
            //listHistory.DataSource = null;
            //listHistory.DataSource = _listTime;
           
        } 
        private void buttonReset_Click(object sender,EventArgs e)
        {
            timer.Stop();
            _onStopWatch = false;
            btnOnOff.Text = "OFF";
            btnOnOff.BackColor = Color.Red;
            btnSave.Enabled = false;
            btnReset.Enabled = false;
            _elapsed = TimeSpan.Zero;
            txtTime.Text = "00:00:00:00";
            _listSaveTime.Clear();
            _listSaveTime = new List<SaveTime>();
            dataTime.DataSource = null;
        }  
    }
}
