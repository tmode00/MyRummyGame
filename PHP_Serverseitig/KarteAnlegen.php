<?php
	require_once('inc_StackUpdater.php');
	$anlagestring = $_GET["anlagestring"];

	//Die before anything:
	if ($Spielphase != "KarteWeggeworfen") 	{ die("Darf nicht anlegen, da keine weggeworfene Karte erkannt"); }
	if ($wersendet != $weristdran) { die("Du Bist nicht Dran!"); }
	
	//In Vorbereitung Anlagestring auseinander nehmen, in 2-Dimensionales Array:
	//Testexplode						
	$dzboxen=explode("x",$anlagestring);    
	$dzboxen6Array[0] = explode("~",$dzboxen[0]);//Enthält einzelkartenvvon $dzboxen[0]
	$dzboxen6Array[1] = explode("~",$dzboxen[1]);
	$dzboxen6Array[2] = explode("~",$dzboxen[2]);
	$dzboxen6Array[3] = explode("~",$dzboxen[3]);
	$dzboxen6Array[4] = explode("~",$dzboxen[4]);
	$dzboxen6Array[5] = explode("~",$dzboxen[5]);
	$dzboxen6Array[6] = explode("~",$dzboxen[6]);
	$dzboxen6Array[7] = explode("~",$dzboxen[7]);
	$dzboxen6Array[8] = explode("~",$dzboxen[8]);
		
	
	
	//Die Alten DropZoneStrings (falls nicht anlgen erfolgreich war) sind in $dropzone1 - 9
	//Wen weniger als 3 Karten in der DZ Box sind, dann das DZ-Box Array komplett auf AltZustand setzen (wenige rals 3 Karten können nicht ruas):
	//komisch e alte logik if (count($DropZone1Array) < 3) { $dzboxen6Array[0] = null; $dzboxen[0] = ""; $weniger3error = true; } 
	
	
	//stupides anlegen:		
	if ($weristdran == "Player1")
	{
		//Außen immer nächste DZ schalten
		for ($f=0;$f<=8;$f++)	
		{
			if ($dzboxen6Array[$f] != null)
			{
				//Weiter imnnen immer eine Karte aus dem PlayerCards Array checken
				for ($c=0;$c<=count($Player1CardsArray)-1;$c++)
				{	
					//im inneren nun DZbox Array durchlaufen und die jeweilige DZ Card mit der jeweiligen Player1CardArrycard vergleichen:
					for ($d=0;$d<=count($dzboxen6Array[$f])-1;$d++)
					{							
						if (strval($dzboxen6Array[$f][$d]) == strval($Player1CardsArray[$c]))
						{								
							$Player1CardsArray[$c] = "";													
						}													
					}	
				}		
				$Player1Cards = WriteArrayBackToTilde($Player1CardsArray);	
				$Player1CardsArray = WriteTildeBackToArray($Player1Cards);				
			}
		}

		$nextplayer = "Player2";
		
		//Gewinner schrieben wenn keine karten mehr auf hand nach wegwerfen
		if ($Player1Cards == "")
		{
			mysqli_query($link,"UPDATE romegame SET Spielphase='WinPlayer1' WHERE GameID='".$GameID."'");
			$winner = "Player1";
			
			//Strafpunkte des geners ermitteln
			$strafpoints = get_strafpunkte($Karte, $Player2Cards);
			mysqli_query($link,"UPDATE romegame SET StrafpunkteP2=".$strafpoints." WHERE GameID='".$GameID."'");
			
		}
	} 
	
	if ($weristdran == "Player2")
	{
		//Außen immer nächste DZ schalten
		for ($f=0;$f<=8;$f++)	
		{
			if ($dzboxen6Array[$f] != null)
			{
				//Weiter imnnen immer eine Karte aus dem PlayerCards Array checken
				for ($c=0;$c<=count($Player2CardsArray)-1;$c++)
				{	
					//im inneren nun DZbox Array durchlaufen und die jeweilige DZ Card mit der jeweiligen Player1CardArrycard vergleichen:
					for ($d=0;$d<=count($dzboxen6Array[$f])-1;$d++)
					{							
						if (strval($dzboxen6Array[$f][$d]) == strval($Player2CardsArray[$c]))
						{								
							$Player2CardsArray[$c] = "";													
						}
					}							
				}
				$Player2Cards = WriteArrayBackToTilde($Player2CardsArray);	
				$Player2CardsArray = WriteTildeBackToArray($Player2Cards);								
			}
		}
		
		$nextplayer = "Player1";
		
		//Gewinner schrieben wenn keine karten mehr auf hand nach wegwerfen
		if ($Player2Cards == "")
		{
			mysqli_query($link,"UPDATE romegame SET Spielphase='WinPlayer2' WHERE GameID='".$GameID."'");
			$winner = "Player2";
			
			//Strafpunkte des geners ermitteln
			$strafpoints = get_strafpunkte($Karte, $Player1Cards);
			mysqli_query($link,"UPDATE romegame SET StrafpunkteP2=".$strafpoints." WHERE GameID='".$GameID."'");
		}
	}
		
	//ZugID Updaten:
	$zugid+=1;
		
	//Neue DropZoneinhalte Bilden
	if ($dzboxen[0] != "") { $dropzone1 = $dropzone1 . "~" . $dzboxen[0]; }
	if ($dzboxen[1] != "") { $dropzone2 = $dropzone2 . "~" . $dzboxen[1]; }
	if ($dzboxen[2] != "") { $dropzone3 = $dropzone3 . "~" . $dzboxen[2]; }
	if ($dzboxen[3] != "") { $dropzone4 = $dropzone4 . "~" . $dzboxen[3]; }
	if ($dzboxen[4] != "") { $dropzone5 = $dropzone5 . "~" . $dzboxen[4]; }
	if ($dzboxen[5] != "") { $dropzone6 = $dropzone6 . "~" . $dzboxen[5]; }
	if ($dzboxen[6] != "") { $dropzone7 = $dropzone7 . "~" . $dzboxen[6]; }
	if ($dzboxen[7] != "") { $dropzone8 = $dropzone8 . "~" . $dzboxen[7]; }
	if ($dzboxen[8] != "") { $dropzone9 = $dropzone9 . "~" . $dzboxen[8]; }		
	
	
	//Erste und letze Tilde sicher abschneiden:
	while (substr($dropzone1, 0, 1) == "~")	{ $dropzone1 = substr($dropzone1, 1); 		}	
	while (substr($dropzone1, -1)   == "~") { $dropzone1 = substr($dropzone1, 0, -1); 	}
	while (substr($dropzone2, 0, 1) == "~")	{ $dropzone2 = substr($dropzone2, 1); 		}	
	while (substr($dropzone2, -1)   == "~") { $dropzone2 = substr($dropzone2, 0, -1); 	}
	while (substr($dropzone3, 0, 1) == "~")	{ $dropzone3 = substr($dropzone3, 1); 		}	
	while (substr($dropzone3, -1)   == "~") { $dropzone3 = substr($dropzone3, 0, -1); 	}
	while (substr($dropzone4, 0, 1) == "~")	{ $dropzone4 = substr($dropzone4, 1); 		}	
	while (substr($dropzone4, -1)   == "~") { $dropzone4 = substr($dropzone4, 0, -1); 	}
	while (substr($dropzone5, 0, 1) == "~")	{ $dropzone5 = substr($dropzone5, 1); 		}	
	while (substr($dropzone5, -1)   == "~") { $dropzone5 = substr($dropzone5, 0, -1); 	}
	while (substr($dropzone6, 0, 1) == "~")	{ $dropzone6 = substr($dropzone6, 1); 		}	
	while (substr($dropzone6, -1)   == "~") { $dropzone6 = substr($dropzone6, 0, -1); 	}
	while (substr($dropzone7, 0, 1) == "~")	{ $dropzone7 = substr($dropzone7, 1); 		}	
	while (substr($dropzone7, -1)   == "~") { $dropzone7 = substr($dropzone7, 0, -1); 	}
	while (substr($dropzone8, 0, 1) == "~")	{ $dropzone8 = substr($dropzone8, 1); 		}	
	while (substr($dropzone8, -1)   == "~") { $dropzone8 = substr($dropzone8, 0, -1); 	}
	while (substr($dropzone9, 0, 1) == "~")	{ $dropzone9 = substr($dropzone9, 1); 		}	
	while (substr($dropzone9, -1)   == "~") { $dropzone9 = substr($dropzone9, 0, -1); 	}
		
		
	//SQL Updates:		
	mysqli_query($link,"UPDATE romegame SET DropZone1='".$dropzone1."' WHERE GameID='".$GameID."'");
	mysqli_query($link,"UPDATE romegame SET DropZone2='".$dropzone2."' WHERE GameID='".$GameID."'");
	mysqli_query($link,"UPDATE romegame SET DropZone3='".$dropzone3."' WHERE GameID='".$GameID."'");
	mysqli_query($link,"UPDATE romegame SET DropZone4='".$dropzone4."' WHERE GameID='".$GameID."'");
	mysqli_query($link,"UPDATE romegame SET DropZone5='".$dropzone5."' WHERE GameID='".$GameID."'");
	mysqli_query($link,"UPDATE romegame SET DropZone6='".$dropzone6."' WHERE GameID='".$GameID."'");
	mysqli_query($link,"UPDATE romegame SET DropZone7='".$dropzone7."' WHERE GameID='".$GameID."'");
	mysqli_query($link,"UPDATE romegame SET DropZone8='".$dropzone8."' WHERE GameID='".$GameID."'");
	mysqli_query($link,"UPDATE romegame SET DropZone9='".$dropzone9."' WHERE GameID='".$GameID."'");
		
	mysqli_query($link,"UPDATE romegame SET ZugID='".$zugid."' WHERE GameID='".$GameID."'");
	mysqli_query($link,"UPDATE romegame SET Weristdran='".$nextplayer."' WHERE GameID='".$GameID."'");	

	mysqli_query($link,"UPDATE romegame SET Player1Cards='".$Player1Cards."' WHERE GameID='".$GameID."'");			
	mysqli_query($link,"UPDATE romegame SET Player2Cards='".$Player2Cards."' WHERE GameID='".$GameID."'");	


	if ($winner != "")
	{
		echo $winner . "\n";
		echo $strafpoints;	
	}
	else
	{
		mysqli_query($link,"UPDATE romegame SET Spielphase='". "ZugBeendet" ."' WHERE GameID='".$GameID."'");
		if ($weniger3error)
		{
			echo "AnlegeNotioWeniger3"; 		
		}
		else
		{
			echo "Anlegeio"; 	
		}
	}
?>