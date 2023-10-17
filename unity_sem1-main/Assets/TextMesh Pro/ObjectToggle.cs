using UnityEngine;
using UnityEngine.UI;

public class ObjectToggle : MonoBehaviour
{
    public GameObject objectToToggle; // Объект, который нужно активировать/деактивировать
    public Text buttonText; // Текст на кнопке

    private bool isObjectActive = true;

    private void Start()
    {
        // При запуске игры установим начальное состояние объекта и текст на кнопке
        ToggleObject();
    }

    public void ToggleObject()
    {
        // Изменяем состояние объекта
        isObjectActive = !isObjectActive;

        // Активируем/деактивируем объект в зависимости от состояния
        objectToToggle.SetActive(isObjectActive);

        // Изменяем текст на кнопке
        buttonText.text = isObjectActive ? "Выключить объект" : "Включить объект";
    }
}
