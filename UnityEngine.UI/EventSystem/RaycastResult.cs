using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.EventSystems
{
    //BaseRaycaster检测结果
    public class RaycastResult
    {
        //射线碰撞到的物体
        private GameObject m_GameObject;
        /// <summary>
        /// 射线碰撞到的物体 
        /// </summary>
        public GameObject gameObject
        {
            get { return m_GameObject; }
            set { m_GameObject = value; }
        }

        public BaseRaycaster module;
    }
}
