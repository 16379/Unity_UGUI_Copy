namespace UnityEngine.EventSystems
{
    //BaseInputModule使用的输入系统接口。有了它，就可以用自己的输入系统绕过输入系统，
    //但仍然使用相同的输入模块。例如，这可以用于将假输入输入到UI或与不同输入系统的接口中。
    public class BaseInput : UIBehaviour
    {
        //接口到Input.compositionString。可以重写以提供自定义输入，而不是使用输入类。
        public virtual string compositionString
        {
            get { return Input.compostionString; }
        }

        //接口到Input.imeCompositionMode。可以重写以提供自定义输入，而不是使用输入类。
        public virtual IMECompostionMode imeCompositionMode
        {
            get { return Input.imeCompositionMode; }
            set { Input.imeCompositionMode = value; }
        }

    }

}