using TMPro;
using UnityEngine;

public class lifeManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    private Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Life: " + player.hP;
    }
}
