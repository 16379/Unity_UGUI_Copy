namespace UnityEngine.EventSystems
{
    //可用于通过事件系统发送简单事件的类。
    public abstract class AbstractEventData
    {
        protected bool m_Used;
        //重置事件。
        public virtual void Reset()
        {
            m_Used = false;
        }
        //使用这个事件
        //在内部设置一个标志，该标志可通过检查来查看是否应进行进一步处理。
        public virtual void Use()
        {
            m_Used = true;
        }
        //这个事件是否在使用
        public virtual bool used
        {
            get { return m_Used; }
        }
    }

    //包含新EventSystem中所有事件类型通用的基本事件数据的类
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

