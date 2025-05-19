using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

// Manages login information from VR devices and sends it to the server.
public class LoginManager : MonoBehaviour
{
    public string groupId;
    public string deviceId;
    public string userName;
    public string serverUrl = "http://localhost:9000"; // Example server URL

    public void SendLogin()
    {
        string data = $"{groupId},{deviceId},{userName}";
        StartCoroutine(PostLogin(data));
    }

    private IEnumerator PostLogin(string data)
    {
        var request = new UnityWebRequest(serverUrl, "POST");
        byte[] body = System.Text.Encoding.UTF8.GetBytes(data);
        request.uploadHandler = new UploadHandlerRaw(body);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "text/plain");
        yield return request.SendWebRequest();
        Debug.Log("Login sent to server: " + data);
    }
}
