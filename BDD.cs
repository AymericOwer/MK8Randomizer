using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace MK8Randomizer
{
    public partial class BDD : Form
    {
        private DAL dal = new DAL();
        Random randomise = new Random();

        public void PrepareData()
        {
            dal.setCharacter();
            dal.setVehicule();
            dal.setWheel();
            dal.setGlider();
        } 

        public Character getRandomCharacter()
        {
            int index = randomise.Next(0,dal.characters.Count-1);
            return dal.characters[index];
        }

        public Vehicule getRandomVehicule()
        {
            int index = randomise.Next(0,dal.vehicules.Count-1);
            return dal.vehicules[index];
        }

        public Wheel getRandomWheel()
        {
            int index = randomise.Next(0, dal.wheels.Count-1);
            return dal.wheels[index];
        }

        public Glider getRandomGlider()
        {
            int index = randomise.Next(0, dal.gliders.Count-1);
            return dal.gliders[index];
        }

        public BDD()
        {
            InitializeComponent();
        }
    }

    public class Character
    {
        public string _name;
        public string _url;
        public double _accel;
        public double _weight;
        public bool _isdlc;


        public Character(string name, string url, double accel, double weight, bool isdlc)
        {
            _name = name;
            _url = url;
            _weight = weight;
            _accel = accel;
            _isdlc = isdlc;
        }
    }

    public class Vehicule
    {
        public string _name;
        public string _url;
        public bool _isKart;
        public double _accel;
        public double _weight;

        public Vehicule(string name, string url, bool isKart, double accel, double weight)
        {
            _name = name;
            _url = url;
            _isKart = isKart;
            _accel = accel;
            _weight = weight;
        }
    }
    public class Wheel
    {
        public string _name;
        public string _url;
        public double _accel;
        public double _weight;

        public Wheel(string name, string url, double accel, double weight)
        {
            _name = name;
            _url = url;
            _accel = accel;
            _weight = weight;
        }
    }
    public class Glider
    { 
        public string _name;
        public string _url;
        public double _accel;
        public double _weight;

        public Glider(string name, string url, double accel, double weight)
        {
            _name = name;
            _url = url;
            _accel = accel;
            _weight = weight;
        }
    }

    public class DAL
    {
        public List<Vehicule> vehicules = new List<Vehicule>();
        public List<Character> characters = new List<Character>();
        public List<Wheel> wheels = new List<Wheel>();
        public List<Glider> gliders = new List<Glider>();

        public void setVehicule()
        {
            vehicules = new List<Vehicule>()
            {
                new Vehicule("The Duke", "https://mario.wiki.gallery/images/8/8a/TheDukeBodyMK8.png",true, 0, 0),
                new Vehicule("Standard Kart", "https://mario.wiki.gallery/images/0/05/StandardKartBodyMK8.png",true, 0, 0),
                new Vehicule("300 SL Roadster", "https://mario.wiki.gallery/images/f/f4/300SLRoadster_MK8.png",true, 0, 0),
                new Vehicule("Pipe Frame", "https://mario.wiki.gallery/images/d/d1/PipeFrameBodyMK8.png",true, -0.25, 0.5),
                new Vehicule("City Tripper", "https://mario.wiki.gallery/images/b/be/MK8_Light-Green_City_Tripper.png",false, -0.25, 0.5),
                new Vehicule("Varmint", "https://mario.wiki.gallery/images/d/d0/VarmintBodyMK8.png",false, -0.25, 0.5),
                new Vehicule("Sports Coupe", "https://mario.wiki.gallery/images/f/f8/SportsCoupeMK8.png",true, 0.25, -0.25),
                new Vehicule("Mach 8", "https://mario.wiki.gallery/images/d/df/Mach8BodyMK8.png",true, 0.25, -0.25),
                new Vehicule("Inkstriker", "https://mario.wiki.gallery/images/e/eb/MK8DX_Inkstriker.png",true, 0.25, -0.25),
                new Vehicule("Tri-Speeder", "https://mario.wiki.gallery/images/5/56/TrispeederBodyMK8.png",true, 0.5, -0.75),
                new Vehicule("Steel Driver", "https://mario.wiki.gallery/images/9/94/Steel_Driver.png",true, 0.5, -0.75),
                new Vehicule("Bone Rattler", "https://mario.wiki.gallery/images/0/0a/MK8BoneRattler.png",true, 0.5, -0.75),
                new Vehicule("Teddy Buggy", "https://mario.wiki.gallery/images/f/fa/TeddyBuggyBodyMK8.png",true, 0, 0.25),
                new Vehicule("Cat Cruiser", "https://mario.wiki.gallery/images/f/f4/CatCruiserBodyMK8.png",true, 0, 0.25),
                new Vehicule("Yoshi Bike", "https://mario.wiki.gallery/images/6/62/YoshiBikeBodyMK8.png",true, 0, 0.25),
                new Vehicule("Comet", "https://mario.wiki.gallery/images/0/0e/CometBodyMK8.png",true, 0, 0.25),
                new Vehicule("P-Wing", "https://mario.wiki.gallery/images/c/cd/MK8PWing.png",true, 0.25, -0.75),
                new Vehicule("B-Dasher", "https://mario.wiki.gallery/images/1/15/ZeldaMK8Bdasher.png",true, 0.25, -0.75),
                new Vehicule("Circuit Special", "https://mario.wiki.gallery/images/6/6c/CircuitSpecialBodyMK8.png",true, 0.25, -0.75),
                new Vehicule("GLA", "https://mario.wiki.gallery/images/c/c2/GLA-MK8.png",true, 0.5, -1),
                new Vehicule("Badwagon", "https://mario.wiki.gallery/images/c/c2/BadwagonBodyMK8.png",true, 0.5, -1),
                new Vehicule("Standard ATV", "https://mario.wiki.gallery/images/2/23/StandardATVBodyMK8.png",true, 0.5, -1),
                new Vehicule("Prancer", "https://mario.wiki.gallery/images/f/ff/PrancerBodyMK8.png",true, -0.25, -0.5),
                new Vehicule("Jet Bike", "https://mario.wiki.gallery/images/1/12/JetBikeBodyMK8.png",true, -0.25, -0.5),
                new Vehicule("Sport Bike", "https://mario.wiki.gallery/images/f/fe/SportBikeBodyMK8.png",true, -0.25, -0.5),
                new Vehicule("Mr Scooty", "https://mario.wiki.gallery/images/1/18/MrScootyBodyMK8.png",true, -0.5, 0.75),
                new Vehicule("Biddybuggy", "https://mario.wiki.gallery/images/4/45/BiddybuggyBodyMK8.png",true, -0.5, 0.75),
                new Vehicule("Landship", "https://mario.wiki.gallery/images/6/6d/LandshipBodyMK8.png",true, -0.5, 0.5),
                new Vehicule("Streetle", "https://mario.wiki.gallery/images/c/cf/MK8Streetle.png",true, -0.5, 0.5),
                new Vehicule("Sneeker", "https://mario.wiki.gallery/images/4/47/SneakerBodyMK8.png",true, 0, -0.5),
                new Vehicule("Gold Standard", "https://mario.wiki.gallery/images/f/fe/Gold_Standard.png",true, 0, -0.5),
                new Vehicule("Master Cycle", "https://mario.wiki.gallery/images/8/8a/MK8MasterCycle.png",true, 0, -0.5),
                new Vehicule("W 25 Silver Arrow", "https://mario.wiki.gallery/images/2/25/W25SilverArrow-MK8.png",true, -0.25, 0.25),
                new Vehicule("Flame Rider", "https://mario.wiki.gallery/images/3/31/FlameRiderBodyMK8.png",true, -0.25, 0.25),
                new Vehicule("Standard Bike", "https://mario.wiki.gallery/images/8/84/StandardBikeBodyMK8.png",true, -0.25, 0.25),
                new Vehicule("Wild Wiggler", "https://mario.wiki.gallery/images/a/aa/WildWigglerBodyMK8.png",true, -0.25, 0.25),
                new Vehicule("Blue Falcon", "https://mario.wiki.gallery/images/f/f6/MK8BlueFalcon.png",true, -0.5, -0.25),
                new Vehicule("Splat Buggy", "https://mario.wiki.gallery/images/6/63/MK8DX_Splat_Buggy.png",true, -0.5, -0.25),
                new Vehicule("Tanooki Kart", "https://mario.wiki.gallery/images/7/76/MK8_Tanooki_Buggy_Sprite.png",true, 0.25, -0.5),
                new Vehicule("Master Cycle Zero", "https://mario.wiki.gallery/images/2/26/MK8D_Master_Cycle_Zero.png",true, 0.25, -0.5),
                new Vehicule("Koopa Clown", "https://mario.wiki.gallery/images/7/70/MK8DX_Koopa_Clown.png",true, 0.25, -0.5)
            };
        }

        public void setCharacter()
        {
            characters = new List<Character>()
            {
                new Character("Baby Daisy", "https://mario.wiki.gallery/images/thumb/4/43/MK8_BabyDaisy_Icon.png/64px-MK8_BabyDaisy_Icon.png", 2, 4, false),
                new Character("Baby Peach", "https://mario.wiki.gallery/images/thumb/3/3d/MK8_BabyPeach_Icon.png/64px-MK8_BabyPeach_Icon.png", 2, 4, false),
                new Character("Lemmy", "https://mario.wiki.gallery/images/thumb/f/fc/MK8_Lemmy_Icon.png/64px-MK8_Lemmy_Icon.png", 2, 4.25, false),
                new Character("Baby Rosalina", "https://mario.wiki.gallery/images/thumb/0/09/MK8_BabyRosalina_Icon.png/64px-MK8_BabyRosalina_Icon.png", 2, 4.25, false),
                new Character("Dry Bones", "https://mario.wiki.gallery/images/3/3f/MK8DX_Dry_Bones_Icon.png", 2.25, 4.25, false),
                new Character("Baby Luigi", "https://mario.wiki.gallery/images/thumb/a/aa/MK8_BabyLuigi_Icon.png/64px-MK8_BabyLuigi_Icon.png", 2.25, 4.25, false),
                new Character("Baby Mario", "https://mario.wiki.gallery/images/thumb/d/d2/MK8_BabyMario_Icon.png/64px-MK8_BabyMario_Icon.png", 2.25, 4.25, false),
                new Character("Wendy", "https://mario.wiki.gallery/images/thumb/d/d9/MK8_Wendy_Icon.png/64px-MK8_Wendy_Icon.png", 2.5, 4.25, false),
                new Character("Isabelle", "https://mario.wiki.gallery/images/thumb/2/20/MK8_Isabelle_Icon.png/64px-MK8_Isabelle_Icon.png", 2.5, 4.25, false),
                new Character("Toadette", "https://mario.wiki.gallery/images/thumb/8/8e/MK8_Toadette_Icon.png/64px-MK8_Toadette_Icon.png", 2.5, 4.25, false),
                new Character("Lakitu", "https://mario.wiki.gallery/images/thumb/7/7d/MK8_Lakitu_Icon.png/64px-MK8_Lakitu_Icon.png", 2.5, 4, false),
                new Character("Bowser Jr.", "https://mario.wiki.gallery/images/thumb/2/26/MK8_Bowser_Jr_Icon.png/64px-MK8_Bowser_Jr_Icon.png", 2.5, 4, false),
                new Character("Koopa Troopa", "https://mario.wiki.gallery/images/thumb/b/bc/MK8_Koopa_Icon.png/64px-MK8_Koopa_Icon.png", 2.5, 4, false),
                new Character("Larry", "https://mario.wiki.gallery/images/thumb/c/c2/MK8_Larry_Icon.png/64px-MK8_Larry_Icon.png", 2.75, 4, false),
                new Character("Shy Guy", "https://mario.wiki.gallery/images/thumb/7/7f/MK8_ShyGuy_Icon.png/64px-MK8_ShyGuy_Icon.png", 2.75, 4, false),
                new Character("Toad", "https://mario.wiki.gallery/images/thumb/4/45/MK8_Toad_Icon.png/64px-MK8_Toad_Icon.png", 2.75, 4, false),
                new Character("Inkling Girl", "https://mario.wiki.gallery/images/thumb/b/b9/MK8DX_Female_Inkling_Icon.png/64px-MK8DX_Female_Inkling_Icon.png", 2.75, 4, false),
                new Character("Female Villager", "https://mario.wiki.gallery/images/thumb/c/c3/VillagerFemale-Icon-MK8.png/64px-VillagerFemale-Icon-MK8.png", 2.75, 4, false),
                new Character("Cat Peach", "https://mario.wiki.gallery/images/thumb/a/ad/MK8_Cat_Peach_Icon.png/64px-MK8_Cat_Peach_Icon.png", 2.75, 4, false),
                new Character("Daisy", "https://mario.wiki.gallery/images/thumb/3/32/MK8_Daisy_Icon.png/64px-MK8_Daisy_Icon.png", 3, 3.75, false),
                new Character("Yoshi", "https://mario.wiki.gallery/images/thumb/9/91/MK8_Yoshi_Icon.png/64px-MK8_Yoshi_Icon.png", 3, 3.75, false),
                new Character("Birdo", "https://mario.wiki.gallery/images/thumb/f/f6/MK8D_Birdo_Icon.png/64px-MK8D_Birdo_Icon.png", 3, 3.75, true),
                new Character("Peach", "https://mario.wiki.gallery/images/c/c2/MK8_Peach_Icon.png", 3, 3.75, false),
                new Character("Inkling Boy", "https://mario.wiki.gallery/images/thumb/3/3c/MK8DX_Male_Inkling_Icon.png/64px-MK8DX_Male_Inkling_Icon.png", 3.25, 3.75, false),
                new Character("Male Villager", "https://mario.wiki.gallery/images/thumb/1/16/VillagerMale-Icon-MK8.png/64px-VillagerMale-Icon-MK8.png", 3.25, 3.75, false),
                new Character("Tanooki Mario", "https://mario.wiki.gallery/images/thumb/a/a2/MK8_Tanooki_Mario_Icon.png/64px-MK8_Tanooki_Mario_Icon.png", 3.25, 3.75, false),
                new Character("Ludwig", "https://mario.wiki.gallery/images/thumb/a/a8/MK8_Ludwig_Icon.png/64px-MK8_Ludwig_Icon.png", 3.5, 3.5, false),
                new Character("Mii", "https://mario.wiki.gallery/images/thumb/a/ab/Mii_amiibo_MK8.png/64px-Mii_amiibo_MK8.png", 3.5, 3.5, false),
                new Character("Mario", "https://mario.wiki.gallery/images/d/d9/MK8_Mario_Icon.png", 3.5, 3.5, false),
                new Character("Kamek", "https://mario.wiki.gallery/images/thumb/0/00/MK8DX_Kamek_Icon.png/64px-MK8DX_Kamek_Icon.png", 3.5, 3.5, true),
                new Character("Iggy", "https://mario.wiki.gallery/images/thumb/d/dd/MK8_Iggy_Icon.png/64px-MK8_Iggy_Icon.png", 3.5, 3.5, false),
                new Character("Luigi", "https://mario.wiki.gallery/images/thumb/5/51/MK8_Luigi_Icon.png/64px-MK8_Luigi_Icon.png", 3.5, 3.5, false),
                new Character("King Boo", "https://mario.wiki.gallery/images/thumb/1/1d/MK8DX_King_Boo_Icon.png/64px-MK8DX_King_Boo_Icon.png", 3.75, 3.25, false),
                new Character("Link", "https://mario.wiki.gallery/images/thumb/e/e8/MK8_Link_Icon.png/64px-MK8_Link_Icon.png", 3.75, 3.25, false),
                new Character("Rosalina", "https://mario.wiki.gallery/images/thumb/8/89/MK8_Rosalina_Icon.png/64px-MK8_Rosalina_Icon.png", 3.75, 3.25, false),
                new Character("Gold Mario", "https://mario.wiki.gallery/images/thumb/c/c8/MK8DX_Gold_Mario_Icon.png/120px-MK8DX_Gold_Mario_Icon.png?20170727185506", 4.5, 3.25, false),
                new Character("Pink Gold Peach", "https://mario.wiki.gallery/images/thumb/0/0d/MK8_PGPeach_Icon.png/64px-MK8_PGPeach_Icon.png", 4.5, 3.25, false),
                new Character("Metal Mario", "https://mario.wiki.gallery/images/thumb/e/e3/MK8_MMario_Icon.png/64px-MK8_MMario_Icon.png", 4.5, 3.25, false),
                new Character("Petey Piranha", "https://mario.wiki.gallery/images/thumb/8/86/MK8DX_Petey_Piranha_Icon.png/64px-MK8DX_Petey_Piranha_Icon.png", 4.5, 3.25, true),
                new Character("Donkey Kong", "https://mario.wiki.gallery/images/thumb/0/08/MK8_DKong_Icon.png/64px-MK8_DKong_Icon.png", 4, 3.25, false),
                new Character("Roy", "https://mario.wiki.gallery/images/thumb/3/3e/MK8_Roy_Icon.png/64px-MK8_Roy_Icon.png", 4, 3.25, false),
                new Character("Wiggler", "https://mario.wiki.gallery/images/thumb/7/7e/MK8DX_Wiggler_Icon.png/64px-MK8DX_Wiggler_Icon.png", 4, 3.25, true),
                new Character("Waluigi", "https://mario.wiki.gallery/images/thumb/7/78/MK8_Waluigi_Icon.png/64px-MK8_Waluigi_Icon.png", 4, 3.25, false),
                new Character("Dry Bowser", "https://mario.wiki.gallery/images/thumb/2/29/MK8_Dry_Bowser_Icon.png/64px-MK8_Dry_Bowser_Icon.png", 4.25, 3, false),
                new Character("Wario", "https://mario.wiki.gallery/images/thumb/c/c2/MK8_Wario_Icon.png/64px-MK8_Wario_Icon.png", 4.25, 3, false),
                new Character("Morton", "https://www.mariowiki.com/File:MK8_Morton_Icon.png", 4.5, 3, false),
                new Character("Bowser", "https://mario.wiki.gallery/images/thumb/4/47/MK8_Bowser_Icon.png/64px-MK8_Bowser_Icon.png\r\n", 4.5, 3, false)
            };
        }

        public void setWheel()
        {
            wheels = new List<Wheel>()
            {
                new Wheel("Standard", "https://mario.wiki.gallery/images/a/a8/StandardTiresMK8.png", 0, 0),
                new Wheel("Blue Standar", "https://mario.wiki.gallery/images/d/db/Blue_Standard.png", 0, 0),
                new Wheel("GLA Tires", "https://mario.wiki.gallery/images/b/ba/GLATires-MK8.png", 0, 0),
                new Wheel("Hot Monster", "https://mario.wiki.gallery/images/d/d1/HotMonsterTiresMK8.png", 0.5, -0.5),
                new Wheel("Monster", "https://mario.wiki.gallery/images/2/29/MonsterTiresMK8.png", 0.5, -0.5),
                new Wheel("Ancient Tires", "https://mario.wiki.gallery/images/d/d5/MK8D_Ancient_Tires.png", 0.5, -0.5),
                new Wheel("Azure Roller", "https://mario.wiki.gallery/images/f/fe/AzureRollerTiresMK8.png", -0.5, 0.5),
                new Wheel("Roller", "https://mario.wiki.gallery/images/7/76/RollerTiresMK8.png", -0.5, 0.5),
                new Wheel("Wood", "https://mario.wiki.gallery/images/0/03/WoodTiresMK8.png", 0, -0.5),
                new Wheel("Crimson Slim", "https://mario.wiki.gallery/images/7/71/CrimsonSlimTiresMK8.png", 0, -0.5),
                new Wheel("Slim", "https://mario.wiki.gallery/images/f/f8/SlimTiresMK8.png", 0, -0.5),
                new Wheel("Cyber Slick", "https://mario.wiki.gallery/images/2/29/CyberSlickTiresMK8.png", 0.25, -0.75),
                new Wheel("Slick", "https://mario.wiki.gallery/images/d/dd/SlickTiresMK8.png", 0.25, -0.75),
                new Wheel("Metal", "https://mario.wiki.gallery/images/9/96/MetalTiresMK8.png", 0.5, -1),
                new Wheel("Gold Tires", "https://mario.wiki.gallery/images/5/52/Gold_Tires_MK8.png", 0.5, -1),
                new Wheel("Leaf Tires", "https://mario.wiki.gallery/images/f/f9/Leaf_Tires_MK8.png", -0.5, 0.25),
                new Wheel("Button", "https://mario.wiki.gallery/images/0/07/ButtonTiresMK8.png", -0.5, 0.25),
                new Wheel("Retro Off-Road", "https://mario.wiki.gallery/images/4/48/Retro_Off-Road.png", 0.25, -0.25),
                new Wheel("Off-Road", "https://mario.wiki.gallery/images/2/25/Off-Road.png", 0.25, -0.25),
                new Wheel("Triforce Tires", "https://mario.wiki.gallery/images/9/9d/MK8-TriforceTires.png", 0.25, -0.25),
                new Wheel("Sponge", "https://mario.wiki.gallery/images/4/4c/SpongeTiresMK8.png", -0.25, 0),
                new Wheel("Cushion", "https://mario.wiki.gallery/images/9/92/CushionTiresMK8.png", -0.25, 0)
            };
        }

        public void setGlider()
        {
            gliders = new List<Glider>()
            {
                new Glider("Super Glider", "https://mario.wiki.gallery/images/a/a8/SuperGliderMK8.png", 0, 0),
                new Glider("Waddle Wing", "https://mario.wiki.gallery/images/e/ef/WaddleWingMK8.png", 0, 0),
                new Glider("Hylian Kite", "https://mario.wiki.gallery/images/9/9c/MK8-HylianKite.png", 0, 0),
                new Glider("Parachute", "https://mario.wiki.gallery/images/d/dd/ParachuteGliderMK8.png", -0.25, 0.25),
                new Glider("Flower Glider", "https://mario.wiki.gallery/images/b/b3/FlowerGliderMK8.png", -0.25, 0.25),
                new Glider("Paper Glider", "https://mario.wiki.gallery/images/0/0e/PaperGliderIcon-MK8.png", -0.25, 0.25),
                new Glider("Cloud Glider", "https://mario.wiki.gallery/images/8/84/Cloud_Glider.png", -0.25, 0.25),
                new Glider("Paraglider", "https://mario.wiki.gallery/images/3/39/MK8D_Paraglider.png", 0.25, 0),
                new Glider("Gold Glider", "https://mario.wiki.gallery/images/1/18/GoldGliderMK8.png", 0.25, 0),
                new Glider("Plane Glider", "https://mario.wiki.gallery/images/c/ca/PlaneGliderMK8.png", 0.25, 0),
                new Glider("Wario Wing", "https://mario.wiki.gallery/images/a/ae/WarioWingMK8.png", 0.25, 0),
                new Glider("MKTV Parfoil", "https://mario.wiki.gallery/images/9/96/MKTVParafoilGliderMK8.png", 0, 0.25),
                new Glider("Bowser Kite", "https://mario.wiki.gallery/images/f/f7/BowserKiteMK8.png", 0, 0.25),
                new Glider("Parafoil", "https://mario.wiki.gallery/images/c/c4/ParafoilGliderMK8.png", 0, 0.25),
                new Glider("Peach Parasol", "https://mario.wiki.gallery/images/6/6e/PeachParasolGliderMK8.png", 0, 0.25)
            };
        }
    }
}
