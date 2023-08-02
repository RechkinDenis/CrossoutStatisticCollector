using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static CrossoutStats.GameLogsParser;

/*
 * смотри надо делать проверку по времени кста вот шаблон тебе
 */

namespace CrossoutStats
{

    public partial class Form1 : Form
    {
        static Resource Scrap = new Resource("Металлолом", "Scrap_Common", "https://crossoutdb.com/api/v1/item/53");
        static Resource Wires = new Resource("Провода", "Scrap_Rare", "https://crossoutdb.com/api/v1/item/85");
        static Resource Copper = new Resource("Медь", "Platinum", "https://crossoutdb.com/api/v1/item/43");
        static Resource Petrol = new Resource("Бензин", "ResourcePack_Gasoline5", "https://crossoutdb.com/api/v1/item/106");
        static Resource Plastic = new Resource("Пластик", "Plastic", "https://crossoutdb.com/api/v1/item/785");
        static Resource Accumulator = new Resource("Аккумуляторы", "Accumulators", "https://crossoutdb.com/api/v1/item/784");
        static Resource Electronics = new Resource("Электроника", "Scrap_Epic", "https://crossoutdb.com/api/v1/item/168");

        private List<Resource> resources = new List<Resource>() {
            new Resource("Металлолом", "Scrap_Common", "https://crossoutdb.com/api/v1/item/53"),
            new Resource("Провода", "Scrap_Rare", "https://crossoutdb.com/api/v1/item/85"),
            new Resource("Медь", "Platinum", "https://crossoutdb.com/api/v1/item/43"),
            new Resource("Бензин", "ResourcePack_Gasoline5", "https://crossoutdb.com/api/v1/item/106"),
            new Resource("Пластик", "Plastic", "https://crossoutdb.com/api/v1/item/785"),
            new Resource("Аккумуляторы", "Accumulators", "https://crossoutdb.com/api/v1/item/784"),
            new Resource("Электроника", "Scrap_Epic", "https://crossoutdb.com/api/v1/item/168")
        };

        private List<Statistic> statistics = new List<Statistic>();

        public int commissionPercentage = 10;// Процент с продажи на рынке

        enum GameResult { defeat, victory, unfinished, freePlayFinish }

        public string playersFileDB = "stat.db";
        public string templateFileDB = "template.db";
        public string gameLog = "game.log";
        
        string input1 = "19:45:05.432 | Gameplay statistic. gameResult 'victory'\n19:45:05.432 | Accumulators 5, Glory 35, score 952, expBase 952, expDailyBonus 2.0, expTotal 2856, expBaseFactionTotal 2856, expFactionTotal 2856";
        string input = "23:20:24.557         | Gameplay statistic. gameResult 'victory'\r\n23:20:24.557         |      Accumulators   4, Glory  31,  score 266, expBase 266, expDailyBonus 2.0, expTotal 798, expBaseFactionTotal 798, expFactionTotal 798";

        public string LocalDerictory => AppDomain.CurrentDomain.BaseDirectory;

        public string PathToDuplicate => $"{LocalDerictory}\\Logs";

        public string PathToLogsFile => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\Crossout\logs\";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.Items.AddRange(resourcesNameLog);
            
        }

        public async Task ParsePriceAndName()
        {
            using (HttpClient client = new HttpClient())
            {
                foreach (Resource resource in resources)
                {
                    HttpResponseMessage response = await client.GetAsync(resource.Url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        try
                        {
                            JArray dataArray = JArray.Parse(responseBody);
                            if (dataArray.Count > 0)
                            {
                                JObject data = (JObject)dataArray[0];
                                string name = data["name"].ToString();
                                string formatBuyPrice = data["formatBuyPrice"].ToString();
                                formatBuyPrice = formatBuyPrice.Replace('.', ',');
                                resource.Price = double.Parse(formatBuyPrice);
                            }
                            else
                            {
                                Console.WriteLine("No data found.");
                            }
                        }
                        catch (JsonReaderException ex)
                        {
                            Console.WriteLine("Error parsing JSON: " + ex.Message);
                            Console.WriteLine("Response body: " + responseBody);
                        }
                    }
                    else
                    {
                        Console.WriteLine("HTTP request failed with status code: " + response.StatusCode);
                    }
                }
            }
        }

        public void DuplicateFolders(string sourcePath, string destinationPath)
        {
            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            foreach (string subdirectory in Directory.GetDirectories(sourcePath))
            {
                string subdirectoryName = Path.GetFileName(subdirectory);
                string destinationSubdirectory = Path.Combine(destinationPath, subdirectoryName);

                DuplicateFolders(subdirectory, destinationSubdirectory);
            }

            foreach (string file in Directory.GetFiles(sourcePath))
            {
                string fileName = Path.GetFileName(file);
                string destinationFile = Path.Combine(destinationPath, fileName);

                File.Copy(file, destinationFile);
            }
        }

        public void DeleteFolderRecursively(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                // Удаляем все файлы в папке
                string[] files = Directory.GetFiles(folderPath);
                foreach (string file in files)
                {
                    File.Delete(file);
                }

                // Рекурсивно удаляем все подпапки
                string[] subdirectories = Directory.GetDirectories(folderPath);
                foreach (string subdirectory in subdirectories)
                {
                    DeleteFolderRecursively(subdirectory);
                }

                // Удаляем саму папку
                Directory.Delete(folderPath);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DeleteFolderRecursively(PathToDuplicate);
            DuplicateFolders(PathToLogsFile, PathToDuplicate);

            await ParsePriceAndName();
            
            //foreach(Resource resource in resources)
            //{
            //    string content = null;
            //
            //    content = $"Имя: {resource.NameRu}/ Цена: {resource.Price}";
            //
            //    if(!listBox1.Items.Contains(content)) listBox1.Items.Add(content);
            //}
            
            LoadPriceToTextBox();

            // Используем регулярное выражение для поиска времени
            string timePattern = @"(\d{2}:\d{2}:\d{2}\.\d{3})";
            Match timeMatch = Regex.Match(input, timePattern);

            if (timeMatch.Success)
            {
                string time = timeMatch.Groups[1].Value;
                Console.WriteLine($"Time: {time}");

                // Используем регулярное выражение для поиска gameResult
                string gameResultPattern = @"gameResult '([a-zA-Z]+)'";
                Match gameResultMatch = Regex.Match(input, gameResultPattern);

                string gameResult = string.Empty;
                string resource = string.Empty;
                string countResource = string.Empty;
                string glory = string.Empty;
                string score = string.Empty;
                string expTotal = string.Empty;

                if (gameResultMatch.Success)
                {
                    gameResult = gameResultMatch.Groups[1].Value;
                    Console.WriteLine($"Game Result: {gameResult}");

                    // Используем регулярное выражение для поиска статистики
                    string statsPattern = @"([a-zA-Z\s]+) (\d+)";
                    MatchCollection statsMatches = Regex.Matches(input, statsPattern);

                    foreach (Match match in statsMatches)
                    {
                        string statName = match.Groups[1].Value.Trim();
                        int statValue = int.Parse(match.Groups[2].Value);
                        Console.WriteLine($"{statName}: {statValue}");


                        foreach(Resource _resource in resources)
                        {
                            if (statName == _resource.NameLog) countResource = statValue.ToString();
                            if (statName == _resource.NameLog) resource = statName;
                        }

                        if (statName == "Glory") glory = statValue.ToString();
                        if(statName == "score") score = statValue.ToString();
                        if(statName == "expTotal") expTotal = statValue.ToString();
                    }
                }
                else
                {
                    Console.WriteLine("No match found for game result.");
                }

                Statistic statistic = new Statistic(time, gameResult, resource , score, expTotal, countResource);
                statistics.Add(statistic);
            }
            else
            {
                Console.WriteLine("No match found for time.");
            }

            foreach (Statistic statistic in statistics)
            {
                string content = string.Empty;

                content = $"{statistic.Time} / {statistic.GameResult} / {statistic.Resource}: {statistic.CountResource} / EXP: {statistic.Exp} / Score: {statistic.Score}";

                listBox1.Items.Add(content);
            }
        }

        private void LoadPriceToTextBox()
        {
            foreach (Resource resource in resources)
            {
                switch (resource.NameRu)
                {
                    case "Металлолом":
                        textScrap.Text = resource.Price.ToString();
                        break;
                    case "Провода":
                        textWires.Text = resource.Price.ToString();
                        break;
                    case "Медь":
                        textCopper.Text = resource.Price.ToString();
                        break;
                    case "Бензин":
                        textPetrol.Text = resource.Price.ToString();
                        break;
                    case "Пластик":
                        textPlastic.Text = resource.Price.ToString();
                        break;
                    case "Аккумуляторы":
                        textAccumulators.Text = resource.Price.ToString();
                        break;
                    case "Электроника":
                        textElectronics.Text = resource.Price.ToString();
                        break;
                    default:
                        break;
                }
            }
        }
    }

    /*
19:45:05.432         | Gameplay statistic. gameResult 'victory'
19:45:05.432         |      Accumulators   5, Glory  35,  score 952, expBase 952, expDailyBonus 2.0, expTotal 2856, expBaseFactionTotal 2856, expFactionTotal 2856
19:45:05.432         |      loot: ResourcePack_Gasoline5;
19:45:05.432         |      quest Weekly_10_Hard_WinsAccumulators: 6 / 12 -> 7 / 12 
     */

    class Statistic
    {
        public string Time { get; set; }
        public string GameResult { get; set; }
        public string Resource { get; set; }
        public string CountResource { get; set; }
        public string Score { get; set; }
        public string Exp { get; set; }
        public string Loot { get; set; }

        public Statistic(string time, string gameResult, string resource, string score, string exp, string countResource)
        {
            Time = time;
            GameResult = gameResult;
            Resource = resource;
            Score = score;
            Exp = exp;
            CountResource = countResource;
        }
    }

    class Resource
    {
        public string NameRu { get; set; }
        public string NameLog { get; set; }
        public string Url { get; set; }
        public double Price { get; set; }


        public Resource(string nameRu, string nameLog, string url)
        {
            NameRu = nameRu;
            NameLog = nameLog;
            Url = url;
        }
    }
}
