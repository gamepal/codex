using UnityEngine;

// Simple placeholder script for updating other players' positions.
public class PlayerSync : MonoBehaviour
{
    // Called when the server reports another player's position
    public void UpdatePlayerPosition(string playerId, Vector3 position)
    {
        // TODO: update avatar or object representing the other player
    }
}
