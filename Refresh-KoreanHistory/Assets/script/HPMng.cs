using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPMng : MonoBehaviour
{
    public Image Heart_0;
    public Image Heart_1;
    public Image Heart_2;
    public Image Heart_3;
    public Image Heart_4;

    public Sprite FullHeart;
    public Sprite HalfHeart;
    public Sprite EmptyHeart;

    public playerCtrl Ctr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float life = Ctr.life;

        switch (life)
        {
            case 10:
                Heart_0.sprite = FullHeart;
                Heart_1.sprite = FullHeart;
                Heart_2.sprite = FullHeart;
                Heart_3.sprite = FullHeart;
                Heart_4.sprite = FullHeart;
                break;
            case 9:
                Heart_0.sprite = HalfHeart;
                Heart_1.sprite = FullHeart;
                Heart_2.sprite = FullHeart;
                Heart_3.sprite = FullHeart;
                Heart_4.sprite = FullHeart;
                break;
            case 8:
                Heart_0.sprite = EmptyHeart;
                Heart_1.sprite = FullHeart;
                Heart_2.sprite = FullHeart;
                Heart_3.sprite = FullHeart;
                Heart_4.sprite = FullHeart;
                break;
            case 7:
                Heart_0.sprite = EmptyHeart;
                Heart_1.sprite = HalfHeart;
                Heart_2.sprite = FullHeart;
                Heart_3.sprite = FullHeart;
                Heart_4.sprite = FullHeart;
                break;
            case 6:
                Heart_0.sprite = EmptyHeart;
                Heart_1.sprite = EmptyHeart;
                Heart_2.sprite = FullHeart;
                Heart_3.sprite = FullHeart;
                Heart_4.sprite = FullHeart;
                break;
            case 5:
                Heart_0.sprite = EmptyHeart;
                Heart_1.sprite = EmptyHeart;
                Heart_2.sprite = HalfHeart;
                Heart_3.sprite = FullHeart;
                Heart_4.sprite = FullHeart;
                break;
            case 4:
                Heart_0.sprite = EmptyHeart;
                Heart_1.sprite = EmptyHeart;
                Heart_2.sprite = EmptyHeart;
                Heart_3.sprite = FullHeart;
                Heart_4.sprite = FullHeart;
                break;
            case 3:
                Heart_0.sprite = EmptyHeart;
                Heart_1.sprite = EmptyHeart;
                Heart_2.sprite = EmptyHeart;
                Heart_3.sprite = HalfHeart;
                Heart_4.sprite = FullHeart;
                break;
            case 2:
                Heart_0.sprite = EmptyHeart;
                Heart_1.sprite = EmptyHeart;
                Heart_2.sprite = EmptyHeart;
                Heart_3.sprite = EmptyHeart;
                Heart_4.sprite = FullHeart;
                break;
            case 1:
                Heart_0.sprite = EmptyHeart;
                Heart_1.sprite = EmptyHeart;
                Heart_2.sprite = EmptyHeart;
                Heart_3.sprite = EmptyHeart;
                Heart_4.sprite = HalfHeart;
                break;
            case 0:
                Heart_0.sprite = EmptyHeart;
                Heart_1.sprite = EmptyHeart;
                Heart_2.sprite = EmptyHeart;
                Heart_3.sprite = EmptyHeart;
                Heart_4.sprite = EmptyHeart;
                break;
            default:
                break;
        }

    }
}
