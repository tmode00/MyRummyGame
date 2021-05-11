<?php
		error_reporting(E_ERROR | E_PARSE);
		require_once('class.Karte.php');
    
		//DB Connect:		
		$link = mysqli_connect("localhost","tmode00_bousers","********") or die ('ERROR: Could not connect to database!');
		mysqli_select_db($link, "tmode00_bousers");
	
		
		
		//UniqueID generieren		
		//$uniqid = "T";//uniqid();					 
		
		//letze GameID in der Datenbank suchen
		$e=mysqli_query($link,"SELECT id FROM romegame ORDER BY id DESC LIMIT 1");
		$arr = mysqli_fetch_array($e);
		$uniqid = $arr["id"] + 1;//nächste GameID wird eins höher
		
		//mysqli_query($link,"DELETE FROM `romegame` WHERE 1");		
						
		if ($_GET["werbekommtdreizehn"] == "Player1")
		{
			//13 Karten für den 1. Spieler			
			$anz_cards = 12;			
			$Weristdran = "Player1";
		}	
		elseif ($_GET["werbekommtdreizehn"] == "Player2")
		{
			$anz_cards = 11;
			$Weristdran = "Player2";
		}
		else
		{
			die("Error im Aufruf!");
		}
		$Player1KartenInHand = $anz_cards + 1;
		
		//ULTIMATIVE  Only One Card Routine, 12/13 Karten für Spieler1:
		$Player1Cards = GetCardFromStack($Karte, $Player1Cards, $anz_cards, "Spieler1");
		
		//CHEATBLOCK
		//$Player1Cards = "0~1~2~3~4~5~6~7~8~9~10~11~12";		                   
		
		if ($_GET["werbekommtdreizehn"] == "Player1")
		{
			//13 Karten für den 1. Spieler, daher 12 für Player 2			
			$anz_cards = 11;				
		}	
		elseif ($_GET["werbekommtdreizehn"] == "Player2")
		{
			//12 Karten für den 1. Spieler, daher 13 für Player 2			
			$anz_cards = 12;			
		}
		else
		{
			die("Error im Aufruf!");
		}
		$Player2KartenInHand = $anz_cards + 1;				
						
		//ULTIMATIVE  Only One Card Routine, 12/13 Karten für Spieler2:
		$Player2Cards = GetCardFromStack($Karte, $Player2Cards, $anz_cards, "Spieler2");
		//$Player2Cards = "0~1~2~3~4~5~6~7~8~9~10~11~12";
		
		//KArten stehen nun fest, for DB insert nun noch sortieren:
		$Player1Cards = SuperSorter($Karte, $Player1Cards);
		$Player2Cards = SuperSorter($Karte, $Player2Cards);

	
		//Benutze Karten in die Datenbank legen:
		$UsedCards = $Player1Cards . "~" . $Player2Cards;						
		
		$ZugID = 0;
		//$Spielphase = "SpielErstellt";
		$Spielphase = "KarteGezogen";//da Runde 1 sowieso clientseitig abfragt wer dran ist (und serverseitig) ist dies wie Kartegezogen
		
		
		
		//$Weristdran = "Player1/2" => siehe Oben;
		
		//// DB SUPERINSERT NEW GAME///
		mysqli_query($link,"insert into romegame (GameID, Player1Cards, Player2Cards, UsedCards, Player1KartenInHand, Player2KartenInHand, ZugID, Spielphase, Weristdran) VALUES ('".$uniqid."','".$Player1Cards."','".$Player2Cards."','".$UsedCards."','".$Player1KartenInHand."','".$Player2KartenInHand."','".$ZugID."','".$Spielphase."','".$Weristdran."')");		
				
		////Rückgaben an Client ====>
		//Handler Name zurückgeben
		echo "NewGame" . "\n";
		
		//gameID zurückgeben: (ResultLines[1])
		echo $uniqid . "\n";
		
		//Player1Cards zurückgeben (ResultLines[2])
		echo $Player1Cards . "\n";

		//Player2Cards zurückgeben (ResultLines[3])
		echo $Player2Cards. "\n";//later \n nicht vergessen
		
		//Weristdran zurückkgeben:  (ResultLines[4])
		echo $Weristdran;
		
?>
