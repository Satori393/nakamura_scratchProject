using UnityEngine;

public class MoveToRandomPosition : MonoBehaviour
{
    [Header("�����_���ړ��̍ő�͈�")]
    public float rangeX = 10f;
    public float rangeY = 5f;
    public float rangeZ = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomPosition = CalculateRandomPosition();

            transform.position = randomPosition;
        }
    }

    private Vector3 CalculateRandomPosition()
    {

        float randomX = Random.Range(-rangeX, rangeX);
        float randomY = Random.Range(-rangeY, rangeY);
        float randomZ = Random.Range(-rangeZ, rangeZ);

        // �V����Vector3 (�ʒu) ���쐬���ĕԂ�
        return new Vector3(randomX, randomY, randomZ);
    }
}
