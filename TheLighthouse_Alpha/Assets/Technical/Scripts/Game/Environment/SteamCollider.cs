using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamCollider : MonoBehaviour
{
    public int NarrativeCue;

    private void OnCollisionEnter(Collision other) {
        var player = other.gameObject.GetComponent<Player.PlayerManager>();
        if (player is Player.PlayerManager) {
            NarrativeController.instance.TriggerNarrative(NarrativeCue);
        }
    }
}
