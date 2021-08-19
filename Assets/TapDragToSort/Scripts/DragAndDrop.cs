using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Simsoft.CaseStudyDependencyInversion.Unity
{
    public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
    {
        [SerializeField]
        private Canvas canvas;

        private RectTransform rectTransform;
        private CanvasGroup canvasGroup;

        private void Awake()
        {
            
            rectTransform = GetComponent<RectTransform>();
            canvasGroup = GetComponent<CanvasGroup>();
            canvasGroup.blocksRaycasts = true;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            Debug.Log("OnBeginDrag");
            canvasGroup.blocksRaycasts = false;
            canvasGroup.alpha = .5f;
        }

        public void OnDrag(PointerEventData eventData)
        {
            Debug.Log("OnDrag");
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            Debug.Log("OnEndDrag");
            canvasGroup.blocksRaycasts = true;
            canvasGroup.alpha = 1f;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            Debug.Log("OnPointerDown");
        }
    }
}
