using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChinaTest
{
    internal class MouseInterface
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out Win32Point lpPoint);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        private static extern void mouse_event(MouseFlags dwFlags, int dx, int dy, int dwData, uint dwExtraInfo);
        [Flags]
        private enum MouseFlags : uint
        {
            MOUSEEVENTF_ABSOLUTE = 0x8000,   // If set, dx and dy contain normalized absolute coordinates between 0 and 65535. The event procedure maps these coordinates onto the display surface. Coordinate (0,0) maps onto the upper-left corner of the display surface, (65535,65535) maps onto the lower-right corner.
            MOUSEEVENTF_LEFTDOWN = 0x0002,   // The left button is down.
            MOUSEEVENTF_LEFTUP = 0x0004,     // The left button is up.
            MOUSEEVENTF_MIDDLEDOWN = 0x0020, // The middle button is down.
            MOUSEEVENTF_MIDDLEUP = 0x0040,   // The middle button is up.
            MOUSEEVENTF_MOVE = 0x0001,       // Movement occurred.
            MOUSEEVENTF_RIGHTDOWN = 0x0008,  // The right button is down.
            MOUSEEVENTF_RIGHTUP = 0x0010,    // The right button is up.
            MOUSEEVENTF_WHEEL = 0x0800,      // The wheel has been moved, if the mouse has a wheel.The amount of movement is specified in dwData
            MOUSEEVENTF_XDOWN = 0x0080,      // An X button was pressed.
            MOUSEEVENTF_XUP = 0x0100,        // An X button was released.
            MOUSEEVENTF_HWHEEL = 0x01000     // The wheel button is tilted.
        }
        [StructLayout(LayoutKind.Sequential)]
        internal struct Win32Point
        {
            public int X;
            public int Y;
        };
        private static Win32Point GetMousePosition()
        {
            GetCursorPos(out Win32Point w32Mouse);
            return w32Mouse;
        }

        public struct Position
        {
            public static int X { get { return GetMousePosition().X; } }
            public static int Y { get { return GetMousePosition().Y; } }
        }

        public static void ScrollDown()
        {
            mouse_event(MouseFlags.MOUSEEVENTF_WHEEL, 0, 0, -120, 0);
            Thread.Sleep(50);
        }

        public static void ScrollUp()
        {
            mouse_event(MouseFlags.MOUSEEVENTF_WHEEL, 0, 0, 120, 0);
            Thread.Sleep(50);
        }

        public static void LeftDown()
        {
            mouse_event(MouseFlags.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        }

        public static void LeftUp()
        {
            mouse_event(MouseFlags.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        public static void RightDown()
        {
            mouse_event(MouseFlags.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
        }

        public static void RightUp()
        {
            mouse_event(MouseFlags.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        public static void MiddleDown()
        {
            mouse_event(MouseFlags.MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
        }

        public static void MiddleUp()
        {
            mouse_event(MouseFlags.MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
        }

        public static void LeftClick()
        {
            LeftDown();
            Thread.Sleep(100);
            LeftUp();
        }

        public static void RightClick()
        {
            RightDown();
            Thread.Sleep(100);
            RightUp();
        }

        public static void MiddleClick()
        {
            MiddleDown();
            Thread.Sleep(100);
            MiddleUp();
        }

        public static void MoveTo(int X, int Y)
        {
            SetCursorPos(X, Y);
        }

        public static void Move(int X, int Y)
        {
            SetCursorPos(Position.X + X, Position.Y + Y);
        }

        public static void SmoothMove(int X, int Y, int moveTime)
        {
            if (moveTime <= 0) moveTime = 500; else moveTime *= 1000;
            if (moveTime > 30000) moveTime = 30000;
            double rateDelay = 1000 / 60; // 1 sec div by framerate (60)
            int stepsCount = (int)(moveTime / rateDelay);
            int posX = 0, posY = 0;
            for (int i = 1; i <= stepsCount; i++)
            {
                int oldX = posX;
                int oldY = posY;
                double pos = -(Math.Cos(Math.PI * i / stepsCount) - 1) / 2;
                posX = (int)(X * pos);
                posY = (int)(Y * pos);
                Move(posX - oldX, posY - oldY);
                Thread.Sleep((int)rateDelay);
            }
        }

        public static void SmoothMoveTo(int X, int Y, int moveTime)
        {
            SmoothMove(X - Position.X, Y - Position.Y, moveTime);
        }
    }
}
