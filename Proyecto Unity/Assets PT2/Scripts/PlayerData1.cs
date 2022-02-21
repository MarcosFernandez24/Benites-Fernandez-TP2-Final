using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/PlayerData", fileName = "PlayerData", order = 0)]
public class PlayerData1 : ScriptableObject
{
    public LayerMask InteractableLayerMask;

    public float InteractionRadius;

    public KeyCode InteractionKey;

    public int MaxHealth;

    public float Speed;

    public string Name;
}
