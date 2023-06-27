using System.Collections;
using UnityEngine;

public class MoveCube : MonoBehaviour, IManagerSave
{
    private float mouseX;
    private float mouseY;
    private Rigidbody character;

    private void Awake()
    {
        mouseX = 0f;
        mouseY = 0f;
        character = this.GetComponent<Rigidbody>();
        StartCoroutine(CheckPositionIsGood());
    }

    private void OnMouseDrag()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mouseX = Input.GetAxis("Mouse X") * 2000f;
        mouseY = Input.GetAxis("Mouse Y") * 2000f;
        character.AddForceAtPosition((transform.forward * mouseY + transform.right * mouseX) * Time.deltaTime, this.transform.position);
    }


    private void OnMouseUp()
    {
        Cursor.lockState = CursorLockMode.None;
    }


    private IEnumerator CheckPositionIsGood()
    {
        while (true)
        {
            if (this.transform.position.y <= -1f)
            {
                this.transform.position = Vector3.up;
            }
            yield return new WaitForSeconds(1f);
        }
    }

    public void DataSave(ref GameData gameData)
    {
        gameData.AddVectorToDictionary(gameData.CubePosition, this.transform.position);
        gameData.AddVectorToDictionary(gameData.ForceCube, this.GetComponent<Rigidbody>().velocity);
    }

    public void DataLoad(GameData gameData)
    {
        this.transform.position = gameData.DictionaryToVector(gameData.CubePosition);
        this.GetComponent<Rigidbody>().velocity = gameData.DictionaryToVector(gameData.ForceCube);
    }
}
