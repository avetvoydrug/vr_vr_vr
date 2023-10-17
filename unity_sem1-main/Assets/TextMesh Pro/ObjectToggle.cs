using UnityEngine;
using UnityEngine.UI;

public class ObjectToggle : MonoBehaviour
{
    public GameObject objectToToggle; // ������, ������� ����� ������������/��������������
    public Text buttonText; // ����� �� ������

    private bool isObjectActive = true;

    private void Start()
    {
        // ��� ������� ���� ��������� ��������� ��������� ������� � ����� �� ������
        ToggleObject();
    }

    public void ToggleObject()
    {
        // �������� ��������� �������
        isObjectActive = !isObjectActive;

        // ����������/������������ ������ � ����������� �� ���������
        objectToToggle.SetActive(isObjectActive);

        // �������� ����� �� ������
        buttonText.text = isObjectActive ? "��������� ������" : "�������� ������";
    }
}
