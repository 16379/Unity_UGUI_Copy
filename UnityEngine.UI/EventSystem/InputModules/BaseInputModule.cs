using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
    [RequireComponent(typeof(EventSystem))]
    //�����¼������䷢�͵�GameObjects�Ļ���ģ�顣
    //����ģ����EventSystem��һ����������������¼������䷢�͵�GameObjects���д���
    //BaseInputModule��EventSystem����������ģ��̳��Ե��ࡣ�ṩ��ģ��ʾ����TouchInputModule��StandaloneInputModule
    //��������ǲ��ʺ�������Ŀ��������ͨ����չBaseInputModule�������Լ���ģ�顣
    public abstract class BaseInputModule : UIBehaviour
    {
        [NonSerialized]
        protected List<RaycastResult> m_RaycastResultCache = new List<RaycastResult>();
        private AxisEventData m_AxisEventData;

        private EventSystem m_EventSystem;
        private BaseEventData m_BaseEventData;

        protected BaseInput m_InputOverride;
        private BaseInput m_DefaultInput;

        /// <summary>
        /// ����ģ��ʹ�õĵ�ǰ�������롣
        /// </summary>
        public BaseInput input
        {
            get
            {
                if(m_InputOverride != null)
                {
                    return m_InputOverride;
                }
                if (m_DefaultInput == null)
                {
                    var inputs = GetComponents<BaseInput>();
                    foreach (var baseInput in inputs)
                    {
                        //���ǲ���ʹ���κδ�BaseInput����������ΪĬ���ࡣ
                        if (baseInput != null && baseInput.GetType() == typeof(BaseInput))
                        {
                            m_DefaultInput = baseInput;
                            break;
                        }
                    }
                }
                return m_DefaultInput;
            }
        }
        /// <summary>
        /// ���ڸ�������ģ���Ĭ��BaseInput��
        /// ���������Ϳ������Լ�������ϵͳ�ƹ�����ϵͳ������Ȼʹ����ͬ������ģ�顣
        /// ���磬��������ڽ����������뵽UI���벻ͬ����ϵͳ�Ľӿ��С�
        /// </summary>
        public BaseInput inputOverride
        {
            get { return m_InputOverride; }
            set { m_InputOverride = value; }
        }

        protected EventSystem eventSystem
        {
            get { return m_EventSystem;}
        }
        protected override void OnEnable()
        {
            base.OnEnable();
            m_EventSystem = GetComponent<EventSystem>();
            m_EventSystem.UpdateModules();
        }








    }
}