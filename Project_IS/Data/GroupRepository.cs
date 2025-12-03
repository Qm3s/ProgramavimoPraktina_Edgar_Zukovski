using Project_IS.Abstractions;
using Project_IS.Models;
using System.Data.SQLite;

internal class GroupRepository : IGroupRepository
{
    private readonly string _connString;

    public GroupRepository(string connString)
    {
        _connString = connString;
    }

    public IEnumerable<Group> GetAll()
    {
        var list = new List<Group>();

        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "SELECT Id, GroupName FROM Groups";

        using var cmd = new SQLiteCommand(sql, conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Group
            {
                GroupId = Convert.ToInt32(reader["Id"]),
                GroupName = reader["GroupName"].ToString()!
            });
        }

        return list;
    }

    public Group GetById(int id)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "SELECT Id, GroupName FROM Groups WHERE Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", id);

        using var reader = cmd.ExecuteReader();

        if (!reader.Read())
            return null;

        return new Group
        {
            GroupId = Convert.ToInt32(reader["Id"]),
            GroupName = reader["GroupName"].ToString()!
        };
    }

    public Group GetByName(string name)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "SELECT Id, GroupName FROM Groups WHERE GroupName = @name";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@name", name);

        using var reader = cmd.ExecuteReader();

        if (!reader.Read())
            return null;

        return new Group
        {
            GroupId = Convert.ToInt32(reader["Id"]),
            GroupName = reader["GroupName"].ToString()!
        };
    }

    public void Add(Group group)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "INSERT INTO Groups (GroupName) VALUES (@name)";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@name", group.GroupName);

        cmd.ExecuteNonQuery();
    }

    public void Update(Group group)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "UPDATE Groups SET GroupName = @name WHERE Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@name", group.GroupName);
        cmd.Parameters.AddWithValue("@id", group.GroupId);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var conn = new SQLiteConnection(_connString);
        conn.Open();

        string sql = "DELETE FROM Groups WHERE Id = @id";

        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", id);

        cmd.ExecuteNonQuery();
    }
}