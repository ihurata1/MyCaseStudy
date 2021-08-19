using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simsoft.CaseStudyDependencyInversion.Unity
{
    public class RotateAround : MonoBehaviour
    {
        [SerializeField]
        [Range(25,100)]
        private int rotateSpeed = 50;
        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
        }
    }
}
