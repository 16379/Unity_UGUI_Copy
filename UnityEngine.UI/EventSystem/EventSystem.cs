
using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
    [AddComponentMenu("Event/Event System")]
    //处理输入、光线投射和发送事件。
    //EventSystem负责处理Unity场景中的事件。一个场景应仅包含一个EventSystem。
    //EventSystem与多个模块协同工作，大多数情况下只保存状态并将功能委托给特定的、可重写的组件。
    //当EventSystem启动时，它会搜索连接到同一游戏对象的任何BaseInputModule，并将其添加到内部列表中。
    //更新时，每个连接的模块接收一个UpdateModules调用，模块可以在其中修改内部状态。
    //每个模块更新后，活动模块将执行进程调用。这是可以进行自定义模块处理的地方。
    public class EventSystem : UIBehaviour
    {
        private List<BaseInputModule> m_SystemInputModules = new List<BaseInputModule>();

        private BaseInputModule m_CurrentInputModule;

        private static List<EventSystem> m_EventSystems = new List<EventSystem>();

        /// <summary>
        /// 返回当前的事件系统
        /// </summary>
        public static EventSystem current
        {
            get { return m_EventSystems.Count > 0 ? m_EventSystems[0] : null; }
            set
            {
                int index = m_EventSystems.IndexOf(value);
                if (index >= 0)
                {
                    m_EventSystems.RemoveAt(index);
                    m_EventSystems.Insert(0, value);
                }
            }
        }
        [SerializeField]
        [FormerlySerializedAs("m_Selected")]
        private GameObject m_FirstSelected;

        [SerializeField]
        private bool m_sendNavigationEvents = true;

        /// <summary>
        /// 事件系统是否允许导航事件（移动/提交/取消）。
        /// </summary>
        public bool sendNavigationEvents
        {
            get { return m_sendNavigationEvents; }
            set { m_sendNavigationEvents = value; }
        }
        [SerializeField]
        //拖拽开端
        private int m_DragThreshold = 10;
        /// <summary>
        /// 用于拖动像素的软区域。
        /// </summary>
        public int pixelDragThreshold
        {
            get { return m_DragThreshold; }
            set { m_DragThreshold = value; }
        }

        private GameObject m_CurrentSelected;

        /// <summary>
        /// 当前活动的EventSystems.BaseInputModule。
        /// </summary>
        public BaseInputModule currentInputModule
        {
            get { return m_CurrentInputModule; }
        }
        /// <summary>
        /// 一次只能选择一个对象。思考：控制器选择按钮。
        /// </summary>
        public GameObject firstSelectedGameObject
        {
            get { return m_FirstSelected; }
            set { m_FirstSelected = value; }
        }
        /// <summary>
        /// EventSystem当前认为处于活动状态的游戏对象。
        /// </summary>
        public GameObject currentSelectedGameObject
        {
            get { return m_CurrentSelected; }
        }
        [Obsolete("不再支持lastSelectedGameObject")]
        public GameObject lastSelectedGameObject
        {
            get { return null; }
        }
        private bool m_HasFocus = true;
        /// <summary>
        /// 标志，表示EventSystem根据聚焦状态是否认为应该暂停。
        /// 用于在单个输入模块内确定应用程序没有焦点时是否应勾选模块
        /// </summary>
        public bool isFocus
        {
            get { return m_HasFocus; }
        }

        protected EventSystem() { }

        /// <summary>
        /// 重新计算BaseInputModule的内部列表。
        /// </summary>
        public void UpdateModules()
        {
            GetComponents(m_SystemInputModules);
            for(int i = m_SystemInputModules.Count - 1;i>= 0; i--)
            {
                if (m_SystemInputModules[i] && m_SystemInputModules[i].IsActive())
                    continue;
                m_SystemInputModules.RemoveAt(i);
            }
        }

        private bool m_SelectionGuard;
        /// <summary>
        /// 如果EventSystem已在SetSelectedGameObject中，则返回true。
        /// </summary>
        public bool alreadySelecting
        {
            get { return m_SelectionGuard; }
        }
        /// <summary>
        /// 将对象设置为选定对象。将向旧选定对象发送OnDeselect，并向新选定对象发送OnSelect。
        /// </summary>
        /// <param name="selected">选中的GameObject</param>
        /// <param name="pointer">关联事件数据</param>
        public void SetSelectedGameObject(GameObject selected,BaseEventData pointer)
        {
            if (m_SelectionGuard)
            {
                Debug.LogError("");
                return;
            }
            m_SelectionGuard = true;
            if(selected == m_CurrentSelected)
            {
                m_SelectionGuard = false;
                return;
            }
            ExecuteEvents.Execute(m_CurrentSelected, pointer, ExecuteEvents.deselectHandler);
        }








    }

}