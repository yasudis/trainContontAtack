using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    GameObject player;
    float moveSpeed = 10f;
    Vector3 cameraPositionOfPlayer;
    Vector3 cameraRotationOfOlayer;
    Quaternion startRotation;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        startRotation=transform.localRotation;
    }
    private void Update()
    {
        cameraPositionOfPlayer = new Vector3(player.transform.position.x, player.transform.position.y + 24, player.transform.position.z - 20);

        if (Input.GetMouseButtonDown(0))
        {
            ShakeCamera(0.5f, 1f, 20f);
        }
        transform.position = Vector3.MoveTowards(transform.position, cameraPositionOfPlayer, moveSpeed * Time.deltaTime);
        transform.rotation = startRotation;

    }


    public void ShakeCamera(float duration, float magnitude, float noize)//� ������� ������ ������� ����� �������� �������� ����� ������� ������
    {
        //��������� �������� ��������
        StartCoroutine(ShakeCameraCor(duration, magnitude, noize));
    }

    //������������ ������� � ������ ���������� ��������
    //���� �������������� ����������� �������, ��������� ������� Update
    //������� ����� ����� �������� �� ��������� � ����� ������
    private IEnumerator ShakeCameraCor(float duration, float magnitude, float noize)
    {
        //�������������� ��������� ���������� �������
        float elapsed = 0f;
        //��������� ��������� ��������� �������
        Vector3 startPosition = transform.localPosition;
        //���������� ��� ����� �� "��������" ���� �������
        Vector2 noizeStartPoint0 = Random.insideUnitCircle * noize;
        Vector2 noizeStartPoint1 = Random.insideUnitCircle * noize;

        //��������� ��� �� ��� ��� ���� �� �������� �����
        while (elapsed < duration)
        {
            //���������� ��� ��������� ���������� �� �������� ������� � ����������� �� ���������� �������
            Vector2 currentNoizePoint0 = Vector2.Lerp(noizeStartPoint0, Vector2.zero, elapsed / duration);
            Vector2 currentNoizePoint1 = Vector2.Lerp(noizeStartPoint1, Vector2.zero, elapsed / duration);
            //������ ����� ������ ��� ������ � �������� � �� ����� ���� ������ �������� �������
            Vector2 cameraPostionDelta = new Vector2(Mathf.PerlinNoise(currentNoizePoint0.x, currentNoizePoint0.y), Mathf.PerlinNoise(currentNoizePoint1.x, currentNoizePoint1.y));
            cameraPostionDelta *= magnitude;

            //���������� ������ � ����� ����������
            transform.localPosition = startPosition + (Vector3)cameraPostionDelta;

            //����������� ������� ���������� �������
            elapsed += Time.deltaTime;
            //���������������� ���������� ��������, � ��������� ����� ��� ��������� ���������� � ������ �����
            yield return null;
        }
        //�� ���������� ��������, ���������� ������ � �������� �������
       transform.localPosition = startPosition;
    }
}
