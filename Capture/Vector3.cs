using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Syncron
{
    internal class Vector3
    {
        public float X; public float Y; public float Z;

        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static float Distance(Vector3 a, Vector3 b)
        {
            float float1 = Math.Abs((a.X + a.Y + a.Z)/3);
            float float2 = Math.Abs((b.X + b.Y + b.Z)/3);
            return float1 - float2;
        }

        [Obsolete]
        public static Vector3 EularAngles(Quaternion q)
        {
            Vector3 ToReturn = Vector3.Zero;
            return ToReturn;
        }

        public static Vector3 Zero = new Vector3(0, 0, 0);
    }
}
