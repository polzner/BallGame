using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableWithChance : MonoBehaviour
{
    [Range(0, 1)]
    [SerializeField] private float _stayChance = 0.5f;

    private void OnEnable()
    {
        if (Random.value > _stayChance)
            this.gameObject.SetActive(false);
    }
}
