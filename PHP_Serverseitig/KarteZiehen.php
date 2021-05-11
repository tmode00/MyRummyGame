<?php
		require_once('inc_StackUpdater.php');

		//Wen Kerte vom Stpel kommen soll dann wird gegnerstapelcard = DummyCard heißen sonst wird die ID der Karte übermittelt 
		$gegnerstapelcard = $_GET["gegnerstapelcard"];

		echo "KarteZiehen" . "\n"; //Reslines 0
		
		//Wenn GET Wersendet != Wersendet (DB) dann du bist nciht dran:
		if ($wersendet != $weristdran)
		{
			die("Du Bist nicht Dran!");
		}
		else
		{
			//Spielstatus prüfen, es darf nur gezogen werden, wenn der Status vorher weggeworfen war (nicht bei neu erstellten Spiel, nicht bei gejointem Spiel und nicht wenn Karte (bereiits) gezogen wurde):
			if ($Spielphase == "ZugBeendet")
			{
				$anz_cards = 0;
			
				///bevor eine Karte gezogen wird, guggen ob der stapel noch reicht, ggf weggeworfene Karten wieder auf Tsapellegen:			
				if ($UsedCards != "")
				{				
					if (count($UsedCardsArray) == 104)
					{
						//Weggeworfene Karten durchlaufen
						if ($dropzone10 != "")
						{
							for ($c=0;$c<=count($DroppedCardsArray)-1;$c++)
							{	
								//Karte die bislang weggeworfen war als verfügbar markieren
								$Karte[$DroppedCardsArray[$c]] = GetCardByStapelID($Karte, $DroppedCardsArray[$c]);	
								$Karte[$DroppedCardsArray[$c]]->Status = "verfuegbar";								
							}	
						}	
										
						//UsedCards durchlaufen, wenn Karte "verfügbar" diese aus Usedcards array entfernen
						if ($UsedCards != "")
						{
							for ($c=0;$c<=count($UsedCardsArray)-1;$c++)
							{								
								$Karte[$UsedCardsArray[$c]] = GetCardByStapelID($Karte, $UsedCardsArray[$c]);
								if ($Karte[$UsedCardsArray[$c]]->Status == "verfuegbar")
								{
									$UsedCardsArray[$c]  = "";
								}
							}
							//String neu schreiben:
							$UsedCards = WriteArrayBackToTilde($UsedCardsArray);
							$UsedCardsArray = WriteTildeBackToArray($UsedCards);
							
							//Datenbank wird im "Karte ziehen" neu geschrieben
							$dropzone10 = "";//es ist nun keine Karte mehr weggeworfen, da der Stapel aktulisiert wurde							
							mysqli_query($link,"UPDATE romegame SET DropZone10='".$dropzone10."' WHERE GameID='".$GameID."'");
						}						
					}	
				}
			
			
			
				//Anhand weristdran prüfen wer die Karte gezogen hat:
				if ($weristdran == "Player1")
				{
					//ULTIMATIVE  Only One Card Routine, 12/13 Karten für Spieler1:				
					if (strval($gegnerstapelcard) == "DummyCard")
					{
						$thenewcardID = GetCardFromStack($Karte, $Player1Cards, $anz_cards, "Spieler1");
						$Player1Cards = $Player1Cards . "~" . strval($thenewcardID);
						$UsedCards = $UsedCards . "~" . strval($thenewcardID);							
						echo "iofromstack";	
					}
					else
					{
						$thenewcardID = GetPredefinedCardFromStack($Karte, $Player1Cards, $anz_cards, "Spieler1", $gegnerstapelcard);
						$Player1Cards = $Player1Cards . "~" . strval($thenewcardID);
						//$UsedCards = $UsedCards . "~" . $thenewcardID; => nicht in usedkarts da die Karte schon im Umlauf ist
											
						if ($dropzone10 != "")
						{
							//Wenn Karte vom gegner kommt, muss diese "aus dem Weggeworfenstapel" gerechnet werden
							//Dazu alle Karten im DropZone10Array durchlaufen 
							for ($c=0;$c<=count($DroppedCardsArray)-1;$c++)
							{		
								if (strval($thenewcardID) == strval($DroppedCardsArray[$c]))
								{
									$DroppedCardsArray[$c] = "";														
								}
							}	
							$dropzone10 = WriteArrayBackToTilde($DroppedCardsArray);
							$DroppedCardsArray = WriteTildeBackToArray($dropzone10);
							
							//Wenn 1. Zeichen ~ ist dies abschneiden / //Wenn letzes Zeichen immernoch ~ ist dies abschneiden				
							while (substr($dropzone10, 0, 1) == "~") { $dropzone10 = substr($dropzone10, 1); }		
							while (substr($dropzone10, -1) == "~") { $dropzone10 = substr($dropzone10, 0, -1);	}
							mysqli_query($link,"UPDATE romegame SET DropZone10='".$dropzone10."' WHERE GameID='".$GameID."'");
						}
							
						echo "iofromgegner";
					}
					
					$Player1KartenInHand = $anz_cards + 1;		

					//KArten stehen nun fest, for DB insert nun noch sortieren:
					//$Player1Cards = SuperSorter($Karte, $Player1Cards);
					
					mysqli_query($link,"UPDATE romegame SET Player1Cards='".$Player1Cards ."' WHERE GameID='".$GameID."'");
				} 
				if ($weristdran == "Player2")
				{
					//ULTIMATIVE  Only One Card Routine, 12/13 Karten für Spieler1:
					if (strval($gegnerstapelcard) == "DummyCard")
					{
						$thenewcardID = GetCardFromStack($Karte, $Player2Cards, $anz_cards, "Spieler2");						
						$Player2Cards = $Player2Cards . "~" . strval($thenewcardID);
						$UsedCards = $UsedCards . "~" . strval($thenewcardID);	
						echo "iofromstack";							
					}
					else
					{
						$thenewcardID = GetPredefinedCardFromStack($Karte, $Player2Cards, $anz_cards, "Spieler2",  strval($gegnerstapelcard));
						$Player2Cards = $Player2Cards . "~" . strval($thenewcardID);
						//$UsedCards = $UsedCards . "~" . $thenewcardID; => nicht in usedkarts da die Karte schon im Umlauf ist	


						if ($dropzone10 != "")
						{
							//Wenn Karte vom gegner kommt, muss diese "aus dem Weggeworfenstapel" gerechnet werden
							//Dazu alle Karten im DropZone10Array durchlaufen 
							for ($c=0;$c<=count($DroppedCardsArray)-1;$c++)
							{		
								if (strval($thenewcardID) == strval($DroppedCardsArray[$c]))
								{
									$DroppedCardsArray[$c] = "";														
								}
							}	
							$dropzone10 = WriteArrayBackToTilde($DroppedCardsArray);
							$DroppedCardsArray = WriteTildeBackToArray($dropzone10);
							
							//Wenn 1. Zeichen ~ ist dies abschneiden / //Wenn letzes Zeichen immernoch ~ ist dies abschneiden				
							while (substr($dropzone10, 0, 1) == "~") { $dropzone10 = substr($dropzone10, 1); }		
							while (substr($dropzone10, -1) == "~") { $dropzone10 = substr($dropzone10, 0, -1);	}						
							mysqli_query($link,"UPDATE romegame SET DropZone10='".$dropzone10."' WHERE GameID='".$GameID."'");
						}	
						echo "iofromgegner";	
						
					}
					$Player2KartenInHand = $anz_cards + 1;	
					//KArten stehen nun fest, for DB insert nun noch sortieren:
					//$Player2Cards = SuperSorter($Karte, $Player2Cards);
					mysqli_query($link,"UPDATE romegame SET Player2Cards='".$Player2Cards ."' WHERE GameID='".$GameID."'");
				}
			
				//Datenbank schreiben:
				mysqli_query($link,"UPDATE romegame SET UsedCards='".$UsedCards ."' WHERE GameID='".$GameID."'");
				mysqli_query($link,"UPDATE romegame SET Spielphase='". "KarteGezogen" ."' WHERE GameID='".$GameID."'");
			}
			else
			{
				die("Du bist dran, darfst aber im Moment keine Karte ziehen!");
			}
		}
?>