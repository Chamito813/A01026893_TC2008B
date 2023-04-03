/* 
Keep track of the points scored in the game

Samuel Acevedo
*/

using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text tmpObj;
    [SerializeField] int maxScore;
    //[SerializeField] CreateBalls creator;

    CreateBalls creator;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        creator = GetComponent<CreateBalls>();
        score = 0;
    }

    // Update is called once per frame
    public void AddPoints(int amount)
    {
        score += amount;
        tmpObj.text = "Score: " + score;
        //Debug.Log("New score: " + score);

        if(score==maxScore){
            Finish();
        }
    }

    void Finish(){
        creator.StopBalls();
        tmpObj.text += "\n\nYou Won!!!";
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene(){
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("FinalScene");
    }
}
