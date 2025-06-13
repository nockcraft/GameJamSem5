using UnityEngine;
using Unity.VisualScripting;

public class AnimationEventBridge : MonoBehaviour
{
    public void PlayFootstep()
    {
        // Call Custom Event in Visual Scripting
        CustomEvent.Trigger(gameObject, "PlayFootstep");
    }
}
