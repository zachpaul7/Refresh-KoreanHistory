using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP_Controller : MonoBehaviour
{
    [SerializeField] private Image[] lifeImages;

    public void UpdateLifeIcon(int life)
    {
        for (int index = 0; index < lifeImages.Length; index++)
        {
            lifeImages[index].color = new Color(1, 1, 1, 0);
        }

        for (int index = 0; index < life; index++)
        {
            lifeImages[index].color = new Color(1, 1, 1, 1);
        }
    }
}
