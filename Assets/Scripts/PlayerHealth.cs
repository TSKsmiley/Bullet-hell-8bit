using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField]private int health = 100;
        public Scrollbar hb;

        /// <summary>
        /// Changes the health by the given ammount
        /// </summary>
        public void ChangeHealth(int deltaHealth)
        {
            health += deltaHealth;
            if (health <= 0) die();
            hb.size = (float)health / 100;
        }

        /// <summary>
        /// Overrides the current health level
        /// </summary>
        public void SetHealth(int newHealth)
        {
            health = newHealth;
            if (health <= 0) die();
            hb.size = (float)health / 100;
        }

        /// <summary>
        /// Gets the current health level
        /// </summary> 
        public int GETHealth()
        {
            return health;
        }

        private void die()
        {
            // Restart the game
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}