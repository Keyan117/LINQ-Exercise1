//using C34PracticeLinqExercise;

List<string> VideoGamesNames = new List<string>();

VideoGamesNames.Add("halo");
VideoGamesNames.Add("gta");
VideoGamesNames.Add("sonic");

var orderedNames = VideoGamesNames.OrderBy(name => name.Length);

foreach (var names in orderedNames)
{
    Console.WriteLine(names);
}