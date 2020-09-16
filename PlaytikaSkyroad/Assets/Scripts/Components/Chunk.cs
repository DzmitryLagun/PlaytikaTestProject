using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlaytikaSkyroad
{
    public class Chunk : MonoBehaviour
    {
       public Transform NextChunkSpawnPoint { get { return _nextChunkSpawnPoint; } }

        [SerializeField]
        private List<Transform> _obstaclesPositions = null;
        [SerializeField]
        private Transform _nextChunkSpawnPoint = null;

        private void Start()
        {
            foreach (var obstaclesTransform in _obstaclesPositions)
            {
                var settingsInstance = SettingsManager.Instance;
                int randomindex = Random.Range(0, settingsInstance.ObstaclesPrefabs.Count);
                var obstaclesPrefab = settingsInstance.ObstaclesPrefabs[randomindex];

                var newObject = Instantiate(obstaclesPrefab);

                newObject.transform.position = obstaclesTransform.position;
                newObject.transform.rotation = obstaclesTransform.rotation;

                newObject.transform.SetParent(obstaclesTransform);
            }
        }
    }
}
