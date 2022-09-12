using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    [SerializeField] private GameObject questGiverText;
    [SerializeField] private Text textComponent;
    [SerializeField] private int amountToDo = 1;
    [SerializeField] private string questBeginText;
    [SerializeField] private string questCompleteText;
    [SerializeField] private GameObject doorToOpenWhenQuestIsComplete;
    [SerializeField] private GameObject doorToCloseAtStart;
    void Start()
    {
        questGiverText.SetActive(false);
        textComponent.text = questBeginText;
        doorToCloseAtStart.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {

            if (collision.GetComponent<PlayerState>().itemAmount >= amountToDo)
            {
                textComponent.text = questCompleteText;
                collision.GetComponent<PlayerQuest>().isQuestComplete = true;
                doorToOpenWhenQuestIsComplete.SetActive(false);
                doorToCloseAtStart.SetActive(true);
            }
            else
            {
                textComponent.text = questBeginText;
            }

            questGiverText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            questGiverText.SetActive(false);
        }
    }
}
