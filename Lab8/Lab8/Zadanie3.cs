using System;
using System.ComponentModel;

namespace Lab8
{
    public class Zadanie3
    {
        public void Run()
        {
            Punkt p = new Punkt();
        }
    }
    public class Punkt : IDisposable
    {
        int _x;
        int _y;

        public Punkt(int x = 0, int y = 0)
        {
            _x = x;
            _y = y;
        }

        protected bool disposed = false;
        private IntPtr handle;
        private Component components;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    components.Dispose();
                }
                CloseHandle(handle);
                handle = IntPtr.Zero;
            }
            disposed = true;
        }

        ~Punkt()
        {
            Dispose(false);
        }


        [System.Runtime.InteropServices.DllImport("Kernel32")]
        private extern static Boolean CloseHandle(IntPtr handle);

    }

}