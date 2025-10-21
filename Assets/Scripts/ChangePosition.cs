using UnityEngine;

public class MoveToRandomPosition : MonoBehaviour
{
    [Header("ƒ‰ƒ“ƒ_ƒ€ˆÚ“®‚ÌÅ‘å”ÍˆÍ")]
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

        // V‚µ‚¢Vector3 (ˆÊ’u) ‚ğì¬‚µ‚Ä•Ô‚·
        return new Vector3(randomX, randomY, randomZ);
    }
}
