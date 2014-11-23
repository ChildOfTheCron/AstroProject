using UnityEngine;
using System.Collections;

public class TradeManager : MonoBehaviour {

	//Added on - 22/03/2014
	public class Items2{
		public int itemVal;
		public Texture2D itemSkin;
		public bool itemSelect;
		
		public Items2(int val, Texture2D tex, bool state){
			itemVal = val;
			itemSkin = tex;
			itemSelect = state;
		}
	}
	
	//Trying a Hashtable since I cant use an array for Items (int and Texture2D)
	Hashtable items = new Hashtable();
	
	//Used to get Player Item values
	ItemScript itemscript1;
	ItemScript itemscript2;
	ItemScript itemscript3;
	ItemScript itemscript4;
	
	//Used to get NPC Item values
	ItemScript itemscript5;
	ItemScript itemscript6;
	ItemScript itemscript7;
	ItemScript itemscript8;	
	
	//Debug text script access variable
	DebugText debugtext;
	int tmpScoreCounter;
	
	int totalPLRValue;
	int totalNPCValue;
	
	// Use this for initialization
	void Start () {

		totalPLRValue = 0;
		totalNPCValue = 0;
		
		//Debug text script
		debugtext = GameObject.Find("DebugM2").gameObject.GetComponent<DebugText>();
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void Compare(){
		itemscript1 = GameObject.Find("Item1").gameObject.GetComponent<ItemScript>();
		itemscript2 = GameObject.Find("Item2").gameObject.GetComponent<ItemScript>();
		itemscript3 = GameObject.Find("Item3").gameObject.GetComponent<ItemScript>();
		itemscript4 = GameObject.Find("Item4").gameObject.GetComponent<ItemScript>();
		
		itemscript5 = GameObject.Find("NPCItem1(Clone)").gameObject.GetComponent<ItemScript>();
		itemscript6 = GameObject.Find("NPCItem2(Clone)").gameObject.GetComponent<ItemScript>();
		itemscript7 = GameObject.Find("NPCItem3(Clone)").gameObject.GetComponent<ItemScript>();
		itemscript8 = GameObject.Find("NPCItem4(Clone)").gameObject.GetComponent<ItemScript>();
		
		//Don't use these yet. Using them as a temp storage even though I use
		//the GetItemVal directly. Don't know if it's a good way of doing things yet
		// (See case/switch/select/whatever statement)
		//int Item1 = itemscript1.GetItemVal();
		//int Item2 = itemscript2.GetItemVal();
		//int Item3 = itemscript3.GetItemVal();
		//int Item4 = itemscript4.GetItemVal();
		
		//Player Item bools
		bool Item1State = itemscript1.GetSelectState();
		bool Item2State = itemscript2.GetSelectState();
		bool Item3State = itemscript3.GetSelectState();
		bool Item4State = itemscript4.GetSelectState();
		
		//NPC item bools
		bool Item5State = itemscript5.GetSelectState();
		bool Item6State = itemscript6.GetSelectState();
		bool Item7State = itemscript7.GetSelectState();
		bool Item8State = itemscript8.GetSelectState();
		
		//Player Catagories
		string Item1Cat = itemscript1.GetItemCat();
		string Item2Cat = itemscript2.GetItemCat();
		string Item3Cat = itemscript3.GetItemCat();
		string Item4Cat = itemscript4.GetItemCat();
		
		//NPC Catagories
		string Item5Cat = itemscript5.GetItemCat();
		string Item6Cat = itemscript6.GetItemCat();
		string Item7Cat = itemscript7.GetItemCat();
		string Item8Cat = itemscript8.GetItemCat();		
		
		//This is a switch statement to see which catagory the item belongs to
		//Then adds their value to the right total counter
		if(Item1State == true){
			switch (Item1Cat)
			{
			    case "NPC":
					totalNPCValue = totalNPCValue + itemscript1.GetItemVal();
					Debug.Log("Item1 is an NPC item");
			        Debug.Log("totalNPCValue is: " + totalNPCValue);
			        break;
			    case "PLR":
					totalPLRValue = totalPLRValue + itemscript1.GetItemVal();
					Debug.Log("Item1 is a player item");
					Debug.Log("totalPLRValue is: " + totalPLRValue);
			        break;
			    default:
			        Debug.Log("Default case");
			        break;
			}
		}
		
		if(Item2State == true){
			switch (Item2Cat)
			{
			    case "NPC":
					totalNPCValue = totalNPCValue + itemscript2.GetItemVal();
					Debug.Log("Item2 is an NPC item");
			        Debug.Log("totalNPCValue is: " + totalNPCValue);
			        break;
			    case "PLR":
					totalPLRValue = totalPLRValue + itemscript1.GetItemVal();
					Debug.Log("Item2 is a player item");
					Debug.Log("totalPLRValue is: " + totalPLRValue);
			        break;
			    default:
			        Debug.Log("Default case");
			        break;
			}
		}
		
		if(Item3State == true){
			switch (Item3Cat)
			{
			    case "NPC":
					totalNPCValue = totalNPCValue + itemscript3.GetItemVal();
					Debug.Log("Item3 is an NPC item");
			        Debug.Log("totalNPCValue is: " + totalNPCValue);
			        break;
			    case "PLR":
					totalPLRValue = totalPLRValue + itemscript3.GetItemVal();
					Debug.Log("Item3 is a player item");
					Debug.Log("totalPLRValue is: " + totalPLRValue);
			        break;
			    default:
			        Debug.Log("Default case");
			        break;
			}
		}
		
		if(Item4State == true){
			switch (Item4Cat)
			{
			    case "NPC":
					totalNPCValue = totalNPCValue + itemscript4.GetItemVal();
					Debug.Log("Item4 is an NPC item");
			        Debug.Log("totalNPCValue is: " + totalNPCValue);
			        break;
			    case "PLR":
					totalPLRValue = totalPLRValue + itemscript4.GetItemVal();
					Debug.Log("Item4 is a player item");
					Debug.Log("totalPLRValue is: " + totalPLRValue);
			        break;
			    default:
			        Debug.Log("Default case");
			        break;
			}
		}
		
		if(Item5State == true){
			switch (Item5Cat)
			{
			    case "NPC":
					totalNPCValue = totalNPCValue + itemscript5.GetItemVal();
					Debug.Log("Item5 is an NPC item");
			        Debug.Log("totalNPCValue is: " + totalNPCValue);
			        break;
			    case "PLR":
					totalPLRValue = totalPLRValue + itemscript5.GetItemVal();
					Debug.Log("Item5 is a player item");
					Debug.Log("totalPLRValue is: " + totalPLRValue);
			        break;
			    default:
			        Debug.Log("Default case");
			        break;
			}
		}
		
		if(Item6State == true){
			switch (Item6Cat)
			{
			    case "NPC":
					totalNPCValue = totalNPCValue + itemscript6.GetItemVal();
					Debug.Log("Item6 is an NPC item");
			        Debug.Log("totalNPCValue is: " + totalNPCValue);
			        break;
			    case "PLR":
					totalPLRValue = totalPLRValue + itemscript6.GetItemVal();
					Debug.Log("Item6 is a player item");
					Debug.Log("totalPLRValue is: " + totalPLRValue);
			        break;
			    default:
			        Debug.Log("Default case");
			        break;
			}
		}
		
		if(Item7State == true){
			switch (Item7Cat)
			{
			    case "NPC":
					totalNPCValue = totalNPCValue + itemscript7.GetItemVal();
					Debug.Log("Item7 is an NPC item");
			        Debug.Log("totalNPCValue is: " + totalNPCValue);
			        break;
			    case "PLR":
					totalPLRValue = totalPLRValue + itemscript7.GetItemVal();
					Debug.Log("Item7 is a player item");
					Debug.Log("totalPLRValue is: " + totalPLRValue);
			        break;
			    default:
			        Debug.Log("Default case");
			        break;
			}
		}
		
		if(Item8State == true){
			switch (Item8Cat)
			{
			    case "NPC":
					totalNPCValue = totalNPCValue + itemscript8.GetItemVal();
					Debug.Log("Item8 is an NPC item");
			        Debug.Log("totalNPCValue is: " + totalNPCValue);
			        break;
			    case "PLR":
					totalPLRValue = totalPLRValue + itemscript8.GetItemVal();
					Debug.Log("Item8 is a player item");
					Debug.Log("totalPLRValue is: " + totalPLRValue);
			        break;
			    default:
			        Debug.Log("Default case");
			        break;
			}
		}
	}
	
	//Added on - 22/03/2014
	void MakeTrade2(){
		//If trade is succesful
		//if(totalPLRValue <= totalNPCValue){
				
			//Item table (array of size 8) that holds all of the NPC and Player items information
			Items2[] itemTable = new Items2[9];
			//NPC items
			itemTable[0] = new Items2(itemscript5.GetItemVal(),itemscript5.GetItemSkin(),itemscript5.GetSelectState());
			itemTable[1] = new Items2(itemscript6.GetItemVal(),itemscript6.GetItemSkin(),itemscript6.GetSelectState());
			itemTable[2] = new Items2(itemscript7.GetItemVal(),itemscript7.GetItemSkin(),itemscript7.GetSelectState());
			itemTable[3] = new Items2(itemscript8.GetItemVal(),itemscript8.GetItemSkin(),itemscript8.GetSelectState());
			//Player items
			itemTable[4] = new Items2(itemscript1.GetItemVal(),itemscript1.GetItemSkin(),itemscript1.GetSelectState());
			itemTable[5] = new Items2(itemscript2.GetItemVal(),itemscript2.GetItemSkin(),itemscript2.GetSelectState());
			itemTable[6] = new Items2(itemscript3.GetItemVal(),itemscript3.GetItemSkin(),itemscript3.GetSelectState());
			itemTable[7] = new Items2(itemscript4.GetItemVal(),itemscript4.GetItemSkin(),itemscript4.GetSelectState());
			//temp item - used to get player items into the NPC inventory
			itemTable[8] = new Items2(itemscript4.GetItemVal(),itemscript4.GetItemSkin(),itemscript4.GetSelectState());
			
			//ints used to track array positions
			//rather than one two arrays I just share one, x for NPC and j for player
			int x = 0;
			int j = 4;
				
				//Loops through the NPC items and if they are selected, checks the player items
				//The player items have their own index and if they are selected the Item object of NPC is given to player
				//If the player item isn't selected then we just increment player item array index (j++)
				//If the npc item being checked wasn't  selected we just skip all this and increment to the next npc item (x++)
				while(x < 4 ){
					if(itemTable[x].itemSelect == true){
						if(itemTable[j].itemSelect == true){
							itemTable[8] = itemTable[j];
							itemTable[j] = itemTable[x];
							itemTable[x] = itemTable[8];
							
							x++;
							j++;
						}
						else{
							j++;
						}
					}
					else{
							x++;
						}
				}
		
			//Rebuilds the new items by using the Item classes new values and writing them into the
			//itemscripts attached to the items
			//Item Skins
			itemscript1.SetItemSkin(itemTable[4].itemSkin);
			itemscript2.SetItemSkin(itemTable[5].itemSkin);
			itemscript3.SetItemSkin(itemTable[6].itemSkin);
			itemscript4.SetItemSkin(itemTable[7].itemSkin);
			//Item values
			itemscript1.SetItemVal(itemTable[4].itemVal);
			itemscript2.SetItemVal(itemTable[5].itemVal);
			itemscript3.SetItemVal(itemTable[6].itemVal);
			itemscript4.SetItemVal(itemTable[7].itemVal);
		
			//Item Skins
			itemscript5.SetItemSkin(itemTable[0].itemSkin);
			itemscript6.SetItemSkin(itemTable[1].itemSkin);
			itemscript7.SetItemSkin(itemTable[2].itemSkin);
			itemscript8.SetItemSkin(itemTable[3].itemSkin);
			//Item values
			itemscript5.SetItemVal(itemTable[0].itemVal);
			itemscript6.SetItemVal(itemTable[1].itemVal);
			itemscript7.SetItemVal(itemTable[2].itemVal);
			itemscript8.SetItemVal(itemTable[3].itemVal);
		
			//debug text creator. Stores the total value of your inventory
			//just for testing purposes so sloppy code
			tmpScoreCounter = tmpScoreCounter + itemscript1.GetItemVal();
			tmpScoreCounter = tmpScoreCounter + itemscript2.GetItemVal();
			tmpScoreCounter = tmpScoreCounter + itemscript3.GetItemVal();
			tmpScoreCounter = tmpScoreCounter + itemscript4.GetItemVal();
			debugtext.SetText(tmpScoreCounter.ToString());
			
					
			//Resets the items selected
			//Player item inventory
			itemscript1.SetSelectedState(false);
			itemscript2.SetSelectedState(false);
			itemscript3.SetSelectedState(false);
			itemscript4.SetSelectedState(false);
			//NPC item inventory
			itemscript5.SetSelectedState(false);
			itemscript6.SetSelectedState(false);
			itemscript7.SetSelectedState(false);
			itemscript8.SetSelectedState(false);
			
			//Reset values for next trade
			tmpScoreCounter = 0;
		
	}
	
	void MakeTrade(){
		
		//if the players trade is less valueble to the NPCs trade then pass else fail it
		//Also deals with resetting the player and NPC item value totals
		//Need to reset the selected items from someplace on trigger exit (see Collide SCript maybe?
		if(totalPLRValue <= totalNPCValue){
			
			//This'll take the first item from the NPC items and put it in the players
			// first item slot, if the trade is acceptable to the player
			//this is just a test run, not the way to do things
			//if(Item1State == true){
				//itemscript1.SetItemVal(itemscript5.GetItemVal());
				//itemscript1.SetItemSkin(itemscript5.GetItemSkin());
			
				//Won't allow duplicate keys
				//items.Add(itemscript5.GetItemSkin(),itemscript5.GetItemVal());
				//items.Add(itemscript6.GetItemSkin(),itemscript6.GetItemVal());
				//will allow duplicate keys
				int counter = 0;
				items[itemscript5.GetItemSkin()] = itemscript5.GetItemVal();
				items[itemscript6.GetItemSkin()] = itemscript6.GetItemVal();
				items[itemscript7.GetItemSkin()] = itemscript7.GetItemVal();
				items[itemscript8.GetItemSkin()] = itemscript8.GetItemVal();
					
				foreach (DictionaryEntry entry in items)
				{
					//if(counter == 1){
					//Need to think of a way to assign key/value pairs
					//per stored item per player item
					//Right now it loops through and assigns the last value
					Debug.Log(entry.Key);
					Debug.Log(entry.Value);
					Debug.Log ("Counter is: " + counter);
					//needed to cast here
	    			itemscript1.SetItemSkin((Texture2D)entry.Key);
					itemscript1.SetItemVal((int)entry.Value);
					//}
				//counter++;
				}
			//}
			
			
			Debug.Log ("Passable Trade");
			totalPLRValue = 0;
			totalNPCValue = 0;
			
			//Resets the items selected
			//Player item inventory
			itemscript1.SetSelectedState(false);
			itemscript2.SetSelectedState(false);
			itemscript3.SetSelectedState(false);
			itemscript4.SetSelectedState(false);
			//NPC item inventory
			itemscript5.SetSelectedState(false);
			itemscript6.SetSelectedState(false);
			itemscript7.SetSelectedState(false);
			itemscript8.SetSelectedState(false);
			
			
		}
		else{
			Debug.Log ("Trade Fail");
			totalPLRValue = 0;
			totalNPCValue = 0;
			
			//Resets the items selected
			//Player item inventory
			itemscript1.SetSelectedState(false);
			itemscript2.SetSelectedState(false);
			itemscript3.SetSelectedState(false);
			itemscript4.SetSelectedState(false);
			//NPC item inventory
			itemscript5.SetSelectedState(false);
			itemscript6.SetSelectedState(false);
			itemscript7.SetSelectedState(false);
			itemscript8.SetSelectedState(false);
		}
	}
	
	void OnMouseDown(){
		Compare();
		MakeTrade2();
	}
	
}
