using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncron
{
    internal class GameObject3D
    {
        public Physics Physics;
        public string ObjectName;
        public LayerMask LayerMask;
        public Vector3 Position;
        public Quaternion Rotation;
        public static List<GameObject3D> list = new List<GameObject3D>();

        public GameObject3D(string name, Vector3 pos, Quaternion rot, LayerMask layerMask)
        {
            this.ObjectName = name;
            this.Position = pos;
            this.Rotation = rot;
            this.LayerMask = layerMask;
        }

        public static void RegisterGameObject(GameObject3D gameObject)
        {
            list.Add(gameObject);
        }

        public static GameObject3D Find(string name)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ObjectName == name) return list[i];
            }
            return null;
        }
    }
}
