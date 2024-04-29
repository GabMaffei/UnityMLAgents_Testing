using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{

    [Tooltip("The color when the flower is full")]
    public Color fullFlowerColor = Color.red;

    [Tooltip("The color when the flower is full")]
    public Color emptyFlowerColor = new Color(0.5f, 0f, 1f); //Purple

    [HideInInspector]
    public Collider nectarCollider;

    public Collider flowerCollider;

    public Material flowerMaterial;

    public Vector3 FlowerUpVector
    {
        get
        {
            return nectarCollider.transform.up;
        }
    }

    public Vector3 FlowerCenterPosition
    {
        get
        {
            return nectarCollider.transform.postion;
        }
    }

}
