using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Simsoft.CaseStudyDependencyInversion.Unity
{
    public class ItemSlot : MonoBehaviour, IDropHandler
    {
        public string nameType="";
        public void OnDrop(PointerEventData eventData)
        {
            Debug.Log("OnDrop");
            if(eventData.pointerDrag != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                nameType = eventData.pointerDrag.tag;
                Debug.Log(nameType);
            }
        }
    }
}
