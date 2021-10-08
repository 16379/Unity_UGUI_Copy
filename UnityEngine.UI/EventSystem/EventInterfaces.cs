namespace UnityEngine.EventSystems
{
    //����EventSystem�¼����м̳еĻ��ࡣ
    public interface IEventSystemHandler { }

    /// <summary>
    /// ���ϣ������OnPointerEnter�ص�����Ҫʵ�ֵĽӿڡ�
    /// ���¼�������ȡ����ʵ�֡����磬�����StandAloneInputModule��
    /// </summary>
    public interface IPointerEnterHandler:IEventSystemHandler
    {
        /// <summary>
        /// ʹ�ô˻ص��ɼ��ָ�������¼�
        /// </summary>
        /// <param name="eventData"></param>
        void OnPointerEnter(PointerEventData eventData);
    }
    /// <summary>
    /// ���ϣ������ OnPointerExit �ص�����Ҫʵ�ֵĽӿڡ�
    /// ���¼�������ȡ����ʵ�֡����磬�����StandAloneInputModule��
    /// </summary>
    public interface IPointerExitHandler : IEventSystemHandler
    {
        /// <summary>
        /// ʹ�ô˻ص����ָ���˳��¼�
        /// </summary>
        /// <param name="eventData"></param>
        void OnPointerExit(PointerEventData eventData);
    }
    /// <summary>
    /// ���ϣ������ OnPointerDown �ص�����Ҫʵ�ֵĽӿڡ�
    /// ���¼�������ȡ����ʵ�֡����磬�����StandAloneInputModule��
    /// </summary>
    public interface IPointerDownHandler : IEventSystemHandler
    {
        /// <summary>
        /// ʹ�ô˻ص�����ָ�밴���¼�
        /// </summary>
        /// <param name="eventData"></param>
        void OnPointerDown(PointerEventData eventData);
    }





}