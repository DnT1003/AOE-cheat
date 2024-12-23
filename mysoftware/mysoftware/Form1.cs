using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using static System.Formats.Asn1.AsnWriter;

namespace mysoftware
{
    public partial class Form1 : Form
    {
        private string currentSelection = "Villager"; // Track current DomainUpDown selection
        private string BAcurrentSelection = "1:(Barracks)Clubman";
        private string BEcurrentSelection = "1:(Barracks)Clubman";
        // Villager data storage
        private string VillagerAttackValue;
        private string VillagerHpValue;
        private string VillagerSpeedValue;
        private string VillagerCSpeedValue;

        // Fishing Boat data storage
        private string fishingBoatAttackValue;
        private string fishingBoatHpValue;
        private string fishingBoatSpeedValue;
        private string fishingBoatCSpeedValue;

        private string ClubmanAttackValue;
        private string ClubmanHpValue;
        private string ClubmanSpeedValue;
        private string ClubmanLoSValue;

        private string AxemanAttackValue;
        private string AxemanHpValue;
        private string AxemanSpeedValue;
        private string AxemanLoSValue;

        private string ShortSwordsmanAttackValue;
        private string ShortSwordsmanHpValue;
        private string ShortSwordsmanSpeedValue;
        private string ShortSwordsmanLoSValue;

        private string BroadSwordsmanAttackValue;
        private string BroadSwordsmanHpValue;
        private string BroadSwordsmanSpeedValue;
        private string BroadSwordsmanLoSValue;

        private string LongSwordsmanAttackValue;
        private string LongSwordsmanHpValue;
        private string LongSwordsmanSpeedValue;
        private string LongSwordsmanLoSValue;

        private string LegionaryAttackValue;
        private string LegionaryHpValue;
        private string LegionarySpeedValue;
        private string LegionaryLoSValue;

        private string SlingerAttackValue;
        private string SlingerHpValue;
        private string SlingerSpeedValue;
        private string SlingerLoSValue;

        private string BowmanAttackValue;
        private string BowmanHpValue;
        private string BowmanSpeedValue;
        private string BowmanLoSValue;

        private string ImprovedBowmanAttackValue;
        private string ImprovedBowmanHpValue;
        private string ImprovedBowmanSpeedValue;
        private string ImprovedBowmanLoSValue;

        private string CompositeBowmanAttackValue;
        private string CompositeBowmanHpValue;
        private string CompositeBowmanSpeedValue;
        private string CompositeBowmanLoSValue;

        private string ChariotArcherAttackValue;
        private string ChariotArcherHpValue;
        private string ChariotArcherSpeedValue;
        private string ChariotArcherLoSValue;

        private string HorseArcherAttackValue;
        private string HorseArcherHpValue;
        private string HorseArcherSpeedValue;
        private string HorseArcherLoSValue;

        private string HeavyHorseArcherAttackValue;
        private string HeavyHorseArcherHpValue;
        private string HeavyHorseArcherSpeedValue;
        private string HeavyHorseArcherLoSValue;

        private string ElephantArcherAttackValue;
        private string ElephantArcherHpValue;
        private string ElephantArcherSpeedValue;
        private string ElephantArcherLoSValue;

        private string ScoutAttackValue;
        private string ScoutHpValue;
        private string ScoutSpeedValue;
        private string ScoutLoSValue;

        private string ChariotAttackValue;
        private string ChariotHpValue;
        private string ChariotSpeedValue;
        private string ChariotLoSValue;

        private string ScytheChariotAttackValue;
        private string ScytheChariotHpValue;
        private string ScytheChariotSpeedValue;
        private string ScytheChariotLoSValue;

        private string CavalryAttackValue;
        private string CavalryHpValue;
        private string CavalrySpeedValue;
        private string CavalryLoSValue;

        private string HeavyCavalryAttackValue;
        private string HeavyCavalryHpValue;
        private string HeavyCavalrySpeedValue;
        private string HeavyCavalryLoSValue;

        private string CataphractAttackValue;
        private string CataphractHpValue;
        private string CataphractSpeedValue;
        private string CataphractLoSValue;

        private string WarElephantAttackValue;
        private string WarElephantHpValue;
        private string WarElephantSpeedValue;
        private string WarElephantLoSValue;

        private string ArmoredElephantAttackValue;
        private string ArmoredElephantHpValue;
        private string ArmoredElephantSpeedValue;
        private string ArmoredElephantLoSValue;

        private string CamelRiderAttackValue;
        private string CamelRiderHpValue;
        private string CamelRiderSpeedValue;
        private string CamelRiderLoSValue;

        private string StoneThrowerAttackValue;
        private string StoneThrowerHpValue;
        private string StoneThrowerSpeedValue;
        private string StoneThrowerLoSValue;

        private string CatapultAttackValue;
        private string CatapultHpValue;
        private string CatapultSpeedValue;
        private string CatapultLoSValue;

        private string HeavyCatapultAttackValue;
        private string HeavyCatapultHpValue;
        private string HeavyCatapultSpeedValue;
        private string HeavyCatapultLoSValue;

        private string BallistaAttackValue;
        private string BallistaHpValue;
        private string BallistaSpeedValue;
        private string BallistaLoSValue;

        private string HelepolisAttackValue;
        private string HelepolisHpValue;
        private string HelepolisSpeedValue;
        private string HelepolisLoSValue;

        private string HopliteAttackValue;
        private string HopliteHpValue;
        private string HopliteSpeedValue;
        private string HopliteLoSValue;

        private string PhalangiteAttackValue;
        private string PhalangiteHpValue;
        private string PhalangiteSpeedValue;
        private string PhalangiteLoSValue;

        private string CenturionAttackValue;
        private string CenturionHpValue;
        private string CenturionSpeedValue;
        private string CenturionLoSValue;

        private string PriestAttackValue;
        private string PriestHpValue;
        private string PriestSpeedValue;
        private string PriestLoSValue;

        private string TradeBoatAttackValue;
        private string TradeBoatHpValue;
        private string TradeBoatSpeedValue;
        private string TradeBoatLoSValue;

        private string MerchantShipAttackValue;
        private string MerchantShipHpValue;
        private string MerchantShipSpeedValue;
        private string MerchantShipLoSValue;

        private string LightTransportAttackValue;
        private string LightTransportHpValue;
        private string LightTransportSpeedValue;
        private string LightTransportLoSValue;

        private string HeavyTransportAttackValue;
        private string HeavyTransportHpValue;
        private string HeavyTransportSpeedValue;
        private string HeavyTransportLoSValue;

        private string ScoutShipAttackValue;
        private string ScoutShipHpValue;
        private string ScoutShipSpeedValue;
        private string ScoutShipLoSValue;

        private string WarGalleyAttackValue;
        private string WarGalleyHpValue;
        private string WarGalleySpeedValue;
        private string WarGalleyLoSValue;

        private string TriremeAttackValue;
        private string TriremeHpValue;
        private string TriremeSpeedValue;
        private string TriremeLoSValue;

        private string CatapultTriremeAttackValue;
        private string CatapultTriremeHpValue;
        private string CatapultTriremeSpeedValue;
        private string CatapultTriremeLoSValue;

        private string JuggernautAttackValue;
        private string JuggernautHpValue;
        private string JuggernautSpeedValue;
        private string JuggernautLoSValue;

        private string FireGalleyAttackValue;
        private string FireGalleyHpValue;
        private string FireGalleySpeedValue;
        private string FireGalleyLoSValue;

        private string TradeCartAttackValue;
        private string TradeCartHpValue;
        private string TradeCartSpeedValue;
        private string TradeCartLoSValue;

        private string EClubmanAttackValue;
        private string EClubmanHpValue;
        private string EClubmanSpeedValue;
        private string EClubmanLoSValue;

        private string EAxemanAttackValue;
        private string EAxemanHpValue;
        private string EAxemanSpeedValue;
        private string EAxemanLoSValue;

        private string EShortSwordsmanAttackValue;
        private string EShortSwordsmanHpValue;
        private string EShortSwordsmanSpeedValue;
        private string EShortSwordsmanLoSValue;

        private string EBroadSwordsmanAttackValue;
        private string EBroadSwordsmanHpValue;
        private string EBroadSwordsmanSpeedValue;
        private string EBroadSwordsmanLoSValue;

        private string ELongSwordsmanAttackValue;
        private string ELongSwordsmanHpValue;
        private string ELongSwordsmanSpeedValue;
        private string ELongSwordsmanLoSValue;

        private string ELegionaryAttackValue;
        private string ELegionaryHpValue;
        private string ELegionarySpeedValue;
        private string ELegionaryLoSValue;

        private string ESlingerAttackValue;
        private string ESlingerHpValue;
        private string ESlingerSpeedValue;
        private string ESlingerLoSValue;

        private string EBowmanAttackValue;
        private string EBowmanHpValue;
        private string EBowmanSpeedValue;
        private string EBowmanLoSValue;

        private string EImprovedBowmanAttackValue;
        private string EImprovedBowmanHpValue;
        private string EImprovedBowmanSpeedValue;
        private string EImprovedBowmanLoSValue;

        private string ECompositeBowmanAttackValue;
        private string ECompositeBowmanHpValue;
        private string ECompositeBowmanSpeedValue;
        private string ECompositeBowmanLoSValue;

        private string EChariotArcherAttackValue;
        private string EChariotArcherHpValue;
        private string EChariotArcherSpeedValue;
        private string EChariotArcherLoSValue;

        private string EHorseArcherAttackValue;
        private string EHorseArcherHpValue;
        private string EHorseArcherSpeedValue;
        private string EHorseArcherLoSValue;

        private string EHeavyHorseArcherAttackValue;
        private string EHeavyHorseArcherHpValue;
        private string EHeavyHorseArcherSpeedValue;
        private string EHeavyHorseArcherLoSValue;

        private string EElephantArcherAttackValue;
        private string EElephantArcherHpValue;
        private string EElephantArcherSpeedValue;
        private string EElephantArcherLoSValue;

        private string EScoutAttackValue;
        private string EScoutHpValue;
        private string EScoutSpeedValue;
        private string EScoutLoSValue;

        private string EChariotAttackValue;
        private string EChariotHpValue;
        private string EChariotSpeedValue;
        private string EChariotLoSValue;

        private string EScytheChariotAttackValue;
        private string EScytheChariotHpValue;
        private string EScytheChariotSpeedValue;
        private string EScytheChariotLoSValue;

        private string ECavalryAttackValue;
        private string ECavalryHpValue;
        private string ECavalrySpeedValue;
        private string ECavalryLoSValue;

        private string EHeavyCavalryAttackValue;
        private string EHeavyCavalryHpValue;
        private string EHeavyCavalrySpeedValue;
        private string EHeavyCavalryLoSValue;

        private string ECataphractAttackValue;
        private string ECataphractHpValue;
        private string ECataphractSpeedValue;
        private string ECataphractLoSValue;

        private string EWarElephantAttackValue;
        private string EWarElephantHpValue;
        private string EWarElephantSpeedValue;
        private string EWarElephantLoSValue;

        private string EArmoredElephantAttackValue;
        private string EArmoredElephantHpValue;
        private string EArmoredElephantSpeedValue;
        private string EArmoredElephantLoSValue;

        private string ECamelRiderAttackValue;
        private string ECamelRiderHpValue;
        private string ECamelRiderSpeedValue;
        private string ECamelRiderLoSValue;

        private string EStoneThrowerAttackValue;
        private string EStoneThrowerHpValue;
        private string EStoneThrowerSpeedValue;
        private string EStoneThrowerLoSValue;

        private string ECatapultAttackValue;
        private string ECatapultHpValue;
        private string ECatapultSpeedValue;
        private string ECatapultLoSValue;

        private string EHeavyCatapultAttackValue;
        private string EHeavyCatapultHpValue;
        private string EHeavyCatapultSpeedValue;
        private string EHeavyCatapultLoSValue;

        private string EBallistaAttackValue;
        private string EBallistaHpValue;
        private string EBallistaSpeedValue;
        private string EBallistaLoSValue;

        private string EHelepolisAttackValue;
        private string EHelepolisHpValue;
        private string EHelepolisSpeedValue;
        private string EHelepolisLoSValue;

        private string EHopliteAttackValue;
        private string EHopliteHpValue;
        private string EHopliteSpeedValue;
        private string EHopliteLoSValue;

        private string EPhalangiteAttackValue;
        private string EPhalangiteHpValue;
        private string EPhalangiteSpeedValue;
        private string EPhalangiteLoSValue;

        private string ECenturionAttackValue;
        private string ECenturionHpValue;
        private string ECenturionSpeedValue;
        private string ECenturionLoSValue;

        private string EPriestAttackValue;
        private string EPriestHpValue;
        private string EPriestSpeedValue;
        private string EPriestLoSValue;

        private string ETradeBoatAttackValue;
        private string ETradeBoatHpValue;
        private string ETradeBoatSpeedValue;
        private string ETradeBoatLoSValue;

        private string EMerchantShipAttackValue;
        private string EMerchantShipHpValue;
        private string EMerchantShipSpeedValue;
        private string EMerchantShipLoSValue;

        private string ELightTransportAttackValue;
        private string ELightTransportHpValue;
        private string ELightTransportSpeedValue;
        private string ELightTransportLoSValue;

        private string EHeavyTransportAttackValue;
        private string EHeavyTransportHpValue;
        private string EHeavyTransportSpeedValue;
        private string EHeavyTransportLoSValue;

        private string EScoutShipAttackValue;
        private string EScoutShipHpValue;
        private string EScoutShipSpeedValue;
        private string EScoutShipLoSValue;

        private string EWarGalleyAttackValue;
        private string EWarGalleyHpValue;
        private string EWarGalleySpeedValue;
        private string EWarGalleyLoSValue;

        private string ETriremeAttackValue;
        private string ETriremeHpValue;
        private string ETriremeSpeedValue;
        private string ETriremeLoSValue;

        private string ECatapultTriremeAttackValue;
        private string ECatapultTriremeHpValue;
        private string ECatapultTriremeSpeedValue;
        private string ECatapultTriremeLoSValue;

        private string EJuggernautAttackValue;
        private string EJuggernautHpValue;
        private string EJuggernautSpeedValue;
        private string EJuggernautLoSValue;

        private string EFireGalleyAttackValue;
        private string EFireGalleyHpValue;
        private string EFireGalleySpeedValue;
        private string EFireGalleyLoSValue;

        private string ETradeCartAttackValue;
        private string ETradeCartHpValue;
        private string ETradeCartSpeedValue;
        private string ETradeCartLoSValue;

        private RadioButton[] VillagerRadioButtons; // Array for "Villager" RadioButtons
        private RadioButton[] fishingBoatRadioButtons; // Array for "Fishing Boat" RadioButtons
        private RadioButton selectedVillagerRadioButton; // To store the selected Villager RadioButton
        private RadioButton selectedFishingBoatRadioButton; // To store the selected Fishing Boat RadioButton

        public Form1()
        {
            InitializeComponent();
            InitializeDomainUpDown(); // Initialize DomainUpDown items
            InitializeAlliesComboBox();
            InitializeEnemiesComboBox();
            InitializeSpawnUnitsComboBox();
            InitializeSpawnBuildingsComboBox();
            InitializeSpawnResourcesComboBox();
            InitializeBackgroundMusicComboBox();
            InitializeRadioButtonGroups(); // Group RadioButtons
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateRadioButtonsVisibility("Villager"); // Set initial visibility
        }

        private void domainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            string selectedItem = Collectors.Text;

            // Only update visibility if selection changes
            if (selectedItem != currentSelection)
            {
                SaveCurrentSelection(); // Save the current selection
                currentSelection = selectedItem;
                UpdateRadioButtonsVisibility(selectedItem);
                RestoreSavedSelection(); // Restore the saved selection for the new domain
            }
        }

        private void InitializeDomainUpDown()
        {
            // Add items to DomainUpDown
            Collectors.Items.Add("Villager");
            Collectors.Items.Add("Fishing Boat");
            Collectors.SelectedIndex = 0; // Default selection
        }
        private void InitializeAlliesComboBox()
        {


            AlliesName.Items.AddRange(new string[] { "1:(Barracks)Clubman", "2:(Barracks)Axeman",
                "3:(Barracks)Short Swordsman", "4:(Barracks)Broad Swordsman", "5:(Barracks)Long Swordsman",
                "6:(Barracks)Legionary", "7:(Barracks)Slinger", "8:(Archery Range)Bowman", "9:(Archery Range)Improved Bowman",
                "10:(Archery Range)Composite Bowman", "11:(Archery Range)Chariot Archer", "12:(Archery Range)Horse Archer",
                "13:(Archery Range)Heavy Horse Archer", "14:(Archery Range)Elephant Archer", "15:(Stable)Scout", "16:(Stable)Chariot",
                "17:(Stable)Scythe Chariot", "18:(Stable)Cavalry", "19:(Stable)Heavy Cavalry", "20:(Stable)Cataphract",
                "21:(Stable)War Elephant", "22:(Stable)Armored Elephant", "23:(Stable)Camel Rider", "24:(Siege Workshop)Stone Thrower",
                "25:(Siege Workshop)Catapult", "26:(Siege Workshop)Heavy Catapult", "27:(Siege Workshop)Ballista",
                "28:(Siege Workshop)Helepolis", "29:(Academy)Hoplite", "30:(Academy)Phalangite",
                "31:(Academy)Centurion", "32:(Temple)Priest", "33:(Dock)Trade Boat", "34:(Dock)Merchant Ship", "35:(Dock)Heavy Transport",
                "36:(Dock)Light Transport", "37:(Dock)Scout Ship", "38:(Dock)War Galley", "39:(Dock)Trireme", "40:(Dock)Catapult Trireme",
                "41:(Dock)Juggernaut", "42:(Dock)Fire Galley","43:(Dock)Trade Cart"}); // Add domains
            AlliesName.SelectedIndex = 0; // Set default selection


        }

        private void InitializeEnemiesComboBox()
        {


            EnemiesName.Items.AddRange(new string[] { "1:(Barracks)Clubman", "2:(Barracks)Axeman",
                "3:(Barracks)Short Swordsman", "4:(Barracks)Broad Swordsman ", "5:(Barracks)Long Swordsman ",
                "6:(Barracks)Legionary", "7:(Barracks)Slinger", "8:(Archery Range)Bowman", "9:(Archery Range)Improved Bowman",
                "10:(Archery Range)Composite Bowman", "11:(Archery Range)Chariot Archer", "12:(Archery Range)Horse Archer",
                "13:(Archery Range)Heavy Horse Archer", "14:(Archery Range)Elephant Archer", "15:(Stable)Scout", "16:(Stable)Chariot",
                "17:(Stable)Scythe Chariot", "18:(Stable)Cavalry", "19:(Stable)Heavy Cavalry", "20:(Stable)Cataphract",
                "21:(Stable)War Elephant", "22:(Stable)Armored Elephant", "23:(Stable)Camel Rider", "24:(Siege Workshop)Stone Thrower",
                "25:(Siege Workshop)Catapult", "26:(Siege Workshop)Heavy Catapult", "27:(Siege Workshop)Ballista",
                "28:(Siege Workshop)Helepolis", "29:(Academy)Hoplite", "30:(Academy)Phalangite",
                "31:(Academy)Centurion", "32:(Temple)Priest", "33:(Dock)Trade Boat", "34:(Dock)Merchant Ship", "35:(Dock)Heavy Transport",
                "36:(Dock)Light Transport", "37:(Dock)Scout Ship", "38:(Dock)War Galley", "39:(Dock)Trireme", "40:(Dock)Catapult Trireme",
                "41:(Dock)Juggernaut", "42:(Dock)Fire Galley","43:(Dock)Trade Cart"}); // Add domains
            EnemiesName.SelectedIndex = 0; // Set default selection


        }
        private void InitializeSpawnUnitsComboBox()
        {
            SpawnUnits.Items.AddRange(new string[] { "0:(Town Center)Villager", "1:(Barracks)Clubman", "2:(Barracks)Axeman",
                "3:(Barracks)Short Swordsman", "4:(Barracks)Broad Swordsman", "5:(Barracks)Long Swordsman",
                "6:(Barracks)Legionary", "7:(Barracks)Slinger", "8:(Archery Range)Bowman", "9:(Archery Range)Improved Bowman",
                "10:(Archery Range)Composite Bowman", "11:(Archery Range)Chariot Archer", "12:(Archery Range)Horse Archer",
                "13:(Archery Range)Heavy Horse Archer", "14:(Archery Range)Elephant Archer", "15:(Stable)Scout", "16:(Stable)Chariot",
                "17:(Stable)Scythe Chariot", "18:(Stable)Cavalry", "19:(Stable)Heavy Cavalry", "20:(Stable)Cataphract",
                "21:(Stable)War Elephant", "22:(Stable)Armored Elephant", "23:(Stable)Camel Rider", "24:(Siege Workshop)Stone Thrower",
                "25:(Siege Workshop)Catapult", "26:(Siege Workshop)Heavy Catapult", "27:(Siege Workshop)Ballista",
                "28:(Siege Workshop)Helepolis", "29:(Academy)Hoplite", "30:(Academy)Phalangite",
                "31:(Academy)Centurion", "32:(Temple)Priest", "33:(Dock)Trade Boat", "34:(Dock)Merchant Ship", "35:(Dock)Heavy Transport",
                "36:(Dock)Light Transport", "37:(Dock)Scout Ship", "38:(Dock)War Galley", "39:(Dock)Trireme", "40:(Dock)Catapult Trireme",
                "41:(Dock)Juggernaut", "42:(Dock)Fire Galley","43:(Dock)Trade Cart","44:(Dock)Fishing Boat","44:(Dock)Fishing Ship"}); // Add domains
            SpawnUnits.SelectedIndex = 0; // Set default selection




        }
        private void InitializeSpawnResourcesComboBox()
        {

            SpawnResources.Items.AddRange(new string[] { "1:Berry Bush", "2:Shore Fish", "3:Deep Sea Fish", "4:Tree", "5:Stone Mine",
                "6:Gold Mine","7:Alligator","8:Gazelle","9:Elephant (Alpha)","10:Elephant","11:Lion","12:Gazelle (Alpha)","13:Crocodile (Alpha)",
                "14:Lion (Alpha)","15:Elephant",});
            SpawnResources.SelectedIndex = 0;



        }
        private void InitializeSpawnBuildingsComboBox()
        {

            SpawnBuildings.Items.AddRange(new string[] { "1:Town Center", "2:Storage Pit", "3:Dock", "4:Barracks", "5:Granary",
                "6:House","7:Archery Range","8:Market","9:Watch Tower","10:Stable","11:Small Wall","12:Farm","13:Small Gate",
                "14:Government Center","15:Temple","16:Medium Wall","17:Medium Gate","18:Sentry Tower","19:Academy","20:Siege Workshop",
                "21:Temple","22:Town Center(Bronze Age)","23:Fortified Wall","24:Fortified Gate","25:Guard Tower","26:Ballista Tower"});
            SpawnBuildings.SelectedIndex = 0;



        }
        private void InitializeBackgroundMusicComboBox()
        {

            BackgroundMusic.Items.AddRange(new string[] { "1:The Hunt", "2:Marching Forward", "3:Discovery At Sea", "4:Conquest", "5:Awakening Spirits",
                "6:Dawn of a New Age","7:The Wind Gods","8:The Emergence","9:The Journey","10:Eastern Echoes","11:Egyptian Hymn","12:Stephen","13:New Technology",
                "14:Tango Alpha Bravo","15:Polyester Jammy","16:Hyman's Wrath","17:Slow and Spacious (Mix 2)","18:Mean (Aint no Hip-Hop in tha House Mix)","19:Medieval Melody (Mix 2)","20:Sh'washa / Rocky Roads",
                "21:Crawly / Kitty's Song","22:Fretless Salsa (Mix 2)","23:Fortified Wall","24:Bigelow's Bungalow","25:Loss (Mix 2)","26:Win (Mix 2)"});
            BackgroundMusic.SelectedIndex = 0;



        }



        private void InitializeRadioButtonGroups()
        {
            // Group "Villager" RadioButtons
            VillagerRadioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };

            // Group "Fishing Boat" RadioButtons
            fishingBoatRadioButtons = new RadioButton[] { radioButton5 /* Add more if needed */ };
        }

        private void UpdateRadioButtonsVisibility(string selection)
        {
            // Handle "Villager"
            if (selection == "Villager")
            {
                SetRadioButtonsVisibility(VillagerRadioButtons, true);
                SetRadioButtonsVisibility(fishingBoatRadioButtons, false);
            }
            // Handle "Fishing Boat"
            else if (selection == "Fishing Boat")
            {
                SetRadioButtonsVisibility(VillagerRadioButtons, false);
                SetRadioButtonsVisibility(fishingBoatRadioButtons, true);
            }
        }

        private void SetRadioButtonsVisibility(RadioButton[] radioButtons, bool isVisible)
        {
            foreach (var rb in radioButtons)
            {
                rb.Visible = isVisible;
            }
        }

        private void SaveCurrentSelection()
        {
            // Save the selected RadioButton for the current domain
            if (currentSelection == "Villager")
            {
                selectedVillagerRadioButton = GetSelectedRadioButton(VillagerRadioButtons);
                // Save current Villager values
                VillagerAttackValue = AttackValue.Text;
                VillagerHpValue = HpValue.Text;
                VillagerSpeedValue = Speed.Value.ToString();
                VillagerCSpeedValue = CSpeed.Value.ToString();
            }
            else if (currentSelection == "Fishing Boat")
            {
                selectedFishingBoatRadioButton = GetSelectedRadioButton(fishingBoatRadioButtons);
                // Save current Fishing Boat values
                fishingBoatAttackValue = AttackValue.Text;
                fishingBoatHpValue = HpValue.Text;
                fishingBoatSpeedValue = Speed.Value.ToString();
                fishingBoatCSpeedValue = CSpeed.Value.ToString();
            }
        }
        private void SaveCurrentSelection1()
        {
            // Save the selected RadioButton for the current domain
            if (BAcurrentSelection == "1:(Barracks)Clubman")
            {
                ClubmanAttackValue = BAAttackValue.Text;
                ClubmanHpValue = BAHpValue.Text;
                ClubmanSpeedValue = BASpeed.Value.ToString();
                ClubmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "2:(Barracks)Axeman")
            {
                AxemanAttackValue = BAAttackValue.Text;
                AxemanHpValue = BAHpValue.Text;
                AxemanSpeedValue = BASpeed.Value.ToString();
                AxemanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "3:(Barracks)Short Swordsman")
            {
                ShortSwordsmanAttackValue = BAAttackValue.Text;
                ShortSwordsmanHpValue = BAHpValue.Text;
                ShortSwordsmanSpeedValue = BASpeed.Value.ToString();
                ShortSwordsmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "4:(Barracks)Broad Swordsman")
            {
                BroadSwordsmanAttackValue = BAAttackValue.Text;
                BroadSwordsmanHpValue = BAHpValue.Text;
                BroadSwordsmanSpeedValue = BASpeed.Value.ToString();
                BroadSwordsmanLoSValue = BALoS.Text;
            }

            else if (BAcurrentSelection == "5:(Barracks)Long Swordsman")
            {
                LongSwordsmanAttackValue = BAAttackValue.Text;
                LongSwordsmanHpValue = BAHpValue.Text;
                LongSwordsmanSpeedValue = BASpeed.Value.ToString();
                LongSwordsmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "6:(Barracks)Legionary")
            {
                LegionaryAttackValue = BAAttackValue.Text;
                LegionaryHpValue = BAHpValue.Text;
                LegionarySpeedValue = BASpeed.Value.ToString();
                LegionaryLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "7:(Barracks)Slinger")
            {
                SlingerAttackValue = BAAttackValue.Text;
                SlingerHpValue = BAHpValue.Text;
                SlingerSpeedValue = BASpeed.Value.ToString();
                SlingerLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "8:(Archery Range)Bowman")
            {
                BowmanAttackValue = BAAttackValue.Text;
                BowmanHpValue = BAHpValue.Text;
                BowmanSpeedValue = BASpeed.Value.ToString();
                BowmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "9:(Archery Range)Improved Bowman")
            {
                ImprovedBowmanAttackValue = BAAttackValue.Text;
                ImprovedBowmanHpValue = BAHpValue.Text;
                ImprovedBowmanSpeedValue = BASpeed.Value.ToString();
                ImprovedBowmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "10:(Archery Range)Composite Bowman")
            {
                CompositeBowmanAttackValue = BAAttackValue.Text;
                CompositeBowmanHpValue = BAHpValue.Text;
                CompositeBowmanSpeedValue = BASpeed.Value.ToString();
                CompositeBowmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "11:(Archery Range)Chariot Archer")
            {
                ChariotArcherAttackValue = BAAttackValue.Text;
                ChariotArcherHpValue = BAHpValue.Text;
                ChariotArcherSpeedValue = BASpeed.Value.ToString();
                ChariotArcherLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "12:(Archery Range)Horse Archer")
            {
                HorseArcherAttackValue = BAAttackValue.Text;
                HorseArcherHpValue = BAHpValue.Text;
                HorseArcherSpeedValue = BASpeed.Value.ToString();
                HorseArcherLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "13:(Archery Range)Heavy Horse Archer")
            {
                HeavyHorseArcherAttackValue = BAAttackValue.Text;
                HeavyHorseArcherHpValue = BAHpValue.Text;
                HeavyHorseArcherSpeedValue = BASpeed.Value.ToString();
                HeavyHorseArcherLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "14:(Archery Range)Elephant Archer")
            {
                ElephantArcherAttackValue = BAAttackValue.Text;
                ElephantArcherHpValue = BAHpValue.Text;
                ElephantArcherSpeedValue = BASpeed.Value.ToString();
                ElephantArcherLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "15:(Stable)Scout")
            {
                ScoutAttackValue = BAAttackValue.Text;
                ScoutHpValue = BAHpValue.Text;
                ScoutSpeedValue = BASpeed.Value.ToString();
                ScoutLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "16:(Stable)Chariot")
            {
                ChariotAttackValue = BAAttackValue.Text;
                ChariotHpValue = BAHpValue.Text;
                ChariotSpeedValue = BASpeed.Value.ToString();
                ChariotLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "17:(Stable)Scythe Chariot")
            {
                ScytheChariotAttackValue = BAAttackValue.Text;
                ScytheChariotHpValue = BAHpValue.Text;
                ScytheChariotSpeedValue = BASpeed.Value.ToString();
                ScytheChariotLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "18:(Stable)Cavalry")
            {
                CavalryAttackValue = BAAttackValue.Text;
                CavalryHpValue = BAHpValue.Text;
                CavalrySpeedValue = BASpeed.Value.ToString();
                CavalryLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "19:(Stable)Heavy Cavalry")
            {
                HeavyCavalryAttackValue = BAAttackValue.Text;
                HeavyCavalryHpValue = BAHpValue.Text;
                HeavyCavalrySpeedValue = BASpeed.Value.ToString();
                HeavyCavalryLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "20:(Stable)Cataphract")
            {
                CataphractAttackValue = BAAttackValue.Text;
                CataphractHpValue = BAHpValue.Text;
                CataphractSpeedValue = BASpeed.Value.ToString();
                CataphractLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "21:(Stable)War Elephant")
            {
                WarElephantAttackValue = BAAttackValue.Text;
                WarElephantHpValue = BAHpValue.Text;
                WarElephantSpeedValue = BASpeed.Value.ToString();
                WarElephantLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "22:(Stable)Armored Elephant")
            {
                ArmoredElephantAttackValue = BAAttackValue.Text;
                ArmoredElephantHpValue = BAHpValue.Text;
                ArmoredElephantSpeedValue = BASpeed.Value.ToString();
                ArmoredElephantLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "23:(Stable)Camel Rider")
            {
                CamelRiderAttackValue = BAAttackValue.Text;
                CamelRiderHpValue = BAHpValue.Text;
                CamelRiderSpeedValue = BASpeed.Value.ToString();
                CamelRiderLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "24:(Siege Workshop)Stone Thrower")
            {
                StoneThrowerAttackValue = BAAttackValue.Text;
                StoneThrowerHpValue = BAHpValue.Text;
                StoneThrowerSpeedValue = BASpeed.Value.ToString();
                StoneThrowerLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "25:(Siege Workshop)Catapult")
            {
                CatapultAttackValue = BAAttackValue.Text;
                CatapultHpValue = BAHpValue.Text;
                CatapultSpeedValue = BASpeed.Value.ToString();
                CatapultLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "26:(Siege Workshop)Heavy Catapult")
            {
                HeavyCatapultAttackValue = BAAttackValue.Text;
                HeavyCatapultHpValue = BAHpValue.Text;
                HeavyCatapultSpeedValue = BASpeed.Value.ToString();
                HeavyCatapultLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "27:(Siege Workshop)Ballista")
            {
                BallistaAttackValue = BAAttackValue.Text;
                BallistaHpValue = BAHpValue.Text;
                BallistaSpeedValue = BASpeed.Value.ToString();
                BallistaLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "28:(Siege Workshop)Helepolis")
            {
                HelepolisAttackValue = BAAttackValue.Text;
                HelepolisHpValue = BAHpValue.Text;
                HelepolisSpeedValue = BASpeed.Value.ToString();
                HelepolisLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "29:(Academy)Hoplite")
            {
                HopliteAttackValue = BAAttackValue.Text;
                HopliteHpValue = BAHpValue.Text;
                HopliteSpeedValue = BASpeed.Value.ToString();
                HopliteLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "30:(Academy)Phalangite")
            {
                PhalangiteAttackValue = BAAttackValue.Text;
                PhalangiteHpValue = BAHpValue.Text;
                PhalangiteSpeedValue = BASpeed.Value.ToString();
                PhalangiteLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "31:(Academy)Centurion")
            {
                CenturionAttackValue = BAAttackValue.Text;
                CenturionHpValue = BAHpValue.Text;
                CenturionSpeedValue = BASpeed.Value.ToString();
                CenturionLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "32:(Temple)Priest")
            {
                PriestAttackValue = BAAttackValue.Text;
                PriestHpValue = BAHpValue.Text;
                PriestSpeedValue = BASpeed.Value.ToString();
                PriestLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "33:(Dock)Trade Boat")
            {
                TradeBoatAttackValue = BAAttackValue.Text;
                TradeBoatHpValue = BAHpValue.Text;
                TradeBoatSpeedValue = BASpeed.Value.ToString();
                TradeBoatLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "34:(Dock)Merchant Ship")
            {
                MerchantShipAttackValue = BAAttackValue.Text;
                MerchantShipHpValue = BAHpValue.Text;
                MerchantShipSpeedValue = BASpeed.Value.ToString();
                MerchantShipLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "35:(Dock)Heavy Transport")
            {
                HeavyTransportAttackValue = BAAttackValue.Text;
                HeavyTransportHpValue = BAHpValue.Text;
                HeavyTransportSpeedValue = BASpeed.Value.ToString();
                HeavyTransportLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "36:(Dock)Light Transport")
            {
                LightTransportAttackValue = BAAttackValue.Text;
                LightTransportHpValue = BAHpValue.Text;
                LightTransportSpeedValue = BASpeed.Value.ToString();
                LightTransportLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "37:(Dock)Scout Ship")
            {
                ScoutShipAttackValue = BAAttackValue.Text;
                ScoutShipHpValue = BAHpValue.Text;
                ScoutShipSpeedValue = BASpeed.Value.ToString();
                ScoutShipLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "38:(Dock)War Galley")
            {
                WarGalleyAttackValue = BAAttackValue.Text;
                WarGalleyHpValue = BAHpValue.Text;
                WarGalleySpeedValue = BASpeed.Value.ToString();
                WarGalleyLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "39:(Dock)Trireme")
            {
                TriremeAttackValue = BAAttackValue.Text;
                TriremeHpValue = BAHpValue.Text;
                TriremeSpeedValue = BASpeed.Value.ToString();
                TriremeLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "40:(Dock)Catapult Trireme")
            {
                CatapultTriremeAttackValue = BAAttackValue.Text;
                CatapultTriremeHpValue = BAHpValue.Text;
                CatapultTriremeSpeedValue = BASpeed.Value.ToString();
                CatapultTriremeLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "41:(Dock)Juggernaut")
            {
                JuggernautAttackValue = BAAttackValue.Text;
                JuggernautHpValue = BAHpValue.Text;
                JuggernautSpeedValue = BASpeed.Value.ToString();
                JuggernautLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "42:(Dock)Fire Galley")
            {
                FireGalleyAttackValue = BAAttackValue.Text;
                FireGalleyHpValue = BAHpValue.Text;
                FireGalleySpeedValue = BASpeed.Value.ToString();
                FireGalleyLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "43:(Dock)Trade Cart")
            {
                TradeCartAttackValue = BAAttackValue.Text;
                TradeCartHpValue = BAHpValue.Text;
                TradeCartSpeedValue = BASpeed.Value.ToString();
                TradeCartLoSValue = BALoS.Text;
            }

        }

        private void SaveCurrentSelection2()
        {
            // Save the selected RadioButton for the current domain
            if (BEcurrentSelection == "1:(Barracks)Clubman")
            {
                EClubmanAttackValue = BEAttackValue.Text;
                EClubmanHpValue = BEHpValue.Text;
                EClubmanSpeedValue = BESpeed.Value.ToString();
                EClubmanLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "2:(Barracks)Axeman")
            {
                EAxemanAttackValue = BEAttackValue.Text;
                EAxemanHpValue = BEHpValue.Text;
                EAxemanSpeedValue = BESpeed.Value.ToString();
                EAxemanLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "3:(Barracks)Short Swordsman")
            {
                EShortSwordsmanAttackValue = BEAttackValue.Text;
                EShortSwordsmanHpValue = BEHpValue.Text;
                EShortSwordsmanSpeedValue = BESpeed.Value.ToString();
                EShortSwordsmanLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "4:(Barracks)Broad Swordsman")
            {
                EBroadSwordsmanAttackValue = BEAttackValue.Text;
                EBroadSwordsmanHpValue = BEHpValue.Text;
                EBroadSwordsmanSpeedValue = BESpeed.Value.ToString();
                EBroadSwordsmanLoSValue = BELoS.Text;
            }

            else if (BEcurrentSelection == "5:(Barracks)Long Swordsman")
            {
                ELongSwordsmanAttackValue = BEAttackValue.Text;
                ELongSwordsmanHpValue = BEHpValue.Text;
                ELongSwordsmanSpeedValue = BESpeed.Value.ToString();
                ELongSwordsmanLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "6:(Barracks)Legionary")
            {
                ELegionaryAttackValue = BEAttackValue.Text;
                ELegionaryHpValue = BEHpValue.Text;
                ELegionarySpeedValue = BESpeed.Value.ToString();
                ELegionaryLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "7:(Barracks)Slinger")
            {
                ESlingerAttackValue = BEAttackValue.Text;
                ESlingerHpValue = BEHpValue.Text;
                ESlingerSpeedValue = BESpeed.Value.ToString();
                ESlingerLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "8:(Archery Range)Bowman")
            {
                EBowmanAttackValue = BEAttackValue.Text;
                EBowmanHpValue = BEHpValue.Text;
                EBowmanSpeedValue = BESpeed.Value.ToString();
                EBowmanLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "9:(Archery Range)Improved Bowman")
            {
                EImprovedBowmanAttackValue = BEAttackValue.Text;
                EImprovedBowmanHpValue = BEHpValue.Text;
                EImprovedBowmanSpeedValue = BESpeed.Value.ToString();
                EImprovedBowmanLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "10:(Archery Range)Composite Bowman")
            {
                ECompositeBowmanAttackValue = BEAttackValue.Text;
                ECompositeBowmanHpValue = BEHpValue.Text;
                ECompositeBowmanSpeedValue = BESpeed.Value.ToString();
                ECompositeBowmanLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "11:(Archery Range)Chariot Archer")
            {
                EChariotArcherAttackValue = BEAttackValue.Text;
                EChariotArcherHpValue = BEHpValue.Text;
                EChariotArcherSpeedValue = BESpeed.Value.ToString();
                EChariotArcherLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "12:(Archery Range)Horse Archer")
            {
                EHorseArcherAttackValue = BEAttackValue.Text;
                EHorseArcherHpValue = BEHpValue.Text;
                EHorseArcherSpeedValue = BESpeed.Value.ToString();
                EHorseArcherLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "13:(Archery Range)Heavy Horse Archer")
            {
                EHeavyHorseArcherAttackValue = BEAttackValue.Text;
                EHeavyHorseArcherHpValue = BEHpValue.Text;
                EHeavyHorseArcherSpeedValue = BESpeed.Value.ToString();
                EHeavyHorseArcherLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "14:(Archery Range)Elephant Archer")
            {
                EElephantArcherAttackValue = BEAttackValue.Text;
                EElephantArcherHpValue = BEHpValue.Text;
                EElephantArcherSpeedValue = BESpeed.Value.ToString();
                EElephantArcherLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "15:(Stable)Scout")
            {
                EScoutAttackValue = BEAttackValue.Text;
                EScoutHpValue = BEHpValue.Text;
                EScoutSpeedValue = BESpeed.Value.ToString();
                EScoutLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "16:(Stable)Chariot")
            {
                EChariotAttackValue = BEAttackValue.Text;
                EChariotHpValue = BEHpValue.Text;
                EChariotSpeedValue = BESpeed.Value.ToString();
                EChariotLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "17:(Stable)Scythe Chariot")
            {
                EScytheChariotAttackValue = BEAttackValue.Text;
                EScytheChariotHpValue = BEHpValue.Text;
                EScytheChariotSpeedValue = BESpeed.Value.ToString();
                EScytheChariotLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "18:(Stable)Cavalry")
            {
                ECavalryAttackValue = BEAttackValue.Text;
                ECavalryHpValue = BEHpValue.Text;
                ECavalrySpeedValue = BESpeed.Value.ToString();
                ECavalryLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "19:(Stable)Heavy Cavalry")
            {
                EHeavyCavalryAttackValue = BEAttackValue.Text;
                EHeavyCavalryHpValue = BEHpValue.Text;
                EHeavyCavalrySpeedValue = BESpeed.Value.ToString();
                EHeavyCavalryLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "20:(Stable)Cataphract")
            {
                ECataphractAttackValue = BEAttackValue.Text;
                ECataphractHpValue = BEHpValue.Text;
                ECataphractSpeedValue = BESpeed.Value.ToString();
                ECataphractLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "21:(Stable)War Elephant")
            {
                EWarElephantAttackValue = BEAttackValue.Text;
                EWarElephantHpValue = BEHpValue.Text;
                EWarElephantSpeedValue = BESpeed.Value.ToString();
                EWarElephantLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "22:(Stable)Armored Elephant")
            {
                EArmoredElephantAttackValue = BEAttackValue.Text;
                EArmoredElephantHpValue = BEHpValue.Text;
                EArmoredElephantSpeedValue = BESpeed.Value.ToString();
                EArmoredElephantLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "23:(Stable)Camel Rider")
            {
                ECamelRiderAttackValue = BEAttackValue.Text;
                ECamelRiderHpValue = BEHpValue.Text;
                ECamelRiderSpeedValue = BESpeed.Value.ToString();
                ECamelRiderLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "24:(Siege Workshop)Stone Thrower")
            {
                EStoneThrowerAttackValue = BEAttackValue.Text;
                EStoneThrowerHpValue = BEHpValue.Text;
                EStoneThrowerSpeedValue = BESpeed.Value.ToString();
                EStoneThrowerLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "25:(Siege Workshop)Catapult")
            {
                ECatapultAttackValue = BEAttackValue.Text;
                ECatapultHpValue = BEHpValue.Text;
                ECatapultSpeedValue = BESpeed.Value.ToString();
                ECatapultLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "26:(Siege Workshop)Heavy Catapult")
            {
                EHeavyCatapultAttackValue = BEAttackValue.Text;
                EHeavyCatapultHpValue = BEHpValue.Text;
                EHeavyCatapultSpeedValue = BESpeed.Value.ToString();
                EHeavyCatapultLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "27:(Siege Workshop)BEllista")
            {
                EBallistaAttackValue = BEAttackValue.Text;
                EBallistaHpValue = BEHpValue.Text;
                EBallistaSpeedValue = BESpeed.Value.ToString();
                EBallistaLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "28:(Siege Workshop)Helepolis")
            {
                EHelepolisAttackValue = BEAttackValue.Text;
                EHelepolisHpValue = BEHpValue.Text;
                EHelepolisSpeedValue = BESpeed.Value.ToString();
                EHelepolisLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "29:(Academy)Hoplite")
            {
                EHopliteAttackValue = BEAttackValue.Text;
                EHopliteHpValue = BEHpValue.Text;
                EHopliteSpeedValue = BESpeed.Value.ToString();
                EHopliteLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "30:(Academy)Phalangite")
            {
                EPhalangiteAttackValue = BEAttackValue.Text;
                EPhalangiteHpValue = BEHpValue.Text;
                EPhalangiteSpeedValue = BESpeed.Value.ToString();
                EPhalangiteLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "31:(Academy)Centurion")
            {
                ECenturionAttackValue = BEAttackValue.Text;
                ECenturionHpValue = BEHpValue.Text;
                ECenturionSpeedValue = BESpeed.Value.ToString();
                ECenturionLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "32:(Temple)Priest")
            {
                EPriestAttackValue = BEAttackValue.Text;
                EPriestHpValue = BEHpValue.Text;
                EPriestSpeedValue = BESpeed.Value.ToString();
                EPriestLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "33:(Dock)Trade Boat")
            {
                ETradeBoatAttackValue = BEAttackValue.Text;
                ETradeBoatHpValue = BEHpValue.Text;
                ETradeBoatSpeedValue = BESpeed.Value.ToString();
                ETradeBoatLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "34:(Dock)Merchant Ship")
            {
                EMerchantShipAttackValue = BEAttackValue.Text;
                EMerchantShipHpValue = BEHpValue.Text;
                EMerchantShipSpeedValue = BESpeed.Value.ToString();
                EMerchantShipLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "35:(Dock)Heavy Transport")
            {
                EHeavyTransportAttackValue = BEAttackValue.Text;
                EHeavyTransportHpValue = BEHpValue.Text;
                EHeavyTransportSpeedValue = BESpeed.Value.ToString();
                EHeavyTransportLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "36:(Dock)Light Transport")
            {
                ELightTransportAttackValue = BEAttackValue.Text;
                ELightTransportHpValue = BEHpValue.Text;
                ELightTransportSpeedValue = BESpeed.Value.ToString();
                ELightTransportLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "37:(Dock)Scout Ship")
            {
                EScoutShipAttackValue = BEAttackValue.Text;
                EScoutShipHpValue = BEHpValue.Text;
                EScoutShipSpeedValue = BESpeed.Value.ToString();
                EScoutShipLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "38:(Dock)War Galley")
            {
                EWarGalleyAttackValue = BEAttackValue.Text;
                EWarGalleyHpValue = BEHpValue.Text;
                EWarGalleySpeedValue = BESpeed.Value.ToString();
                EWarGalleyLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "39:(Dock)Trireme")
            {
                ETriremeAttackValue = BEAttackValue.Text;
                ETriremeHpValue = BEHpValue.Text;
                ETriremeSpeedValue = BESpeed.Value.ToString();
                ETriremeLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "40:(Dock)Catapult Trireme")
            {
                ECatapultTriremeAttackValue = BEAttackValue.Text;
                ECatapultTriremeHpValue = BEHpValue.Text;
                ECatapultTriremeSpeedValue = BESpeed.Value.ToString();
                ECatapultTriremeLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "41:(Dock)Juggernaut")
            {
                EJuggernautAttackValue = BEAttackValue.Text;
                EJuggernautHpValue = BEHpValue.Text;
                EJuggernautSpeedValue = BESpeed.Value.ToString();
                EJuggernautLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "42:(Dock)Fire Galley")
            {
                EFireGalleyAttackValue = BEAttackValue.Text;
                EFireGalleyHpValue = BEHpValue.Text;
                EFireGalleySpeedValue = BESpeed.Value.ToString();
                EFireGalleyLoSValue = BELoS.Text;
            }
            else if (BEcurrentSelection == "43:(Dock)Trade Cart")
            {
                ETradeCartAttackValue = BEAttackValue.Text;
                ETradeCartHpValue = BEHpValue.Text;
                ETradeCartSpeedValue = BESpeed.Value.ToString();
                ETradeCartLoSValue = BELoS.Text;
            }

        }


        private void RestoreSavedSelection()
        {
            // Restore the saved RadioButton selection for the current domain
            if (currentSelection == "Villager")
            {
                if (selectedVillagerRadioButton != null)
                    selectedVillagerRadioButton.Checked = true;
                // Restore Villager values
                AttackValue.Text = VillagerAttackValue;
                HpValue.Text = VillagerHpValue;
                Speed.Value = int.TryParse(VillagerSpeedValue, out var spd) ? spd : 0;
                CSpeed.Value = int.TryParse(VillagerCSpeedValue, out var cspd) ? cspd : 0;
            }
            else if (currentSelection == "Fishing Boat")
            {
                if (selectedFishingBoatRadioButton != null)
                    selectedFishingBoatRadioButton.Checked = true;
                // Restore Fishing Boat values
                AttackValue.Text = fishingBoatAttackValue;
                HpValue.Text = fishingBoatHpValue;
                Speed.Value = int.TryParse(fishingBoatSpeedValue, out var spd) ? spd : 0;
                CSpeed.Value = int.TryParse(fishingBoatCSpeedValue, out var cspd) ? cspd : 0;
            }
        }
        private void RestoreSavedSelection1()
        {
            if (BAcurrentSelection == "1:(Barracks)Clubman")
            {
                BAAttackValue.Text = ClubmanAttackValue;
                BAHpValue.Text = ClubmanHpValue;
                BASpeed.Value = int.TryParse(ClubmanSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = ClubmanLoSValue;
            }
            else if (BAcurrentSelection == "2:(Barracks)Axeman")
            {
                BAAttackValue.Text = AxemanAttackValue;
                BAHpValue.Text = AxemanHpValue;
                BASpeed.Value = int.TryParse(AxemanSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = AxemanLoSValue;
            }
            else if (BAcurrentSelection == "3:(Barracks)Short Swordsman")
            {
                BAAttackValue.Text = ShortSwordsmanAttackValue;
                BAHpValue.Text = ShortSwordsmanHpValue;
                BASpeed.Value = int.TryParse(ShortSwordsmanSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = ShortSwordsmanLoSValue;
            }
            else if (BAcurrentSelection == "4:(Barracks)Broad Swordsman")
            {
                BAAttackValue.Text = BroadSwordsmanAttackValue;
                BAHpValue.Text = BroadSwordsmanHpValue;
                BASpeed.Value = int.TryParse(BroadSwordsmanSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = BroadSwordsmanLoSValue;
            }
            else if (BAcurrentSelection == "5:(Barracks)Long Swordsman")
            {
                BAAttackValue.Text = LongSwordsmanAttackValue;
                BAHpValue.Text = LongSwordsmanHpValue;
                BASpeed.Value = int.TryParse(LongSwordsmanSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = LongSwordsmanLoSValue;
            }
            else if (BAcurrentSelection == "6:(Barracks)Legionary")
            {
                BAAttackValue.Text = LegionaryAttackValue;
                BAHpValue.Text = LegionaryHpValue;
                BASpeed.Value = int.TryParse(LegionarySpeedValue, out var spd) ? spd : 0;
                BALoS.Text = LegionaryLoSValue;
            }
            else if (BAcurrentSelection == "7:(Barracks)Slinger")
            {
                BAAttackValue.Text = SlingerAttackValue;
                BAHpValue.Text = SlingerHpValue;
                BASpeed.Value = int.TryParse(SlingerSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = SlingerLoSValue;
            }
            else if (BAcurrentSelection == "8:(Archery Range)Bowman")
            {
                BAAttackValue.Text = BowmanAttackValue;
                BAHpValue.Text = BowmanHpValue;
                BASpeed.Value = int.TryParse(BowmanSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = BowmanLoSValue;
            }
            else if (BAcurrentSelection == "9:(Archery Range)Improved Bowman")
            {
                BAAttackValue.Text = ImprovedBowmanAttackValue;
                BAHpValue.Text = ImprovedBowmanHpValue;
                BASpeed.Value = int.TryParse(ImprovedBowmanSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = ImprovedBowmanLoSValue;
            }
            else if (BAcurrentSelection == "10:(Archery Range)Composite Bowman")
            {
                BAAttackValue.Text = CompositeBowmanAttackValue;
                BAHpValue.Text = CompositeBowmanHpValue;
                BASpeed.Value = int.TryParse(CompositeBowmanSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = CompositeBowmanLoSValue;
            }
            else if (BAcurrentSelection == "11:(Archery Range)Chariot Archer")
            {
                BAAttackValue.Text = ChariotArcherAttackValue;
                BAHpValue.Text = ChariotArcherHpValue;
                BASpeed.Value = int.TryParse(ChariotArcherSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = ChariotArcherLoSValue;
            }
            else if (BAcurrentSelection == "12:(Archery Range)Horse Archer")
            {
                BAAttackValue.Text = HorseArcherAttackValue;
                BAHpValue.Text = HorseArcherHpValue;
                BASpeed.Value = int.TryParse(HorseArcherSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = HorseArcherLoSValue;
            }
            else if (BAcurrentSelection == "13:(Archery Range)Heavy Horse Archer")
            {
                BAAttackValue.Text = HeavyHorseArcherAttackValue;
                BAHpValue.Text = HeavyHorseArcherHpValue;
                BASpeed.Value = int.TryParse(HeavyHorseArcherSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = HeavyHorseArcherLoSValue;
            }
            else if (BAcurrentSelection == "14:(Archery Range)Elephant Archer")
            {
                BAAttackValue.Text = ElephantArcherAttackValue;
                BAHpValue.Text = ElephantArcherHpValue;
                BASpeed.Value = int.TryParse(ElephantArcherSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = ElephantArcherLoSValue;
            }
            else if (BAcurrentSelection == "15:(Stable)Scout")
            {
                BAAttackValue.Text = ScoutAttackValue;
                BAHpValue.Text = ScoutHpValue;
                BASpeed.Value = int.TryParse(ScoutSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = ScoutLoSValue;
            }
            else if (BAcurrentSelection == "16:(Stable)Chariot")
            {
                BAAttackValue.Text = ChariotAttackValue;
                BAHpValue.Text = ChariotHpValue;
                BASpeed.Value = int.TryParse(ChariotSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = ChariotLoSValue;
            }
            else if (BAcurrentSelection == "17:(Stable)Scythe Chariot")
            {
                BAAttackValue.Text = ScytheChariotAttackValue;
                BAHpValue.Text = ScytheChariotHpValue;
                BASpeed.Value = int.TryParse(ScytheChariotSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = ScytheChariotLoSValue;
            }
            else if (BAcurrentSelection == "18:(Stable)Cavalry")
            {
                BAAttackValue.Text = CavalryAttackValue;
                BAHpValue.Text = CavalryHpValue;
                BASpeed.Value = int.TryParse(CavalrySpeedValue, out var spd) ? spd : 0;
                BALoS.Text = CavalryLoSValue;
            }
            else if (BAcurrentSelection == "19:(Stable)Heavy Cavalry")
            {
                BAAttackValue.Text = HeavyCavalryAttackValue;
                BAHpValue.Text = HeavyCavalryHpValue;
                BASpeed.Value = int.TryParse(HeavyCavalrySpeedValue, out var spd) ? spd : 0;
                BALoS.Text = HeavyCavalryLoSValue;
            }
            else if (BAcurrentSelection == "20:(Stable)Cataphract")
            {
                BAAttackValue.Text = CataphractAttackValue;
                BAHpValue.Text = CataphractHpValue;
                BASpeed.Value = int.TryParse(CataphractSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = CataphractLoSValue;
            }
            else if (BAcurrentSelection == "21:(Stable)War Elephant")
            {
                BAAttackValue.Text = WarElephantAttackValue;
                BAHpValue.Text = WarElephantHpValue;
                BASpeed.Value = int.TryParse(WarElephantSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = WarElephantLoSValue;
            }
            else if (BAcurrentSelection == "22:(Stable)Armored Elephant")
            {
                BAAttackValue.Text = ArmoredElephantAttackValue;
                BAHpValue.Text = ArmoredElephantHpValue;
                BASpeed.Value = int.TryParse(ArmoredElephantSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = ArmoredElephantLoSValue;
            }
            else if (BAcurrentSelection == "23:(Stable)Camel Rider")
            {
                BAAttackValue.Text = CamelRiderAttackValue;
                BAHpValue.Text = CamelRiderHpValue;
                BASpeed.Value = int.TryParse(CamelRiderSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = CamelRiderLoSValue;
            }
            else if (BAcurrentSelection == "24:(Siege Workshop)Stone Thrower")
            {
                BAAttackValue.Text = StoneThrowerAttackValue;
                BAHpValue.Text = StoneThrowerHpValue;
                BASpeed.Value = int.TryParse(StoneThrowerSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = StoneThrowerLoSValue;
            }
            else if (BAcurrentSelection == "25:(Siege Workshop)Catapult")
            {
                BAAttackValue.Text = CatapultAttackValue;
                BAHpValue.Text = CatapultHpValue;
                BASpeed.Value = int.TryParse(CatapultSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = CatapultLoSValue;
            }
            else if (BAcurrentSelection == "26:(Siege Workshop)Heavy Catapult")
            {
                BAAttackValue.Text = HeavyCatapultAttackValue;
                BAHpValue.Text = HeavyCatapultHpValue;
                BASpeed.Value = int.TryParse(HeavyCatapultSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = HeavyCatapultLoSValue;
            }
            else if (BAcurrentSelection == "27:(Siege Workshop)Ballista")
            {
                BAAttackValue.Text = BallistaAttackValue;
                BAHpValue.Text = BallistaHpValue;
                BASpeed.Value = int.TryParse(BallistaSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = BallistaLoSValue;
            }
            else if (BAcurrentSelection == "28:(Siege Workshop)Helepolis")
            {
                BAAttackValue.Text = HelepolisAttackValue;
                BAHpValue.Text = HelepolisHpValue;
                BASpeed.Value = int.TryParse(HelepolisSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = HelepolisLoSValue;
            }
            else if (BAcurrentSelection == "29:(Academy)Hoplite")
            {
                BAAttackValue.Text = HopliteAttackValue;
                BAHpValue.Text = HopliteHpValue;
                BASpeed.Value = int.TryParse(HopliteSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = HopliteLoSValue;
            }
            else if (BAcurrentSelection == "30:(Academy)Phalangite")
            {
                BAAttackValue.Text = PhalangiteAttackValue;
                BAHpValue.Text = PhalangiteHpValue;
                BASpeed.Value = int.TryParse(PhalangiteSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = PhalangiteLoSValue;
            }
            else if (BAcurrentSelection == "31:(Academy)Centurion")
            {
                BAAttackValue.Text = CenturionAttackValue;
                BAHpValue.Text = CenturionHpValue;
                BASpeed.Value = int.TryParse(CenturionSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = CenturionLoSValue;
            }
            else if (BAcurrentSelection == "32:(Temple)Priest")
            {
                BAAttackValue.Text = PriestAttackValue;
                BAHpValue.Text = PriestHpValue;
                BASpeed.Value = int.TryParse(PriestSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = PriestLoSValue;
            }
            else if (BAcurrentSelection == "33:(Dock)Trade Boat")
            {
                BAAttackValue.Text = TradeBoatAttackValue;
                BAHpValue.Text = TradeBoatHpValue;
                BASpeed.Value = int.TryParse(TradeBoatSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = TradeBoatLoSValue;
            }
            else if (BAcurrentSelection == "34:(Dock)Merchant Ship")
            {
                BAAttackValue.Text = MerchantShipAttackValue;
                BAHpValue.Text = MerchantShipHpValue;
                BASpeed.Value = int.TryParse(MerchantShipSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = MerchantShipLoSValue;
            }
            else if (BAcurrentSelection == "35:(Dock)Heavy Transport")
            {
                BAAttackValue.Text = HeavyTransportAttackValue;
                BAHpValue.Text = HeavyTransportHpValue;
                BASpeed.Value = int.TryParse(HeavyTransportSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = HeavyTransportLoSValue;
            }
            else if (BAcurrentSelection == "36:(Dock)Light Transport")
            {
                BAAttackValue.Text = LightTransportAttackValue;
                BAHpValue.Text = LightTransportHpValue;
                BASpeed.Value = int.TryParse(LightTransportSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = LightTransportLoSValue;
            }
            else if (BAcurrentSelection == "37:(Dock)Scout Ship")
            {
                BAAttackValue.Text = ScoutShipAttackValue;
                BAHpValue.Text = ScoutShipHpValue;
                BASpeed.Value = int.TryParse(ScoutShipSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = ScoutShipLoSValue;
            }
            else if (BAcurrentSelection == "38:(Dock)War Galley")
            {
                BAAttackValue.Text = WarGalleyAttackValue;
                BAHpValue.Text = WarGalleyHpValue;
                BASpeed.Value = int.TryParse(WarGalleySpeedValue, out var spd) ? spd : 0;
                BALoS.Text = WarGalleyLoSValue;
            }
            else if (BAcurrentSelection == "39:(Dock)Trireme")
            {
                BAAttackValue.Text = TriremeAttackValue;
                BAHpValue.Text = TriremeHpValue;
                BASpeed.Value = int.TryParse(TriremeSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = TriremeLoSValue;
            }
            else if (BAcurrentSelection == "40:(Dock)Catapult Trireme")
            {
                BAAttackValue.Text = CatapultTriremeAttackValue;
                BAHpValue.Text = CatapultTriremeHpValue;
                BASpeed.Value = int.TryParse(CatapultTriremeSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = CatapultTriremeLoSValue;
            }
            else if (BAcurrentSelection == "42:(Dock)Fire Galley")
            {
                BAAttackValue.Text = FireGalleyAttackValue;
                BAHpValue.Text = FireGalleyHpValue;
                BASpeed.Value = int.TryParse(FireGalleySpeedValue, out var spd) ? spd : 0;
                BALoS.Text = FireGalleyLoSValue;
            }
            else if (BAcurrentSelection == "41:(Dock)Juggernaut")
            {
                BAAttackValue.Text = JuggernautAttackValue;
                BAHpValue.Text = JuggernautHpValue;
                BASpeed.Value = int.TryParse(JuggernautSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = JuggernautLoSValue;
            }
            else if (BAcurrentSelection == "43:(Dock)Trade Cart")
            {
                BAAttackValue.Text = TradeCartAttackValue;
                BAHpValue.Text = TradeCartHpValue;
                BASpeed.Value = int.TryParse(TradeCartSpeedValue, out var spd) ? spd : 0;
                BALoS.Text = TradeCartLoSValue;
            }
        }

        private void RestoreSavedSelection2()
        {
            if (BEcurrentSelection == "1:(Barracks)Clubman")
            {
                BEAttackValue.Text = EClubmanAttackValue;
                BEHpValue.Text = EClubmanHpValue;
                BESpeed.Value = int.TryParse(EClubmanSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EClubmanLoSValue;
            }
            else if (BEcurrentSelection == "2:(Barracks)Axeman")
            {
                BEAttackValue.Text = EAxemanAttackValue;
                BEHpValue.Text = EAxemanHpValue;
                BESpeed.Value = int.TryParse(EAxemanSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EAxemanLoSValue;
            }
            else if (BEcurrentSelection == "3:(Barracks)Short Swordsman")
            {
                BEAttackValue.Text = EShortSwordsmanAttackValue;
                BEHpValue.Text = EShortSwordsmanHpValue;
                BESpeed.Value = int.TryParse(EShortSwordsmanSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EShortSwordsmanLoSValue;
            }
            else if (BEcurrentSelection == "4:(Barracks)Broad Swordsman")
            {
                BEAttackValue.Text = EBroadSwordsmanAttackValue;
                BEHpValue.Text = EBroadSwordsmanHpValue;
                BESpeed.Value = int.TryParse(EBroadSwordsmanSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EBroadSwordsmanLoSValue;
            }
            else if (BEcurrentSelection == "5:(Barracks)Long Swordsman")
            {
                BEAttackValue.Text = ELongSwordsmanAttackValue;
                BEHpValue.Text = ELongSwordsmanHpValue;
                BESpeed.Value = int.TryParse(ELongSwordsmanSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ELongSwordsmanLoSValue;
            }
            else if (BEcurrentSelection == "6:(Barracks)Legionary")
            {
                BEAttackValue.Text = ELegionaryAttackValue;
                BEHpValue.Text = ELegionaryHpValue;
                BESpeed.Value = int.TryParse(ELegionarySpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ELegionaryLoSValue;
            }
            else if (BEcurrentSelection == "7:(Barracks)Slinger")
            {
                BEAttackValue.Text = ESlingerAttackValue;
                BEHpValue.Text = ESlingerHpValue;
                BESpeed.Value = int.TryParse(ESlingerSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ESlingerLoSValue;
            }
            else if (BEcurrentSelection == "8:(Archery Range)Bowman")
            {
                BEAttackValue.Text = EBowmanAttackValue;
                BEHpValue.Text = EBowmanHpValue;
                BESpeed.Value = int.TryParse(EBowmanSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EBowmanLoSValue;
            }
            else if (BEcurrentSelection == "9:(Archery Range)Improved Bowman")
            {
                BEAttackValue.Text = EImprovedBowmanAttackValue;
                BEHpValue.Text = EImprovedBowmanHpValue;
                BESpeed.Value = int.TryParse(EImprovedBowmanSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EImprovedBowmanLoSValue;
            }
            else if (BEcurrentSelection == "10:(Archery Range)Composite Bowman")
            {
                BEAttackValue.Text = ECompositeBowmanAttackValue;
                BEHpValue.Text = ECompositeBowmanHpValue;
                BESpeed.Value = int.TryParse(ECompositeBowmanSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ECompositeBowmanLoSValue;
            }
            else if (BEcurrentSelection == "11:(Archery Range)Chariot Archer")
            {
                BEAttackValue.Text = EChariotArcherAttackValue;
                BEHpValue.Text = EChariotArcherHpValue;
                BESpeed.Value = int.TryParse(EChariotArcherSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EChariotArcherLoSValue;
            }
            else if (BEcurrentSelection == "12:(Archery Range)Horse Archer")
            {
                BEAttackValue.Text = EHorseArcherAttackValue;
                BEHpValue.Text = EHorseArcherHpValue;
                BESpeed.Value = int.TryParse(EHorseArcherSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EHorseArcherLoSValue;
            }
            else if (BEcurrentSelection == "13:(Archery Range)Heavy Horse Archer")
            {
                BEAttackValue.Text = EHeavyHorseArcherAttackValue;
                BEHpValue.Text = EHeavyHorseArcherHpValue;
                BESpeed.Value = int.TryParse(EHeavyHorseArcherSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EHeavyHorseArcherLoSValue;
            }
            else if (BEcurrentSelection == "14:(Archery Range)Elephant Archer")
            {
                BEAttackValue.Text = EElephantArcherAttackValue;
                BEHpValue.Text = EElephantArcherHpValue;
                BESpeed.Value = int.TryParse(EElephantArcherSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EElephantArcherLoSValue;
            }
            else if (BEcurrentSelection == "15:(Stable)Scout")
            {
                BEAttackValue.Text = EScoutAttackValue;
                BEHpValue.Text = EScoutHpValue;
                BESpeed.Value = int.TryParse(EScoutSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EScoutLoSValue;
            }
            else if (BEcurrentSelection == "16:(Stable)Chariot")
            {
                BEAttackValue.Text = EChariotAttackValue;
                BEHpValue.Text = EChariotHpValue;
                BESpeed.Value = int.TryParse(EChariotSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EChariotLoSValue;
            }
            else if (BEcurrentSelection == "17:(Stable)Scythe Chariot")
            {
                BEAttackValue.Text = EScytheChariotAttackValue;
                BEHpValue.Text = EScytheChariotHpValue;
                BESpeed.Value = int.TryParse(EScytheChariotSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EScytheChariotLoSValue;
            }
            else if (BEcurrentSelection == "18:(Stable)Cavalry")
            {
                BEAttackValue.Text = ECavalryAttackValue;
                BEHpValue.Text = ECavalryHpValue;
                BESpeed.Value = int.TryParse(ECavalrySpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ECavalryLoSValue;
            }
            else if (BEcurrentSelection == "19:(Stable)Heavy Cavalry")
            {
                BEAttackValue.Text = EHeavyCavalryAttackValue;
                BEHpValue.Text = EHeavyCavalryHpValue;
                BESpeed.Value = int.TryParse(EHeavyCavalrySpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EHeavyCavalryLoSValue;
            }
            else if (BEcurrentSelection == "20:(Stable)Cataphract")
            {
                BEAttackValue.Text = ECataphractAttackValue;
                BEHpValue.Text = ECataphractHpValue;
                BESpeed.Value = int.TryParse(ECataphractSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ECataphractLoSValue;
            }
            else if (BEcurrentSelection == "21:(Stable)War Elephant")
            {
                BEAttackValue.Text = EWarElephantAttackValue;
                BEHpValue.Text = EWarElephantHpValue;
                BESpeed.Value = int.TryParse(EWarElephantSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EWarElephantLoSValue;
            }
            else if (BEcurrentSelection == "22:(Stable)Armored Elephant")
            {
                BEAttackValue.Text = EArmoredElephantAttackValue;
                BEHpValue.Text = EArmoredElephantHpValue;
                BESpeed.Value = int.TryParse(EArmoredElephantSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EArmoredElephantLoSValue;
            }
            else if (BEcurrentSelection == "23:(Stable)Camel Rider")
            {
                BEAttackValue.Text = ECamelRiderAttackValue;
                BEHpValue.Text = ECamelRiderHpValue;
                BESpeed.Value = int.TryParse(ECamelRiderSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ECamelRiderLoSValue;
            }
            else if (BEcurrentSelection == "24:(Siege Workshop)Stone Thrower")
            {
                BEAttackValue.Text = EStoneThrowerAttackValue;
                BEHpValue.Text = EStoneThrowerHpValue;
                BESpeed.Value = int.TryParse(EStoneThrowerSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EStoneThrowerLoSValue;
            }
            else if (BEcurrentSelection == "25:(Siege Workshop)Catapult")
            {
                BEAttackValue.Text = ECatapultAttackValue;
                BEHpValue.Text = ECatapultHpValue;
                BESpeed.Value = int.TryParse(ECatapultSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ECatapultLoSValue;
            }
            else if (BEcurrentSelection == "26:(Siege Workshop)Heavy Catapult")
            {
                BEAttackValue.Text = EHeavyCatapultAttackValue;
                BEHpValue.Text = EHeavyCatapultHpValue;
                BESpeed.Value = int.TryParse(EHeavyCatapultSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EHeavyCatapultLoSValue;
            }
            else if (BEcurrentSelection == "27:(Siege Workshop)BEllista")
            {
                BEAttackValue.Text = EBallistaAttackValue;
                BEHpValue.Text = EBallistaHpValue;
                BESpeed.Value = int.TryParse(EBallistaSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EBallistaLoSValue;
            }
            else if (BEcurrentSelection == "28:(Siege Workshop)Helepolis")
            {
                BEAttackValue.Text = EHelepolisAttackValue;
                BEHpValue.Text = EHelepolisHpValue;
                BESpeed.Value = int.TryParse(EHelepolisSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EHelepolisLoSValue;
            }
            else if (BEcurrentSelection == "29:(Academy)Hoplite")
            {
                BEAttackValue.Text = EHopliteAttackValue;
                BEHpValue.Text = EHopliteHpValue;
                BESpeed.Value = int.TryParse(EHopliteSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EHopliteLoSValue;
            }
            else if (BEcurrentSelection == "30:(Academy)Phalangite")
            {
                BEAttackValue.Text = EPhalangiteAttackValue;
                BEHpValue.Text = EPhalangiteHpValue;
                BESpeed.Value = int.TryParse(EPhalangiteSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EPhalangiteLoSValue;
            }
            else if (BEcurrentSelection == "31:(Academy)Centurion")
            {
                BEAttackValue.Text = ECenturionAttackValue;
                BEHpValue.Text = ECenturionHpValue;
                BESpeed.Value = int.TryParse(ECenturionSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ECenturionLoSValue;
            }
            else if (BEcurrentSelection == "32:(Temple)Priest")
            {
                BEAttackValue.Text = EPriestAttackValue;
                BEHpValue.Text = EPriestHpValue;
                BESpeed.Value = int.TryParse(EPriestSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EPriestLoSValue;
            }
            else if (BEcurrentSelection == "33:(Dock)Trade Boat")
            {
                BEAttackValue.Text = ETradeBoatAttackValue;
                BEHpValue.Text = ETradeBoatHpValue;
                BESpeed.Value = int.TryParse(ETradeBoatSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ETradeBoatLoSValue;
            }
            else if (BEcurrentSelection == "34:(Dock)Merchant Ship")
            {
                BEAttackValue.Text = EMerchantShipAttackValue;
                BEHpValue.Text = EMerchantShipHpValue;
                BESpeed.Value = int.TryParse(EMerchantShipSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EMerchantShipLoSValue;
            }
            else if (BEcurrentSelection == "35:(Dock)Heavy Transport")
            {
                BEAttackValue.Text = EHeavyTransportAttackValue;
                BEHpValue.Text = EHeavyTransportHpValue;
                BESpeed.Value = int.TryParse(EHeavyTransportSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EHeavyTransportLoSValue;
            }
            else if (BEcurrentSelection == "36:(Dock)Light Transport")
            {
                BEAttackValue.Text = ELightTransportAttackValue;
                BEHpValue.Text = ELightTransportHpValue;
                BESpeed.Value = int.TryParse(ELightTransportSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ELightTransportLoSValue;
            }
            else if (BEcurrentSelection == "37:(Dock)Scout Ship")
            {
                BEAttackValue.Text = EScoutShipAttackValue;
                BEHpValue.Text = EScoutShipHpValue;
                BESpeed.Value = int.TryParse(EScoutShipSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EScoutShipLoSValue;
            }
            else if (BEcurrentSelection == "38:(Dock)War Galley")
            {
                BEAttackValue.Text = EWarGalleyAttackValue;
                BEHpValue.Text = EWarGalleyHpValue;
                BESpeed.Value = int.TryParse(EWarGalleySpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EWarGalleyLoSValue;
            }
            else if (BEcurrentSelection == "39:(Dock)Trireme")
            {
                BEAttackValue.Text = ETriremeAttackValue;
                BEHpValue.Text = ETriremeHpValue;
                BESpeed.Value = int.TryParse(ETriremeSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ETriremeLoSValue;
            }
            else if (BEcurrentSelection == "40:(Dock)Catapult Trireme")
            {
                BEAttackValue.Text = ECatapultTriremeAttackValue;
                BEHpValue.Text = ECatapultTriremeHpValue;
                BESpeed.Value = int.TryParse(ECatapultTriremeSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ECatapultTriremeLoSValue;
            }
            else if (BEcurrentSelection == "42:(Dock)Fire Galley")
            {
                BEAttackValue.Text = EFireGalleyAttackValue;
                BEHpValue.Text = EFireGalleyHpValue;
                BESpeed.Value = int.TryParse(EFireGalleySpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EFireGalleyLoSValue;
            }
            else if (BEcurrentSelection == "41:(Dock)Juggernaut")
            {
                BEAttackValue.Text = EJuggernautAttackValue;
                BEHpValue.Text = EJuggernautHpValue;
                BESpeed.Value = int.TryParse(EJuggernautSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = EJuggernautLoSValue;
            }
            else if (BEcurrentSelection == "43:(Dock)Trade Cart")
            {
                BEAttackValue.Text = ETradeCartAttackValue;
                BEHpValue.Text = ETradeCartHpValue;
                BESpeed.Value = int.TryParse(ETradeCartSpeedValue, out var spd) ? spd : 0;
                BELoS.Text = ETradeCartLoSValue;
            }
        }

        private RadioButton GetSelectedRadioButton(RadioButton[] radioButtons)
        {
            foreach (var rb in radioButtons)
            {
                if (rb.Checked)
                {
                    return rb;
                }
            }
            return null;
        }

        // Event Handlers for AttackValue, HpValue, Speed, CSpeed changes
        private void AttackValue_TextChanged_1(object sender, EventArgs e)
        {
            if (currentSelection == "Villager")
            {
                VillagerAttackValue = AttackValue.Text;
            }
            else if (currentSelection == "Fishing Boat")
            {
                fishingBoatAttackValue = AttackValue.Text;
            }
        }

        private void HpValue_TextChanged_1(object sender, EventArgs e)
        {
            if (currentSelection == "Villager")
            {
                VillagerHpValue = HpValue.Text;
            }
            else if (currentSelection == "Fishing Boat")
            {
                fishingBoatHpValue = HpValue.Text;
            }
        }

        private void Speed_ValueChanged(object sender, EventArgs e)
        {
            if (currentSelection == "Villager")
            {
                VillagerSpeedValue = Speed.Value.ToString();
            }
            else if (currentSelection == "Fishing Boat")
            {
                fishingBoatSpeedValue = Speed.Value.ToString();
            }
        }

        private void CSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (currentSelection == "Villager")
            {
                VillagerCSpeedValue = CSpeed.Value.ToString();
            }
            else if (currentSelection == "Fishing Boat")
            {
                fishingBoatCSpeedValue = CSpeed.Value.ToString();
            }
        }

        // Other existing event handlers can remain unchanged.






        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Logic for radioButton1 (if needed)
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Logic for radioButton2 (if needed)
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Logic for radioButton3 (if needed)
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // Logic for radioButton4 (if needed)
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            // Logic for radioButton5 (if needed)
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void AlliesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string selectedItem1 = AlliesName.Text;

                // Only update visibility if selection changes
                if (selectedItem1 != BAcurrentSelection)
                {
                    SaveCurrentSelection1(); // Save the current selection
                    BAcurrentSelection = selectedItem1;

                    RestoreSavedSelection1(); // Restore the saved selection for the new domain
                }
            }
        }

        private void EnemiesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string selectedItem2 = EnemiesName.Text;

                // Only update visibility if selection changes
                if (selectedItem2 != BEcurrentSelection)
                {
                    SaveCurrentSelection2(); // Save the current selection
                    BEcurrentSelection = selectedItem2;

                    RestoreSavedSelection2(); // Restore the saved selection for the new domain
                }
            }

        }

        private void BAHpValue_TextChanged(object sender, EventArgs e)
        {
            if (BAcurrentSelection == "1:(Barracks)Clubman")
            {
                ClubmanHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "2:(Barracks)Axeman")
            {
                AxemanHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "3:(Barracks)Short Swordsman")
            {
                ShortSwordsmanHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "4:(Barracks)Broad Swordsman")
            {
                BroadSwordsmanHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "5:(Barracks)Long Swordsman")
            {
                LongSwordsmanHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "6:(Barracks)Legionary")
            {
                LegionaryHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "7:(Barracks)Slinger")
            {
                SlingerHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "8:(Archery Range)Bowman")
            {
                BowmanHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "9:(Archery Range)Improved Bowman")
            {
                ImprovedBowmanHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "10:(Archery Range)Composite Bowman")
            {
                CompositeBowmanHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "11:(Archery Range)Chariot Archer")
            {
                ChariotArcherHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "12:(Archery Range)Horse Archer")
            {
                HorseArcherHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "13:(Archery Range)Heavy Horse Archer")
            {
                HeavyHorseArcherHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "14:(Archery Range)Elephant Archer")
            {
                ElephantArcherHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "15:(Stable)Scout")
            {
                ScoutHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "16:(Stable)Chariot")
            {
                ChariotArcherHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "17:(Stable)Scythe Chariot")
            {
                ScytheChariotHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "18:(Stable)Cavalry")
            {
                CavalryHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "19:(Stable)Heavy Cavalry")
            {
                HeavyCavalryHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "20:(Stable)Cataphract")
            {
                CataphractHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "21:(Stable)War Elephant")
            {
                WarElephantHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "22:(Stable)Armored Elephant")
            {
                ArmoredElephantHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "23:(Stable)Camel Rider")
            {
                CamelRiderHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "24:(Siege Workshop)Stone Thrower")
            {
                StoneThrowerHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "25:(Siege Workshop)Catapult")
            {
                CatapultHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "26:(Siege Workshop)Heavy Catapult")
            {
                HeavyCatapultHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "27:(Siege Workshop)Ballista")
            {
                BallistaHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "28:(Siege Workshop)Helepolis")
            {
                HelepolisHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "29:(Academy)Hoplite")
            {
                HopliteHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "30:(Academy)Phalangite")
            {
                PhalangiteHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "31:(Academy)Centurion")
            {
                CenturionHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "32:(Temple)Priest")
            {
                PriestHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "33:(Dock)Trade Boat")
            {
                TradeBoatHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "34:(Dock)Merchant Ship")
            {
                MerchantShipHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "35:(Dock)Heavy Transport")
            {
                HeavyTransportHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "36:(Dock)Light Transport")
            {
                LightTransportHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "37:(Dock)Scout Ship")
            {
                ScoutShipHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "38:(Dock)War Galley")
            {
                WarGalleyHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "39:(Dock)Trireme")
            {
                TriremeHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "40:(Dock)Catapult Trireme")
            {
                CatapultTriremeHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "41:(Dock)Juggernaut")
            {
                JuggernautHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "42:(Dock)Fire Galley")
            {
                FireGalleyHpValue = BAHpValue.Text;
            }
            else if (BAcurrentSelection == "43:(Dock)Trade Cart")
            {
                TradeCartHpValue = BAHpValue.Text;
            }

        }

        private void BAAttackValue_TextChanged(object sender, EventArgs e)
        {
            if (BAcurrentSelection == "1:(Barracks)Clubman")
            {
                ClubmanAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "2:(Barracks)Axeman")
            {
                AxemanAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "3:(Barracks)Short Swordsman")
            {
                ShortSwordsmanAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "4:(Barracks)Broad Swordsman")
            {
                BroadSwordsmanAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "5:(Barracks)Long Swordsman")
            {
                LongSwordsmanAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "6:(Barracks)Legionary")
            {
                LegionaryAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "7:(Barracks)Slinger")
            {
                SlingerAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "8:(Archery Range)Bowman")
            {
                BowmanAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "9:(Archery Range)Improved Bowman")
            {
                ImprovedBowmanAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "10:(Archery Range)Composite Bowman")
            {
                CompositeBowmanAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "11:(Archery Range)Chariot Archer")
            {
                ChariotArcherAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "12:(Archery Range)Horse Archer")
            {
                HorseArcherAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "13:(Archery Range)Heavy Horse Archer")
            {
                HeavyHorseArcherAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "14:(Archery Range)Elephant Archer")
            {
                ElephantArcherAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "15:(Stable)Scout")
            {
                ScoutAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "16:(Stable)Chariot")
            {
                ChariotArcherAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "17:(Stable)Scythe Chariot")
            {
                ScytheChariotAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "18:(Stable)Cavalry")
            {
                CavalryAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "19:(Stable)Heavy Cavalry")
            {
                HeavyCavalryAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "20:(Stable)Cataphract")
            {
                CataphractAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "21:(Stable)War Elephant")
            {
                WarElephantAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "22:(Stable)Armored Elephant")
            {
                ArmoredElephantAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "23:(Stable)Camel Rider")
            {
                CamelRiderAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "24:(Siege Workshop)Stone Thrower")
            {
                StoneThrowerAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "25:(Siege Workshop)Catapult")
            {
                CatapultAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "26:(Siege Workshop)Heavy Catapult")
            {
                HeavyCatapultAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "27:(Siege Workshop)Ballista")
            {
                BallistaAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "28:(Siege Workshop)Helepolis")
            {
                HelepolisAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "29:(Academy)Hoplite")
            {
                HopliteAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "30:(Academy)Phalangite")
            {
                PhalangiteAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "31:(Academy)Centurion")
            {
                CenturionAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "32:(Temple)Priest")
            {
                PriestAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "33:(Dock)Trade Boat")
            {
                TradeBoatAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "34:(Dock)Merchant Ship")
            {
                MerchantShipAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "35:(Dock)Heavy Transport")
            {
                HeavyTransportAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "36:(Dock)Light Transport")
            {
                LightTransportAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "37:(Dock)Scout Ship")
            {
                ScoutShipAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "38:(Dock)War Galley")
            {
                WarGalleyAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "39:(Dock)Trireme")
            {
                TriremeAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "40:(Dock)Catapult Trireme")
            {
                CatapultTriremeAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "41:(Dock)Juggernaut")
            {
                JuggernautAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "42:(Dock)Fire Galley")
            {
                FireGalleyAttackValue = BAAttackValue.Text;
            }
            else if (BAcurrentSelection == "43:(Dock)Trade Cart")
            {
                TradeCartAttackValue = BAAttackValue.Text;
            }

        }

        private void BASpeed_ValueChanged(object sender, EventArgs e)
        {
            if (BAcurrentSelection == "1:(Barracks)Clubman")
            {
                ClubmanSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "2:(Barracks)Axeman")
            {
                AxemanSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "3:(Barracks)Short Swordsman")
            {
                ShortSwordsmanSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "4:(Barracks)Broad Swordsman")
            {
                BroadSwordsmanSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "5:(Barracks)Long Swordsman")
            {
                LongSwordsmanSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "6:(Barracks)Legionary")
            {
                LegionarySpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "7:(Barracks)Slinger")
            {
                SlingerSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "8:(Archery Range)Bowman")
            {
                BowmanSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "9:(Archery Range)Improved Bowman")
            {
                ImprovedBowmanSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "10:(Archery Range)Composite Bowman")
            {
                CompositeBowmanSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "11:(Archery Range)Chariot Archer")
            {
                ChariotArcherSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "12:(Archery Range)Horse Archer")
            {
                HorseArcherSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "13:(Archery Range)Heavy Horse Archer")
            {
                HeavyHorseArcherSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "14:(Archery Range)Elephant Archer")
            {
                ElephantArcherSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "15:(Stable)Scout")
            {
                ScoutSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "16:(Stable)Chariot")
            {
                ChariotArcherSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "17:(Stable)Scythe Chariot")
            {
                ScytheChariotSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "18:(Stable)Cavalry")
            {
                CavalrySpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "19:(Stable)Heavy Cavalry")
            {
                HeavyCavalrySpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "20:(Stable)Cataphract")
            {
                CataphractSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "21:(Stable)War Elephant")
            {
                WarElephantSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "22:(Stable)Armored Elephant")
            {
                ArmoredElephantSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "23:(Stable)Camel Rider")
            {
                CamelRiderSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "24:(Siege Workshop)Stone Thrower")
            {
                StoneThrowerSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "25:(Siege Workshop)Catapult")
            {
                CatapultSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "26:(Siege Workshop)Heavy Catapult")
            {
                HeavyCatapultSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "27:(Siege Workshop)Ballista")
            {
                BallistaSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "28:(Siege Workshop)Helepolis")
            {
                HelepolisSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "29:(Academy)Hoplite")
            {
                HopliteSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "30:(Academy)Phalangite")
            {
                PhalangiteSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "31:(Academy)Centurion")
            {
                CenturionSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "32:(Temple)Priest")
            {
                PriestSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "33:(Dock)Trade Boat")
            {
                TradeBoatSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "34:(Dock)Merchant Ship")
            {
                MerchantShipSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "35:(Dock)Heavy Transport")
            {
                HeavyTransportSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "36:(Dock)Light Transport")
            {
                LightTransportSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "37:(Dock)Scout Ship")
            {
                ScoutShipSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "38:(Dock)War Galley")
            {
                WarGalleySpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "39:(Dock)Trireme")
            {
                TriremeSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "40:(Dock)Catapult Trireme")
            {
                CatapultTriremeSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "41:(Dock)Juggernaut")
            {
                JuggernautSpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "42:(Dock)Fire Galley")
            {
                FireGalleySpeedValue = BASpeed.Value.ToString();
            }
            else if (BAcurrentSelection == "43:(Dock)Trade Cart")
            {
                TradeCartSpeedValue = BASpeed.Value.ToString();
            }

        }

        private void BALoS_TextChanged(object sender, EventArgs e)
        {
            if (BAcurrentSelection == "1:(Barracks)Clubman")
            {
                ClubmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "2:(Barracks)Axeman")
            {
                AxemanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "3:(Barracks)Short Swordsman")
            {
                ShortSwordsmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "4:(Barracks)Broad Swordsman")
            {
                BroadSwordsmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "5:(Barracks)Long Swordsman")
            {
                LongSwordsmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "6:(Barracks)Legionary")
            {
                LegionaryLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "7:(Barracks)Slinger")
            {
                SlingerLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "8:(Archery Range)Bowman")
            {
                BowmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "9:(Archery Range)Improved Bowman")
            {
                ImprovedBowmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "10:(Archery Range)Composite Bowman")
            {
                CompositeBowmanLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "11:(Archery Range)Chariot Archer")
            {
                ChariotArcherLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "12:(Archery Range)Horse Archer")
            {
                HorseArcherLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "13:(Archery Range)Heavy Horse Archer")
            {
                HeavyHorseArcherLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "14:(Archery Range)Elephant Archer")
            {
                ElephantArcherLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "15:(Stable)Scout")
            {
                ScoutLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "16:(Stable)Chariot")
            {
                ChariotArcherLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "17:(Stable)Scythe Chariot")
            {
                ScytheChariotLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "18:(Stable)Cavalry")
            {
                CavalryLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "19:(Stable)Heavy Cavalry")
            {
                HeavyCavalryLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "20:(Stable)Cataphract")
            {
                CataphractLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "21:(Stable)War Elephant")
            {
                WarElephantLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "22:(Stable)Armored Elephant")
            {
                ArmoredElephantLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "23:(Stable)Camel Rider")
            {
                CamelRiderLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "24:(Siege Workshop)Stone Thrower")
            {
                StoneThrowerLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "25:(Siege Workshop)Catapult")
            {
                CatapultLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "26:(Siege Workshop)Heavy Catapult")
            {
                HeavyCatapultLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "27:(Siege Workshop)Ballista")
            {
                BallistaLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "28:(Siege Workshop)Helepolis")
            {
                HelepolisLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "29:(Academy)Hoplite")
            {
                HopliteLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "30:(Academy)Phalangite")
            {
                PhalangiteLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "31:(Academy)Centurion")
            {
                CenturionLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "32:(Temple)Priest")
            {
                PriestLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "33:(Dock)Trade Boat")
            {
                TradeBoatLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "34:(Dock)Merchant Ship")
            {
                MerchantShipLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "35:(Dock)Heavy Transport")
            {
                HeavyTransportLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "36:(Dock)Light Transport")
            {
                LightTransportLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "37:(Dock)Scout Ship")
            {
                ScoutShipLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "38:(Dock)War Galley")
            {
                WarGalleyLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "39:(Dock)Trireme")
            {
                TriremeLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "40:(Dock)Catapult Trireme")
            {
                CatapultTriremeLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "41:(Dock)Juggernaut")
            {
                JuggernautLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "42:(Dock)Fire Galley")
            {
                FireGalleyLoSValue = BALoS.Text;
            }
            else if (BAcurrentSelection == "43:(Dock)Trade Cart")
            {
                TradeCartLoSValue = BALoS.Text;
            }

        }

        private void BEHpValue_TextChanged(object sender, EventArgs e)
        {
            if (BEcurrentSelection == "1:(Barracks)Clubman")
            {
                EClubmanHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "2:(Barracks)Axeman")
            {
                EAxemanHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "3:(Barracks)Short Swordsman")
            {
                EShortSwordsmanHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "4:(Barracks)Broad Swordsman")
            {
                EBroadSwordsmanHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "5:(Barracks)Long Swordsman")
            {
                ELongSwordsmanHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "6:(Barracks)Legionary")
            {
                ELegionaryHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "7:(Barracks)Slinger")
            {
                ESlingerHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "8:(Archery Range)Bowman")
            {
                EBowmanHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "9:(Archery Range)Improved Bowman")
            {
                EImprovedBowmanHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "10:(Archery Range)Composite Bowman")
            {
                ECompositeBowmanHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "11:(Archery Range)Chariot Archer")
            {
                EChariotArcherHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "12:(Archery Range)Horse Archer")
            {
                EHorseArcherHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "13:(Archery Range)Heavy Horse Archer")
            {
                EHeavyHorseArcherHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "14:(Archery Range)Elephant Archer")
            {
                EElephantArcherHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "15:(Stable)Scout")
            {
                EScoutHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "16:(Stable)Chariot")
            {
                EChariotArcherHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "17:(Stable)Scythe Chariot")
            {
                EScytheChariotHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "18:(Stable)Cavalry")
            {
                ECavalryHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "19:(Stable)Heavy Cavalry")
            {
                EHeavyCavalryHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "20:(Stable)Cataphract")
            {
                ECataphractHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "21:(Stable)War Elephant")
            {
                EWarElephantHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "22:(Stable)Armored Elephant")
            {
                EArmoredElephantHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "23:(Stable)Camel Rider")
            {
                ECamelRiderHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "24:(Siege Workshop)Stone Thrower")
            {
                EStoneThrowerHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "25:(Siege Workshop)Catapult")
            {
                ECatapultHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "26:(Siege Workshop)Heavy Catapult")
            {
                EHeavyCatapultHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "27:(Siege Workshop)Ballista")
            {
                EBallistaHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "28:(Siege Workshop)Helepolis")
            {
                EHelepolisHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "29:(Academy)Hoplite")
            {
                EHopliteHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "30:(Academy)Phalangite")
            {
                EPhalangiteHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "31:(Academy)Centurion")
            {
                ECenturionHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "32:(Temple)Priest")
            {
                EPriestHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "33:(Dock)Trade Boat")
            {
                ETradeBoatHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "34:(Dock)Merchant Ship")
            {
                EMerchantShipHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "35:(Dock)Heavy Transport")
            {
                EHeavyTransportHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "36:(Dock)Light Transport")
            {
                ELightTransportHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "37:(Dock)Scout Ship")
            {
                EScoutShipHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "38:(Dock)War Galley")
            {
                EWarGalleyHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "39:(Dock)Trireme")
            {
                ETriremeHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "40:(Dock)Catapult Trireme")
            {
                ECatapultTriremeHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "41:(Dock)Juggernaut")
            {
                EJuggernautHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "42:(Dock)Fire Galley")
            {
                EFireGalleyHpValue = BEHpValue.Text;
            }
            else if (BEcurrentSelection == "43:(Dock)Trade Cart")
            {
                ETradeCartHpValue = BEHpValue.Text;
            }

        }

        private void BEAttackValue_TextChanged(object sender, EventArgs e)
        {
            if (BEcurrentSelection == "1:(Barracks)Clubman")
            {
                EClubmanAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "2:(Barracks)Axeman")
            {
                EAxemanAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "3:(Barracks)Short Swordsman")
            {
                EShortSwordsmanAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "4:(Barracks)Broad Swordsman")
            {
                EBroadSwordsmanAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "5:(Barracks)Long Swordsman")
            {
                ELongSwordsmanAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "6:(Barracks)Legionary")
            {
                ELegionaryAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "7:(Barracks)Slinger")
            {
                ESlingerAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "8:(Archery Range)Bowman")
            {
                EBowmanAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "9:(Archery Range)Improved Bowman")
            {
                EImprovedBowmanAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "10:(Archery Range)Composite Bowman")
            {
                ECompositeBowmanAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "11:(Archery Range)Chariot Archer")
            {
                EChariotArcherAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "12:(Archery Range)Horse Archer")
            {
                EHorseArcherAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "13:(Archery Range)Heavy Horse Archer")
            {
                EHeavyHorseArcherAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "14:(Archery Range)Elephant Archer")
            {
                EElephantArcherAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "15:(Stable)Scout")
            {
                EScoutAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "16:(Stable)Chariot")
            {
                EChariotArcherAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "17:(Stable)Scythe Chariot")
            {
                EScytheChariotAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "18:(Stable)Cavalry")
            {
                ECavalryAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "19:(Stable)Heavy Cavalry")
            {
                EHeavyCavalryAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "20:(Stable)Cataphract")
            {
                ECataphractAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "21:(Stable)War Elephant")
            {
                EWarElephantAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "22:(Stable)Armored Elephant")
            {
                EArmoredElephantAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "23:(Stable)Camel Rider")
            {
                ECamelRiderAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "24:(Siege Workshop)Stone Thrower")
            {
                EStoneThrowerAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "25:(Siege Workshop)Catapult")
            {
                ECatapultAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "26:(Siege Workshop)Heavy Catapult")
            {
                EHeavyCatapultAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "27:(Siege Workshop)Ballista")
            {
                EBallistaAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "28:(Siege Workshop)Helepolis")
            {
                EHelepolisAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "29:(Academy)Hoplite")
            {
                EHopliteAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "30:(Academy)Phalangite")
            {
                EPhalangiteAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "31:(Academy)Centurion")
            {
                ECenturionAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "32:(Temple)Priest")
            {
                EPriestAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "33:(Dock)Trade Boat")
            {
                ETradeBoatAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "34:(Dock)Merchant Ship")
            {
                EMerchantShipAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "35:(Dock)Heavy Transport")
            {
                EHeavyTransportAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "36:(Dock)Light Transport")
            {
                ELightTransportAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "37:(Dock)Scout Ship")
            {
                EScoutShipAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "38:(Dock)War Galley")
            {
                EWarGalleyAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "39:(Dock)Trireme")
            {
                ETriremeAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "40:(Dock)Catapult Trireme")
            {
                ECatapultTriremeAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "41:(Dock)Juggernaut")
            {
                EJuggernautAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "42:(Dock)Fire Galley")
            {
                EFireGalleyAttackValue = BEAttackValue.Text;
            }
            else if (BEcurrentSelection == "43:(Dock)Trade Cart")
            {
                ETradeCartAttackValue = BEAttackValue.Text;
            }
        }

        private void BESpeed_ValueChanged(object sender, EventArgs e)
        {
            if (BEcurrentSelection == "1:(Barracks)Clubman")
                EClubmanSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "2:(Barracks)Axeman")
                EAxemanSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "3:(Barracks)Short Swordsman")
                EShortSwordsmanSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "4:(Barracks)Broad Swordsman")
                EBroadSwordsmanSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "5:(Barracks)Long Swordsman")
                ELongSwordsmanSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "6:(Barracks)Legionary")
                ELegionarySpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "7:(Barracks)Slinger")
                ESlingerSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "8:(Archery Range)Bowman")
                EBowmanSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "9:(Archery Range)Improved Bowman")
                EImprovedBowmanSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "10:(Archery Range)Composite Bowman")
                ECompositeBowmanSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "11:(Archery Range)Chariot Archer")
                EChariotArcherSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "12:(Archery Range)Horse Archer")
                EHorseArcherSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "13:(Archery Range)Heavy Horse Archer")
                EHeavyHorseArcherSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "14:(Archery Range)Elephant Archer")
                EElephantArcherSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "15:(Stable)Scout")
                EScoutSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "16:(Stable)Chariot")
                EChariotArcherSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "17:(Stable)Scythe Chariot")
                EScytheChariotSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "18:(Stable)Cavalry")
                ECavalrySpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "19:(Stable)Heavy Cavalry")
                EHeavyCavalrySpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "20:(Stable)Cataphract")
                ECataphractSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "21:(Stable)War Elephant")
                EWarElephantSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "22:(Stable)Armored Elephant")
                EArmoredElephantSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "23:(Stable)Camel Rider")
                ECamelRiderSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "24:(Siege Workshop)Stone Thrower")
                EStoneThrowerSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "25:(Siege Workshop)Catapult")
                ECatapultSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "26:(Siege Workshop)Heavy Catapult")
                EHeavyCatapultSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "27:(Siege Workshop)Ballista")
                EBallistaSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "28:(Siege Workshop)Helepolis")
                EHelepolisSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "29:(Academy)Hoplite")
                EHopliteSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "30:(Academy)Phalangite")
                EPhalangiteSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "31:(Academy)Centurion")
                ECenturionSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "32:(Temple)Priest")
                EPriestSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "33:(Dock)Trade Boat")
                ETradeBoatSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "34:(Dock)Merchant Ship")
                EMerchantShipSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "35:(Dock)Heavy Transport")
                EHeavyTransportSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "36:(Dock)Light Transport")
                ELightTransportSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "37:(Dock)Scout Ship")
                EScoutShipSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "38:(Dock)War Galley")
                EWarGalleySpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "39:(Dock)Trireme")
                ETriremeSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "40:(Dock)Catapult Trireme")
                ECatapultTriremeSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "41:(Dock)Juggernaut")
                EJuggernautSpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "42:(Dock)Fire Galley")
                EFireGalleySpeedValue = BESpeed.Value.ToString();
            else if (BEcurrentSelection == "43:(Dock)Trade Cart")
                ETradeCartSpeedValue = BESpeed.Value.ToString();


        }

        private void BELoS_TextChanged(object sender, EventArgs e)
        {
            if (BEcurrentSelection == "1:(Barracks)Clubman")
                EClubmanLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "2:(Barracks)Axeman")
                EAxemanLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "3:(Barracks)Short Swordsman")
                EShortSwordsmanLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "4:(Barracks)Broad Swordsman")
                EBroadSwordsmanLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "5:(Barracks)Long Swordsman")
                ELongSwordsmanLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "6:(Barracks)Legionary")
                ELegionaryLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "7:(Barracks)Slinger")
                ESlingerLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "8:(Archery Range)Bowman")
                EBowmanLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "9:(Archery Range)Improved Bowman")
                EImprovedBowmanLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "10:(Archery Range)Composite Bowman")
                ECompositeBowmanLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "11:(Archery Range)Chariot Archer")
                EChariotArcherLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "12:(Archery Range)Horse Archer")
                EHorseArcherLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "13:(Archery Range)Heavy Horse Archer")
                EHeavyHorseArcherLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "14:(Archery Range)Elephant Archer")
                EElephantArcherLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "15:(Stable)Scout")
                EScoutLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "16:(Stable)Chariot")
                EChariotArcherLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "17:(Stable)Scythe Chariot")
                EScytheChariotLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "18:(Stable)Cavalry")
                ECavalryLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "19:(Stable)Heavy Cavalry")
                EHeavyCavalryLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "20:(Stable)Cataphract")
                ECataphractLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "21:(Stable)War Elephant")
                EWarElephantLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "22:(Stable)Armored Elephant")
                EArmoredElephantLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "23:(Stable)Camel Rider")
                ECamelRiderLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "24:(Siege Workshop)Stone Thrower")
                EStoneThrowerLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "25:(Siege Workshop)Catapult")
                ECatapultLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "26:(Siege Workshop)Heavy Catapult")
                EHeavyCatapultLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "27:(Siege Workshop)Ballista")
                EBallistaLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "28:(Siege Workshop)Helepolis")
                EHelepolisLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "29:(Academy)Hoplite")
                EHopliteLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "30:(Academy)Phalangite")
                EPhalangiteLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "31:(Academy)Centurion")
                ECenturionLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "32:(Temple)Priest")
                EPriestLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "33:(Dock)Trade Boat")
                ETradeBoatLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "34:(Dock)Merchant Ship")
                EMerchantShipLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "35:(Dock)Heavy Transport")
                EHeavyTransportLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "36:(Dock)Light Transport")
                ELightTransportLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "37:(Dock)Scout Ship")
                EScoutShipLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "38:(Dock)War Galley")
                EWarGalleyLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "39:(Dock)Trireme")
                ETriremeLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "40:(Dock)Catapult Trireme")
                ECatapultTriremeLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "41:(Dock)Juggernaut")
                EJuggernautLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "42:(Dock)Fire Galley")
                EFireGalleyLoSValue = BELoS.Text;
            else if (BEcurrentSelection == "43:(Dock)Trade Cart")
                ETradeCartLoSValue = BELoS.Text;


        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }
    }
}