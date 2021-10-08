namespace UnityEngine.EventSystems
{
    //BaseInputModuleʹ�õ�����ϵͳ�ӿڡ����������Ϳ������Լ�������ϵͳ�ƹ�����ϵͳ��
    //����Ȼʹ����ͬ������ģ�顣���磬��������ڽ����������뵽UI���벻ͬ����ϵͳ�Ľӿ��С�
    public class BaseInput : UIBehaviour
    {
        //�ӿڵ�Input.compositionString��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual string compositionString
        {
            get { return Input.compositionString; }
        }

        //�ӿڵ�Input.imeCompositionMode��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual IMECompositionMode imeCompositionMode
        {
            get { return Input.imeCompositionMode; }
            set { Input.imeCompositionMode = value; }
        }

        //�ӿڵ�Input.compositionCursorPos��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual Vector2 compositionCursorPos
        {
            get { return Input.compositionCursorPos; }
            set { Input.compositionCursorPos = value; }
        }
        //�ӿڵ�Input.mousePresent��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual bool mousePresent
        {
            get { return Input.mousePresent; }
        }
        //�ӿڵ�Input.GetMouseButtonDown��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual bool GetMouseButtonDown(int button)
        {
            return Input.GetMouseButtonDown(button);
        }
        //�ӿڵ�Input.GetMouseButtonUp��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual bool GetMouseButtonUp(int button)
        {
            return Input.GetMouseButtonUp(button);
        }
        //�ӿڵ�Input.GetMountButton��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual bool GetMountButton(int button)
        {
            return Input.GetMouseButton(button);
        }
        //�ӿڵ�Input.mousePosition��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual Vector2 mousePosition
        {
            get { return Input.mousePosition; }
        }
        //�ӿڵ�Input.mouseScrollDelta��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual Vector2 mouseScrollDelta
        {
            get { return Input.mouseScrollDelta; }
        }
        //�ӿڵ�Input.touchSupported��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual bool touchSupported
        {
            get { return Input.touchSupported; }
        }
        //�ӿڵ�Input.touchCount��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual int touchCount
        {
            get { return Input.touchCount; }
        }
        //�ӿڵ�Input.GetTouch��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual Touch GetTouch(int index)
        {
            return Input.GetTouch(index);
        }
        //�ӿڵ�Input.GetAxisRaw��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual float GetAxisRaw(string axisName)
        {
            return Input.GetAxisRaw(axisName);
        }
        //�ӿڵ�Input.GetButtonDown��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual bool GetButtonDown(string buttonName)
        {
            return Input.GetButtonDown(buttonName);
        }

    }

}