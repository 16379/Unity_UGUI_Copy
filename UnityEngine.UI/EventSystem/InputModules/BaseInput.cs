namespace UnityEngine.EventSystems
{
    //BaseInputModuleʹ�õ�����ϵͳ�ӿڡ����������Ϳ������Լ�������ϵͳ�ƹ�����ϵͳ��
    //����Ȼʹ����ͬ������ģ�顣���磬��������ڽ����������뵽UI���벻ͬ����ϵͳ�Ľӿ��С�
    public class BaseInput : UIBehaviour
    {
        //�ӿڵ�Input.compositionString��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual string compositionString
        {
            get { return Input.compostionString; }
        }

        //�ӿڵ�Input.imeCompositionMode��������д���ṩ�Զ������룬������ʹ�������ࡣ
        public virtual IMECompostionMode imeCompositionMode
        {
            get { return Input.imeCompositionMode; }
            set { Input.imeCompositionMode = value; }
        }

    }

}