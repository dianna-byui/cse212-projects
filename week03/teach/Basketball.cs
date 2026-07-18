/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData) {
            var fields = reader.ReadFields()!;
            var playerId = fields[0]; 
            var points = int.Parse(fields[8]);

            if (players.ContainsKey(playerId))
            {
                int value = players[playerId];
                players[playerId] = value + points;
            }
            else
            {
                players.Add(playerId, points);
            }
        }

        KeyValuePair<string, int>[] totals = players.ToArray();

        for (int i = 0; i < totals.Length - 1; i++)
        {
            for (int j = i + 1; j < totals.Length; j++)
            {
                if (totals[j].Value > totals[i].Value)
                {
                    KeyValuePair<string, int> temp = totals[i];
                    totals[i] = totals[j];
                    totals[j] = temp;
                }
            }
        }
        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{totals[i].Key} : {totals[i].Value}");
        }

        var topPlayers = new string[10];
    }
}