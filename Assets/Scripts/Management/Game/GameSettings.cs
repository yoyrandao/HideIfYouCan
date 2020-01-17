﻿using System;

using UnityEngine;

namespace Scripts.Management.Game
{
    [Serializable]
    public sealed class GameSettings
    {
        public TimeSettings timeSettings = new TimeSettings();

        [Header("Roles Settings")]
        [Range(.0625f, 1f)] public float seekersToHidersRelation = .25f;
    }
}