using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    [Header("跳ねる高さ")]public float boundHeight;
    [HideInInspector]public bool playerStepOn; //踏んづけたか

}
