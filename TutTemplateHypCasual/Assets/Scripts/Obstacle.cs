using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
   public float speed = 10f;
   public TMP_Text text;

   private void Start() {
    text = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
   }

   private void Update() {
    transform.Translate(Vector3.back * speed * Time.deltaTime);
   }

   private void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.name == "Player") 
    {
      Destroy(collision.gameObject);
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    if (collision.gameObject.name == "Out") 
    {
      int newScore = int.Parse(text.text) + 1;
      text.text = newScore.ToString();
      Destroy(gameObject);
    }
   }

}
