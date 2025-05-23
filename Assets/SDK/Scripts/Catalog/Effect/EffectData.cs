﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#else
using TriInspector;
#endif

namespace ThunderRoad
{
    public class EffectData : CatalogData
    {
#if ODIN_INSPECTOR
        [BoxGroup("Group"), ValueDropdown(nameof(GetAllEffectGroupID))]
#endif
        public string groupId;
#if ODIN_INSPECTOR
        [BoxGroup("Group")]
#endif
        [NonSerialized]
        public EffectGroupData effectGroupData;
#if ODIN_INSPECTOR
        [BoxGroup("Group"), ShowInInspector, InlineButton("RefreshGroupParents")]
#endif
        [NonSerialized]
        public List<EffectGroupData> groupParents;

#if ODIN_INSPECTOR
        [BoxGroup("Audio")]
#endif
        public float volumeDb = 0;

#if ODIN_INSPECTOR
        [BoxGroup("Effects"), ShowInInspector]
#endif
        public List<EffectModule> modules = new List<EffectModule>();

#if ODIN_INSPECTOR
        public List<ValueDropdownItem<string>> GetAllEffectGroupID()
        {
            return Catalog.GetDropdownAllID(Category.EffectGroup);
        }
#endif

        public void RefreshGroupParents()
        {
        }

    }
}
