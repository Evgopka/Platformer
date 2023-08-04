using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjectOnGrid : MonoBehaviour
{
    public GameObject objectPrefab; // Ссылка на префаб объекта
    public float gridStep = 0.5f; // Шаг сетки

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 clickPosition = GetMouseWorldPosition();
            Vector3 alignedPosition = AlignToGrid(clickPosition);
            alignedPosition.z = 10; // Устанавливаем Z-координату на 10
            Instantiate(objectPrefab, alignedPosition, Quaternion.identity);
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }

    private Vector3 AlignToGrid(Vector3 position)
    {
        Vector3 alignedPosition = Vector3.zero; // Инициализируем переменную
        alignedPosition.x = Mathf.Round(position.x / gridStep) * gridStep;
        alignedPosition.y = Mathf.Round(position.y / gridStep) * gridStep;
        return alignedPosition;
    }
}
