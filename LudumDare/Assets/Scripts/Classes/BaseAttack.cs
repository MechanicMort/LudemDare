using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseAttack : MonoBehaviour {

    public string AttackName;

    public float Damage;
    public float Cost;

    public GameObject myProjectile;
    public Sprite UIElement;

}
