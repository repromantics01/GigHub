using GigHubLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using System.Reflection;

namespace GigHubLibrary
{
    public class SQLConnector : IDataConnection
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R83M1NS;Initial Catalog=GigHub;Integrated Security=True");

        /// <summary>
        /// Saves a new user to the database
        /// </summary>
        /// <param name="model">The user information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        /// 

        public UserModel CreateUser(UserModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GigHub")))
            {
                var p = new DynamicParameters();
                p.Add("@firstName", model.FirstName);
                p.Add("@lastName", model.LastName);
                p.Add("@username", model.Username);
                p.Add("@email", model.EmailAddress);
                p.Add("@password", model.Password);
                p.Add("@messengerLink", model.MessengerLink);
                p.Add("@contactNo", model.PhoneNumber);
                p.Add("@user_type", model.UserType.ToString());
                p.Add("@date_created", model.DateCreated);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.sp_InsertUsers", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id"); //gets id attribute of p

                return model;
            }
        }
        // TODO - add updateUser class that updates user info and connect it to sql

        public GigModel CreateGig(GigModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GigHub")))
            {
                var p = new DynamicParameters();
                p.Add("@title", model.GigTitle);
                p.Add("@description", model.Description);
                p.Add("@location", model.Location);
                p.Add("@type", model.Type.ToString());
                p.Add("@start_date", model.StartDate);
                p.Add("@end_date", model.EndDate);
                p.Add("@rate", model.Rate);
                p.Add("@status", model.Status.ToString());
                p.Add("gigPoster_id", model.gigPoster);
                p.Add("@date_created", model.DateCreated);
                p.Add("@skills_required", model.SkillsRequired);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.InsertGigs_2", p, commandType: CommandType.StoredProcedure);
                model.GigID = p.Get<int>("@id"); //gets id attribute of p

                return model;
            }
        }

        public UserModel GetUserById(int userId)
        {
            using (var connection = new SqlConnection(@"Data Source=DESKTOP-R83M1NS;Initial Catalog=GigHub;Integrated Security=True"))
            {
                connection.Open();

                // Define a SQL query to retrieve user data based on ID
                var sql = "SELECT * FROM Users WHERE id ='"+ userId+"'";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", userId); 

                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read(); 
                                       
                        // Map the retrieved data from the data reader to a UserModel object
                        string temp = reader["date_created"].ToString();
                        DateTime parsedDate = DateTime.Parse(temp);

                        return new UserModel
                        {
                            Id = Convert.ToInt32(reader["id"]), 
                            FirstName = reader["firstName"].ToString(),
                            LastName = reader["lastName"].ToString(),
                            Username = reader["username"].ToString(),
                            EmailAddress = reader["email"].ToString(),
                            Password = reader["password"].ToString(),
                            MessengerLink = reader["messengerLink"].ToString(),
                            PhoneNumber = reader["contactNo"].ToString(),
                            UserType = (UserType)Enum.Parse(typeof(UserType),reader["user_type"].ToString(),true),
                            DateCreated = parsedDate
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public List<GigModel> GetGigsPostedByID(int userId)
        {
            List<GigModel> userGigs = new List<GigModel>();
            using (var connection = new SqlConnection(@"Data Source=DESKTOP-R83M1NS;Initial Catalog=GigHub;Integrated Security=True"))
            {
                connection.Open();

                // Define a SQL query to retrieve gig data based on ID
                var sql = "SELECT * FROM Gigs WHERE gigPoster_id ='" + userId + "'";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@gigPoster_id", userId);

                    var reader = command.ExecuteReader();
                    try
                    {
                        while (reader.HasRows)
                        {
                            reader.Read();

                            //Convert string to date only
                            string dC = reader["date_created"].ToString();
                            DateTime parseddC = DateTime.Parse(dC);

                            string sDate = reader["start_date"].ToString();
                            DateTime sDateParsed = DateTime.Parse(sDate);

                            string eDate = reader["end_date"].ToString();
                            DateTime eDateParsed = DateTime.Parse(eDate);

                            GigModel gig = new GigModel
                            {
                                GigID = Convert.ToInt32(reader["id"]),
                                GigTitle = reader["title"].ToString(),
                                Description = reader["description"].ToString(),
                                Location = reader["location"].ToString(),
                                Type = (GigType)Enum.Parse(typeof(GigType), reader["type"].ToString(), true),
                                StartDate = sDateParsed,
                                EndDate = eDateParsed,
                                Rate = Convert.ToDecimal(reader["rate"]),
                                Status = (GigStatus)Enum.Parse(typeof(GigStatus), reader["status"].ToString(), true),
                                gigPoster = userId,
                                DateCreated = parseddC,
                                SkillsRequired = reader["skills_required"].ToString() 
                            };
                            userGigs.Add(gig);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error retrieving user gigs: " + e.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return userGigs;
        }

        public bool UpdatesGig(GigModel gig)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R83M1NS;Initial Catalog=GigHub;Integrated Security=True");
            try
            {
                conn.Open();

                String query = "UPDATE dbo.Gigs SET title = '"+gig.GigTitle+"', description = '"+ gig.Description+"', start_date = '"+gig.StartDate+"', end_date = '"+gig.EndDate+"' , skills_required = '"+gig.SkillsRequired+"', rate = '"+gig.Rate+"', type = '"+gig.Type+"' , status = '" + gig.Status + "', location = '" + gig.Location + "' WHERE id = '" +gig.GigID+"'";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@title", gig.GigTitle);
                cmd.Parameters.AddWithValue("@description", gig.Description);
                cmd.Parameters.AddWithValue("@start_date", gig.StartDate);
                cmd.Parameters.AddWithValue("@end_date", gig.EndDate);
                cmd.Parameters.AddWithValue("@skills_required", gig.SkillsRequired);
                cmd.Parameters.AddWithValue("@rate", gig.Rate);
                cmd.Parameters.AddWithValue("@type", gig.Type);
                cmd.Parameters.AddWithValue("@status", gig.Status);
                cmd.Parameters.AddWithValue("@location", gig.Location);

                int rowsAffected = cmd.ExecuteNonQuery();
      
                return rowsAffected > 0; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating gig: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool UpdatesUser(UserModel user)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R83M1NS;Initial Catalog=GigHub;Integrated Security=True");
            try
            {
                conn.Open();

                String query = "UPDATE dbo.Users SET firstName = '" + user.FirstName + "', lastName = '" + user.LastName + "', username= '" + user.Username + "', email= '" + user.EmailAddress + "' , password = '" + user.Password + "', messengerLink = '" + user.MessengerLink + "', contactNo = '" + user.PhoneNumber + "' , user_type = '" + user.UserType + "', date_created  = '" + user.DateCreated + "' WHERE id = '" + user.Id + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                cmd.Parameters.AddWithValue("@lastName", user.LastName);    
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@email", user.EmailAddress);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@messengerLink", user.MessengerLink);
                cmd.Parameters.AddWithValue("@contactNo", user.PhoneNumber);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;  // Update successful if at least one row affected
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating user: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool DeletesGig(int gigId)
        {
            try
            {
                conn.Open();

                String query = "DELETE FROM Gigs WHERE id = '"+gigId+"'";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", gigId);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;  // Deletion successful if at least one row affected
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting gig: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        

        public List<GigModel> GetGigsInDatabase()
        {
            List<GigModel> userGigs = new List<GigModel>();
            using (var connection = new SqlConnection(@"Data Source=DESKTOP-R83M1NS;Initial Catalog=GigHub;Integrated Security=True"))
            {
                connection.Open();

                // Define a SQL query to retrieve gig data based on ID
                var sql = "SELECT * FROM Gigs";
                using (var command = new SqlCommand(sql, connection))
                {
                    var reader = command.ExecuteReader();
                    try
                    {
                        while (reader.HasRows)
                        {
                            reader.Read();

                            //Conveert string to date only
                            string dC = reader["date_created"].ToString();
                            DateTime parseddC = DateTime.Parse(dC);

                            string sDate = reader["start_date"].ToString();
                            DateTime sDateParsed = DateTime.Parse(sDate);

                            string eDate = reader["end_date"].ToString();
                            DateTime eDateParsed = DateTime.Parse(eDate);

                            GigModel gig = new GigModel
                            {
                                GigID = Convert.ToInt32(reader["id"]),
                                GigTitle = reader["title"].ToString(),
                                Description = reader["description"].ToString(),
                                Location = reader["location"].ToString(),
                                Type = (GigType)Enum.Parse(typeof(GigType), reader["type"].ToString(), true),
                                StartDate = sDateParsed,
                                EndDate = eDateParsed,
                                Rate = Convert.ToDecimal(reader["rate"]),
                                Status = (GigStatus)Enum.Parse(typeof(GigStatus), reader["status"].ToString(), true),
                                DateCreated = parseddC,
                                gigPoster = Convert.ToInt32(reader["gigPoster_id"]),
                                SkillsRequired = reader["skills_required"].ToString()
                            };
                            userGigs.Add(gig);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error retrieving gigs: " + e.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return userGigs;
        }
        public bool SaveGig(int gigId, int userId)
        {
            // Connect to database
            using (var connection = new SqlConnection(@"Data Source=DESKTOP-R83M1NS;Initial Catalog=GigHub;Integrated Security=True"))
            {
                connection.Open();
                
                string query = "INSERT INTO dbo.SavedGigs (GigId, UserId) VALUES ('"+gigId+"', '"+userId+"')";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@GigId", gigId);
                cmd.Parameters.AddWithValue("@UserId", userId);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; // Successful save if a row is inserted
            }
        }

        public bool UnsaveGig(int gigId, int userId)
        {
            // Connect to database
            using (var connection = new SqlConnection(@"Data Source=DESKTOP-R83M1NS;Initial Catalog=GigHub;Integrated Security=True"))
            {
                connection.Open();

                string query = "DELETE FROM dbo.SavedGigs WHERE GigId = '" + gigId + "' AND UserId = '" + userId + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@GigId", gigId);
                cmd.Parameters.AddWithValue("@UserId", userId);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; // Successful save if a row is inserted
            }
        }

        public List<GigModel> GetSavedGigs(int userId)
        {
            // Connect to database
            using (var connection = new SqlConnection(@"Data Source=DESKTOP-R83M1NS;Initial Catalog=GigHub;Integrated Security=True"))
            {
                connection.Open();

                string query = "SELECT g.* FROM Gigs g INNER JOIN SavedGigs sg ON g.Id = sg.GigId WHERE sg.UserId = '"+userId+"'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@userId", userId);

                List<GigModel> savedGigs = new List<GigModel>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        string dC = reader["date_created"].ToString();
                        DateTime parseddC = DateTime.Parse(dC);

                        string sDate = reader["start_date"].ToString();
                        DateTime sDateParsed = DateTime.Parse(sDate);

                        string eDate = reader["end_date"].ToString();
                        DateTime eDateParsed = DateTime.Parse(eDate);
                            
                            GigModel gig = new GigModel
                            {
                                GigID = Convert.ToInt32(reader["id"]),
                                GigTitle = reader["title"].ToString(),
                                Description = reader["description"].ToString(),
                                Location = reader["location"].ToString(),
                                Type = (GigType)Enum.Parse(typeof(GigType), reader["type"].ToString(), true),
                                StartDate = sDateParsed,
                                EndDate = eDateParsed,
                                Rate = Convert.ToDecimal(reader["rate"]),
                                Status = (GigStatus)Enum.Parse(typeof(GigStatus), reader["status"].ToString(), true),
                                gigPoster = userId,
                                DateCreated = parseddC,
                                SkillsRequired = reader["skills_required"].ToString()
                            };
                        savedGigs.Add(gig);
                    }
                }
                return savedGigs;
            }
        }
    }
}
