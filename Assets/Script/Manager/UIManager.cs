using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    private void Awake()
    {
        #region 싱글톤
        if (instance == null) instance = this;
        else if (instance != null) return;
        #endregion
    }

    public HealthBar healthBar;
}
