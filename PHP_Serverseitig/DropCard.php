<?php
	require_once('inc_StackUpdater.php');
	
	$winner = "";
	$DropCardStapelID = $_GET["DropCardStapelID"];
	$anlagestring = $_GET["anlagestring"];
	
	//Wenn GET Wersendet != Wersendet (DB) dann du bist nciht dran:
	if ($wersendet != $weristdran) { die("Du Bist nicht Dran!"); }
	
	//Anhand weristdran prüfen wer die Karte weggeworfen hat (Kann 13. Karte von Player1 oder Player2 sein)
	if ($weristdran == "Player1")
	{
		//Wegggeorfene Karte aus Player1Cards entfernen			
		//Dazu alle Karten im Player1CardsArray durchlaufen 
		for ($c=0;$c<=count($Player1CardsArray)-1;$c++)
		{		
			if (strval($DropCardStapelID) == strval($Player1CardsArray[$c]))
			{
				$Player1CardsArray[$c] = "";														
			}
		}	
		$Player1Cards = WriteArrayBackToTilde($Player1CardsArray);
		$Player1CardsArray = WriteTildeBackToArray($Player1Cards);//Array wurd emanipuliert mit lleren "" einträgen, daher Array mit neuem Explode überschreiben	
		//$nextplayer = "Player2";			
		
		

	} 
	
	if ($weristdran == "Player2")
	{
		for ($c=0;$c<=count($Player2CardsArray)-1;$c++)
		{		
			if (strval($DropCardStapelID) == strval($Player2CardsArray[$c]))
			{
				$Player2CardsArray[$c] = "";									
			}
		}	
		$Player2Cards = WriteArrayBackToTilde($Player2CardsArray);
		$Player2CardsArray = WriteTildeBackToArray($Player2Cards);//Array wurd emanipuliert mit lleren "" einträgen, daher Array mit neuem Explode überschreiben
		//$nextplayer = "Player1";	
		

		
		
	}
			
	//Weggeworfene Karte in DropZone10 legen				
	$dropzone10 = $dropzone10 . "~" . strval($DropCardStapelID);
		
	//Wenn 1. Zeichen ~ ist dies abschneiden / //Wenn letzes Zeichen immernoch ~ ist dies abschneiden				
	while (substr($dropzone10, 0, 1) == "~") { $dropzone10 = substr($dropzone10, 1); }		
	while (substr($dropzone10, -1) == "~") { $dropzone10 = substr($dropzone10, 0, -1);	}
		
	//ZugID Updaten:
	//$zugid+=1;
		
	//SQL Updates:
	mysqli_query($link,"UPDATE romegame SET DropZone10='".$dropzone10."' WHERE GameID='".$GameID."'");
	//mysqli_query($link,"UPDATE romegame SET ZugID='".$zugid."' WHERE GameID='".$GameID."'");
	//mysqli_query($link,"UPDATE romegame SET Weristdran='".$nextplayer."' WHERE GameID='".$GameID."'");	
	mysqli_query($link,"UPDATE romegame SET Spielphase='". "KarteWeggeworfen" ."' WHERE GameID='".$GameID."'");
	mysqli_query($link,"UPDATE romegame SET Player1Cards='".$Player1Cards."' WHERE GameID='".$GameID."'");			
	mysqli_query($link,"UPDATE romegame SET Player2Cards='".$Player2Cards."' WHERE GameID='".$GameID."'");		



	echo "Dropio"; 		




?>