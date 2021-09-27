namespace UnityEngine.EventSystems
{
    //所有EventSystem事件从中继承的基类。
    public interface IEventSystemHandler { }

    public interface IPointerEnterHandler:IEventSystemHandler
    {
        void OnPointerEnter(PointerEventData eventData);
    }
}