using System;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    #region Variables

    public float lifeTime;
    public Vector3 positionDelta;

    public float currentLifeTime;

    #endregion


    #region Events

    public static event Action<Sphere> OnLifeTimeExpired;

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        currentLifeTime = lifeTime;
    }

    private void Update()
    {
        UpdateLifeTime(Time.deltaTime);
        Move(Time.deltaTime);
    }

    #endregion


    #region Private methods

    private void UpdateLifeTime(float deltaTime)
    {
        currentLifeTime -= deltaTime;

        if (currentLifeTime <= 0)
        {
            OnLifeTimeExpired?.Invoke(this);
        }
    }

    private void Move(float deltaTime)
    {
        transform.position += positionDelta * deltaTime;
    }

    #endregion
}
