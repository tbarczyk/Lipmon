using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Leap;

namespace Lipmon
{
    public interface ILeapEventDelegate
    {
        void LeapEventNotification(string EventName);
    }

    public class LeapListener : ILeapEventDelegate, IDisposable
    {
        public LeapFrame LeapInfo { get; set; }
        private Controller controller;
        private LeapEventListener listener;
        public delegate void LeapEventDelegate(string EventName);

        public LeapListener()
        {
            this.LeapInfo = new LeapFrame();
            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);
        }

        public void LeapEventNotification(string EventName)
        {
            switch (EventName)
            {
                case "onInit":
                    break;
                case "onConnect":
                    this.connectHandler();
                    break;
                case "onFrame":
                    this.newFrameHandler(this.controller.Frame());
                    break;
                case "onExit":
                    
                    this.controller.Dispose();
                    this.listener.Dispose(); 
                    break;
            }
        }

        public void connectHandler()
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
            this.controller.Config.SetFloat("Gesture.Swipe.MinLength", 100.0f);
        }
        void newFrameHandler(Leap.Frame frame)
        {
            LeapInfo.X = (int)frame.Pointables.Frontmost.TipPosition.x;
            LeapInfo.Y = (int)frame.Pointables.Frontmost.TipPosition.y;
            LeapInfo.Z = (int)frame.Pointables.Frontmost.TipPosition.z;
        }

        public class LeapEventListener : Listener
        {
            ILeapEventDelegate eventDelegate;

            public LeapEventListener(ILeapEventDelegate delegateObject)
            {
                this.eventDelegate = delegateObject;
            }
            public override void OnInit(Controller controller)
            {
                this.eventDelegate.LeapEventNotification("onInit");
            }
            public override void OnConnect(Controller controller)
            {
                controller.SetPolicy(Controller.PolicyFlag.POLICY_IMAGES);
                controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
                this.eventDelegate.LeapEventNotification("onConnect");
            }

            public override void OnFrame(Controller controller)
            {
                this.eventDelegate.LeapEventNotification("onFrame");
            }
            public override void OnExit(Controller controller)
            {
                this.eventDelegate.LeapEventNotification("onExit");
            }
            public override void OnDisconnect(Controller controller)
            {
                this.eventDelegate.LeapEventNotification("onDisconnect");
            }
        }


        public void Dispose()
        {
            listener.OnExit(controller);
        }
    }
}
