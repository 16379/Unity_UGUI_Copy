namespace UnityEngine.EventSystems
{
    //BaseInputModule使用的输入系统接口。有了它，就可以用自己的输入系统绕过输入系统，
    //但仍然使用相同的输入模块。例如，这可以用于将假输入输入到UI或与不同输入系统的接口中。
    public class BaseInput : UIBehaviour
    {
        //接口到Input.compositionString。可以重写以提供自定义输入，而不是使用输入类。
        public virtual string compositionString
        {
            get { return Input.compositionString; }
        }

        //接口到Input.imeCompositionMode。可以重写以提供自定义输入，而不是使用输入类。
        public virtual IMECompositionMode imeCompositionMode
        {
            get { return Input.imeCompositionMode; }
            set { Input.imeCompositionMode = value; }
        }

        //接口到Input.compositionCursorPos。可以重写以提供自定义输入，而不是使用输入类。
        public virtual Vector2 compositionCursorPos
        {
            get { return Input.compositionCursorPos; }
            set { Input.compositionCursorPos = value; }
        }
        //接口到Input.mousePresent。可以重写以提供自定义输入，而不是使用输入类。
        public virtual bool mousePresent
        {
            get { return Input.mousePresent; }
        }
        //接口到Input.GetMouseButtonDown。可以重写以提供自定义输入，而不是使用输入类。
        public virtual bool GetMouseButtonDown(int button)
        {
            return Input.GetMouseButtonDown(button);
        }
        //接口到Input.GetMouseButtonUp。可以重写以提供自定义输入，而不是使用输入类。
        public virtual bool GetMouseButtonUp(int button)
        {
            return Input.GetMouseButtonUp(button);
        }
        //接口到Input.GetMountButton。可以重写以提供自定义输入，而不是使用输入类。
        public virtual bool GetMountButton(int button)
        {
            return Input.GetMouseButton(button);
        }
        //接口到Input.mousePosition。可以重写以提供自定义输入，而不是使用输入类。
        public virtual Vector2 mousePosition
        {
            get { return Input.mousePosition; }
        }
        //接口到Input.mouseScrollDelta。可以重写以提供自定义输入，而不是使用输入类。
        public virtual Vector2 mouseScrollDelta
        {
            get { return Input.mouseScrollDelta; }
        }
        //接口到Input.touchSupported。可以重写以提供自定义输入，而不是使用输入类。
        public virtual bool touchSupported
        {
            get { return Input.touchSupported; }
        }
        //接口到Input.touchCount。可以重写以提供自定义输入，而不是使用输入类。
        public virtual int touchCount
        {
            get { return Input.touchCount; }
        }
        //接口到Input.GetTouch。可以重写以提供自定义输入，而不是使用输入类。
        public virtual Touch GetTouch(int index)
        {
            return Input.GetTouch(index);
        }
        //接口到Input.GetAxisRaw。可以重写以提供自定义输入，而不是使用输入类。
        public virtual float GetAxisRaw(string axisName)
        {
            return Input.GetAxisRaw(axisName);
        }
        //接口到Input.GetButtonDown。可以重写以提供自定义输入，而不是使用输入类。
        public virtual bool GetButtonDown(string buttonName)
        {
            return Input.GetButtonDown(buttonName);
        }

    }

}