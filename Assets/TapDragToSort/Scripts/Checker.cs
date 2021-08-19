using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Simsoft.CaseStudyDependencyInversion.Unity
{
    public class Checker : MonoBehaviour
    {   
        public bool isMatched = false;
        public Image [] types;
        // Start is called before the first frame update
        void check()
        {
            if(types[0].GetComponent<ItemSlot>().nameType.Equals(types[1].GetComponent<ItemSlot>().nameType) && !types[0].GetComponent<ItemSlot>().nameType.Equals("")){
                if (types[1].GetComponent<ItemSlot>().nameType.Equals(types[2].GetComponent<ItemSlot>().nameType))
                    if (types[2].GetComponent<ItemSlot>().nameType.Equals(types[3].GetComponent<ItemSlot>().nameType))
                        {
                            Debug.Log("Matched");
                            for(int i = 0; i<types.Length ; i++){
                                types[i].color = Color.green;
                                isMatched = true;
                            }
                        }
            }

            
        }

        // Update is called once per frame
        void Update()
        {
            check();
        }
    }
}
