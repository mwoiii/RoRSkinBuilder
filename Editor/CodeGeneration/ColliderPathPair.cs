using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using RoRSkinBuilder.CustomEditors;

namespace RoRSkinBuilder
{
    [Serializable]
    public struct ColliderPathPair {
        [PathReference]
        public string prefabDynamicBonePath;

        [PathReference]
        public string modelDynamicBoneColliderPath;
    }
}
