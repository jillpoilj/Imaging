using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using System.Numerics;

using OxyPlot;
using OxyPlot.Series;


namespace Radar
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxSignal.SelectedIndex = 0;
            comboBoxOutput.SelectedIndex = 0;
            /*Signal signal = Signal.CreateChirp(0, 1e7, 1e-5);
            MathNet.Numerics.IntegralTransforms.Fourier.Forward(signal.Value);
            
            var myModel = new PlotModel { Title = "Example 1" };
            OxyPlot.Series.LineSeries ls = new OxyPlot.Series.LineSeries();
            for (int i = 0; i < signal.N; i++)
            {
                //signal[i] = new Complex(Math.Cos(2 * Math.PI * i / 40), Math.Sin(2 * Math.PI * i / 40));
                ls.Points.Add(new DataPoint(i, (signal.Value[i]).Magnitude));
            }
            myModel.Series.Add(ls);
            this.plot1.Model = myModel;*/
        }

        public static Complex[] MatlabHilbert(double[] xr)
        {
            //MathNet.Numerics.IntegralTransforms.Fourier.
            //var fft = new MathNet.Numerics.IntegralTransforms.Algorithms.DiscreteFourierTransform();
            var x = (from sample in xr select new Complex(sample, 0)).ToArray();
            MathNet.Numerics.IntegralTransforms.Fourier.BluesteinForward(x, MathNet.Numerics.IntegralTransforms.FourierOptions.Default);
            var h = new double[x.Length];
            var fftLengthIsOdd = (x.Length | 1) == 1;
            if (fftLengthIsOdd)
            {
                h[0] = 1;
                for (var i = 1; i < xr.Length / 2; i++) h[i] = 2;
            }
            else
            {
                h[0] = 1;
                h[(xr.Length / 2)] = 1;
                for (var i = 1; i < xr.Length / 2; i++) h[i] = 2;
            }
            for (var i = 0; i < x.Length; i++) x[i] *= h[i];
            MathNet.Numerics.IntegralTransforms.Fourier.BluesteinInverse(x, MathNet.Numerics.IntegralTransforms.FourierOptions.Default);
            return x;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Signal signal = new Signal();
            double duration, fill, bandwidth;
            if (double.TryParse(textBoxDuration.Text, out duration))
                duration = duration * 1e-6;
            else
                duration = 1e-5;

            if (double.TryParse(textBoxBandwidth.Text, out bandwidth))
                bandwidth = bandwidth * 1e6;
            else
                bandwidth = 1e7;

            if (double.TryParse(textBoxFill.Text, out fill))
                if (fill > 100) fill = 1;
                else if (fill < 0) fill = 0;
                else fill = fill / 100;
            else
                fill = 0.5;

            switch (comboBoxSignal.Text)
            {
                case "ЛЧМ":
                    signal = Signal.CreateChirp(0, bandwidth, duration, fill);
                    break;
                default:
                    signal = Signal.CreateChirp(0, 1e7, 1e-5);
                    break;
            }

            var myModel = new PlotModel { Title = "Example 1" };
            OxyPlot.Series.LineSeries ls = new OxyPlot.Series.LineSeries();

            switch (comboBoxOutput.Text)
            {
                case "Сигнал":
                    for (int i = 0; i < signal.N; i++)
                    {
                        ls.Points.Add(new DataPoint(i, (signal.Value[i]).Real));
                    }
                    break;
                case "Спектр":
                    MathNet.Numerics.IntegralTransforms.Fourier.Forward(signal.Value);
                    for (int i = 0; i < signal.N; i++)
                    {
                        ls.Points.Add(new DataPoint(i, (signal.Value[i]).Real));
                    }
                    break;
                case "Модуль сигнала":
                    for (int i = 0; i < signal.N; i++)
                    {
                        ls.Points.Add(new DataPoint(i, (signal.Value[i]).Magnitude));
                    }
                    break;
                case "Модуль спектра":
                    MathNet.Numerics.IntegralTransforms.Fourier.Forward(signal.Value);
                    for (int i = 0; i < signal.N; i++)
                    {
                        ls.Points.Add(new DataPoint(i, (signal.Value[i]).Magnitude));
                    }
                    break;
            }

            
            myModel.Series.Add(ls);
            this.plot1.Model = myModel;
        }

        
    }

    public class Signal
    {
        public double T;
        public int N;
        public Complex[] Value;

        public static Signal CreateChirp(double f0, double Df, double T, double filling = 0.5)
        {
            if (filling < 0.01)
                filling = 0.5;
            if (filling > 1)
                filling = 1;
            double T1 = T * filling;
            Signal ret = new Signal();
            ret.T = T;
            for (int i = 1; i < (1 << 14); i = (i << 1))
            {
                if (i >= T * 2 * (f0+2*Df))
                {
                    ret.N = i;
                    break;
                }
            }
            if (ret.N == 0)
            {
                ret.N = (1 << 14);
                MessageBox.Show("Too many points!");
            }
            double dT = T / ret.N;
            double alpha = 2 * Math.PI * Df / T;
            double empty = (T - T1) / 2;
            Complex[] value = new Complex[ret.N];
            for (int i = 0; i < ret.N; i++)
            {
                double t = i * dT - empty;
                if (t < 0 || t > T1)
                    continue;
                value[i] = new Complex(Math.Cos(2 * Math.PI * f0 * t) * Math.Cos(alpha * t * t), Math.Sin(2 * Math.PI * f0 * t) * Math.Sin(alpha * t * t));
            }
            ret.Value = value;
            return ret;
        }

    }
}
