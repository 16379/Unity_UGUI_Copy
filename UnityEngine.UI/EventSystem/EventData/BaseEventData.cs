namespace UnityEngine.EventSystems
{
    //������ͨ���¼�ϵͳ���ͼ��¼����ࡣ
    public abstract class AbstractEventData
    {
        protected bool m_Used;
        //�����¼���
        public virtual void Reset()
        {
            m_Used = false;
        }
        //ʹ������¼�
        //���ڲ�����һ����־���ñ�־��ͨ��������鿴�Ƿ�Ӧ���н�һ������
        public virtual void Use()
        {
            m_Used = true;
        }
        //����¼��Ƿ���ʹ��
        public virtual bool used
        {
            get { return m_Used; }
        }
    }

    //������EventSystem�������¼�����ͨ�õĻ����¼����ݵ���
    public class BaseEventData : AbstractEventData 
    {
        private readonly EventSystem m_EventSystem;
        public BaseEventData(EventSystem eventSystem)
        {
            m_EventSystem = eventSystem;
        }
        //public BaseInputModule currentInputModule
        //{
        //    get { return m_EventSystem.currentInputModule; }
        //}


    }



}

