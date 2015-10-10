using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lipmon
{
    class CoordinatesVisualizer : IDisposable
    {
        const int fps = 10;
        private const int delay = 1000/fps; 
        delegate void SetTextCallback(string text);
        SetTextCallback d;
        bool _listening = true;
        Thread _readingThread;
        LeapListener _leapListener;
        TextBox coordinatesTextBox;
        MainWindow mainWindow;

        public CoordinatesVisualizer(LeapListener leapListener, TextBox coordTextBox, MainWindow mainWindow)
        {
            _leapListener = leapListener;
            _readingThread = new Thread(GetInfoFromLeap);
            _readingThread.Start();
            this.mainWindow = mainWindow;
            this.coordinatesTextBox = coordTextBox;
        }

        public void GetInfoFromLeap(Object obj)
        {
            if (coordinatesTextBox.InvokeRequired)
            {
                d = new SetTextCallback(SetCoordinates);
            }
            while (_listening)
            {
                var msg = _leapListener.LeapInfo.X + "," + _leapListener.LeapInfo.Y + "," + _leapListener.LeapInfo.Z;
                SetCoordinates(msg);
                Thread.Sleep(delay);
            }
        }

        public void SetCoordinates(string text)
        {
            if (coordinatesTextBox.InvokeRequired)
            {
                mainWindow.Invoke(d, new object[] { text });
            }
            else
            {
                this.coordinatesTextBox.Text = text;
                this.coordinatesTextBox.Refresh();
            }
        }

        public void Dispose()
        {
            _readingThread.Abort();
        }
    }
}
