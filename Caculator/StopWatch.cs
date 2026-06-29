using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private int _millisecond = 0;

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
            _millisecond++;
            if (_millisecond == 100)
            {
                _millisecond = 0;
                _second++;
            }
            if (_second == 60)
            {
                _second = 0;
                _minute++;
            }
            if(_minute == 60)
            {
                _minute = 0;
                _hour++;
            }
          
            txtTime.Text = $"{_hour:D2}:{_minute:D2}:{_second:D2}.{_millisecond:D2}";
            if( txtTime.Text == "00:00:00:00")
            {
                btnSave.Enabled = false;
                btnReset.Enabled = false;
            }
        }
        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            if(!_onStopWatch)
            {
               _onStopWatch=true;
                btnOnOff.Text = "ON";
                btnOnOff.BackColor = Color.Green;
                btnSave.Enabled = true;
                btnReset.Enabled = true;
                timer.Start();
            }  
            else
            {
                _onStopWatch = false;
                btnOnOff.Text = "OFF";
                btnOnOff.BackColor = Color.Red;
                if(txtTime.Text != "00:00:00.00")
                {
                    btnReset.Enabled = true;
                } 
                else 
                { 
                    btnReset.Enabled = false; 
                }
                btnSave.Enabled = false;
                timer.Stop();
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
            _hour = 0;
            _minute = 0;
            _second = 0;
            _millisecond = 0;
            txtTime.Text = "00:00:00.00";
            //listHistory.DataSource = null;
            _listSaveTime.Clear();
            _listSaveTime = new List<SaveTime>();
            dataTime.DataSource = null;
        }  
    }
}
