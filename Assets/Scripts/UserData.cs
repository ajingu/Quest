using UnityEngine;

[System.Serializable]
public class UserStatus
{
    public int id;
    public string name;
    public bool isPaid;
}

[CreateAssetMenu]
public class UserData : ScriptableObject
{
    public UserStatus[] userStatuses;
}
