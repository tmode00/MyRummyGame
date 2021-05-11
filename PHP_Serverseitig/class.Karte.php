<?php
	class Karte
	{
		public $LfdNr = 0;
		public $StapelID = 0;
		public $Zaehlwert = 0;
		public $Name = "";
		public $Farbe = "";
		public $Status = "verfuegbar";
		public $Eigentuemer = "stapel";
		public $AnlageID = 0;
		 
		function __construct($StapelID,$Zaehlwert,$Name,$Farbe,$AnlageID)
		{								
			$this->StapelID = $StapelID;
			$this->Zaehlwert = $Zaehlwert;
			$this->Name = $Name;
			$this->Farbe = $Farbe;
			$this->AnlageID = $AnlageID;
		}
	}
	

	//109er Kartenstapel erstellen:
	$Karte[0] = new Karte(0,11,"Ass","Kreuz",1);			
	$Karte[1] = new Karte(1,2,"2","Kreuz",2);			
	$Karte[2] = new Karte(2,3,"3","Kreuz",3);			
	$Karte[3] = new Karte(3,4,"4","Kreuz",4);			
	$Karte[4] = new Karte(4,5,"5","Kreuz",5);			
	$Karte[5] = new Karte(5,6,"6","Kreuz",6);			
	$Karte[6] = new Karte(6,7,"7","Kreuz",7);			
	$Karte[7] = new Karte(7,8,"8","Kreuz",8);			
	$Karte[8] = new Karte(8,9,"9","Kreuz",9);			
	$Karte[9] = new Karte(9,10,"10","Kreuz",10);			
	$Karte[10] = new Karte(10,10,"Bube","Kreuz",11);			
	$Karte[11] = new Karte(11,10,"Dame","Kreuz",12);			
	$Karte[12] = new Karte(12,10,"Koenig","Kreuz",13);							
	$Karte[13] = new Karte(13,11,"Ass","Karo",1);			
	$Karte[14] = new Karte(14,2,"2","Karo",2);			
	$Karte[15] = new Karte(15,3,"3","Karo",3);			
	$Karte[16] = new Karte(16,4,"4","Karo",4);			
	$Karte[17] = new Karte(17,5,"5","Karo",5);			
	$Karte[18] = new Karte(18,6,"6","Karo",6);			
	$Karte[19] = new Karte(19,7,"7","Karo",7);			
	$Karte[20] = new Karte(20,8,"8","Karo",8);			
	$Karte[21] = new Karte(21,9,"9","Karo",9);			
	$Karte[22] = new Karte(22,10,"10","Karo",10);			
	$Karte[23] = new Karte(23,10,"Bube","Karo",11);			
	$Karte[24] = new Karte(24,10,"Dame","Karo",12);			
	$Karte[25] = new Karte(25,10,"Koenig","Karo",13);					
	$Karte[26] = new Karte(26,11,"Ass","Herz",1);			
	$Karte[27] = new Karte(27,2,"2","Herz",2);			
	$Karte[28] = new Karte(28,3,"3","Herz",3);			
	$Karte[29] = new Karte(29,4,"4","Herz",4);			
	$Karte[30] = new Karte(30,5,"5","Herz",5);			
	$Karte[31] = new Karte(31,6,"6","Herz",6);			
	$Karte[32] = new Karte(32,7,"7","Herz",7);			
	$Karte[33] = new Karte(33,8,"8","Herz",8);			
	$Karte[34] = new Karte(34,9,"9","Herz",9);			
	$Karte[35] = new Karte(35,10,"10","Herz",10);			
	$Karte[36] = new Karte(36,10,"Bube","Herz",11);			
	$Karte[37] = new Karte(37,10,"Dame","Herz",12);			
	$Karte[38] = new Karte(38,10,"Koenig","Herz",13);							
	$Karte[39] = new Karte(39,11,"Ass","Schwarz",1);			
	$Karte[40] = new Karte(40,2,"2","Schwarz",2);			
	$Karte[41] = new Karte(41,3,"3","Schwarz",3);			
	$Karte[42] = new Karte(42,4,"4","Schwarz",4);			
	$Karte[43] = new Karte(43,5,"5","Schwarz",5);			
	$Karte[44] = new Karte(44,6,"6","Schwarz",6);			
	$Karte[45] = new Karte(45,7,"7","Schwarz",7);			
	$Karte[46] = new Karte(46,8,"8","Schwarz",8);			
	$Karte[47] = new Karte(47,9,"9","Schwarz",9);			
	$Karte[48] = new Karte(48,10,"10","Schwarz",10);			
	$Karte[49] = new Karte(49,10,"Bube","Schwarz",11);			
	$Karte[50] = new Karte(50,10,"Dame","Schwarz",12);			
	$Karte[51] = new Karte(51,10,"Koenig","Schwarz",13);				
	$Karte[52] = new Karte(52,20,"Joker","Joker",111);			
	$Karte[53] = new Karte(53,20,"Joker","Joker",111);			
	$Karte[54] = new Karte(54,20,"Joker","Joker",111);							
	$Karte[55] = new Karte(55,11,"Ass","Kreuz",1);			
	$Karte[56] = new Karte(56,2,"2","Kreuz",2);			
	$Karte[57] = new Karte(57,3,"3","Kreuz",3);			
	$Karte[58] = new Karte(58,4,"4","Kreuz",4);			
	$Karte[59] = new Karte(59,5,"5","Kreuz",5);			
	$Karte[60] = new Karte(60,6,"6","Kreuz",6);			
	$Karte[61] = new Karte(61,7,"7","Kreuz",7);			
	$Karte[62] = new Karte(62,8,"8","Kreuz",8);			
	$Karte[63] = new Karte(63,9,"9","Kreuz",9);			
	$Karte[64] = new Karte(64,10,"10","Kreuz",10);			
	$Karte[65] = new Karte(65,10,"Bube","Kreuz",11);			
	$Karte[66] = new Karte(66,10,"Dame","Kreuz",12);			
	$Karte[67] = new Karte(67,10,"Koenig","Kreuz",13);			
	$Karte[68] = new Karte(68,11,"Ass","Karo",1);			
	$Karte[69] = new Karte(69,2,"2","Karo",2);			
	$Karte[70] = new Karte(70,3,"3","Karo",3);			
	$Karte[71] = new Karte(71,4,"4","Karo",4);			
	$Karte[72] = new Karte(72,5,"5","Karo",5);			
	$Karte[73] = new Karte(73,6,"6","Karo",6);			
	$Karte[74] = new Karte(74,7,"7","Karo",7);			
	$Karte[75] = new Karte(75,8,"8","Karo",8);			
	$Karte[76] = new Karte(76,9,"9","Karo",9);			
	$Karte[77] = new Karte(77,10,"10","Karo",10);			
	$Karte[78] = new Karte(78,10,"Bube","Karo",11);			
	$Karte[79] = new Karte(79,10,"Dame","Karo",12);			
	$Karte[80] = new Karte(80,10,"Koenig","Karo",13);			
	$Karte[81] = new Karte(81,11,"Ass","Herz",1);			
	$Karte[82] = new Karte(82,2,"2","Herz",2);			
	$Karte[83] = new Karte(83,3,"3","Herz",3);			
	$Karte[84] = new Karte(84,4,"4","Herz",4);			
	$Karte[85] = new Karte(85,5,"5","Herz",5);			
	$Karte[86] = new Karte(86,6,"6","Herz",6);			
	$Karte[87] = new Karte(87,7,"7","Herz",7);			
	$Karte[88] = new Karte(88,8,"8","Herz",8);			
	$Karte[89] = new Karte(89,9,"9","Herz",9);			
	$Karte[90] = new Karte(90,10,"10","Herz",10);			
	$Karte[91] = new Karte(91,10,"Bube","Herz",11);			
	$Karte[92] = new Karte(92,10,"Dame","Herz",12);			
	$Karte[93] = new Karte(93,10,"Koenig","Herz",13);			
	$Karte[94] = new Karte(94,11,"Ass","Schwarz",1);			
	$Karte[95] = new Karte(95,2,"2","Schwarz",2);			
	$Karte[96] = new Karte(96,3,"3","Schwarz",3);			
	$Karte[97] = new Karte(97,4,"4","Schwarz",4);			
	$Karte[98] = new Karte(98,5,"5","Schwarz",5);			
	$Karte[99] = new Karte(99,6,"6","Schwarz",6);			
	$Karte[100] = new Karte(100,7,"7","Schwarz",7);			
	$Karte[101] = new Karte(101,8,"8","Schwarz",8);			
	$Karte[102] = new Karte(102,9,"9","Schwarz",9);			
	$Karte[103] = new Karte(103,10,"10","Schwarz",10);			
	$Karte[104] = new Karte(104,10,"Bube","Schwarz",11);			
	$Karte[105] = new Karte(105,10,"Dame","Schwarz",12);			
	$Karte[106] = new Karte(106,10,"Koenig","Schwarz",13);			
	$Karte[107] = new Karte(107,20,"Joker","Joker",111);			
	$Karte[108] = new Karte(108,20,"Joker","Joker",111);			
	$Karte[109] = new Karte(109,20,"Joker","Joker",111);	

	//Alle Eigenschaften einer Karte anhand StapelID zurückgeben (returns Karte)
	function GetCardByStapelID($Karte, $StapelID)
	{
		foreach ($Karte as $OneCard) 
		{
			if ($OneCard->StapelID == $StapelID)
			{
				return $OneCard;						
			}							
		}
	}	
	
	//Gibt die Anzahl Strafpunke zurück, welche im Übergebenen Cardsstring liegen
	function get_strafpunkte($Karte, $CardsString)
	{
		$strafpunkte = 0;
		
		//dazu erst den Stirng in ein tepräres Array explodieren:
		$temparray = WriteTildeBackToArray($CardsString);
		
		//Dieses Array nun durchlaufen und einelne Tempkarten bilden
		for ($c=0;$c<=count($temparray)-1;$c++)
		{	
			$strafpunkte = $strafpunkte + GetCardByStapelID($Karte, $temparray[$c])->Zaehlwert;
		}	
		
		return $strafpunkte;
	}
	
	///GETTERS ===>
	//übergeben wird der Stapel (damit Eigenschaften darin geändert werden können), die alten Karten , damit der String erweitert wertdne kann, die ANzahl der zu vergebenden (neuen) Karten und der Eigentümer, welcher die Karte bekommen soll
	//zurückgegeben wird der Kartenstring der genierierten Karten (returns string)
	function GetCardFromStack($Karte, $cardstring, $anz_cards, $owner)
	{
		//ULTIMATIVE  Only One Card Routine, 12/13 Karten für Spieler1:
		for ($c=0;$c<=$anz_cards;$c++)
		{			
			//generieren
			$i = rand(0,109);//vorläufige Karte ziehen
			while ($Karte[$i]->Status == "gezogen" || $Karte[$i]->Name == "Joker")//wenn Karte bereits gezogen
			{
				$i = rand(0,109);//neue Karte ziehen
			}	
			
			$Karte[$i]->Status = "gezogen";//Karte als nicht mehr ziehbar eintragen			             
			$Karte[$i]->Eigentuemer = $owner;			
			
			//Wenn nur eine Karte vergeben wird, soll nicht der ganzue Kartstring sondern nur die eine Karte zurückgegeben werden
			if ($anz_cards > 0)
			{						
				$cardstring = $cardstring . strval($Karte[$i]->StapelID) . "~";
			}
			else
			{
				$cardstring = strval($Karte[$i]->StapelID);
			}
		}		

		//bei mehr als einer Karte muss die Tilde am Ende weg:	
		if ($anz_cards > 0)
		{
			$cardstring = substr($cardstring, 0, -1);
		}
		
		return $cardstring;
	}
	
	function GetPredefinedCardFromStack($Karte, $cardstring, $anz_cards, $owner, $gegnerstapelcard)
	{
		//ULTIMATIVE  Only One Card Routine, 12/13 Karten für Spieler1:
		for ($c=0;$c<=$anz_cards;$c++)
		{			
			//generieren
			$i = intval($gegnerstapelcard); 		
			
			$Karte[$i]->Status = "gezogen";//Karte als nicht mehr ziehbar eintragen			             
			$Karte[$i]->Eigentuemer = $owner;			
			
			//Wenn nur eine Karte vergeben wird muss noch Tilde dazwischen, sonst sieht cardstring so aus (87~27~105104~)
			if ($anz_cards > 0)
			{						
				$cardstring = $cardstring . strval($Karte[$i]->StapelID) . "~";
			}
			else
			{
				$cardstring = strval($Karte[$i]->StapelID);
			}
		}		
		
		//bei mehr als einer Karte muss die Tilde am Ende weg:	
		if ($anz_cards > 0)
		{
			$cardstring = substr($cardstring, 0, -1);
		}		
		
		return $cardstring;
	}
	
	
	
	
	//Gibt die Position einer Karte in einem bereits aufgesplitteten Array (von urspr ~~~) zurück (returns int position)
	function get_card_position($ACardsArray, $SearchCard)
	{
		//Position der Karte vorher finden
		for ($c=0;$c<=count($ACardsArray)-1;$c++)
		{
			if 	(strval($ACardsArray[$c]) == strval($SearchCard))
			{
					//Returns the Position pof the Card in Array
					//echo "Found at: " . $c . "\n";
					return $c;		
			}		
		}		
	}	
	
	//Help functiotions:
	//Bekommt ein SArray z.B: Player1CardsArray und wandelt es zurück zu DB-schreibbarer ~~~ Variante (returns ~ String)
	function WriteArrayBackToTilde($CardsNArray)
	{
		$thecardstring = "";
		for ($c=0;$c<=count($CardsNArray)-1;$c++)
		{	
			if ($CardsNArray[$c] != "")
			{
				$thecardstring = $thecardstring . strval($CardsNArray[$c]) . "~";
			}
		}		
		
		//Wenn 1. Zeichen ~ ist dies abschneiden		
		while (substr($thecardstring, 0, 1) == "~")
		{
			$thecardstring = substr($thecardstring, 1);
		}	
		
		//Wenn letzes Zeichen immernoch ~ ist dies abschneiden		
		while (substr($thecardstring, -1) == "~")
		{
			$thecardstring = substr($thecardstring, 0, -1);
		}
		return $thecardstring;
	}
	
	//Bekommt ein Kartstring z.B: Player1Cards und wandelt es zurück zu Array
	function WriteTildeBackToArray($CardsString)
	{
		$retarray = explode("~",strval($CardsString));  
		return $retarray;
	}
	
	/**
	*Diese Funktion sortiert ein Array nach einer bestimmten Eigenschaft
	*
	*@param  array $array           Es wird ein zu sortierender Array erwartet
	*@param string $eigenschaft     Es wird der Name der Eigenschaft erwartet nach der sortiert werden soll.
	*@param string $sortierrichtung N für Normal und R für Reverse
	*/
	function arraySort($array, $eigenschaft, $sortierrichtung='N'){
		foreach($array as $index=>$value){
			$array_eigenschaft[$index] = strtolower($value->$eigenschaft);
		}

		if($sortierrichtung == 'N'){
			asort($array_eigenschaft);
		}elseif($sortierrichtung == 'R'){
			arsort($array_eigenschaft);
		}

		foreach($array_eigenschaft as $index=>$value){
			$sortiertes_array[$index] = $array[$index];
		}

		return $sortiertes_array;
	}

	//Bekommt unsortierte Karten übergeben im 1~1~1 Format und gibt diese sortiert wieder zurück
	//Dabei wird zuerst aufsteigend (AnlageID) und dann nach farbe sortiert
	//Die Rückgabe erfolgt wieder im 1~1~1 Format
	function SuperSorter($Karte, $UnsortedCardsString)
	{
		//dazu erst den Stirng in ein tepräres Array explodieren:
		$temparray = WriteTildeBackToArray($UnsortedCardsString);
		
		//Dieses Array nun durchlaufen und einelne Tempkarten bilden
		for ($c=0;$c<=count($temparray)-1;$c++)
		{	
			$TempKarte[$c] = GetCardByStapelID($Karte, $temparray[$c]);
		}
		
		//print_r($TempKarte);
		
		
		//print_r("======");
		
		//in $TempKarte[$c]  liegen nun die unsortieretn Karten, sortiermagic starten:	
		$TempKarte = arraySort($TempKarte, 'AnlageID', 'N'); // Hier wird nach der Eigenschaft 'Name' sortiert
		$TempKarte = arraySort($TempKarte, 'Farbe', 'N'); // Hier wird nach der Eigenschaft 'Name' sortiert
		
		//print_r($TempKarte);

		
		//und sortiertes Array als String zurück geben
		//Dazu alle Tempkarten durchlaufen:
		$thecardstring = "";
		
		foreach ($TempKarte as $OneCard) 
		{	
			$thecardstring = $thecardstring . strval($OneCard->StapelID) . "~";  	
		}
			
		//Wenn 1. Zeichen ~ ist dies abschneiden		
		while (substr($thecardstring, 0, 1) == "~")
		{
			$thecardstring = substr($thecardstring, 1);
		}	
		
		//Wenn letzes Zeichen immernoch ~ ist dies abschneiden		
		while (substr($thecardstring, -1) == "~")
		{
			$thecardstring = substr($thecardstring, 0, -1);
		}
		return $thecardstring;	
	}
	
	
	
?>