using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using GalaSoft.MvvmLight.Command;
using NLog;

namespace Demo
{

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Members
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public event PropertyChangedEventHandler PropertyChanged;
        Calculator calc;
        Random rnd;
        Thread PosThread;
        private double _value0;
        private double _value1;
        private double _result;
        private bool _random;
        #endregion

        #region Properties
        public double Value0
        {
            get {
                return _value0;
            }
            set
            {
                _value0 = value;
                NotifyPropertyChanged();
            }
        }
        public double Value1
        {
            get {
                return _value1;
            }
            set
            {
                _value1 = value;
                NotifyPropertyChanged();
            }
        }
        public double Result
        {
            get {
                return _result;
            }
            set
            {
                _result = value;
                NotifyPropertyChanged();
            }
        }
        public bool Random
        {
            get
            {
                return _random;
            }
            set
            {
                _random = value;
                StartRandomizer();
                NotifyPropertyChanged();
            }
        }
        #endregion


        #region Construction
        public MainWindowViewModel()
        {
            logger.Info("Starting Demo");
            calc = new Calculator();
            SystemCommand = new RelayCommand<string>((p) => SetSystem(p));
            rnd = new Random();
            double a = rnd.Next();
        }
        #endregion
        

        #region Commands
        public RelayCommand<string> SystemCommand { get; set; }
        private void SetSystem(string param)
        {
            switch (param)
            {
                case "Add":
                    Result = calc.Add(Value0, Value1);
                    break;
                case "Subtract":
                    Result = calc.Subtract(Value0, Value1);
                    break;
                case "Multiply":
                    Result = calc.Multiply(Value0, Value1);
                    break;
                case "Divide":
                    Result = calc.Divide(Value0, Value1);
                    break;
            }
        }
        #endregion

        #region Helper
        private void StartRandomizer()
        {
            if (_random)
            {
                PosThread = new Thread(new ThreadStart(delegate ()
                {
                    while (_random)
                    {
                        Thread.Sleep(100);
                        Value0 = rnd.Next() / 1E6;
                        Value1 = rnd.Next() / 1E6;
                    }
                }));
                PosThread.IsBackground = true;
                PosThread.Start();
            }
        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }

}
