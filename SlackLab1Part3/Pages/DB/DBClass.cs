using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SlackLab1Part3.Pages.DB
{
    public class DBClass

    {
        public static SqlConnection Lab1DBConnection = new SqlConnection();
        private static readonly String? Lab1DBConnectionString =
            "Server=Localhost;Database=Lab1;Trusted_Connection=True;Encrypt=False;";

        //Creates Grant Reader
        public static SqlDataReader GrantReader()
        {
            SqlCommand cmdGrantRead = new SqlCommand();
            cmdGrantRead.Connection = Lab1DBConnection;
            cmdGrantRead.Connection.ConnectionString = Lab1DBConnectionString;
            cmdGrantRead.CommandText = "SELECT * FROM [GRANT]";
            cmdGrantRead.Connection.Open();
           
            SqlDataReader tempReader = cmdGrantRead.ExecuteReader();
           
            return tempReader;
        }

        // Inserts Dummy Data For All Tables
        public static void InsertDummyData()
        {
            InsertDummyGrants();
            InsertDummyProjects();
            InsertDummyBusinessPartners();
            InsertDummyUsers();
        }

        public static void InsertDummyGrants()
        {
            using (SqlConnection conn = new SqlConnection(Lab1DBConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO [GRANT] (GrantID,Category, FundingOrg, SubmissionDate, AwardDate, AwardSubtotal, GrantStatus) VALUES " +
                    "(1, 'Research', 'National Science Foundation', GETDATE(), NULL, 50000.00, 'Pending')," +
                    "(2, 'Education', 'Department of Education', GETDATE(), NULL, 75000.00, 'Approved');", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertDummyProjects()
        {
            using (SqlConnection conn = new SqlConnection(Lab1DBConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO PROJECT (ProjectID, Title, Description, DueDate, Status) VALUES " +
                    "(1, 'AI Research', 'Developing an AI model', DATEADD(day, 60, GETDATE()), 'In Progress')," +
                    "(2, 'Cybersecurity Audit', 'Reviewing security protocols', DATEADD(day, 90, GETDATE()), 'Pending');", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertDummyBusinessPartners()
        {
            using (SqlConnection conn = new SqlConnection(Lab1DBConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO BUSINESSPARTNER (BusinessPartnerID, Name, Status, Organization, OrganizationType, PrimaryContact, StatusFlag) VALUES " +
                    "(1, 'Tech Solutions Inc.', 'Active', 'Tech Solutions', 'Technology', 'John Doe', 1)," +
                    "(2, 'Green Energy Ltd.', 'Inactive', 'Green Energy', 'Renewable Energy', 'Jane Smith', 0);", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertDummyUsers()
        {
            using (SqlConnection conn = new SqlConnection(Lab1DBConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO [USER] (UserID, Name, Password, Role) VALUES " +
                    "(1, 'Alice Johnson', 'password123', 'Faculty')," +
                    "(2, 'Bob Smith', 'securepass', 'Admin')," +
                    "(3, 'Charlie Davis', 'partnerpass', 'BusinessPartnerRep');" +

                    "INSERT INTO FACULTY (FacultyID) VALUES (1);" +

                    "INSERT INTO GRANTORGADMIN (AdminID) VALUES (2);" +

                    "INSERT INTO BUSINESSPARTNERREP (RepresentativeID, BusinessPartnerID) VALUES (3, 1);", conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

