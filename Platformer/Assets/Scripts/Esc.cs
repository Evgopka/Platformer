using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnEscape : MonoBehaviour
{
    public string Menu;

    private void Update()
    {
        // Проверяем, была ли нажата кнопка ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Загружаем указанную сцену
            SceneManager.LoadScene(Menu);
        }
    }
}
