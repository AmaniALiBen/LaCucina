using LaCucina.Models;
using System.Collections.Generic;
using System.Data;

namespace LaCucina.DataLink
{
    public class SpaceRepository
    {
        // 🔹 Get all spaces as List
        public List<spaces> GetAll()
        {
            string query = @"
            SELECT space_id, space_name
            FROM spaces
            ORDER BY space_id";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            List<spaces> s = new List<spaces>();

            foreach (DataRow row in dt.Rows)
            {
                s.Add(new spaces
                    (
                    (int)row["space_id"],
                    row["space_name"].ToString()
                    )

                );
            }

            return s;
        }
    }
}
