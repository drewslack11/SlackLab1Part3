using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SlackLab1Part3.Pages.DB
{
    public class DBClass
    {
        private static readonly string connectionString =
            "Server=Localhost;Database=Lab1;Trusted_Connection=True;";

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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO GRANTS (Category, FundingOrg, SubmissionDate, AwardDate, AwardSubtotal, GrantStatus) VALUES " +
                    "('Research', 'National Science Foundation', GETDATE(), NULL, 50000.00, 'Pending')," +
                    "('Education', 'Department of Education', GETDATE(), NULL, 75000.00, 'Approved');", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertDummyProjects()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO PROJECTS (Title, Description, DueDate, Status) VALUES " +
                    "('AI Research', 'Developing an AI model', DATEADD(day, 60, GETDATE()), 'In Progress')," +
                    "('Cybersecurity Audit', 'Reviewing security protocols', DATEADD(day, 90, GETDATE()), 'Pending');", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertDummyBusinessPartners()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO BUSINESS_PARTNER (Name, Status, Organization, OrganizationType, PrimaryContact, StatusFlag) VALUES " +
                    "('Tech Solutions Inc.', 'Active', 'Tech Solutions', 'Technology', 'John Doe', 1)," +
                    "('Green Energy Ltd.', 'Inactive', 'Green Energy', 'Renewable Energy', 'Jane Smith', 0);", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertDummyUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO USERS (UserID, Name, Password, Role) VALUES " +
                    "(1, 'Alice Johnson', 'password123', 'Faculty')," +
                    "(2, 'Bob Smith', 'securepass', 'Admin')," +
                    "(3, 'Charlie Davis', 'partnerpass', 'BusinessPartnerRep');" +

                    "INSERT INTO FACULTY (FacultyID) VALUES (1);" +

                    "INSERT INTO GRANTORGADMIN (AdminID) VALUES (2);" +

                    "INSERT INTO BUSINESSPARTNERREP (RepresentativeID, BusinessPartnerID) VALUES (3, 1);", conn);
                cmd.ExecuteNonQuery();
            }
        }

        //Create Grant View Method
        public static SqlDataReader GrantReader()
        {
            using (SqlConnection conn = new SqlConnection(
                "Server=Localhost;Database=Lab1;Trusted_Connection=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM GRANTS", conn);
                return cmd.ExecuteReader();
            }
        }

    }
