﻿
using UnityEngine;
namespace Environment
{
    public class ExamineObjectData : MonoBehaviour
    {
        public string ObjectName = "";
        public string ObjectDescription = "";
        public Transform ObjectMesh;
        public Vector3 StartingRotation = new Vector3 (-90, 0, 0);
        public Vector3 PositionOffset;
    }
}