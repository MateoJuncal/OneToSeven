using UnityEngine;

public class NPCHealth : CharacterCollisionHandler
{
    protected override void OnSpikeCollision(Spikes spikes)
    {
        Debug.Log("Npc has collided");
        base.OnSpikeCollision(spikes);
    }
}
