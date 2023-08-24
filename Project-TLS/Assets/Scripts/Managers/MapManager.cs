using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public void LoadMap(string name)
    {
        SceneManager.LoadScene(name);
    }
}
