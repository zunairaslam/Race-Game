using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float countDownTimer = 3f;

    public PlayerCarController PlayerCarController;
    public OpponentCar OpponentCar;
    public OpponentCar OpponentCar1;
    public OpponentCar OpponentCar2;
    public OpponentCar OpponentCar3;
    public OpponentCar OpponentCar4;

    public TMP_Text countDownText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimerCount());
    }

    // Update is called once per frame
    void Update()
    {
        if (countDownTimer > 1)
        {
            PlayerCarController.aForce = 0f;
            OpponentCar.movingSpeed = 0f;
            OpponentCar1.movingSpeed = 0f;
            OpponentCar2.movingSpeed = 0f;
            OpponentCar3.movingSpeed = 0f;
            OpponentCar4.movingSpeed = 0f;
        }
        else if (countDownTimer == 0)
        {
            PlayerCarController.aForce = 300f;
            OpponentCar.movingSpeed = 13f;
            OpponentCar1.movingSpeed = 14f;
            OpponentCar2.movingSpeed = 12f;
            OpponentCar3.movingSpeed = 09f;
            OpponentCar4.movingSpeed = 8f;
        }
    }

    IEnumerator TimerCount()
    {
        while (countDownTimer > 0)
        {
            countDownText.text = countDownTimer.ToString();
            yield return new WaitForSeconds(1f);
            countDownTimer--;
        }
        countDownText.text = "Go";
        yield return new WaitForSeconds(1f);
        countDownText.gameObject.SetActive(false);
    }
}
