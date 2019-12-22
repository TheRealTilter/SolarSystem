using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVar : MonoBehaviour {

    public static bool mainCameraActive = true;
    public static bool inGame = false;

    public static bool getInGame() {
        return inGame;
    }
    public static void SetInGame(bool state) {
        inGame = state;
    }
}
