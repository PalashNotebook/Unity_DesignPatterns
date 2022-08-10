using UnityEngine;

namespace com.palash.game {
    public class Character : MonoBehaviour
    {
        //------Internal Fields 
        internal delegate void CharacterPressed();
        internal static event CharacterPressed OnCharacterPressed;

        private void OnMouseDown()
        {
            OnCharacterPressed?.Invoke();
        }
    }
}
