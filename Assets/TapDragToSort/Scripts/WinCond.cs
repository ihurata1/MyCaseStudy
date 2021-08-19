using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simsoft.CaseStudyDependencyInversion.Unity
{
    public class WinCond : MonoBehaviour
    {
        public GameObject [] allSlotsChecker;
        private int winCounter;
        // Start is called before the first frame update
        void check()
        {
            winCounter = 0;
            for(int i = 0; i<allSlotsChecker.Length; i++){
                if(allSlotsChecker[i].GetComponent<Checker>().isMatched){
                    winCounter++;
                }
            }

            if(winCounter>= 3){
                Camera.main.GetComponent<Camera>().backgroundColor = Color.green;
            }

                

        }

        // Update is called once per frame
        void Update()
        {
            check();
        }
    }
}
