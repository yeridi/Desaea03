using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;


namespace WpfSemana04
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection = new SqlConnection("Server=LAPTOP-PGN556A3" + @"\" + "SQLEXPRESS;Database=db_lab04;Integrated Security=true");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            List<Person> people = new List<Person>();
            SqlCommand command = new SqlCommand("Search", connection);

            command.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlParameter2 = new SqlParameter();
            sqlParameter2.SqlDbType = SqlDbType.VarChar;
            sqlParameter2.Size = 50;
            sqlParameter2.Value = txtBuscar.Text.ToString();
            sqlParameter2.ParameterName = "@FirstName";

            command.Parameters.Add(sqlParameter2);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                people.Add(new Person
                {
                    PersonId = dataReader["PersonId"].ToString(),
                    LastName = dataReader["LastName"].ToString(),
                    FirstName = dataReader["FirstName"].ToString(),
                    FullName = string.Concat(dataReader["FirstName"].ToString(), " ", dataReader["LastName"].ToString())
                });
            }
            connection.Close();
            dvgPeople.ItemsSource = people;

        }
    }
}
