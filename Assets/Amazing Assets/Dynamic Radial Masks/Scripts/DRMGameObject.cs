﻿using UnityEngine;


namespace AmazingAssets.DynamicRadialMasks
{
    //[ExecuteAlways]
    public class DRMGameObject : MonoBehaviour
    {
        public float radius = 5;
        [HideInInspector] public float intensity = 1;
        [HideInInspector] public float noiseStrength = 0;
        [HideInInspector] [Min(0f)] public float edgeSize = 1;
        [HideInInspector] public int ringCount = 3;
        [HideInInspector] public float frequency = 10;
        [HideInInspector] public float phaseSpeed = 2;
        [HideInInspector] public float currentPhase = 0;
        [HideInInspector] [Min(0.001f)] public float smooth = 1;

        [SerializeField] private GameObject audioSyncScale;
        [SerializeField] private bool play = false;
        

#if UNITY_EDITOR
        [HideInInspector] public bool displayAllProperties = true;
        [HideInInspector] public DynamicRadialMasks.Enum.MaskShape maskShape;
#endif


        void Start()
        {
            currentPhase = 0;
        }

        void Update()
        {
            if(play)
                this.radius = audioSyncScale.GetComponent<AudioSyncScale>().radius * 0.3f;
            currentPhase += Time.deltaTime * phaseSpeed;
        }
    }
}