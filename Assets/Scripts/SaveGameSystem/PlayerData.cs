using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerData 
{
    public int health;
    public int points;
    public int starPoints;
    public float[] position;


    public PlayerData(PointsManager player)
    {
        //health = player.HP;
        points = player.Points;
        starPoints = player.StarPoints;
        
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
        
        /*
         W poradniku to wszystko było w skrypcie Player, on przechowywał dane: health, level, score, ale ja nie wiem czy u nas jest taki skrypt a mamy kilka co za to odpowiadają. 
         Może warto by zrobić jeszcze jeden skrypt, który przechowywał by to wszystko w jednym miejscu, chyba że tym skryptem jeest GameManager.
        public void SavePlayer()
        {
            SaveSystem.SavePlayer(this);
        }

        public void LoadPlayer()
        {
            PlayerData data = SaveSystem.loadPlayer();

            //health = player.HP;
            points = player.Points;
            starPoints = player.StarPoints;

            Vector3 position;
            position.x = data.position[0];
            position.y = data.position[1];
            position.z = data.position[2];
            transform.position = position;
        }*/
    }
}
