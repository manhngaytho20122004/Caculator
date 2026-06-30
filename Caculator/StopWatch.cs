using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
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
                btnOnOff.Text = "Stop";
                btnOnOff.BackColor = Color.Red;
                btnSave.Enabled = true;
                btnReset.Enabled = true;
                btnSaveFile.Enabled = false;
                timer.Start();
               
            }
            else
            {
                _elapsed = DateTime.Now - _startTime;
                _onStopWatch = false;
                btnOnOff.Text = "Start";
                btnOnOff.BackColor = Color.Green;
                btnSaveFile.Enabled = true;
                if (txtTime.Text != "00:00:00.00")
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
            return TimeSpan.ParseExact(time, @"hh\:mm\:ss\.ff", null);
        }
        private void buttonSaveTime_Click(object sender, EventArgs e)
        {
            SaveTime Time = new SaveTime();
            Time.Lap = _listSaveTime.Count + 1;
            Time.Total = txtTime.Text;

            if (_listSaveTime.Count == 0)
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
        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            _onStopWatch = false;
            btnOnOff.Text = "Start";
            btnOnOff.BackColor = Color.Green;
            btnSave.Enabled = false;
            btnReset.Enabled = false;
            _elapsed = TimeSpan.Zero;
            txtTime.Text = "00:00:00:00";
            _listSaveTime.Clear();
            _listSaveTime = new List<SaveTime>();
            dataTime.DataSource = null;
        }
        private void SaveTxt()
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text File (*.txt)|*.txt";
                save.Title = "Save File";
                save.FileName = "History.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    List<string> lineItems = new List<string>();
                    foreach (var item in _listSaveTime)
                    {
                        lineItems.Add($"{item.Lap} {item.Time} {item.Total}");
                    }
                    File.WriteAllLines("History.txt", lineItems);
                    MessageBox.Show("Save file .txt success!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Save file .txt fail: " + ex.Message);
            }
        }
        private void OpenTxtFile(OpenFileDialog open)
        {
            _listSaveTime.Clear();
            try
            {
                string[] lines = File.ReadAllLines(open.FileName);
                foreach (var items in lines)
                {
                    string[] data = items.Split(' ');
                    SaveTime Time = new SaveTime();
                    Time.Lap = int.Parse(data[0]);
                    Time.Time = data[1];
                    Time.Total = data[2];
                    _listSaveTime.Add(Time);
                }
                dataTime.DataSource = null;
                dataTime.DataSource = _listSaveTime;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Open file .txt fail: " + ex.Message);
            }
        }            
        private void SaveCsv()
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text File (*.csv)|*.csv";
                save.Title = "Save File";
                save.FileName = "History.csv";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    List<string> lineItems = new List<string>();
                    foreach (var item in _listSaveTime)
                    {
                        lineItems.Add($"{item.Lap},{item.Time},{item.Total}");
                    }
                    File.WriteAllLines("History.csv", lineItems);
                    MessageBox.Show("Save file .csv success!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save file .csv fail: " + ex.Message);
            }
        }
        private void OpenCsvFile(OpenFileDialog open)
        {
            _listSaveTime.Clear();
            try 
            {
                string[] lines = File.ReadAllLines(open.FileName);
                foreach (var items in lines)
                {
                    string[] data = items.Split(',');
                    SaveTime Time = new SaveTime();
                    Time.Lap = int.Parse(data[0]);
                    Time.Time = data[1];
                    Time.Total = data[2];
                    _listSaveTime.Add(Time);
                }
                dataTime.DataSource = null;
                dataTime.DataSource = _listSaveTime;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Open file .csv fail: " + ex.Message);
            }
    
        }
        private void SaveIni()
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text File (*.ini)|*.ini";
                save.Title = "Save File";
                save.FileName = "History.ini";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    List<string> lineItems = new List<string>();
                   
                    foreach (var item in _listSaveTime)
                    {
                        lineItems.Add($"[SaveTime{item.Lap}]");
                        lineItems.Add($"Lap={item.Lap}");
                        lineItems.Add($"Time={item.Time}");
                        lineItems.Add($"Total={item.Total}");
                        lineItems.Add("");
                    }
                    File.WriteAllLines(save.FileName, lineItems);
                    MessageBox.Show("Save file .ini success!");
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Save file .ini fail: " + ex.Message); 
            }
        }
        private void OpenIni(OpenFileDialog open)
        {
            _listSaveTime.Clear();
            try
            {
                string[] lines = File.ReadAllLines(open.FileName);
                SaveTime time = null;
                foreach( var items in lines)
                {
                    if (string.IsNullOrWhiteSpace(items))
                        continue;
                    if (items.StartsWith("["))
                    {
                       
                        time = new SaveTime();
                        _listSaveTime.Add(time);
                        continue;
                    }
                    else
                    {
                        string[] data = items.Split('=');
                        if(data[0] == "Lap")
                        { 
                            time.Lap = Convert.ToInt32(data[1]);
                        }
                        if (data[0]== "Time")
                        {
                            time.Time = data[1];
                        }
                        if (data[0] == "Total")
                        {
                            time.Total = data[1];
                        }
                        
                    }    
                }
                dataTime.DataSource = null;
                dataTime.DataSource = _listSaveTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open file .ini fail: " + ex.Message);
            }
        }
        private void SaveJson()
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text File (*.json)|*.json";
                save.Title = "Save File";
                save.FileName = "History.json";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string json = JsonSerializer.Serialize(
                        _listSaveTime,
                            new JsonSerializerOptions
                            {
                                WriteIndented = true
                            }
                    );
                    File.WriteAllText(save.FileName, json);
                    MessageBox.Show("Save file .json success!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save file .json fail: " + ex.Message);
            }
        }
        private void OpenJson(OpenFileDialog open)
        {
            _listSaveTime.Clear();

            try
            {
                string json = File.ReadAllText(open.FileName);

                _listSaveTime = JsonSerializer.Deserialize<List<SaveTime>>(json);
                dataTime.DataSource = null;
                dataTime.DataSource = _listSaveTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open file .json fail: " + ex.Message);
            }
        }
        private void button_SaveFile_Click(object sender, EventArgs e)
        {
            string fomatFile = cbFile.Text;
            if (fomatFile == ".txt")
            {
                SaveTxt();
            }
            if (fomatFile == ".csv")
            {
                SaveCsv();
            }
            if (fomatFile == ".ini")
            {
                SaveIni();
            }
            if (fomatFile == ".json")
            {
                SaveJson();
            }
            if(string.IsNullOrEmpty(fomatFile))
            {
                MessageBox.Show("Pleas select fomat file!");
            }
        }
        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                string fomatFile = Path.GetExtension(open.FileName);
                MessageBox.Show(fomatFile);
                if (fomatFile == ".txt")
                {
                    OpenTxtFile(open);
                }
                else if (fomatFile == ".csv")
                {
                    OpenCsvFile(open);
                }
                else if (fomatFile == ".ini")
                {
                    OpenIni(open);
                }
                else if (fomatFile == ".json")
                {
                    OpenJson(open);
                }
                else
                {
                    MessageBox.Show("Only supports opening .txt, .csv, .ini, and .json!");
                }
            }    
            
        }
     
    }
}
