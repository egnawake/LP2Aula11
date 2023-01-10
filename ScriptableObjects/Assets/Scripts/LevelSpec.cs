using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="LevelSpec")]
public class LevelSpec : ScriptableObject
{
    [SerializeField] private Vector2[] enemySpawnPoints = null;
    [SerializeField] private Color backgroundColor;
    
    public IEnumerable<Vector2> EnemySpawnPoints => enemySpawnPoints;
    public Color BackgroundColor => backgroundColor;
}
