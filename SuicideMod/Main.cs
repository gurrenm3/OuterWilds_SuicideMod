using OWML.ModHelper;
using UnityEngine.InputSystem;

namespace SuicideMod
{
    public class Main : ModBehaviour
    {
        private void Update()
        {
            if (!Keyboard.current[Key.K].wasPressedThisFrame)
                return;

            FindObjectOfType<DeathManager>()?.KillPlayer(DeathType.Default);
        }
    }
}