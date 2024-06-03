using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using WindowsFormsApp4;
namespace SearchInfo
{
    public class SearchHero
    {
        public async Task<List<HeroMatchup>> Api(int id)
        {
            return await Task.Run(() =>
            {
                string url = $"https://api.opendota.com/api/heroes/{id}/matchups";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string response;
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    response = streamReader.ReadToEnd();
                }
                List<HeroMatchup> heroMatchups = JsonConvert.DeserializeObject<List<HeroMatchup>>(response);
                return heroMatchups;
            });
        }
        public int Name(string Name)
        {
            Name = Name.ToLowerInvariant();
            Dictionary<int, string> idToName = new Dictionary<int, string>();
            idToName.Add(1, "anti-mage");
            idToName.Add(2, "axe");
            idToName.Add(3, "bane");
            idToName.Add(4, "bloodseeker");
            idToName.Add(5, "crystal maiden");
            idToName.Add(6, "drow ranger");
            idToName.Add(7, "earthshaker");
            idToName.Add(8, "juggernaut");
            idToName.Add(9, "mirana");
            idToName.Add(10, "morphling");
            idToName.Add(11, "shadow fiend");
            idToName.Add(12, "phantom lancer");
            idToName.Add(13, "puck");
            idToName.Add(14, "pudge");
            idToName.Add(15, "razor");
            idToName.Add(16, "sand king");
            idToName.Add(17, "storm spirit");
            idToName.Add(18, "sven");
            idToName.Add(19, "tiny");
            idToName.Add(20, "vengeful spirit");
            idToName.Add(21, "windranger");
            idToName.Add(22, "zeus");
            idToName.Add(23, "kunkka");
            idToName.Add(25, "lina");
            idToName.Add(26, "lion");
            idToName.Add(27, "shadow shaman");
            idToName.Add(28, "slardar");
            idToName.Add(29, "tidehunter");
            idToName.Add(30, "witch doctor");
            idToName.Add(31, "lich");
            idToName.Add(32, "riki");
            idToName.Add(33, "enigma");
            idToName.Add(34, "tinker");
            idToName.Add(35, "sniper");
            idToName.Add(36, "necrophos");
            idToName.Add(37, "warlock");
            idToName.Add(38, "beastmaster");
            idToName.Add(39, "queen of pain");
            idToName.Add(40, "venomancer");
            idToName.Add(41, "faceless void");
            idToName.Add(42, "wraith King");
            idToName.Add(43, "death prophet");
            idToName.Add(44, "phantom assassin");
            idToName.Add(45, "pugna");
            idToName.Add(46, "templar assassin");
            idToName.Add(47, "viper");
            idToName.Add(48, "luna");
            idToName.Add(49, "dragon knight");
            idToName.Add(50, "dazzle");
            idToName.Add(51, "clockwerk");
            idToName.Add(52, "leshrac");
            idToName.Add(53, "nature's prophet");
            idToName.Add(54, "lifestealer");
            idToName.Add(55, "dark Seer");
            idToName.Add(56, "clinkz");
            idToName.Add(57, "omniknight");
            idToName.Add(58, "enchantress");
            idToName.Add(59, "huskar");
            idToName.Add(60, "night stalker");
            idToName.Add(61, "broodmother");
            idToName.Add(62, "bounty hunter");
            idToName.Add(63, "weaver");
            idToName.Add(64, "jakiro");
            idToName.Add(65, "batrider");
            idToName.Add(66, "chen");
            idToName.Add(67, "spectre");
            idToName.Add(68, "ancient apparition");
            idToName.Add(69, "doom");
            idToName.Add(70, "ursa");
            idToName.Add(71, "spirit breaker");
            idToName.Add(72, "gyrocopter");
            idToName.Add(73, "alchemist");
            idToName.Add(74, "invoker");
            idToName.Add(75, "silencer");
            idToName.Add(76, "outworld destroyer");
            idToName.Add(77, "lycan");
            idToName.Add(78, "brewmaster");
            idToName.Add(79, "shadow demon");
            idToName.Add(80, "lone druid");
            idToName.Add(81, "chaos knight");
            idToName.Add(82, "meepo");
            idToName.Add(83, "treant protector");
            idToName.Add(84, "ogre Magi");
            idToName.Add(85, "undying");
            idToName.Add(86, "rubick");
            idToName.Add(87, "disruptor");
            idToName.Add(88, "nyx assassin");
            idToName.Add(89, "naga siren");
            idToName.Add(90, "keeper of the light");
            idToName.Add(91, "io");
            idToName.Add(92, "visage");
            idToName.Add(93, "slark");
            idToName.Add(94, "medusa");
            idToName.Add(95, "troll warlord");
            idToName.Add(96, "centaur warrunner");
            idToName.Add(97, "magnus");
            idToName.Add(98, "timbersaw");
            idToName.Add(99, "bristleback");
            idToName.Add(100, "tusk");
            idToName.Add(101, "skywrath mage");
            idToName.Add(102, "abaddon");
            idToName.Add(103, "elder titan");
            idToName.Add(104, "legion commander");
            idToName.Add(105, "techies");
            idToName.Add(106, "ember spirit");
            idToName.Add(107, "earth spirit");
            idToName.Add(108, "underlord");
            idToName.Add(109, "terrorblade");
            idToName.Add(110, "phoenix");
            idToName.Add(111, "oracle");
            idToName.Add(112, "winter wyvern");
            idToName.Add(113, "arc warden");
            idToName.Add(114, "monkey king");
            idToName.Add(119, "dark willow");
            idToName.Add(120, "pangolier");
            idToName.Add(121, "grimstroke");
            idToName.Add(123, "hoodwink");
            idToName.Add(126, "void spirit");
            idToName.Add(128, "snapfire");
            idToName.Add(129, "mars");
            idToName.Add(135, "dawnbreaker");
            idToName.Add(136, "marci");
            idToName.Add(137, "primal beast");
            idToName.Add(138, "muerta");
            int id = 139;
            foreach (var name in idToName)
            {
                if (name.Value == Name)
                {
                    id = name.Key;
                }
            }
            return id;
        }
        public string Id(int id)
        {
            Dictionary<int, string> NameToId = new Dictionary<int, string>();
            NameToId.Add(1, "Anti-Mage");
            NameToId.Add(2, "Axe");
            NameToId.Add(3, "Bane");
            NameToId.Add(4, "Bloodseeker");
            NameToId.Add(5, "Crystal Maiden");
            NameToId.Add(6, "Drow Ranger");
            NameToId.Add(7, "Earthshaker");
            NameToId.Add(8, "Juggernaut");
            NameToId.Add(9, "Mirana");
            NameToId.Add(10, "Morphling");
            NameToId.Add(11, "Shadow Fiend");
            NameToId.Add(12, "Phantom Lancer");
            NameToId.Add(13, "Puck");
            NameToId.Add(14, "Pudge");
            NameToId.Add(15, "Razor");
            NameToId.Add(16, "Sand King");
            NameToId.Add(17, "Storm Spirit");
            NameToId.Add(18, "Sven");
            NameToId.Add(19, "Tiny");
            NameToId.Add(20, "Vengeful Spirit");
            NameToId.Add(21, "Windranger");
            NameToId.Add(22, "Zeus");
            NameToId.Add(23, "Kunkka");
            NameToId.Add(25, "Lina");
            NameToId.Add(26, "Lion");
            NameToId.Add(27, "Shadow Shaman");
            NameToId.Add(28, "Slardar");
            NameToId.Add(29, "Tidehunter");
            NameToId.Add(30, "Witch Doctor");
            NameToId.Add(31, "Lich");
            NameToId.Add(32, "Riki");
            NameToId.Add(33, "Enigma");
            NameToId.Add(34, "Tinker");
            NameToId.Add(35, "Sniper");
            NameToId.Add(36, "Necrophos");
            NameToId.Add(37, "Warlock");
            NameToId.Add(38, "Beastmaster");
            NameToId.Add(39, "Queen of Pain");
            NameToId.Add(40, "Venomancer");
            NameToId.Add(41, "Faceless Void");
            NameToId.Add(42, "Wraith King");
            NameToId.Add(43, "Death Prophet");
            NameToId.Add(44, "Phantom Assassin");
            NameToId.Add(45, "Pugna");
            NameToId.Add(46, "Templar Assassin");
            NameToId.Add(47, "Viper");
            NameToId.Add(48, "Luna");
            NameToId.Add(49, "Dragon Knight");
            NameToId.Add(50, "Dazzle");
            NameToId.Add(51, "Clockwerk");
            NameToId.Add(52, "Leshrac");
            NameToId.Add(53, "Nature's Prophet");
            NameToId.Add(54, "Lifestealer");
            NameToId.Add(55, "Dark Seer");
            NameToId.Add(56, "Clinkz");
            NameToId.Add(57, "Omniknight");
            NameToId.Add(58, "Enchantress");
            NameToId.Add(59, "Huskar");
            NameToId.Add(60, "Night Stalker");
            NameToId.Add(61, "Broodmother");
            NameToId.Add(62, "Bounty Hunter");
            NameToId.Add(63, "Weaver");
            NameToId.Add(64, "Jakiro");
            NameToId.Add(65, "Batrider");
            NameToId.Add(66, "Chen");
            NameToId.Add(67, "Spectre");
            NameToId.Add(68, "Ancient Apparition");
            NameToId.Add(69, "Doom");
            NameToId.Add(70, "Ursa");
            NameToId.Add(71, "Spirit Breaker");
            NameToId.Add(72, "Gyrocopter");
            NameToId.Add(73, "Alchemist");
            NameToId.Add(74, "Invoker");
            NameToId.Add(75, "Silencer");
            NameToId.Add(76, "Outworld Destroyer");
            NameToId.Add(77, "Lycan");
            NameToId.Add(78, "Brewmaster");
            NameToId.Add(79, "Shadow Demon");
            NameToId.Add(80, "Lone Druid");
            NameToId.Add(81, "Chaos Knight");
            NameToId.Add(82, "Meepo");
            NameToId.Add(83, "Treant Protector");
            NameToId.Add(84, "Ogre Magi");
            NameToId.Add(85, "Undying");
            NameToId.Add(86, "Rubick");
            NameToId.Add(87, "Disruptor");
            NameToId.Add(88, "Nyx Assassin");
            NameToId.Add(89, "Naga Siren");
            NameToId.Add(90, "Keeper of the Light");
            NameToId.Add(91, "Io");
            NameToId.Add(92, "Visage");
            NameToId.Add(93, "Slark");
            NameToId.Add(94, "Medusa");
            NameToId.Add(95, "Troll Warlord");
            NameToId.Add(96, "Centaur Warrunner");
            NameToId.Add(97, "Magnus");
            NameToId.Add(98, "Timbersaw");
            NameToId.Add(99, "Bristleback");
            NameToId.Add(100, "Tusk");
            NameToId.Add(101, "Skywrath Mage");
            NameToId.Add(102, "Abaddon");
            NameToId.Add(103, "Elder Titan");
            NameToId.Add(104, "Legion Commander");
            NameToId.Add(105, "Techies");
            NameToId.Add(106, "Ember Spirit");
            NameToId.Add(107, "Earth Spirit");
            NameToId.Add(108, "Underlord");
            NameToId.Add(109, "Terrorblade");
            NameToId.Add(110, "Phoenix");
            NameToId.Add(111, "Oracle");
            NameToId.Add(112, "Winter Wyvern");
            NameToId.Add(113, "Arc Warden");
            NameToId.Add(114, "Monkey King");
            NameToId.Add(119, "Dark Willow");
            NameToId.Add(120, "Pangolier");
            NameToId.Add(121, "Grimstroke");
            NameToId.Add(123, "Hoodwink");
            NameToId.Add(126, "Void Spirit");
            NameToId.Add(128, "Snapfire");
            NameToId.Add(129, "Mars");
            NameToId.Add(135, "Dawnbreaker");
            NameToId.Add(136, "Marci");
            NameToId.Add(137, "Primal Beast");
            NameToId.Add(138, "Muerta");
            string name = "Error";
            foreach (var s in NameToId)
            {
                if (s.Key == id)
                {
                    name = s.Value;
                }
            }
            return name;
        }
    }
}
