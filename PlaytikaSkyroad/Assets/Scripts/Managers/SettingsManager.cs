using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlaytikaSkyroad
{
    public class SettingsManager : MonoBehaviour
    {
        public static SettingsManager Instance = null;

        [SerializeField]
        public float ShipSpeed = 2.0f;
        [SerializeField]
        public List<Chunk> ChunkPrefabs = null;
        [SerializeField]
        public List<GameObject> ObstaclesPrefabs = null;

        [SerializeField]
        public int ChunksAheadCount = 15;
        [SerializeField]
        public int ChunksBehindcount = 5;

        private void Start()
        {
            Instance = this;
        }
    }
}