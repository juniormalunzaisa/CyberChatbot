using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CyberSecurityChatbot
{
    public class DatabaseHelper
    {
        private string connectionString = "server=localhost;user=root;password=YOUR_PASSWORD;database=chatbot_db;";

        public void AddTask(string title, string desc, string reminder)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO tasks (title, description, reminder, isCompleted) VALUES (@title, @desc, @reminder, false)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@reminder", reminder);

                cmd.ExecuteNonQuery();
            }
        }

        public List<TaskItem> GetTasks()
        {
            List<TaskItem> tasks = new List<TaskItem>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM tasks";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tasks.Add(new TaskItem
                    {
                        Title = reader["title"].ToString(),
                        Description = reader["description"].ToString(),
                        Reminder = reader["reminder"].ToString(),
                        IsCompleted = Convert.ToBoolean(reader["isCompleted"])
                    });
                }
            }

            return tasks;
        }
    }
}
