﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SmokeScreen", 
    menuName = "Projectile/Smoke Screen Data", order = 1)]
public class SmokeScreenData : ScriptableObject
{
    [Header("Projectile Settings")]
    public float LifeTime;
    [Range(0,1)]
    public float startingOpacity = 1f;
    public Vector3 customScale = new Vector3(1,1,1);

    [Header("Variable Opacity Settings")]
    public bool variableOpacity = false;
    public AnimationCurve opacityOverLifetime;

}
