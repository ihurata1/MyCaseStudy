using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simsoft.CaseStudyDependencyInversion.Unity
{
    public class DrawTrajectory : MonoBehaviour
    {
        [SerializeField]
        private LineRenderer _lineRenderer;
            
        [SerializeField]
        [Range(3, 30)]
        private int _lineSegmentCount = 20;

        [SerializeField]
        [Range(30, 70)]
        private float drawPowerRatio = 50f; 

        private List<Vector3> _linePoints = new List<Vector3>();

        public static DrawTrajectory Instance;

        private void Awake()
        {
            Instance = this;
        }

        public void UpdateTrajectory(Vector3 forceVector, Rigidbody rigidbody, Vector3 startingPoint)
        {
            Vector3 velocity = (forceVector / rigidbody.mass) * Time.fixedDeltaTime; // V = (F/m) * Delta Time 

            _linePoints.Clear();

            for (int i = 0; i < _lineSegmentCount; i++)
            {
                Vector3 movementVector = new Vector3(
                    x: velocity.x * -(i/drawPowerRatio),
                    y: 0,
                    z: velocity.y * -(i/drawPowerRatio)
                );
                
                _linePoints.Add(item: -movementVector + startingPoint);
            }
            _lineRenderer.positionCount = _linePoints.Count;
            _lineRenderer.SetPositions(_linePoints.ToArray());
        }

        public void HideLine()
        {
            _lineRenderer.positionCount = 0;
        }
    }
}
