using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class RandomizeText : MonoBehaviour
{
    [SerializeField] private Text text;

    private List<string> texts;

    void Start()
    {
        texts = new List<string> {
            "Breathing may be performed by contracting chest muscles",
            "Staying in cold temperatures may cause hypothermia",
            "There are more trees than stars",
            "Remember to hydrate",
            "Eating many high sugar foods may have side effects",
            "Staying in hot temperatures may cause heatstroke",
            "Over 90% of Earths volcanic activity happens underwater",
            "Over 50% of our oxygen supply comes from marine life",
			"Earth's inner core is extremely hot, despite being solid",
			"The outer core of Earth is liquid metal",
			"Earth's crust is broken into several tectonic plates",
			"The Pacific Ocean is larger than all of Earth's land area combined",
			"The Atlantic Ocean is getting wider as tectonic plates move apart",
			"The Dead Sea is one of the saltiest bodies of water on Earth",
			"The Nile and Amazon are contenders for the world's longest river",
			"The Amazon River carries more water than any other river",
			"Lake Baikal contains about 20% of the world's unfrozen surface freshwater",
			"Most of Earth's freshwater is stored in glaciers and ice caps",
			"The Antarctic ice sheet contains most of Earth's ice",
			"Some parts of Antarctica have not had significant rain for millions of years",
			"The world's largest desert is Antarctica",
			"The Earth's rotation is gradually slowing down",
			"Earth's equatorial diameter is larger than its polar diameter",
			"The North Pole is located in the Arctic Ocean",
			"The South Pole is located on the continent of Antarctica",
			"The deepest parts of the ocean remain difficult to explore",
			"Most of the ocean has not been mapped in high resolution",
			"Some deep-sea animals produce their own light through bioluminescence",
			"The ocean contains underwater mountains and volcanoes",
			"Hydrothermal vents support life without sunlight",
			"Some corals can live for hundreds or even thousands of years",
			"Mangroves can grow in salty coastal water",
			"Kelp forests provide shelter for many marine animals",
			"Plankton form the foundation of many marine food webs",
			"Phytoplankton use sunlight to produce food through photosynthesis",
			"Some fungi form partnerships with plant roots",
			"Healthy soil contains countless microorganisms",
			"Earthworms help improve soil structure",
			"Peatlands store enormous amounts of carbon",
			"Forests help regulate the water cycle",
			"Plants release water vapor through a process called transpiration",
			"Clouds form when water vapor condenses into tiny droplets or ice crystals",
			"Rain helps replenish rivers, lakes, and groundwater",
			"Groundwater supplies drinking water to many communities",
			"Glaciers slowly move under their own weight",
			"Rocks can be recycled through the rock cycle",
			"Fossils provide evidence of ancient life on Earth",
			"Amber can preserve ancient organisms",
			"Some trees can live for thousands of years",
			"Bamboo is a type of grass, not a tree",
			"Mushrooms are more closely related to animals than to plants",
			"Octopuses have three hearts",
			"Wombats produce cube-shaped droppings",
			"A group of flamingos is called a flamboyance",
			"Sharks existed before trees appeared on Earth",
			"Some turtles can breathe through specialized tissues near their tails",
			"The blue whale is the largest known animal ever to have lived",
			"Earth's biodiversity includes species that scientists have not yet discovered",
			"Bring a reusable bag when shopping to reduce single-use waste",
			"Use a refillable bottle instead of buying disposable plastic bottles",
			"Turn off the tap while brushing your teeth",
			"Take shorter showers to reduce water use",
			"Fix leaking taps to prevent unnecessary water waste",
			"Compost suitable food scraps to reduce landfill waste",
			"Avoid littering because trash can enter rivers and oceans",
			"Choose reusable containers instead of disposable packaging",
			"Plant native species to support local wildlife",
			"Avoid disturbing wild animals or their habitats",
			"Keep a safe distance from wildlife when observing it",
			"Use both sides of paper when possible",
			"Donate or repair usable items instead of throwing them away",
			"Choose walking or cycling for short trips when safe",
			"Use public transportation when practical to reduce emissions",
			"Unplug chargers when they are not needed if they consume standby power",
			"Wash clothes with full loads when practical to save water and energy",
			"Air-dry clothes when weather and space allow",
			"Avoid burning rubbish because it can release harmful pollutants",
			"Dispose of batteries and electronic waste at appropriate collection points",
			"Never release unwanted pets into the wild",
			"Keep drains and waterways free of rubbish",
			"Reduce food waste by planning meals and storing food properly",
			"Choose products with less unnecessary packaging",
			"Protect local trees instead of damaging their bark",
			"Join community cleanups to help keep natural areas clean",
			"Use curtains or blinds to help keep indoor spaces comfortable",
			"Report illegal wildlife trade to the appropriate authorities",
			"Share reliable environmental information to help others learn"};
    }

    public void ChangeText()
    {
        string currentText = text.text;
        string newText;

        do
        {
            newText = texts[Random.Range(0, texts.Count)];
        }
        while (newText == currentText);

        text.text = newText;
    }
}