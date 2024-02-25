using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncron
{
    internal class Quaternion
    {
        public float x; public float y; public float z; public float w;

        public Quaternion(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static Quaternion ToQuaternion(Vector3 v)
        {

            float cy = (float)Math.Cos(v.Z * 0.5);
            float sy = (float)Math.Sin(v.Z * 0.5);
            float cp = (float)Math.Cos(v.Y * 0.5);
            float sp = (float)Math.Sin(v.Y * 0.5);
            float cr = (float)Math.Cos(v.X * 0.5);
            float sr = (float)Math.Sin(v.X * 0.5);

            float x = (sr * cp * cy - cr * sp * sy);
            float y = (cr * sp * cy + sr * cp * sy);
            float z = (cr * cp * sy - sr * sp * cy);
            float w = (cr * cp * cy + sr * sp * sy);

            return new Quaternion(x, y, z, w);
        }
    }
}
