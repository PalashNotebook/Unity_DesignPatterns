using UnityEngine;

namespace com.palash.game
{
    public class BOT : MonoBehaviour
    {
        //------Private Fields
        private Material m_mat;
        private Color m_matCol;

        private void Awake()
        {
            m_mat = GetComponent<MeshRenderer>().material;
            m_matCol = m_mat.color;
        }

        void OnEnable()
        {
            Character.OnCharacterPressed += OnCharacterPressed;
        }

        void OnDisable()
        {
            Character.OnCharacterPressed -= OnCharacterPressed;
        }

        private void OnCharacterPressed()
        {
            m_matCol.r = Random.Range(0.0f, 1.0f);
            m_matCol.g = Random.Range(0.0f, 1.0f);
            m_matCol.b = Random.Range(0.0f, 1.0f);

            m_mat.color = m_matCol;
        }

    }
}
