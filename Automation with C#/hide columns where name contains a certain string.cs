// Ensure a table is selected
if (Selected.Table != null)
{
    var table = Selected.Table;

    // Loop through all columns in the selected table
    foreach (var column in table.Columns)
    {
        if (column.Name.Contains("(int)"))
        {
            column.IsHidden = true;
        }
    }
}
else
{
    Output("Please select a table before running the script.");
}
