using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Application.UI
{
    public class InGameMenu : MonoBehaviour
    {
        public void RestartScene()
        {
            SceneManager.LoadScene(0);
        }
    }

}
