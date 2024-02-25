using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncron
{
    internal class Physics
    {
        public static Vector3 Velocity;
        public static Quaternion Torque;
        public static float Mass = 1;
        public static float Speed = Math.Abs((Velocity.X + Velocity.Y + Velocity.Z) / 3) / Mass;
        public static float TorqueSpeed = Math.Abs((Torque.x + Torque.y + Torque.z + Torque.w) / 4) / Mass;

        public static void AddForce(GameObject3D Origin, Vector3 Direction)
        {
            Vector3 temp = new Vector3((Origin.Position.X +  Direction.X) / 2, (Origin.Position.Y + Direction.Y) / 2, 
                (Origin.Position.Z + Direction.Z) / 2);
            Velocity = temp;
            Origin.Position.Z += Speed;
            Origin.Position.X += Speed;
            Origin.Position.Y += Speed;
        }

        public static void AddTorque(GameObject3D Origin, Vector3 TargetDirection)
        {
            Quaternion temp = Quaternion.ToQuaternion(TargetDirection);
            Torque = new Quaternion((temp.x + Origin.Rotation.x) / 2, (temp.y + Origin.Rotation.y) / 2, 
                (temp.z + Origin.Rotation.z) / 2, (temp.w + Origin.Rotation.w) / 2);
            Origin.Rotation.x += TorqueSpeed;
            Origin.Rotation.y += TorqueSpeed;
            Origin.Rotation.z += TorqueSpeed;
            Origin.Rotation.w += TorqueSpeed;
        }
    }
}
