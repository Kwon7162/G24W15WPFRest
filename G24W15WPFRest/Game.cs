using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G24W15WPFRest;

// 서버로부터 받은 JSON 예제
//{
//    "id": 516,
//    "title": "PUBG: BATTLEGROUNDS",
//    "thumbnail": "https://www.freetogame.com/g/516/thumbnail.jpg",
//    "short_description": "Get into the action in one of the longest running battle royale games PUBG Battlegrounds.",
//    "game_url": "https://www.freetogame.com/open/pubg",
//    "genre": "Shooter",
//    "platform": "PC (Windows)",
//    "publisher": "KRAFTON, Inc.",
//    "developer": "KRAFTON, Inc.",
//    "release_date": "2022-01-12",
//    "freetogame_profile_url": "https://www.freetogame.com/pubg"
//},

// Kotlin의 data class에 해당
public record class Game(
    int id,
    string title,
    string thumbnail,
    string short_description,
    string game_url,
    string genre,
    string platform,
    string publisher,
    string developer,
    string release_date,
    string freetogame_profile_url
);

////이렇게 만들어도 됨
//public class Game {
//    public int id;
//    public string title { get; set; }
//    public string release_date { get; set; }
//    public string genre { get; set; }
//    public string publisher { get; set; }
//    public string developer { get; set; }
//    public string short_description { get; set; }
//    public string platform { get; set; }
//    public string thumbnail { get; set; }
//    public string game_url { get; set; }
//    public string freetogame_profile_url { get; set; }
//}
