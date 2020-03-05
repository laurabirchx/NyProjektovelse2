using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RPI;
using RPI.Display;
using RPI.Controller;
using RPI.Heart_Rate_Monitor;
using LiveCharts;
using LiveCharts.Wpf;
using RPI.IO;
using System.Threading;

namespace NyProjektovelse2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RPI.RPi _rpi = new RPI.RPi(); 
            ADC _adc = new ADC(_rpi);
            _adc.initAdc();
            List<float> dataList = new List<float>();

            float sample = Convert.ToSingle((_adc.readADC(0) / 2048.0) * 6.144)); 
            dataList.Add(sample);
            Thread.Sleep(20);
        }
    }
}
