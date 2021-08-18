using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Simsoft.CaseStudyDependencyInversion.Unity
{
    public class Spawner : MonoBehaviour
    {
        private Vector3 SpawnPos;
        public GameObject spawnObject;
        private float newSpawnDuration = 1f;

       

        public static Spawner Instance;

        private void Awake()
        {
            Instance = this;
        }


        private void Start()
        {
            SpawnPos = transform.position;
            SpawnNewObject();
        }

        void SpawnNewObject()
        {
            Instantiate(spawnObject, SpawnPos, Quaternion.identity);
        }

        public void NewSpawnRequest()
        {
            Invoke("SpawnNewObject", newSpawnDuration);
        }

    }
}
