namespace UnityEngine.EventSystems
{
    //所有EventSystem事件从中继承的基类。
    public interface IEventSystemHandler { }

    /// <summary>
    /// 如果希望接收OnPointerEnter回调，则要实现的接口。
    /// 此事件的条件取决于实现。例如，请参阅StandAloneInputModule。
    /// </summary>
    public interface IPointerEnterHandler:IEventSystemHandler
    {
        /// <summary>
        /// 使用此回调可检测指针输入事件
        /// </summary>
        /// <param name="eventData"></param>
        void OnPointerEnter(PointerEventData eventData);
    }
    /// <summary>
    /// 如果希望接收 OnPointerExit 回调，则要实现的接口。
    /// 此事件的条件取决于实现。例如，请参阅StandAloneInputModule。
    /// </summary>
    public interface IPointerExitHandler : IEventSystemHandler
    {
        /// <summary>
        /// 使用此回调检测指针退出事件
        /// </summary>
        /// <param name="eventData"></param>
        void OnPointerExit(PointerEventData eventData);
    }
    /// <summary>
    /// 如果希望接收 OnPointerDown 回调，则要实现的接口。
    /// 此事件的条件取决于实现。例如，请参阅StandAloneInputModule。
    /// </summary>
    public interface IPointerDownHandler : IEventSystemHandler
    {
        /// <summary>
        /// 使用此回调接受指针按下事件
        /// </summary>
        /// <param name="eventData"></param>
        void OnPointerDown(PointerEventData eventData);
    }





}