﻿using System.Collections.Generic;
using UnityEngine;

namespace Assets.net.kibotu.sandbox.unity.dragnslay.model
{
    class Registry : MonoBehaviour
    {
        public Dictionary<int, Orb> Orbs;

        private static Registry _instance;

        public static Registry Instance
        {
            get { return _instance ?? (_instance = new GameObject("Registry").AddComponent<Registry>()); }
        }
    }
}