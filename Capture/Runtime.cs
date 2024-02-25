using Syncron;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syncron
{
    internal static class Runtime
    {

        public static DateTime lastUpdate;

        public static float RunTimeInSeconds()
        {
            DateTime dateTime = DateTime.Now;

            return (float)(Program.dateTime - dateTime).TotalSeconds;
        }
        
        public static float RunTimeInMilliseconds()
        {
            DateTime dateTime = DateTime.Now;

            return (int)(Program.dateTime - dateTime).TotalMilliseconds;
        }

        public static float DeltaTimeInSeconds()
        {
            DateTime dateTime = DateTime.Now;

            return (float)(lastUpdate - dateTime).TotalSeconds;
        }

        public static float DeltaTimeInMilliseconds()
        {
            DateTime dateTime = DateTime.Now;

            return (float)(lastUpdate - dateTime).TotalMilliseconds;
        }
    }
}
