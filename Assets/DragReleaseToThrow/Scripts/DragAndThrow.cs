using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Simsoft.CaseStudyDependencyInversion.Unity
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Collider))]

    public class DragAndThrow : MonoBehaviour
    {
        private Vector3 mouseDownPos;
        private Vector3 mouseReleasePos;
        private Vector3 forceInit;

        private Rigidbody rb;

        private bool isThrowable;

        public bool dragBackToThrow = true;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void OnMouseDown()
        {
            mouseDownPos = Input.mousePosition;
        }

        private void OnMouseDrag()
        {

            if(dragBackToThrow)
                forceInit = (mouseDownPos - Input.mousePosition);
            else
                forceInit = (Input.mousePosition - mouseDownPos);
                
            Vector3 forceV = (new Vector3(
                forceInit.x,
                forceInit.y,
                forceInit.y
            ) * forceMultiplier);

            if (!isThrowable)
                DrawTrajectory.Instance.UpdateTrajectory(
                forceVector: forceV,
                rigidbody: rb,
                startingPoint: transform.position
                );

        }

        private void OnMouseUp()
        {
            mouseReleasePos = Input.mousePosition;

            if(dragBackToThrow)
                Throw(mouseDownPos - mouseReleasePos);
            else
                Throw(mouseReleasePos - mouseDownPos);

        }

        private float forceMultiplier = 3;

        private void Throw(Vector3 Force)
        {
            if (isThrowable) return;

            rb.AddForce(new Vector3(x: Force.x, y: 0, z: Force.y) * forceMultiplier);

            ObjSpawner();
        }

        void ObjSpawner()
        {
            isThrowable = true;
            Spawner.Instance.NewSpawnRequest();
        }



    }
}
