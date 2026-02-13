// Creates a SUM measure for every currently selected column and hides the column.
foreach(var c in Selected.Columns)
{
    var newMeasure = c.Table.AddMeasure(
    "Stdev. " + c.Name + " (lower)",                    // Name
    "[Avg. "+
    c.DaxObjectFullName+
    "] - STDEV.P(" +
    c.DaxObjectFullName")",    // DAX expression
        c.[Measures]                        // Display Folder
    );
    
    // Set the format string on the new measure:
    newMeasure.FormatString = "#,0.0";

    // Provide some documentation:
    //newMeasure.Description = "This measure is the sum of column " + c.DaxObjectFullName;

    // Hide the base column:
    //c.IsHidden = true;
}