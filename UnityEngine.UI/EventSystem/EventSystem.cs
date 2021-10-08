
using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
    [AddComponentMenu("Event/Event System")]
    //�������롢����Ͷ��ͷ����¼���
    //EventSystem������Unity�����е��¼���һ������Ӧ������һ��EventSystem��
    //EventSystem����ģ��Эͬ����������������ֻ����״̬��������ί�и��ض��ġ�����д�������
    //��EventSystem����ʱ�������������ӵ�ͬһ��Ϸ������κ�BaseInputModule����������ӵ��ڲ��б��С�
    //����ʱ��ÿ�����ӵ�ģ�����һ��UpdateModules���ã�ģ������������޸��ڲ�״̬��
    //ÿ��ģ����º󣬻ģ�齫ִ�н��̵��á����ǿ��Խ����Զ���ģ�鴦��ĵط���
    public class EventSystem : UIBehaviour
    {
        private List<BaseInputModule> m_SystemInputModules = new List<BaseInputModule>();

        private BaseInputModule m_CurrentInputModule;

        private static List<EventSystem> m_EventSystems = new List<EventSystem>();

        /// <summary>
        /// ���ص�ǰ���¼�ϵͳ
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
        /// �¼�ϵͳ�Ƿ��������¼����ƶ�/�ύ/ȡ������
        /// </summary>
        public bool sendNavigationEvents
        {
            get { return m_sendNavigationEvents; }
            set { m_sendNavigationEvents = value; }
        }
        [SerializeField]
        //��ק����
        private int m_DragThreshold = 10;
        /// <summary>
        /// �����϶����ص�������
        /// </summary>
        public int pixelDragThreshold
        {
            get { return m_DragThreshold; }
            set { m_DragThreshold = value; }
        }

        private GameObject m_CurrentSelected;

        /// <summary>
        /// ��ǰ���EventSystems.BaseInputModule��
        /// </summary>
        public BaseInputModule currentInputModule
        {
            get { return m_CurrentInputModule; }
        }
        /// <summary>
        /// һ��ֻ��ѡ��һ������˼����������ѡ��ť��
        /// </summary>
        public GameObject firstSelectedGameObject
        {
            get { return m_FirstSelected; }
            set { m_FirstSelected = value; }
        }
        /// <summary>
        /// EventSystem��ǰ��Ϊ���ڻ״̬����Ϸ����
        /// </summary>
        public GameObject currentSelectedGameObject
        {
            get { return m_CurrentSelected; }
        }
        [Obsolete("����֧��lastSelectedGameObject")]
        public GameObject lastSelectedGameObject
        {
            get { return null; }
        }
        private bool m_HasFocus = true;
        /// <summary>
        /// ��־����ʾEventSystem���ݾ۽�״̬�Ƿ���ΪӦ����ͣ��
        /// �����ڵ�������ģ����ȷ��Ӧ�ó���û�н���ʱ�Ƿ�Ӧ��ѡģ��
        /// </summary>
        public bool isFocus
        {
            get { return m_HasFocus; }
        }

        protected EventSystem() { }

        /// <summary>
        /// ���¼���BaseInputModule���ڲ��б�
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
        /// ���EventSystem����SetSelectedGameObject�У��򷵻�true��
        /// </summary>
        public bool alreadySelecting
        {
            get { return m_SelectionGuard; }
        }
        /// <summary>
        /// ����������Ϊѡ�����󡣽����ѡ��������OnDeselect��������ѡ��������OnSelect��
        /// </summary>
        /// <param name="selected">ѡ�е�GameObject</param>
        /// <param name="pointer">�����¼�����</param>
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