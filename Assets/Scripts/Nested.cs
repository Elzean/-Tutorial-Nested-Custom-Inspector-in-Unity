using UnityEngine;

[CreateAssetMenu(menuName="Create Character", fileName="Character")]
public class Nested : ScriptableObject 
{
    public string characterName;
    public int level;
    public int life;
}
