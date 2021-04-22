using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereHandler : MonoBehaviour
{
    #region Unity lifecycle

    private void Start()
    {
        Sphere.OnLifeTimeExpired += DestroySphere;
    }

    #endregion


    #region Private methods

    private void DestroySphere(Sphere sphere)
    {
        Destroy(sphere.gameObject);
    }

    #endregion
}
