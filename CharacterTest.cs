using UnityEngine;
using Assignment18;

public class CharacterTest : MonoBehaviour
{
    private void Start()
    {
        Character soldier = new Soldier();
        Character officer = new Officer("Captain Alex", 90, new Position(10, 20, 5));

        Character[] characters = { soldier, officer };
        foreach (Character character in characters)
        {
            character.DisplayInfo();
        }
        Debug.Log("\nOfficer attacks Soldier:");
        officer.Attack(30, soldier, "Shooting");
        soldier.DisplayInfo();
    }
}
