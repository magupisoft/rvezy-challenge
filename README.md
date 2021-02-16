# rvezy-challenge

Generate Database Structure

- Change connection string in Rvezy.CodeChallenge project app.settings files

Run the following command in Package Manager Console
- Update-Database -Context RvezyDataContext - StartupProject Rvezy.CodeChallenge -Project  Rvezy.CodeChallenge.DataContext

- First time the Web API is run, the database is seed with the data from CSV files.
