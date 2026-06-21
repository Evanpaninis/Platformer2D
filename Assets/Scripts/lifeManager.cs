using UnityEngine;
using UnityEngine.UI;

public class lifeManager : MonoBehaviour
{
    [SerializeField] Text text;
    private Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "HP: " + player.hP;
    }
}
