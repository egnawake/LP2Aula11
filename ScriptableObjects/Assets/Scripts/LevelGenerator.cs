using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private LevelSpec levelSpec;

    private void Awake()
    {
        foreach (Vector2 pos in levelSpec.EnemySpawnPoints)
        {
            Instantiate(enemyPrefab, pos, Quaternion.identity);
        }

        Camera.main.backgroundColor = levelSpec.BackgroundColor;
    }
}
