namespace UnityEngine.EventSystems
{
    //����EventSystem�¼����м̳еĻ��ࡣ
    public interface IEventSystemHandler { }

    public interface IPointerEnterHandler:IEventSystemHandler
    {
        void OnPointerEnter(PointerEventData eventData);
    }
}