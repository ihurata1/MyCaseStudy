using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simsoft.CaseStudyDependencyInversion.Unity
{
    public class CleaningEffectController : MonoBehaviour
    {
        [SerializeField]
        private GameObject psHolder;
        [SerializeField]
        private GameObject cleanerObj;
        [SerializeField]
        private GameObject diryObj;

        private ParticleSystem particleSystem;
        private Vector3 mousePos;
        private Vector3 cleanerPos;

        void Start()
        {
            particleSystem = psHolder.GetComponent<ParticleSystem>();
            psHolder.SetActive(false);
            
        }

        private void Update()
        {
            movement();
        }

        void movement()
        {
            
            if(Input.GetMouseButton(0))
            {       
                mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1.616f));
                cleanerObj.transform.position = new Vector3(mousePos.x, mousePos.y, mousePos.z);
            
            }
            if (Input.GetMouseButtonDown(0))
            {
                psHolder.SetActive(true);
                particleSystem.Play();
                Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
                psHolder.transform.position = new Vector3(mousePos.x, mousePos.y - 0.09f, mousePos.z + 0.1f);
            }
                
        }
      
    }
}
